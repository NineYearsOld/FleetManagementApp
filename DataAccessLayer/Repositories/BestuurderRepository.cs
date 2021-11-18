using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using BusinessLayer.Entities;
using BusinessLayer.Interfaces;

namespace DataAccessLayer.Repositories {
    public class BestuurderRepository: IBestuurderRepository {
        private string connectionString;
        public BestuurderRepository(string connectionString) {
            this.connectionString = connectionString;
        }

        private SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public bool BestaatBestuurder(int id)
        {
            string query = "select count(*) from dbo.bestuurders where id =@id";
            SqlConnection connection = getConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@id", id);
                    int qr = (int)command.ExecuteScalar();
                    if (qr > 0)
                    {
                        return true;
                    }
                    else return false;
                }
                catch (Exception)
                {

                    throw;
                }

                finally
                {
                    connection.Close();
                }

            }
        }

        public void CreateBestuurder(Bestuurder bestuurder) {

            string query = "insert into dbo.bestuurders (naam, voornaam, postcode, gemeente, straat, huisnummer, geboortedatum, rijksregisternummer, rijbewijs) values(@naam, @voornaam, @postcode, @gemeente, @straat, @huisnummer, @geboortedatum, @rijksregisternummer, @rijbewijs)";
            SqlConnection connection = getConnection();
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                if (ValidatieRijkregisternummer(bestuurder.RijksregisterNummer))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.Add(new SqlParameter("@naam", SqlDbType.NVarChar));
                        command.Parameters["@naam"].Value = bestuurder.Naam;
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
        }

        public static bool ValidatieRijkregisternummer(string rijksregisternr) 
        {
            if (rijksregisternr == null) {
                return false;
            } else if (rijksregisternr.Length != 11) {
                return false;
            } else {
                int laatste2 = int.Parse(rijksregisternr.Substring(9));
                int eerste9 = int.Parse(rijksregisternr.Substring(0, 8));
                if (laatste2 == 97 - (eerste9 % 97)) {
                    return true;
                } else {
                    return false;
                }
            }
        }

        public void DeleteBestuurder(int id)
        {
            string query = "delete from dbo.bestuurders where id=@id";
            SqlConnection connection = getConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    command.Parameters["@id"].Value = id;
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        public void UpdateBestuurder(Bestuurder bestuurder)
        {
            string query = "update from dbo.bestuurders set naam=@naam, where id=@id";
            SqlConnection connection = getConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    command.Parameters["@id"].Value = bestuurder.Id;
                    command.Parameters.Add(new SqlParameter("@naam", SqlDbType.NVarChar));
                    command.Parameters["@naam"].Value = bestuurder.Naam;
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public Bestuurder ToonDetails(int id)
        {
            string query = "select * from dbo.bestuurders where id=@id";
            SqlConnection connection = getConnection();
            Bestuurder bestuurder;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    IDataReader reader = command.ExecuteReader();
                    reader.Read();
                    bestuurder = new Bestuurder((string)reader["naam"], (string)reader["voornaam"], (DateTime)reader["geboortedatum"], (string)reader["rijksregisternummer"], (string)reader["rijbewijs"]);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return bestuurder;
        }
    }
}

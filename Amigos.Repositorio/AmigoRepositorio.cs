
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViaVarejo.Dominio.Entidades;
using ViaVarejo.Dominio.Servicos;


using System.Configuration;
using System.Data.SqlClient;

namespace ViaVarejo.Repositorio
{
    public class AmigoRepositorio : IAmigoRepositorio
    {
       
        string ConectionString = "Server=(localdb)\\mssqllocaldb;Database=AmigosAPIContext;Trusted_Connection=True;MultipleActiveResultSets=true";
        public AmigoRepositorio()
        {
        }

        public bool DeleteAmigo(Amigo amigo)
        {
            throw new NotImplementedException();
        }

        public List<Amigo> GeProximos(Amigo amigo)
        {
           

            throw new NotImplementedException();
        }

        public Amigo GetAmigoById(Amigo amigo)
        {

            Amigo _amigo = new Amigo();
            using (SqlConnection connection = new SqlConnection(ConectionString))
            {
                
                connection.Open();
               
                string sql = "Select * From Amigos where Id = " + amigo.Id;
                SqlCommand command = new SqlCommand(sql, connection);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        _amigo.Id = Convert.ToInt32(dataReader["Id"]);
                        _amigo.Nome = Convert.ToString(dataReader["Nome"]).ToUpper();
                        _amigo.Latitude = Convert.ToDouble(dataReader["Latitude"]);
                        _amigo.Longitude = Convert.ToDouble(dataReader["Longitude"]);
                        _amigo.CEP = Convert.ToString(dataReader["CEP"]);
                    }
                }
                connection.Close();
            }
            return _amigo;

        }

        public List<Amigo> GetAmigos()
        {
            List<Amigo> AmigosList = new List<Amigo>();

            using (SqlConnection connection = new SqlConnection(ConectionString))
            {
                //SqlDataReader
                connection.Open();

                string sql = "Select * From Amigos ";
                SqlCommand command = new SqlCommand(sql, connection);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Amigo _amigo = new Amigo();
                        _amigo.Id = Convert.ToInt32(dataReader["Id"]);
                        _amigo.Nome = Convert.ToString(dataReader["Nome"]).ToUpper();
                        _amigo.Latitude = Convert.ToDouble(dataReader["Latitude"]);
                        _amigo.Longitude = Convert.ToDouble(dataReader["Longitude"]);
                        _amigo.CEP = Convert.ToString(dataReader["CEP"]);
                        AmigosList.Add(_amigo);
                    }
                }
                connection.Close();
            }
            return AmigosList;
        }


        public bool InsertAmigo(Amigo _amigo)
        {
            throw new NotImplementedException();
        }

    }
}

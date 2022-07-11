using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Utiles;

namespace DataAccess
{
    public  class MachineRepository
    {
        public void SaveMachine(Machines machine)
        {
            try
            {
                SqlConnection connection = ConnectionSingleton.getConnection();
                connection.Open();
                string query = $@"INSERT into Machines
                            ([Id_Machine]
                            ,[Id_Brand]
                            ,[Id_Model]
                            ,[Id_Color]
                            ,[Description]
                            ,[Elements]
                            ,[Picture]
                            ,[Failure])
                        VALUES
                            (@Id_Machine
                            , @Id_Brand
                            , @Id_Model
                            , @Id_Color
                            , @Description
                            , @Elements
                            , @Picture
                            , @Failure
                            )";


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;

                cmd.Parameters.Add(new SqlParameter("Id_Machine", machine.Id_Machine));
                cmd.Parameters.Add(new SqlParameter("Id_Brand", machine.Brand));
                cmd.Parameters.Add(new SqlParameter("Id_Model", machine.Model));
                cmd.Parameters.Add(new SqlParameter("Id_Color", machine.Color));
                cmd.Parameters.Add(new SqlParameter("Description", machine.Description));
                cmd.Parameters.Add(new SqlParameter("Elements", machine.Elements));
                cmd.Parameters.Add(new SqlParameter("Picture", machine.Picture));
                cmd.Parameters.Add(new SqlParameter("Failure", machine.Failure));

                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LoadMachine()
        {
            
        }

        public void DeleteMachine()
        { 
            
        }
        
        public List<Machines> listMachines()
        {
            SqlConnection connection = ConnectionSingleton.getConnection();
            List<Machines> list = new List<Machines>();

            try
            {
                connection.Open();
                var cmd = new SqlCommand();
                cmd.Connection = connection;

                var sql = $@"SELECT * from Machines";

                cmd.CommandText = sql;

                SqlDataReader reader = cmd.ExecuteReader();

                Machines machine = new Machines();
                while (reader.Read())
                {
                    machine.Id_Machine = Int32.Parse(reader.GetString(reader.GetOrdinal("Id_Machine")));
                    machine.Description = reader.GetString(reader.GetOrdinal("Description"));
                    machine.Color = reader.GetString(reader.GetOrdinal("Id_Color"));
                    machine.Elements = reader.GetString(reader.GetOrdinal("Elements"));
                    machine.Brand = reader.GetString(reader.GetOrdinal("Id_Brand"));
                    machine.Picture = reader.GetString(reader.GetOrdinal("Picture"));
                    machine.Failure = reader.GetString(reader.GetOrdinal("Failure"));
                    machine.Model = reader.GetString(reader.GetOrdinal("Id_Model"));
                    machine.isApproved = (reader.GetBoolean(reader.GetOrdinal("isApproved")));
                    machine.isPossibleToRepair = (reader.GetBoolean(reader.GetOrdinal("possibleToRepair")));
                    machine.isReviewed = (reader.GetBoolean(reader.GetOrdinal("isApproved")));
                    machine.Id_Client = Int32.Parse(reader.GetString(reader.GetOrdinal("Id_Client")));
                    machine.Id_User = Int32.Parse(reader.GetString(reader.GetOrdinal("Id_User")));
                    machine.Reparation = reader.GetString(reader.GetOrdinal("Reparation"));

                    list.Add(machine);
                }

                reader.Close();
                connection.Close();

                return list;
            }
            catch (Exception)
            {
                connection.Close();
                throw;
            }
        }

        public void Approval(Machines machine)
        {
            //UPDATE Machines SET isApproved = @isApproved where Id_Machine = @Id_Machine
           try
            {
                SqlConnection connection = ConnectionSingleton.getConnection();
                connection.Open();
                string query = $@"UPDATE Machines SET isApproved = @isApproved where Id_Machine = @Id_Machine";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;

                cmd.Parameters.Add(new SqlParameter("Id_Machine", machine.Id_Machine));

                cmd.Parameters.Add(new SqlParameter("isApproved", machine.isApproved));

                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Review(Machines machine)
        {
            //UPDATE Machines SET isRevisada = isRevisada, Reparation = @Reparation, possibleToRepair = @possibleToRepair where Id_Machine = @Id_Machine
            try
            {
                SqlConnection connection = ConnectionSingleton.getConnection();
                connection.Open();
                string query = $@"UPDATE Machines SET isRevisada = isRevisada, Reparation = @Reparation, 
                    possibleToRepair = @possibleToRepair where Id_Machine = @Id_Machine";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;


                cmd.Parameters.Add(new SqlParameter("Id_Machine", machine.Id_Machine));
                cmd.Parameters.Add(new SqlParameter("isRevisada", machine.isReviewed));
                cmd.Parameters.Add(new SqlParameter("Reparation", machine.Reparation));
                cmd.Parameters.Add(new SqlParameter("possibleToRepair", machine.isPossibleToRepair));

                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

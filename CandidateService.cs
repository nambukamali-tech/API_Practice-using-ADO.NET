using ADO.NET_APP.Models;
using MySqlConnector;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ADO.NET_APP.DataAccess
{
    public class CandidateService
    {
        private string connectionString = "server=localhost;user=root;password=16072003;database=CandidatesDB;";
        public Candidate GetCandidate(int id)
        {
            Candidate candidate = null;
            using (var conn = new MySqlConnection(connectionString))
            {
                using (var cmd = new MySqlCommand("GetCandidate", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_CandidateID", id);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            candidate = new Candidate
                            {
                                CandidateID = (int)reader["CandidateID"],
                                Name = reader["Name"].ToString(),
                                Stack = reader["Stack"].ToString(),
                                Education = reader["Education"].ToString(),
                                Place = reader["Place"].ToString()
                            };
                        }                  

                    }
                
                }
             
            }
            return candidate;
        }
        
    }
}

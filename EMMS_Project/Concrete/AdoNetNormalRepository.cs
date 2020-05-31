using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using EMMS_Project.Abstract;
using EMMS_Project.Models;
using MySql.Data.MySqlClient;

namespace EMMS_Project.Concrete
{
    public class AdoNetNormalRepository : INormalRepository
    {
        public IEnumerable<User> UserData
        {
            get
            {
                List<User> lstUser = new List<User>();
                var conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                MySqlConnection sqlConnection = new MySqlConnection(conn);
                string query = "select * from user";
                MySqlCommand comm = new MySqlCommand(query);
                comm.Connection = sqlConnection;
                sqlConnection.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    lstUser.Add(new User
                    {
                        id = (int)dr["id"],
                        user = dr["user"].ToString().Trim(),
                        password = dr["password"].ToString().Trim(),
                        fname = dr["fname"].ToString().Trim(),
                        lname = dr["lname"].ToString().Trim(),
                        is_admin = (int)dr["is_admin"]
                    });
                }
                sqlConnection.Close();

                return lstUser;
            }
        }

            
        
    }
}
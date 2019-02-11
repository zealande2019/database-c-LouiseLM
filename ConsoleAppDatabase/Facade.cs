using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleAppDatabase
{
    public static class Facade
    {
        public static List<Students> GetAllStudents()
        {
            string SelectAllStudents = "select * from student";
            string conn = "Server = tcp:zealand19f.database.windows.net,1433;Initial Catalog = student; Persist Security Info=False;User ID = { Louise Lytken Petersen Møller }; Password={Database123}; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
            using (SqlConnection databaseConnection = new SqlConnection(conn))
            {
                databaseConnection.Open();
                using (SqlCommand selectCommand = new SqlCommand(SelectAllStudents, databaseConnection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            string mobilNr = reader.GetString(2);
                            Students student = new Students();
                            GetAllStudents.Add(student);
                        }
                    }
                }
            }
        }
    }
}

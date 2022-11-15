using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleEditorClassLibrary;
using Microsoft.Data.SqlClient;


namespace ModuleDataLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey");
            Console.WriteLine("hello");
            Console.WriteLine("goodbye");


            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "a41035.mysql.mchost.ru";
            builder.UserID = "a41035_1";
            builder.Password = "Math535130";
            builder.InitialCatalog = "a41035_1";

            //Console.WriteLine(builder.ConnectionString);
            //return;

            using (SqlConnection connection = new SqlConnection("Data Source=a41035.mysql.mchost.ru;Initial Catalog=a41035_1;User ID=a41035_1;Password=Math535130"))
            {
                Console.WriteLine("\nQuery data example:");
                Console.WriteLine("=========================================\n");

                String sql = "SELECT name, collation_name FROM sys.databases";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                        }
                    }
                }
            }

        }
    }
}

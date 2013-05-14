using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CrazyTechGuys.Filetables.DAL
{
    public class GenericDAL
    {

        public List<CrazyTechGuys.Filetables.DAL.File> ListFiles()
        {
            var lst = new List<CrazyTechGuys.Filetables.DAL.File>();

            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=CTG_FileStreamExample;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("Select * from dbo.Documentos", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var file = new CrazyTechGuys.Filetables.DAL.File();
                    file.Name = (string)reader["Name"];
                    file.Extension = (string) reader["file_type"];
                    lst.Add(file);
                }
            }
            return lst;
        }


    }

}

using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Windows.Forms;

namespace проект
{
    public class SQLiteDataAccess
    {
        public static List<Friend> LoadPeopleList()
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Friend>("select * from Friend", new DynamicParameters());

                return output.ToList();
            }
        }

        public static Friend LoadPeople(int Id)
        {
            List<Friend> List_Of_Friends = SQLiteDataAccess.LoadPeopleList();

            foreach (Friend f in List_Of_Friends)
            {
                if (f.Id == Id)
                    return f;
            }

            return null;
        }

        public static void DeletePeople(int Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string SQL_input = $"DELETE FROM Friend WHERE Id = {Id}";

                cnn.Execute(SQL_input);
            }
        }

        public static void ChangePeople(Friend ChangedFriend)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string SQL_input = "UPDATE Friend SET PhotoPath = @PhotoPath, FirstName = @FirstName, LastName = @LastName, SurName = @SurName, Date = @Date, Description = @Description, FullDescription = @FullDescription, PhoneNumber = @PhoneNumber, LFS = @LFS WHERE Id = @Id";

                cnn.Execute(SQL_input, ChangedFriend);
            }
        }

        public static void SavePerson(Friend person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string SQL_input = "insert into Friend (PhotoPath,FirstName, LastName, SurName, Date, Description, FullDescription, PhoneNumber, LFS) values (@PhotoPath, @FirstName, @LastName, @SurName, @Date, @Description, @FullDescription, @PhoneNumber, @LFS)";

                cnn.Execute(SQL_input, person);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

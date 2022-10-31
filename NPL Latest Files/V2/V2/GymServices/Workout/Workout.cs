using GymServices.Workout.Interface;
using GymServices.Workout.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymServices.Workout
{
    public class Workout: IWorkout
    {
        SqlHelper sqlHelper = new SqlHelper("server=tcp:nplappserver.database.windows.net,1433;Initial Catalog=nplDB;Persist Security Info=False;User ID=npladmin;Password=NPLgym007;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public string GetWorkouts(string email)
        {
            string output = sqlHelper.ExecuteInLineSql($"SELECT * FROM Workouts WHERE Email = '{email}'");
            return output;
        }

        public void InsertWorkouts(InsertWorkout collection)
        {
            foreach (var item in collection.Picture)
            {
                string output = sqlHelper.ExecuteInLineSql($"EXEC InsertWorkout '{collection.Email}','{item.ToString()}'");
            }
            
        }
    }
}

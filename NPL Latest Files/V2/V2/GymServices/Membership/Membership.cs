using GymServices.Membership.Interface;
using GymServices.Membership.Model;

namespace GymServices.Membership
{
    public class Membership : IMembership
    {
        SqlHelper sqlHelper = new SqlHelper("server=tcp:nplappserver.database.windows.net,1433;Initial Catalog=nplDB;Persist Security Info=False;User ID=npladmin;Password=NPLgym007;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public string GetMembership(string email)
        {
            string output = sqlHelper.ExecuteInLineSql($"SELECT * FROM Membership WHERE Email = '{email}'");
            return output;
        }

        public void InsertMembership(InsertMembership Items)
        {
            string output = sqlHelper.ExecuteInLineSql($"EXEC InsertMember '{Items.Email}','{Items.Name}','{Items.Surname}','{Items.Picture}','{Items.level}'");
        }
    }
}
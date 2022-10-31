using GymServices.ProgressService.Interface;
using GymServices.ProgressService.Model;

namespace GymServices.ProgressService;

public class Progress : IProgress
{
    SqlHelper sqlHelper = new SqlHelper("server=tcp:nplappserver.database.windows.net,1433;Initial Catalog=nplDB;Persist Security Info=False;User ID=npladmin;Password=NPLgym007;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    public string GetProgress(string email)
    {
        string output = sqlHelper.ExecuteInLineSql($"SELECT * FROM Progress WHERE Email = '{email}'");
        return output;
    }

    public void InsertProgress(InsertProgress Items)
    {
        string output = sqlHelper.ExecuteInLineSql($"EXEC InsertProgress '{Items.Email}','{Items.Comment}','{Items.Picture}','{Items.Cycle}'");
    }

    public void UpdateProgress(UpdateProgress Items)
    {
        string output = sqlHelper.ExecuteInLineSql($"EXEC UpdateProgress '{Items.Email}','{Items.Comment}','{Items.Cycle}'");
    }

    public string GetProgressWhereNull()
    {
        string output = sqlHelper.ExecuteInLineSql($"SELECT * FROM Progress WHERE Comments = ''");
        return output;
    }


}


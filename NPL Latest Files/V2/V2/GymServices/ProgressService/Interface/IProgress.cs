using GymServices.ProgressService.Model;

namespace GymServices.ProgressService.Interface;

public interface IProgress
{
    string GetProgress(string email);

    void InsertProgress(InsertProgress Items);

    void UpdateProgress(UpdateProgress Items);

    string GetProgressWhereNull();
}


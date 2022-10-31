using GymServices.Membership.Model;

namespace GymServices.Membership.Interface
{
    public interface IMembership
    {
        string GetMembership(string email);

        void InsertMembership(InsertMembership Items);
    }
}

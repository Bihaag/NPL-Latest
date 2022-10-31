using GymServices.Workout.Model;


namespace GymServices.Workout.Interface
{
    public interface IWorkout
    {
        string GetWorkouts(string email);

        void InsertWorkouts(InsertWorkout collection);

    }
}

using GymServices.Workout.Interface;
using GymServices.Workout.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GymAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class WorkoutController : ControllerBase
    {
        private readonly IWorkout _IWorkout;
        public WorkoutController(IWorkout IWorkout)
        {
            _IWorkout = IWorkout;
        }

        [HttpPost]
        public string GetWorkouts([FromBody] string email)
        {
            return _IWorkout.GetWorkouts(email);
        }

        [HttpPost]
        public ActionResult InsertWorkouts([FromBody] InsertWorkout InsertWorkout)
        {
            try
            {
                _IWorkout.InsertWorkouts(InsertWorkout);
                return Ok(new { response = "123" });
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}

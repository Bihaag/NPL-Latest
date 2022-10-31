using GymServices.ProgressService.Interface;
using GymServices.ProgressService.Model;
using Microsoft.AspNetCore.Mvc;

namespace GymAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ProgressController : ControllerBase
    {
        private readonly IProgress _IProgress;
        public ProgressController(IProgress Progress)
        {
            _IProgress = Progress;
        }

        [HttpPost]
        public string GetProgress([FromBody] string email)
        {
            return _IProgress.GetProgress(email);
        }

        [HttpPost]
        public string GetProgressWhereNull()
        {
            return _IProgress.GetProgressWhereNull();
        }

        [HttpPost]
        public ActionResult InsertProgress([FromBody] InsertProgress Items) 
        {
            try
            {
                _IProgress.InsertProgress(Items);
                return Ok(new { response = "123" });
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public ActionResult UpdateProgress([FromBody] UpdateProgress Items)
        {
            try
            {
                _IProgress.UpdateProgress(Items);
                return Ok(new { response = "123" });
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}

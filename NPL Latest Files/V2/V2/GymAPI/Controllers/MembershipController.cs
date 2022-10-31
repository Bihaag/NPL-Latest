using GymServices.Membership.Interface;
using GymServices.Membership.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GymAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class MembershipController : ControllerBase
    {
        private readonly IMembership _IMembership;

        public MembershipController(IMembership Membership)
        {
            _IMembership = Membership;
        }

        [HttpPost]
        public string GetMembership([FromBody] string email)
        {
            return _IMembership.GetMembership(email);
        }

        [HttpPost]
        public ActionResult InsertMembership([FromBody] InsertMembership Items)
        {
            try
            {
                _IMembership.InsertMembership(Items);
                return Ok(new { response = "123" });
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}

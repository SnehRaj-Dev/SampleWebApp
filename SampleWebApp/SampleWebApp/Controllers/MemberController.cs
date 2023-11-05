using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleApi.Members.Data.Interface;
using SampleApi.Members.Data.Models;
using SampleApi.Members.Data.Repository;

namespace SampleWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private IMembers _members;
        public MemberController(IMembers members)
        {
            try
            {
                _members = members;
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        [HttpGet]
        [Route("GetAllMembers")]
        public ActionResult<IEnumerable<Member>> GetAllMembers()
        {
            try
            {
                return _members.GetAllMember();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
        [HttpGet]
        [Route("GetById")]
        public ActionResult<Member> GetMemberById(int id)
        {
            try
            {
                return _members.GetMember(id);
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
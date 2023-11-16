using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1_today.Models;

namespace WebApplication1_today.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMembers member;
        public MembersController(IMembers mem)
        {
            member = mem;
        }
        // GET: api/<MemberController>
        [HttpGet]
        public IEnumerable<Members> Get()
        {
            return member.GetAllMembers();
        }
        //GET: api/<MemberController>/name
        [HttpGet("{name}")]
        public IEnumerable<Members> Get(string name)
        {
            return member.GetAllMemberbyname(name);
        }
        //GET: api/<MemberController>/address
        [HttpGet("Address/{address}")]
        public IEnumerable<Members> GetAddress(string address)
        {
            return member.GetAllMemberbyaddress(address);
        }

        // GET api/<MemberController>/5
        [HttpGet("{id:int}")]
        public Members Get(int id)
        {
            return member.GetMember(id);
        }
        // POST api/<MemberController>
        [HttpPost]
        public Members Post([FromBody] Members memberpost)
        {
            return member.Add(memberpost);
        }
        // PUT api/<MemberController>/5
        [HttpPut("{id}")]
        public Members Put(int id, [FromBody] Members memberput)
        {
            return member.Update(id, memberput);
        }

        // DELETE api/<MemberController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            member.Delete(id);
        }

    }
}

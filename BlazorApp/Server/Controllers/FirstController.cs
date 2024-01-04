using Microsoft.AspNetCore.Mvc;
using BlazorApp.Server.Data;
using BlazorApp.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorApp.Server.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FirstController : ControllerBase
    {

        WebDbContext _appDbContext;

        public FirstController(WebDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // GET: 
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("/Pass")]
        public IEnumerable<Course> GetData()
        {
            return _appDbContext.courses.ToList();

            //return new string[] { "Student1", "Student2" , type };
        }

        // GET 
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST 
        [HttpPost]
        public IActionResult Post([FromBody] Course cus)
        {
            try
            {
                _appDbContext.courses.Add(cus);
                _appDbContext.SaveChanges();

                return Ok("Message:Save successfuly");
            }
            catch
            {
                return BadRequest();
            }
        }

        // PUT 
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE 
        [HttpDelete("{id}")]
        public void Delete(int id)
        {


        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using ForWebApi.Data;
using ForWebApi.Models;
using ForWebApi.Services.TestService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        // private static List<Test> tests = new List<Test>{
        //     new Test()
        // };

        private readonly DataContext _context;

        public TestController(DataContext context)
        {
            _context = context;

        }

        [HttpPost("Post")]
        public async Task<ActionResult<ServiceResponse<Test>>> Post(Test newEl)
        {
            
            //tests.Add(newEl);
            _context.Tests.Add(newEl);
           
            await _context.SaveChangesAsync();
            var db = await _context.Tests.ToListAsync();
            return Ok(db);


        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Test>>> Get()
        {
            var db = await _context.Tests.ToListAsync();


            return Ok(db);

            // Test test = newEl;
            //  test.Id = tests.Max(c => c.Id) +1;
            // tests.Add(test);


            // return Ok(tests);
        }

    }
}
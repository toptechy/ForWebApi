using System.Collections.Generic;
using ForWebApi.Models;

namespace ForWebApi.Services.TestService
{
    public class TestService : ITestService
    {
        private static List<Test> tests = new List<Test>{
            new Test()
        };
        
        public List<Test> Get()
        {
            return tests;
        }

        public List<Test> Post(Test newEl)
        {
            throw new System.NotImplementedException();
        }
    }
}
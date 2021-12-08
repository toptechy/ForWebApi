using System.Collections.Generic;
using ForWebApi.Models;

namespace ForWebApi.Services.TestService
{
    public interface ITestService
    {
         List<Test> Get();
         List<Test> Post(Test newEl);
    }
}
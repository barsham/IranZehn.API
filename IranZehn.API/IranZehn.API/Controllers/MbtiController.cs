using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using IranZehn.API.Controllers.Mbti.Services;
using IranZehn.API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace IranZehn.API.Controllers
{
    [Route("/[controller]")]
    public class MbtiAssessmentController : Controller
    {

        private readonly IMbtiAssessmentService _mbtiService;

        //public MbtiAssessmentController()
        //{
        //    _mbtiService = new MbtiAssessmentService();
        //}

        public MbtiAssessmentController(
             IMbtiAssessmentService mbtiService)
        {
            _mbtiService = mbtiService;
        }


        //[HttpGet(Name = nameof(GetMbtiAssessmentAsync))]
        //public async Task<IActionResult> GetMbtiAssessmentAsync(
        //    [FromQuery] string request,
        //    CancellationToken ct)
        //{

        //    AssessmentRegistrationResultDto result = await _mbtiService.RegisterAssessment(null);

        //    return Ok(result);

        //}

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value" + id.ToString();
        //}

        // POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{

        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

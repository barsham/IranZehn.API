using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IranZehn.API.DTOs;

namespace IranZehn.API.Controllers.Mbti.Services
{
    public class MbtiAssessmentService : IMbtiAssessmentService
    {
        public Task<AssessmentRegistrationResultDto> RegisterAssessment(AssessmentRegistrationParameterDto request)
        {
            return new Task<AssessmentRegistrationResultDto>(() =>
            {
                return new AssessmentRegistrationResultDto()
                {
                    TokenId = "456"
                };
            });

        }

    }
}

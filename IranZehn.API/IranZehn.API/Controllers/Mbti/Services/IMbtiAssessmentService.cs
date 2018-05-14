using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IranZehn.API.DTOs;

namespace IranZehn.API.Controllers.Mbti.Services
{
    public interface IMbtiAssessmentService
    {
        
        Task<AssessmentRegistrationResultDto> RegisterAssessment(AssessmentRegistrationParameterDto request);
    }
}

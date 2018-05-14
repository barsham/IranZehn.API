using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IranZehn.API.DTOs
{

    /// <summary>
    /// Response of assessment initiate
    /// </summary>
    [Serializable]
    public class AssessmentRegistrationResultDto
    {
        /// <summary>
        /// Original Request
        /// </summary>
        public AssessmentRegistrationParameterDto Request { get; set; }
        /// <summary>
        /// Unique Token Id for tracing purposes
        /// </summary>
        public string TokenId { get; set; }
        /// <summary>
        /// List of Questions
        /// </summary>
        public List<Question> Questiones { get; set; }
        /// <summary>
        /// List of Errors
        /// </summary>
        public List<string> Errors { get; set; }

    }
}
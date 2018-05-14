using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using IranZehn.BLL;

namespace IranZehn.API.DTOs
{
    /// <summary>
    /// Result of MBTI Test
    /// </summary>
    [Serializable]
    public class AssessmentResponse
    {
        
        internal AssessmentResponse()
        {
            Errors = new List<string>();
        }

        /// <summary>
        /// Initial Request
        /// </summary>
        public AssessmentRequest Request { get; set; }


        /// <summary>
        /// Indicates that test require operator to answer Complementary Question 1
        /// </summary>
        public bool ComplementaryQuestion1Required { get; set; }

        /// <summary>
        /// Indicates that test require operator to answer Complementary Question 2
        /// </summary>
        public bool ComplementaryQuestion2Required { get; set; }
        /// <summary>
        /// Indicates that test require operator to answer Complementary Question 3
        /// </summary>
        public bool ComplementaryQuestion3Required { get; set; }
        /// <summary>
        /// Indicates that test require operator to answer Complementary Question 4
        /// </summary>
        public bool ComplementaryQuestion4Required { get; set; }

        /// <summary>
        /// Complementary Questions if requires
        /// </summary>
        public List<ComplementaryQuestion> ComplementaryQuestions { get; set; }

        /// <summary>
        /// Contains test result if everything is fine.
        /// </summary>
        public TestResult TestResut;
        /// <summary>
        /// List of Errors
        /// </summary>
        public List<string> Errors { get; set; }
 
    }
}
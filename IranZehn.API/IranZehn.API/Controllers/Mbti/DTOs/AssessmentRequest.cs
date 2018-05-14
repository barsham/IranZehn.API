using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IranZehn.API.DTOs
{
    public class AssessmentRequest
    {
        /// <summary>
        /// Unique Token Id for tracing purposes
        /// </summary>
        public string TokenId { get; set; }
        /// <summary>
        /// Initial Answers
        /// </summary>
        public List<Answer> Answers { get; set; }
        /// <summary>
        /// ComplementaryAnswer 1
        /// </summary>
        //public ComplementaryAnswerTypes ComplementaryAnswer1 { get; set; }
        ///// <summary>
        ///// ComplementaryAnswer 2
        ///// </summary>
        //public BLL.Answer.ComplementaryAnswerTypes ComplementaryAnswer2 { get; set; }
        ///// <summary>
        ///// ComplementaryAnswer 3
        ///// </summary>
        //public BLL.Answer.ComplementaryAnswerTypes ComplementaryAnswer3 { get; set; }
        ///// <summary>
        ///// ComplementaryAnswer 4
        ///// </summary>
        //public BLL.Answer.ComplementaryAnswerTypes ComplementaryAnswer4 { get; set; }
    }
}
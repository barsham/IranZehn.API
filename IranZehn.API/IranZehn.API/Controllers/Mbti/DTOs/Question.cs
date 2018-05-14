using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IranZehn.API.DTOs
{
    public class Question
    {
        public int No { get; set; }
        public int QuestionId { get; set; }
        public string QuestionContent { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IranZehn.API.DTOs
{
    public class TestResult
    {
        /// <summary>
        /// MBTI Type
        /// </summary>
        public string MBTIType { get; set; }

        /// <summary>
        /// I/E Percentage
        /// </summary>
        public int Percentage1 { get; set; }
        /// <summary>
        /// S/N Percentage
        /// </summary>
        public int Percentage2 { get; set; }
        /// <summary>
        /// T/F Percentage
        /// </summary>
        public int Percentage3 { get; set; }
        /// <summary>
        /// P/J Percentage
        /// </summary>
        public int Percentage4 { get; set; }
    }
}

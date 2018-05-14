using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IranZehn.API.DTOs
{

    public class Enums
    {
        /// <summary>
        /// Assessment (Test) types
        /// </summary>
        public enum AssessmentTypes
        {
            /// <summary>
            /// Myers-Briggs Type Indicator
            /// </summary>
            MBTI = 0
        }


        public enum GenderTypes
        {
            Mail,
            Femail,
        }

        public enum MarriageStatuses
        {
            Married,
            Single
        }

    }
}
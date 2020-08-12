using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Models
{
    class OnlineCourse : Course
    {
        public string Url { get; set; }

        protected OnlineCourse()
        {

        }
    }
}

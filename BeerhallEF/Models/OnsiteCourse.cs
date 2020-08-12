using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Models
{
    class OnsiteCourse : Course
    {
        private DateTime _dateTime;

        public TimeSpan? From { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan? Till { get; set; }

        protected OnsiteCourse()
        {

        }


    }
}

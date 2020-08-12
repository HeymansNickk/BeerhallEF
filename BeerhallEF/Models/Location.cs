using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Models
{
    class Location
    {
        #region Properties
        public string PostalCode { get; }
        public string Name { get; }
        #endregion

        #region Constructor

        public Location(string postalCode, string name)
        {
            PostalCode = postalCode;
            Name = name;
        }

        #endregion
    }
}

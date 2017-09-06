using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryIdentity.Models
{
    [Serializable]
    public abstract class PrintEdition
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Publisher { get; set; }
        public int Id { get; set; }
    }
}
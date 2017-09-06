using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryIdentity.Models
{
    [Serializable]
    public class Newspaper : PrintEdition
    {
        public string Category { get; set; }
    }
}
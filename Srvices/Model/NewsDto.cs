using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess1;

namespace Srvices.Model
{
    public class NewsDto
    {
        public string title { get; set; }

        
        public string description { get; set; }

        
        public string userCreate { get; set; }

 
        public string userModif { get; set; }

        public DateTime creationDate { get; set; }

        public DateTime updateDate { get; set; }

        public virtual users users { get; set; }

        public virtual users users1 { get; set; }
    }
}

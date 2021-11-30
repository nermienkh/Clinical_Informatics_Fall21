using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myclinic_tabs.Models
{
    class Patient
    {
        public string PAT_ID { get; set; }
        public string PAT_NationalID { get; set; }
        public string PAT_FNAME { get; set; }
        public string PAT_LNAME { get; set; }
        public DateTime PAT_DOB { get; set; }
        public string PAT_PHONE { get; set; }
      
    }
}

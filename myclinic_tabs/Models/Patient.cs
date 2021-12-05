using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace myclinic_tabs.Models
{
    class Patient
    {
        [Required(ErrorMessage = "ID is required")]
        public string PAT_ID { get; set; }
        [Required]
        [RegularExpression("(2|3)[0-9][1-9][0-1][1-9][0-3][1-9](01|02|03|04|11|12|13|14|15|16|17|18|19|21|22|23|24|25|26|27|28|29|31|32|33|34|35|88)",ErrorMessage ="Please enter a valid Natinal ID")]
        public string PAT_NationalID { get; set; }
        [StringLength(10)]
        public string PAT_FNAME { get; set; }
        public string PAT_LNAME { get; set; }
        public DateTime PAT_DOB { get; set; }
        [RegularExpression("(201)[0-9]{9}")]
        public string PAT_PHONE { get; set; }
        [Range(1, 150, ErrorMessage = "Age must be between 1 and 150")]
        public int Age { set; get; }
    }
}

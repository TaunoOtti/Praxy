using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cv
    {
        public int CvId { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }

        public DateTime CvCreatedOn { get; set; }
        public DateTime CvUpdatedOn { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDDB.Models
{
    public class LJResponse
    {
        public string Status { get; set; }
        public List<Job> pending { get; set; }
        public List<Job> running { get; set; }
        public List<Job> finished { get; set; }
    }
}

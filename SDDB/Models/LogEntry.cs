using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDDB.Models
{
    [Table("ScrapyDelegatorLogs")]
    public class LogEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LogEntryId { get; set; }
        public string Method { get; set; }
        public string IpAddress { get; set; }
        public string Body { get; set; }
        public DateTime Timestamp { get; set; }
        public int? StatusCode { get; set; }
    }
}

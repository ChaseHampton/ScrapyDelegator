using SDDB.Models;

namespace SDDB
{
    public class DbLogger : IDbLogger
    {
        private readonly SDDBContext _db;
        public DbLogger(SDDBContext db)
        { 
            _db = db;
        }

        public void LogRequest(string method, string ipAddress, string body, DateTime timestamp, int? statusCode)
        {
            var logEntry = new LogEntry
            {
                Method = method,
                IpAddress = ipAddress,
                Body = body,
                Timestamp = timestamp,
                StatusCode = statusCode
            };

            _db.Logs.Add(logEntry);
            _db.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDDB
{
    public interface IDbLogger
    {
        void LogRequest(string method, string ipAddress, string body, DateTime timestamp, int? statusCode);
    }
}

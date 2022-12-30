using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers
{
    public class DBLogger : LoggerServiceBase
    {
        public DBLogger() : base("DatabaseLogger")
        {

        }
    }
}

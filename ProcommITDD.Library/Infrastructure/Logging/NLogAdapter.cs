using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace ProcommITDD.Library.Infrastructure.Logging
{
    public class NLogAdapter : ILogger
    {
        private readonly Logger _log;

        public NLogAdapter()
        {
            _log = LogManager.GetCurrentClassLogger();
        }

        public void Log(string message)
        {
            _log.Info(message);
        }
    }
}

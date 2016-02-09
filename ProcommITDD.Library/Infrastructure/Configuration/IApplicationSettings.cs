using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcommITDD.Library.Infrastructure.Configuration
{
    public interface IApplicationSettings
    {
        string LoggerName { get; }
    }
}

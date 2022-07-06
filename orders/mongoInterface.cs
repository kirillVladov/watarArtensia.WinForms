using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orders
{
    internal interface mongoInterface:DataBaseInterface
    {
        string connectUrl { get; set; }
        string databaseName { get; set; }
        string databaseTable { get; set; }
    }
}

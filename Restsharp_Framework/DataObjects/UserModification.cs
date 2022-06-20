using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restsharp_Framework.DataObjects
{
    public class UserModification
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}

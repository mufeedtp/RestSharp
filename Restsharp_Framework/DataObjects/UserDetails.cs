using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restsharp_Framework
{
    public partial class UserDetails
    {
        public long Page { get; set; }
        public long PerPage { get; set; }
        public long Total { get; set; }
        public long TotalPages { get; set; }
        public List<Datum> Data { get; set; }
        public Support Support { get; set; }
    }

    public partial class Datum
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public Uri Avatar { get; set; }
    }

    public partial class Support
    {
        public Uri Url { get; set; }
        public string Text { get; set; }
    }
}

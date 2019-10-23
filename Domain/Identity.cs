using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Domain
{
    public class Identity
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}

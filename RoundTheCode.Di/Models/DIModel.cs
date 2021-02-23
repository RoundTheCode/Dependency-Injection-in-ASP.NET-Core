using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoundTheCode.Di.Models
{
    public class DIModel
    {
        public string SingletonTime { get; set; }
        public string ScopedTime { get; set; }
        public string TransientTime { get; set; }
    }
}

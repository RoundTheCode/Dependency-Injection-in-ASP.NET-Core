using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoundTheCode.Di.Services
{
    public class SingletonService : ISingletonService
    {
        public string Time { get; set; }

        public SingletonService()
        {
            Time = DateTime.UtcNow.ToString("HH:mm:ss.ffffff");
        }
    }
}

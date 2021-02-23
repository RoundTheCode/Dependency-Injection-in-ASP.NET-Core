using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoundTheCode.Di.Services
{
    public class TransientService : ITransientService
    {
        public string Time { get; set; }

        public TransientService()
        {
            Time = DateTime.UtcNow.ToString("HH:mm:ss.ffffff");  
        }
    }
}

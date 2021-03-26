using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webrtc_dotnetcore.Models
{
    public class RegisterForm
    {
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserPasswordr { get; set; }
        public bool RemeberMe { get; set; }
    }
}

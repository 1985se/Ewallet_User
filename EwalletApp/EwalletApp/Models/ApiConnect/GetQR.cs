using System;
using System.Collections.Generic;
using System.Text;

namespace EwalletApp.Models.ApiConnect
{
   public class GetQR
    {
        public string Email { get; set; }
        public decimal Amount { get; set; }
        public int AccType { get; set; }
        public int transectionType { get; set; }
    }
}

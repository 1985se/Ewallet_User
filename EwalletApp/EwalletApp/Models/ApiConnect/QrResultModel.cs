using System;
using System.Collections.Generic;
using System.Text;

namespace EwalletApp.Models.ApiConnect
{
   public class QrResultModel
    {
        public string Qrcode { get; set; }
        public string QrRef { get; set; }
        public DateTime Exp { get; set; }
    }
}

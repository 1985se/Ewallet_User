using System;
using System.Collections.Generic;
using System.Text;

namespace EwalletApp.Models
{
   public static class ResultMessages
    {
        public enum MessagesStatus
        {
            Success,
            Unsuccess,
            UserActive,
            UserActive_DataUnFill,
            UserUnActive,
            ConfirmOtpError,
            ServiceError
        };
    }
}

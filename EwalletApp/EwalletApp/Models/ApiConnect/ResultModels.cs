using System;
using System.Collections.Generic;
using System.Text;

namespace EwalletApp.Models
{
  public  class ResultModels<T>
    {
        public ResultMessages.MessagesStatus Message { get; set; }
        public List<T> Data { get; set; }
    }
}

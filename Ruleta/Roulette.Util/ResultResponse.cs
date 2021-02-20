using System;
using System.Collections.ObjectModel;

namespace Roulette.Util
{
    public class ResultResponse<T>
    {
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public int RowsAffected { get; set; }
        public Collection<T> ResultData { get; set; }
    }
}

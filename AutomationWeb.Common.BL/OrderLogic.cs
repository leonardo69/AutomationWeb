using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutomationWeb.Common.BL.Contract;
using AutomationWeb.Common.BL.Contract.Models;

namespace AutomationWeb.Common.BL
{
    public class OrderLogic: IOrderLogic
    {
        public Task<IEnumerable<OrderRecord>> GetAllOrderRecords(string deviceId)
        {
            throw new NotImplementedException();
        }
    }
}

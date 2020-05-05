using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutomationWeb.Common.BL.Contract.Models;

namespace AutomationWeb.Common.BL.Contract
{
    public interface IOrderLogic
    {
        Task<IEnumerable<OrderRecord>> GetAllOrderRecords(string deviceId);
    }
}

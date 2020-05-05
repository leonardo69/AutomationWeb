using System.Collections.Generic;
using System.Threading.Tasks;
using AutomationWeb.Common.Api.Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AutomationWeb.Common.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        ///     Get all order records
        /// </summary>
        /// <returns></returns>
        [HttpGet("allOrders")]
        public async Task<IList<OrderRecordDto>> GetAllOrderRecords()
        {
            var orderRecords = new List<OrderRecordDto>
            {
                new OrderRecordDto {Id = 1, Name = "test name", Description = "test Description", ThinkTypeId = 1}
            };

            var records = await Task.FromResult(orderRecords);
            return records;
        }


        /// <summary>
        ///     Get all order record types
        /// </summary>
        /// <returns></returns>
        [HttpGet("types")]
        public async Task<IList<OrderRecordThinkTypeDto>> GetAllOrderRecordTypes()
        {
            var orderRecordTypes = new List<OrderRecordThinkTypeDto>
            {
                new OrderRecordThinkTypeDto {Id = 1, Name = "test name"}
            };

            return await Task.FromResult(orderRecordTypes);
        }

        /// <summary>
        ///     Test get
        /// </summary>
        /// <returns></returns>
        [HttpGet("test")]
        public IActionResult Get()
        {
            return Ok(new {name = "Nik"});
        }
    }
}
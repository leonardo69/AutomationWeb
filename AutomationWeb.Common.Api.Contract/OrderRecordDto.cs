using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationWeb.Common.Api.Contract
{
    public class OrderRecordDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ThinkTypeId { get; set; }
    }
}

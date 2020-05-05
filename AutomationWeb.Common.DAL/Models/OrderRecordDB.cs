using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AutomationWeb.Common.DAL.Models
{
    public class OrderRecordDB
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }

        public int ThinkTypeId { get; set; }
    }
}

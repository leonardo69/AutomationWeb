﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationWeb.Common.BL.Contract.Models
{
    public class OrderRecord
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ThinkTypeId { get; set; }
    }
}

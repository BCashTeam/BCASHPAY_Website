using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentation.BcashPay.v2.Models
{
    public class Statistics
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string VariableName { get; set; }
        public string Value { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime LastUpdatedDateTime { get; set; }
    }
}
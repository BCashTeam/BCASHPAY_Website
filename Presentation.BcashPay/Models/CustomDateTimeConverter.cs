using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentation.BcashPay.v2.Models
{
    class CustomDateTimeConverter: IsoDateTimeConverter
    {
        public CustomDateTimeConverter (string format)
        {
            base.DateTimeFormat = format;
        }
    }
}
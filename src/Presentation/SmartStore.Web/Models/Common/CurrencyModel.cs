﻿using SmartStore.Web.Framework.Mvc;

namespace SmartStore.Web.Models.Common
{
    public partial class CurrencyModel : EntityModelBase
    {
        public string Name { get; set; }
        public string ISOCode { get; set; }
        public string Symbol { get; set; }
    }
}
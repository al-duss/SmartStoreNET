﻿using SmartStore.Admin.Models.Common;
using SmartStore.Web.Framework.Mvc;

namespace SmartStore.Admin.Models.Customers
{
    public class CustomerAddressModel : ModelBase
    {
        public int CustomerId { get; set; }

        public AddressModel Address { get; set; }
    }
}
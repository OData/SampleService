﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;

namespace ODataService.Models
{
    public class ProductFamily
    {
        public ProductFamily()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KitchenStoryCore.DomainModel;
using System.Threading.Tasks;

namespace KitchenStoryCore.CoreServices.Contracts.OrderDetailContracts
{
    public interface IOrderDetailInsertService
    {
        Task<int> insertSingleItem(OrderDetail OrderDetail);

    }
}

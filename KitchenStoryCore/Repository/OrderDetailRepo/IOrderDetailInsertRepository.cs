﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.OrderDetailRepo
{
    public interface IOrderDetailInsertRepository
    {
         Task<int> insertSingleItem(OrderDetail OrderDetail);

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KitchenStoryCore.DomainModel;
using System.Threading.Tasks;

namespace KitchenStoryCore.CoreServices.Contracts.BrandContracts
{
    public interface IBrandDeleteService
    {
        void deleteSingleItem(Brand targetBrand);


    }
}

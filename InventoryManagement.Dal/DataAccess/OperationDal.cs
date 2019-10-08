﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Dal.Context;
using InventoryManagement.Dal.Repository;
using InventoryManagement.Entities.Tables;

namespace InventoryManagement.Dal.DataAccess
{
    public class OperationDal: EntityRepositoryBase<InventoryManagementContext, Operation>
    {
    }
}
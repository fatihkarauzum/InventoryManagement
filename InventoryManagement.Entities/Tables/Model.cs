﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Entities.Abstract;

namespace InventoryManagement.Entities.Tables
{
    public class Model : ABaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid DeviceTypeId { get; set; }
        public virtual DeviceType DeviceType { get; set; }
        public ICollection<Store> Stores { get; set; }
    }
}

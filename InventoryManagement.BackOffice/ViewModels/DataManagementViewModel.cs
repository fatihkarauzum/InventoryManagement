﻿using System.Collections.Generic;
using System.Linq;
using Caliburn.Micro;
using DevExpress.Mvvm;
using InventoryManagement.Dal.Context;
using InventoryManagement.Entities.Tables;
using InventoryManagement.BackOffice.Models;

namespace InventoryManagement.BackOffice.ViewModels
{
    public class DataManagementViewModel : Screen
    {
        private InventoryManagementContext _inventoryManagementContext;
        public virtual IList<Operation> Operations { get; protected set; }
        public virtual IList<DataModel> DataModels { get; set; }

        public DataManagementViewModel()
        {
            if (!ViewModelBase.IsInDesignMode)
                InitializeInRuntime();
            else
                InitializeInDesingMode();
        }
        void InitializeInRuntime()
        {
            _inventoryManagementContext = new InventoryManagementContext();
            Operations = _inventoryManagementContext.Operations.ToList();
            DataModels = new List<DataModel>();
            foreach (var item in Operations)
            {
                var dataModel = new DataModel()
                {
                    Status = item.Store.Status.Name,
                    Name = item.Name,
                    Surname = item.Surname,
                    Model = item.Store.Model.Name,
                    SerialNumber = item.Store.SerialNumber,
                    Description = item.Description,
                    DeviceType = item.Store.Model.DeviceType.Name,
                    InventoryNumber = item.Store.InventoryNumber,
                    OperationType = item.OperationType.Name,
                    OperationTime = item.OperationTime,
                    Location = item.Location.Name,
                    Company = item.Company.Name
                };
                DataModels.Add(dataModel);
            }
        }

        void InitializeInDesingMode()
        {

        }
    }
}

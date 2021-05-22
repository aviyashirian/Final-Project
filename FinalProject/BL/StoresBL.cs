using System;
using System.Collections.Generic;
using FinalProject.DAL;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.BL
{
    public class StoresBL
    {
        private readonly StoresDAL _storesDAL;
        public StoresBL(BookStoreDbContext bookStoreDb)
        {
            this._storesDAL = new StoresDAL(bookStoreDb);
        }

        public List<Store> GetAll()
        {
            return this._storesDAL.GetAll();
        }
    }
}

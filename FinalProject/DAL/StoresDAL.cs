using System;
using System.Collections.Generic;
using System.Linq;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.DAL
{
    public class StoresDAL
    {
        private readonly DbSet<Store> _table;

        public StoresDAL(BookStoreDbContext bookStoreDb)
        {
            this._table = bookStoreDb.Stores;
        }

        public List<Store> GetAll()
        {
            return this._table.ToList();
        }
    }
}

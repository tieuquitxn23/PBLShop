using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using PBLShop.Data.Infrastructure;
using PBLShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
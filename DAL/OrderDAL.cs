﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDAL
    {
        RestaurantContextEntities dbContext;
        public OrderDAL()
        {
            dbContext = new RestaurantContextEntities();
        }
        public List<Order> GetListOrders()
        {
            return dbContext.Orders.ToList();
        }
        // return lại giá trị orderID
        public int AddOrder(Order o, List<OrderDetail> orderDetails)
        {
            using (DbContextTransaction transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    if (o != null)
                    {
                        var hoaDonTam = dbContext.Orders.Add(new Order()
                        {
                            OrderDate = o.OrderDate,
                            IsPaid = false,
                            Total = o.Total,
                            CustomerID = o.CustomerID,
                            TableID = o.TableID,
                            EmployeeID = o.EmployeeID,
                            OrderDetails = orderDetails
                        });
                        dbContext.SaveChanges();
                        foreach (OrderDetail chiTiet in o.OrderDetails)
                        {
                            chiTiet.OrderID = hoaDonTam.OrderID;
                            dbContext.OrderDetails.Add(chiTiet);
                        }
                        dbContext.SaveChanges();
                        transaction.Commit();
                        return hoaDonTam.OrderID;
                    }
                    return -1;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return -1;
                }
            }

        }
        public bool SetPaid(int ID)
        {
            try
            {
                if (ID > 0)
                {
                    Order x = dbContext.Orders.Where(o => o.TableID == ID).FirstOrDefault();
                    if (x != null)
                    {
                        x.IsPaid = true;
                        dbContext.SaveChanges();
                        return true;

                    }
                    return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int FindOrderIDByTableID(int TableID)
        {
            try
            {
                if (TableID > 0)
                    return dbContext.Orders.Where(o => o.TableID == TableID).Select(o => o.OrderID).FirstOrDefault();
                return -1;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }

    }
}

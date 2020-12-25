﻿using System;
using System.Collections.Generic;
using System.Data.Objects.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        RestaurantContextEntities dbContext;
        public CustomerDAL()
        {
            dbContext = new RestaurantContextEntities();
        }
        public List<Customer> GetListCustomer()
        {
            return dbContext.Customers.ToList();
        }
        public bool AddCustomer(Customer e)
        {
            try
            {
                if (e != null)
                {
                    dbContext.Customers.Add(e);
                    dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditCustomer(Customer e)
        {
            try
            {
                if (e != null)
                {
                    Customer eTmp = dbContext.Customers.Where(d => d.CustomerID == e.CustomerID).FirstOrDefault();
                    if (eTmp == null)
                        return false;
                    eTmp.CustomerID = e.CustomerID;
                    eTmp.Name = e.Name;
                    eTmp.IsFemale = e.IsFemale;
                    eTmp.PhoneNumber = e.PhoneNumber;
                    eTmp.CMND = e.CMND;
                    dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Customer SearchCustomerByName(string name)
        {
            // Trả về ds nếu có người có tên giống nhau
            try
            {
                if (name != null)
                    return dbContext.Customers.Where(c => c.Name == name).FirstOrDefault();
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<string> Name_SearchCustomerByName(string name)
        {
            // Trả về ds nếu có người có tên giống nhau
            try
            {
                if (name != null)
                    return dbContext.Customers.Where(x => x.Name.StartsWith(name))
                             .Select(c => c.Name).ToList();
                return null;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public List<Customer> Sreach(string x, int k, int page, int recordNum)
        {
            if (k == 0) // cac loai ko can phan loai
            {
                return dbContext.Customers.Where(y => y.Name.Contains(x) || y.CMND.StartsWith(x) || y.PhoneNumber.Contains(x))
                    .OrderBy(s => s.CustomerID).Skip((page - 1) * recordNum).Take(recordNum).ToList();
            }
            if (k == 1) //nam
            {
                return dbContext.Customers.Where(y => y.IsFemale == false).ToList();
            }
            if (k == 2)//nu
            {
                return dbContext.Customers.Where(y => y.IsFemale == true).ToList();
            }
            if (k == 3)//nam + string x
            {
                return dbContext.Customers.Where(y => y.IsFemale == false && (y.Name.Contains(x)
                || y.CMND.StartsWith(x) || y.PhoneNumber.Contains(x)
                || SqlFunctions.StringConvert((double)y.CustomerID).TrimStart().StartsWith(x)))
                .OrderBy(s => s.CustomerID).Skip((page - 1) * recordNum).Take(recordNum).ToList();
            }
            if (k == 4)//nu + string x
            {
                return dbContext.Customers.Where(y => y.IsFemale == true && (y.Name.Contains(x)
                || y.CMND.StartsWith(x) || y.PhoneNumber.Contains(x)
                || SqlFunctions.StringConvert((double)y.CustomerID).TrimStart().StartsWith(x)))
                .OrderBy(s => s.CustomerID).Skip((page - 1) * recordNum).Take(recordNum).ToList();
            }
            return dbContext.Customers.ToList();

        }
        public List<Customer> LoadRecord(int page, int recordNum)
        {
            List<Customer> result = new List<Customer>();
            result = dbContext.Customers.Where(e => e.Status == 1).OrderBy(s => s.CustomerID).Skip((page - 1) * recordNum).Take(recordNum).ToList(); //bỏ qua những cái đã load chỉ lấy phần cần lấy

            return result;
        }

        public bool DeleteCustomer(int ID)
        {
            Customer e = dbContext.Customers.Where(d => d.CustomerID == ID).FirstOrDefault();
            try
            {
                if (ID >= 0 && e != null)
                {
                    e.Status = 0; //0: xóa - 1: còn book lịch
                    dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public int GetCustomerID(Customer c)
        {
            try
            {
                if (c != null)
                    return dbContext.Customers.Where(x => x.CustomerID == c.CustomerID).Select(y => y.CustomerID).FirstOrDefault();
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CustomerBLL
    {
        CustomerDAL customerDAL;
        public CustomerBLL()
        {
            customerDAL = new CustomerDAL();
        }

        public List<Customer> GetListCustomer()
        {
            return customerDAL.GetListCustomer();
        }
        public bool EditCustomer(Customer e)
        {
            return customerDAL.EditCustomer(e);
        }

        public bool AddCustomer(Customer e)
        {
            return customerDAL.AddCustomer(e);
        }

        public bool DeleteCustomer(int ID)
        {
            return customerDAL.DeleteCustomer(ID);
        }
        public Customer SearchCustomerByName(string name)
        {
            return customerDAL.SearchCustomerByName(name);
        }
        public List<string> Name_SearchCustomerByName(string name)
        {
            return customerDAL.Name_SearchCustomerByName(name);
        }
        public int GetCustomerID(Customer c)
        {
            return customerDAL.GetCustomerID(c);
        }

        public List<Customer> LoadRecord(int page, int recordNum)
        {
            return customerDAL.LoadRecord(page, recordNum);
        }

        public List<Customer> Sreach(string x, int k, int page, int recordNum)
        {
            return customerDAL.Sreach(x, k, page, recordNum);
        }
    }
}

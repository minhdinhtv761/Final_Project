﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TableBLL
    {
        TableDAL tableDAL;
        public TableBLL()
        {
            tableDAL = new TableDAL();
        }
        public List<Table> GetListTable()
        {
            return tableDAL.GetListTable();
        }
        public bool ChangeTableStatus(int TableID, bool isOrdered, bool isPaid, bool isBooked)
        {
            return tableDAL.ChangeTableStatus(TableID, isOrdered, isPaid, isBooked);
        }
        public bool EditTable(Table table)
        {
            return tableDAL.EditTable(table);
        }
        public bool AddTable(Table t)
        {
            return tableDAL.AddTable(t);
        }
        public bool DeleteTable(int ID)
        {
            return tableDAL.DeleteTable(ID);
        }
        public Table FindTableById(int ID)
        {
            return tableDAL.FindTableById(ID);
        }
        public List<Table> GetListTable_NotUsed()
        {
            return tableDAL.GetListTable_NotUsed();
        }
    }
}

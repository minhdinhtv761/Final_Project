﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using System.Globalization;

namespace GUI.User_Control
{
    public partial class UCOrder : UserControl
    {
        FoodDrinkBLL foodDrinkBLL;
        OrderBLL orderBLL;
        TableBLL tableBLL;
        OrderDetailBLL orderDetailBLL;
        Form_Restaurant mainform;
        int EmpID;
        int TabID;
        int CusID;
        int OrdID;
        List<OrderDetail> lsOrderDetail;
        Order orDer;
        bool readOnly;
        public UCOrder(Form_Restaurant form, List<OrderDetail> orderDetails, int EmployeeID, int TableID, int CustomerID, bool ReadOnly)
        {
            CusID = CustomerID;
            readOnly = ReadOnly;
            tableBLL = new TableBLL();
            orDer = new Order();
            orderBLL = new OrderBLL();
            orderDetailBLL = new OrderDetailBLL();
            foodDrinkBLL = new FoodDrinkBLL();
            EmpID = EmployeeID;
            TabID = TableID;
            mainform = form;
            lsOrderDetail = orderDetails;
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            if (readOnly == true)
            {
                btnSave.Visible = false;
                btnSave.Enabled = false;
                btnCancel.Visible = false;
                btnCancel.Enabled = false;
            }
            var dateNow = DateTime.Now;
            var date = dateNow.ToString("dd/MM/yyyy");
            lbDateOrder.Text = Convert.ToString(date);
            lbEmployeeID.Text = Convert.ToString(EmpID);
            lbTableID.Text = Convert.ToString(TabID);

            // Order
            orDer.CustomerID = CusID;
            //orDer.CustomerID = 10;
            orDer.EmployeeID = EmpID;
            orDer.IsPaid = false;
            orDer.TableID = TabID;
            orDer.OrderDate = dateNow;
            float total = 0;
            foreach (var item in lsOrderDetail)
            {
                total += (item.Price * item.Quantity);
            }
            orDer.Total = total;
            lbTotal.Text = total.ToString("#,#", CultureInfo.InvariantCulture);
            dataGridViewOrder.AutoGenerateColumns = false;
            dataGridViewOrder.DataSource = lsOrderDetail;
            dataGridViewOrder.ReadOnly = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "OrderID";
            column.Name = "Order ID";
            column.Visible = false;
            dataGridViewOrder.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "FoodDrinkID";
            column.Name = "Food Drink Name";
            dataGridViewOrder.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Quantity";
            column.Name = "Quantity";
            dataGridViewOrder.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Note";
            column.Name = "Note";
            dataGridViewOrder.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.Name = "Unit Price";
            dataGridViewOrder.Columns.Add(column);

            dataGridViewOrder.Columns[0].ReadOnly = true;
            dataGridViewOrder.Columns[1].ReadOnly = true;
            dataGridViewOrder.Columns[2].ReadOnly = true;
            dataGridViewOrder.Columns[4].ReadOnly = true;
            dataGridViewOrder.Columns[3].ReadOnly = false;

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to save?", "Save Notification", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //yes...
                bool Check = false;
                OrdID = (orderBLL.AddOrder(orDer, lsOrderDetail));
                if (OrdID != -1)
                {
                    if (tableBLL.ChangeTableStatus(TabID, true, false, false) == true)
                    {
                        Table table = tableBLL.FindTableById(TabID);
                        if (table.Status == 1)
                        {
                            // Bàn này đang được order và khách đến và order
                            CustomerBLL customerBLL = new CustomerBLL();
                            if (customerBLL.DeleteCustomer(CusID) == true)
                                Check = true;
                        }
                        else
                            Check = true;
                    }
                }
                if (Check == true)
                {
                    MessageBox.Show("Saved sucessfully");
                    orDer.OrderID = OrdID;
                    mainform.loadUCTable();
                }
                else
                    MessageBox.Show("Cannot save. Please try again!");
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            mainform.loadUcMenu_Order(TabID, CusID);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Cancel Notification", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //yes...
                // Lưu mọi thứ xuống database
                mainform.loadUCTable();
            }
        }

        private void dataGridViewOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var temp = dataGridViewOrder.Rows[e.RowIndex];
            int id = (int)temp.Cells["Order ID"].Value;
            string note = (string)temp.Cells["Note"].Value;
            foreach (var item in lsOrderDetail)
                if (item.FoodDrinkID == id)
                    item.Note = note;
            // Edit Data (NOTE)
        }

        private void dataGridViewOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridViewOrder.Columns[e.ColumnIndex].Name == "Food Drink Name")
            {
                if (e.Value != null)
                {
                    int ID = Convert.ToInt32(e.Value);
                    e.Value = foodDrinkBLL.GetFoodDrinkName(ID);
                    e.FormattingApplied = true;
                }
            }
            if (this.dataGridViewOrder.Columns[e.ColumnIndex].Name == "Unit Price")
            {
                if (e.Value != null)
                {
                    double Price = Convert.ToDouble(e.Value);
                    e.Value = Price.ToString("#,#", CultureInfo.InvariantCulture);
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Cancel Notification", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //yes...
                // Lưu mọi thứ xuống database
                mainform.loadUCTable();
            }
        }
    }
}

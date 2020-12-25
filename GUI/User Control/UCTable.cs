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

namespace GUI.User_Control
{
    public partial class UCTable : UserControl
    {
        TableBLL tableBLL;
        Form_Restaurant mainform;
        List<Table> lsTable_temp;
        OrderBLL orderBLL;
        OrderDetailBLL orderDetailBLL;
        public UCTable(Form_Restaurant form1)
        {
            orderBLL = new OrderBLL();
            orderDetailBLL = new OrderDetailBLL();
            tableBLL = new TableBLL();
            lsTable_temp = tableBLL.GetListTable();
            orderBLL = new OrderBLL();
            mainform = form1;
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            //CustomerServiceClient cus = new CustomerServiceClient();
            //Table[] lstTable = cus.GetListTable();
            btnBook.Visible = false;
            btnBook.Enabled = false;
            btnOrder.Visible = false;
            btnOrder.Enabled = false;
            btnPay.Visible = false;
            btnPay.Enabled = false;
            List<Table> lstTable = tableBLL.GetListTable();
            foreach (Table item in lstTable)
            {
                if (item.Status == 3)
                    continue;
                myButton btn = new myButton();
                btn.objectID = item.TableID;
                btnPay.objectID = item.TableID;
                btnBook.objectID = item.TableID;
                btnOrder.objectID = item.TableID;
                btn.Width = flpTable1.Width / 6;
                btn.Margin = new Padding(0, 0, 10, 10);
                // btn.Height = 50;
                btn.Height = flpTable1.Width / 6 - 100;
                btn.Text = item.TableName;
                btn.Font = new Font("SVN-Avo", 8f);
                btn.ForeColor = Color.White;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 1;
                switch (item.Status)
                {
                    case 0:
                        {
                            // Trống
                            btn.BackColor = Color.FromArgb(247, 204, 217);
                            btn.FlatAppearance.BorderColor = Color.FromArgb(247, 204, 217);
                            break;
                        }
                    case 1:
                        {
                            // Đã được đặt
                            btn.BackColor = Color.FromArgb(248, 168, 60);
                            btn.FlatAppearance.BorderColor = Color.FromArgb(248, 168, 60);
                            break;
                        }
                    case 2:
                        {
                            // Có người ngồi
                            btn.BackColor = Color.FromArgb(228, 76, 73);
                            btn.FlatAppearance.BorderColor = Color.FromArgb(228, 76, 73);
                            break;
                        }
                }
                btn.MouseClick += Btn_MouseClick;
                //btn.MouseDoubleClick += Btn_MouseDoubleClick;
                btn.DoubleClick += Btn_DoubleClick;
                flpTable1.Controls.Add(btn);
            }
        }

        private void Btn_MouseClick(object sender, MouseEventArgs e)
        {
            myButton btn = sender as myButton;

            foreach (var item in lsTable_temp)
            {

                if (item.TableID == btn.objectID)
                {
                    switch (item.Status)
                    {
                        case 0:
                            {
                                // Trống
                                btnBook.objectID = item.TableID;
                                btnOrder.objectID = item.TableID;

                                btnOrder.Visible = true;
                                btnOrder.Enabled = true;
                                btnPay.Visible = false;
                                btnPay.Enabled = false;
                                btnBook.Visible = true;
                                btnBook.Enabled = true;
                                break;
                            }
                        case 1:
                            {
                                // Đã có ng đặt
                                btnOrder.objectID = item.TableID;

                                btnPay.Visible = false;
                                btnPay.Enabled = false;
                                btnOrder.Visible = true;
                                btnOrder.Enabled = true;
                                btnBook.Visible = false;
                                btnBook.Enabled = false;
                                break;
                            }
                        case 2:
                            {
                                btnPay.objectID = item.TableID;
                                // Đã có người vô ngồi
                                btnPay.Visible = true;
                                btnPay.Enabled = true;
                                btnOrder.Visible = false;
                                btnOrder.Enabled = false;
                                btnBook.Visible = false;
                                btnBook.Enabled = false;
                                break;
                            }
                    }
                }
            }
        }

        private void Btn_DoubleClick(object sender, EventArgs e)
        {
            myButton btn = sender as myButton;
            Table item = lsTable_temp.Find(x => x.TableID == btn.objectID);
            if (item != null)
            {
                if (item.Status == 2)
                {
                    List<Order> orders = orderBLL.GetListOrders();
                    List<OrderDetail> orderDetails_ThisTable = new List<OrderDetail>();
                    List<OrderDetail> allorderDetails = orderDetailBLL.GetListOrderDetails();
                    if (allorderDetails != null)
                    {

                        Order order = orders.Find(x => x.TableID == item.TableID && x.IsPaid == false);
                        if (order != null)
                        {
                            foreach (var o in allorderDetails)
                            {
                                if (o.OrderID == order.OrderID && o != null)
                                {
                                    orderDetails_ThisTable.Add(o);
                                }
                            }
                            BookingTableBLL bookingTableBLL = new BookingTableBLL();
                            int cusID = bookingTableBLL.FindCustomerIDByTableID(btn.objectID);
                            if (cusID > 0)
                                mainform.loadUCOrder(orderDetails_ThisTable, btn.objectID, true, cusID);
                            else
                                mainform.loadUCOrder(orderDetails_ThisTable, btn.objectID, true, 10);
                        }
                        else
                            MessageBox.Show("Không thể thực hiện!");

                    }
                    else
                        MessageBox.Show("Không thể thực hiện!");
                }
                else
                    MessageBox.Show("Không thể thực hiện!");
            }
            else
                MessageBox.Show("Không thể thực hiện!");

        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            mainform.loadUCTableEdit();
        }

        private void btnBook_Click_1(object sender, EventArgs e)
        {
            myButton btn = sender as myButton;
            Form_BookingTable f = new Form_BookingTable(mainform, btn.objectID);
            f.ShowDialog();
            f.Close();
        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            myButton btn = sender as myButton;
            BookingTableBLL bookingTableBLL = new BookingTableBLL();
            int cusID = bookingTableBLL.FindCustomerIDByTableID(btn.objectID);
            if (cusID > 0)
                mainform.loadUcMenu_Order(btn.objectID, cusID);
            else
                mainform.loadUcMenu_Order(btn.objectID, 10);


        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            myButton btn = sender as myButton;
            Table item = lsTable_temp.Find(x => x.TableID == btn.objectID);
            if (item != null)
            {
                List<Order> orders = orderBLL.GetListOrders();
                if (orders != null)
                {
                    List<OrderDetail> orderDetails_ThisTable = new List<OrderDetail>();
                    List<OrderDetail> allorderDetails = orderDetailBLL.GetListOrderDetails();
                    if (allorderDetails != null)
                    {
                        Order order = orders.Find(x => x.TableID == item.TableID && x.IsPaid == false);
                        if (order != null)
                        {
                            bool check = true;
                            foreach (var o in allorderDetails)
                            {
                                if (order == null || o == null)
                                {
                                    MessageBox.Show("Không thể thanh toán !");
                                    check = false;
                                    break;
                                }
                                if (o.OrderID == order.OrderID)
                                {
                                    orderDetails_ThisTable.Add(o);
                                }
                            }
                            if (check == true)
                            {
                                BookingTableBLL bookingTableBLL = new BookingTableBLL();
                                int cusID = bookingTableBLL.FindCustomerIDByTableID(btn.objectID);
                                if (cusID > 0)
                                    mainform.loadUCOrderPay(orderDetails_ThisTable, btn.objectID, cusID);
                                else
                                    mainform.loadUCOrderPay(orderDetails_ThisTable, btn.objectID, 10);

                            }
                            else
                                MessageBox.Show("Không thể thanh toán !");
                        }
                        else
                            MessageBox.Show("Không thể thanh toán !");
                    }
                    else
                        MessageBox.Show("Không thể thanh toán !");
                }
                else
                    MessageBox.Show("Không thể thanh toán !");
            }
            else
                MessageBox.Show("Không thể thanh toán !");

        }
    }
}

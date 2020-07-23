using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Models.ViewModels;
using Win.rpt;

namespace Win
{
    public partial class UCSales : DevExpress.XtraEditors.XtraUserControl
    {

        Items item;
        public string transactionNumber;

        public UCSales()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                txtCustomer.Properties.DataSource = unitOfWork.CustomersRepo.Get();
                //    this.InventoryGridControl.DataSource = new BindingList<Inventory>(unitOfWork.InventoryRepo.Get(x => x.TransactionType != 4));
                this.cboCategoryRepo.DataSource = unitOfWork.CategoriesRepo.Get();
                this.cboItems.DataSource = unitOfWork.ItemsRepo.Get();
                this.cboTransactionType.DataSource = new TransactionType().TransactionTypes;
            }
            catch (Exception e)
            {

            }
        }

        void Search(string search)
        {
            try
            {
                if (search.Contains("@"))
                {
                    search = search.Split('@')[1];
                }
                if (string.IsNullOrEmpty(search))
                    return;
                UnitOfWork unitOfWork = new UnitOfWork(false, false);

                item = unitOfWork.ItemsRepo.Find(x => x.SN.Contains(search) || x.ItemName.Contains(search));
                this.txtDescription.Text = "";
                this.txtDescription.Text = $"Item Name: {item.ItemName} " + Environment.NewLine +
                                           $"SN: {item.SN}" + Environment.NewLine +
                                           $"Price: {item.RetailPrice}" + Environment.NewLine;
                if (item != null)
                    txtCustomer.Focus();

            }
            catch (Exception e)
            {

            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search(txtSearch.Text);

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (item == null)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                int Qty = 1;
                if (txtSearch.Text.Contains("@"))
                {
                    Qty = txtSearch.Text.Split('@')[0].ToInt();
                }
                if (txtCustomer.GetSelectedDataRow() is Customers customer)
                {
                    var inventory = new Inventory()
                    {
                        TransactionNumber = transactionNumber,
                        CustomerId = customer.Id,
                        CustomerName = customer.CustomerName,
                        Address = customer.Address,
                        ItemId = item.Id,
                        ItemName = item.ItemName,
                        CategoryId = item.CategoryId,
                        CategoryName = item.CategoryName,
                        UOM = item.UOM,
                        SKU = item.SKU,
                        SN = item.SN,
                        UnitPrice = item.UnitPrice,
                        OrderLevel = item.OrderLevel,
                        RetailPrice = item.RetailPrice,
                        TransactionType = 4,

                        TotalAmount = (Qty) * (item.RetailPrice)
                    };
                    inventory.QTY = Qty * -1;

                    unitOfWork.InventoryRepo.Insert(inventory);

                    unitOfWork.Save();
                }


                this.InventoryGridControl.DataSource = new BindingList<Inventory>(
                    unitOfWork.InventoryRepo.Get(
                        x => x.TransactionType == 4 && x.TransactionNumber == transactionNumber));
                item = null;
                txtSearch.Text = "";
                //txtCustomer.EditValue = null;
                txtDescription.Text = "";
                txtSearch.Focus();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void New()
        {
            try
            {
                if (InventoryGridView.RowCount > 0)
                {
                    if (Application.OpenForms["Main"] is Main frm)
                    {
                        frm.pnlBody.Controls.Clear();
                        frm.pnlBody.Controls.Add(new UCSales()
                        {
                            Dock = DockStyle.Fill
                        });
                    }
                }
                UnitOfWork unitOfWork = new UnitOfWork();
                var id = unitOfWork.InventoryRepo.Fetch().Select(x => new { x.Id, x.TransactionNumber }).OrderByDescending(x => x.Id).FirstOrDefault();
                this.transactionNumber = new IdHelper().GenerateIdNumber(id?.TransactionNumber);

                unitOfWork.InventoryRepo.Insert(new Inventory()
                {
                    TransactionType = Transaction.NEW.ToInt(),
                    TransactionNumber = transactionNumber
                });
                unitOfWork.Save();
                btnNew.Enabled = false;
                btnEnd.Enabled = true;
                btnCancel.Enabled = true;
                btnPrint.Enabled = false;
                pnlTransaction.Enabled = true;

                txtSearch.Focus();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void End()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                foreach (var i in unitOfWork.InventoryRepo.Get(x =>
                    x.TransactionType == 4 && x.TransactionNumber == transactionNumber && x.SN != null))
                {
                    i.TransactionType = Transaction.OUT.ToInt();
                }
                unitOfWork.Save();

                btnNew.Enabled = true;
                btnPrint.Enabled = true;
                btnEnd.Enabled = false;
                btnCancel.Enabled = false;

                pnlTransaction.Enabled = false;

            }
            catch (Exception e)
            {

            }
        }

        public void Cancel()
        {
            try
            {

                if (MessageBox.Show("Do you want to cancel this?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.InventoryRepo.Delete(x => x.TransactionNumber == transactionNumber);
                unitOfWork.Save();
                if (Application.OpenForms["Main"] is Main frm)
                {
                    frm.pnlBody.Controls.Clear();
                    frm.pnlBody.Controls.Add(new UCSales()
                    {
                        Dock = DockStyle.Fill
                    });
                }
                btnNew.Enabled = true;
                btnEnd.Enabled = false;
                btnCancel.Enabled = false;
                pnlTransaction.Enabled = false;
            }
            catch (Exception e)
            {

            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {

            New();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

            End();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();


        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            Search(txtSearch.Text);
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (InventoryGridView.GetFocusedRow() is Inventory item)
                {

                    if (MessageBox.Show("Do you want to delete this?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.InventoryRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }
            }
            catch (Exception exception)
            {

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var res = unitOfWork.InventoryRepo.Get(x => x.TransactionNumber == transactionNumber);
                frmReportViewer frmReportViewer = new frmReportViewer(
                    new rptPrintReceipt()
                    {
                        DataSource = res
                    });
                frmReportViewer.ShowDialog();

            }
            catch (Exception exception)
            {

            }
        }
    }
}

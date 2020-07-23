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
using Models;
using Models.Repository;
using Models.ViewModels;

namespace Win
{
    public partial class UCInventory : DevExpress.XtraEditors.XtraUserControl
    {
        public UCInventory()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(false, false);
                this.InventoryGridControl.DataSource = new BindingList<Inventory>(unitOfWork.InventoryRepo.Get(x => x.TransactionType != 4));
                this.cboCategoryRepo.DataSource = unitOfWork.CategoriesRepo.Get();
                this.cboItems.DataSource = unitOfWork.ItemsRepo.Get();
                this.cboTransactionType.DataSource = new TransactionType().TransactionTypes;
            }
            catch (Exception e)
            {

            }
        }

        private void InventoryGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (InventoryGridView.GetRow(e.RowHandle) is Inventory item)
            {
                if (!User.UserIsInRoles("Manager"))
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                if (item.SN != null)
                {
                    var res = unitOfWork.ItemsRepo.Find(x => x.SN == item.SN);
                    item.ItemId = res.Id;
                    item.ItemName = res.ItemName;
                    item.CategoryId = res.CategoryId;
                    item.CategoryName = res.CategoryName;
                    item.UOM = res.UOM;
                    item.SKU = res.SKU;
                    item.SN = res.SN;
                    item.UnitPrice = res.UnitPrice;
                    item.OrderLevel = res.OrderLevel;
                    item.RetailPrice = res.RetailPrice;

                }
            }
        }

        private void InventoryGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (e.Row is Inventory item)
                {
                    if (!User.UserIsInRoles("Manager"))
                        return;
                    if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    if (item.Id == 0)
                    {
                        unitOfWork.InventoryRepo.Insert(item);
                    }
                    else
                    {

                        unitOfWork.InventoryRepo.Update(item);
                    }

                    unitOfWork.Save();
                }
            }
            catch (Exception exception)
            {

            }
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (InventoryGridView.GetFocusedRow() is Inventory item)
                {
                    if (!User.UserIsInRoles("Manager"))
                        return;
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
    }
}

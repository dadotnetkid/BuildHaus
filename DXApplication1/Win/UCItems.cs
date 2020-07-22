using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models;
using Models.IInterfaces;
using Models.Repository;
using MethodType = Models.IInterfaces.MethodType;

namespace Win.Itms
{
    public partial class UCItems : DevExpress.XtraEditors.XtraUserControl, ITransactions<Items>
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public UCItems()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(false, false);
                this.ItemsGridControl.DataSource = new BindingList<Items>(unitOfWork.ItemsRepo.Get());
                this.cboCategoryRepo.DataSource = unitOfWork.CategoriesRepo.Get();
                this.suppliersBindingSource.DataSource = unitOfWork.SuppliersRepo.Get();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Delete(Items item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Items, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Detail(Items item)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Save(Items item)
        {
            throw new NotImplementedException();
        }

        public MethodType MethodType { get; set; }
        public void Close(FormClosingEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        private void ItemsGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if (e.Row is Items item)
                {

                    if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                    UnitOfWork unitOfWork = new UnitOfWork(false, false);
                    if (item.Id == 0)
                    {
                        var category = unitOfWork.CategoriesRepo.Find(x => x.Id == item.CategoryId);
                        item.CategoryName = category?.CategoryName;
                        unitOfWork.ItemsRepo.Insert(item);
                    }
                    else
                    {
                        unitOfWork.ItemsRepo.Update(item);
                    }

                    unitOfWork.Save();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();

            var search = txtSearch.Text;
            this.ItemsGridControl.DataSource = new BindingList<Items>(unitOfWork.ItemsRepo.Get(x => x.CategoryName.Contains(search) || x.ItemName.Contains(search) || x.SKU.Contains(search) || x.SN.Contains(search)));
        }
    }
}

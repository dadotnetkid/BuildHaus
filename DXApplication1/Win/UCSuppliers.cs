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

namespace Win
{
    public partial class UCSuppliers : DevExpress.XtraEditors.XtraUserControl
    {
        public UCSuppliers()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(false, false);
                this.SupplierGridControl.DataSource = new BindingList<Suppliers>(unitOfWork.SuppliersRepo.Get());

            }
            catch (Exception e)
            {

            }
        }


        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (SupplierGridView.GetFocusedRow() is Suppliers item)
                {

                    if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.SuppliersRepo.Delete(item);
                    unitOfWork.Save();
                    Init();
                }

            }
            catch (Exception exception)
            {

            }
        }

        private void SupplierGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if (SupplierGridView.GetFocusedRow() is Suppliers item)
                {

                    if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    if (item.Id == 0)
                    {
                        unitOfWork.SuppliersRepo.Insert(item);
                    }
                    else
                    {
                        unitOfWork.SuppliersRepo.Update(item);
                    }

                    unitOfWork.Save();
                }

            }
            catch (Exception exception)
            {

            }
        }
    }
}

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
    public partial class UCCustomers : DevExpress.XtraEditors.XtraUserControl
    {
        public UCCustomers()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(false, false);
                this.CustomerGridControl.DataSource = new BindingList<Customers>(unitOfWork.CustomersRepo.Get());

            }
            catch (Exception e)
            {

            }
        }

        private void CustomerGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

                if (e.Row is Customers item)
                {

                    if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    if (item.Id == 0)
                        unitOfWork.CustomersRepo.Insert(item);
                    else
                        unitOfWork.CustomersRepo.Update(item);
                    unitOfWork.Save();
                }
            }
            catch (Exception exception)
            {
                
            }
        }
    }
}

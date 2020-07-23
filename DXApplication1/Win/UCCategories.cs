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
    public partial class UCCategories : DevExpress.XtraEditors.XtraUserControl
    {
        public UCCategories()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(false, false);
                this.CategoryGridControl.DataSource = new BindingList<Categories>(unitOfWork.CategoriesRepo.Get());
            }
            catch (Exception e)
            {

            }
        }

        private void CategoryGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if (e.Row is Categories item)
                {
                    if (!User.UserIsInRoles("Manager"))
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    if (item.Id == 0)
                    {
                        unitOfWork.CategoriesRepo.Insert(item);
                    }
                    else
                    {
                        unitOfWork.CategoriesRepo.Update(item);
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

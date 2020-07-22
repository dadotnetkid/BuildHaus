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
using Models.Startup;
using MethodType = Models.IInterfaces.MethodType;

namespace Win
{
    public partial class UCMaintenance : DevExpress.XtraEditors.XtraUserControl, ITransactions<Users>
    {
        private ApplicationUserManager userManager = new ApplicationUserManager(new UserStores(new ModelDb()));
        public UCMaintenance()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                MaintenanceGridControl.DataSource = new BindingList<Users>(unitOfWork.UsersRepo.Get());
            }
            catch (Exception e)
            {

            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Delete(Users item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Users, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Detail(Users item)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {

        }

        public void Save(Users item)
        {
            throw new NotImplementedException();
        }

        public MethodType MethodType { get; set; }
        public void Close(FormClosingEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        private void MaintenanceGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if (e.Row is Users item)
                {

                    if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    if (!unitOfWork.UserRolesRepo.Fetch(x => x.Name == item.UserLevel).Any())
                    {
                        unitOfWork.UserRolesRepo.Insert(new UserRoles()
                        {
                            Name = item.UserLevel,
                            Id = Guid.NewGuid().ToString()

                        });
                        unitOfWork.Save();
                        unitOfWork = new UnitOfWork();
                    }
                    if (string.IsNullOrEmpty(item.Id))
                    {
                        var user = new Users()
                        {
                            Id = Guid.NewGuid().ToString(),
                            UserName = item.UserName,
                            FirstName = item.FirstName ?? "",
                            MiddleName = item.MiddleName ?? "",
                            LastName = item.LastName ?? "",
                            Email = item.UserName,


                        };
                        if (!string.IsNullOrEmpty(item.Password))
                            user.PasswordHash = userManager.PasswordHasher.HashPassword(item.Password ?? "");

                        user.UserRoles.Add(unitOfWork.UserRolesRepo.Find(x => x.Name == item.UserLevel));
                        unitOfWork.UsersRepo.Insert(user);
                    }
                    else
                    {


                        unitOfWork = new UnitOfWork();
                        var _user = unitOfWork.UsersRepo.Find(x => x.Id == item.Id, includeProperties: "UserRoles");
                        _user.UserRoles.Add(unitOfWork.UserRolesRepo.Find(x => x.Name == item.UserLevel));
                        if (!string.IsNullOrEmpty(item.Password))
                            _user.PasswordHash = userManager.PasswordHasher.HashPassword(item.Password ?? "");
                        _user.Id = item.Id;
                        _user.UserName = item.UserName;
                        _user.FirstName = item.FirstName ?? "";
                        _user.MiddleName = item.MiddleName ?? "";
                        _user.LastName = item.LastName ?? "";
                        _user.Email = item.UserName;
                    }
                    unitOfWork.Save();
                    Init();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (MaintenanceGridView.GetFocusedRow() is Users item)
                {

                    if (MessageBox.Show("Do you want to delete this?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.UsersRepo.Delete(x => x.Id == item.Id);
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

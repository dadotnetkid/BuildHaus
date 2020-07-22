using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.AspNet.Identity.EntityFramework;
using Models;
using Models.Repository;
using Models.Startup;

namespace Win
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        private ApplicationUserManager userManager;
        private bool isClosed;

        public FrmLogin()
        {
            InitializeComponent();
            this.userManager = new ApplicationUserManager(new UserStores(ModelDb.Create()));
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(txtLogin.Text))
                {
                    MessageBox.Show("Username is Required", "Username is required", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Password is Required", "Password is required", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                UnitOfWork unitOfWork = new UnitOfWork();
                if (!unitOfWork.UsersRepo.Fetch(x => x.UserName == "admin").Any())
                {
                    var _user = new Users()
                    {
                        Id = Guid.NewGuid().ToString(),
                        UserName="admin",
                        FirstName="admin",
                        MiddleName="Admin",
                        Email="admin@admin.com",
                        LastName="admin",
                        PasswordHash = userManager.PasswordHasher.HashPassword("admin"?? "")
                };
                    unitOfWork.UsersRepo.Insert(_user);
                    unitOfWork.Save();
                    unitOfWork = new UnitOfWork();
                }
                var user = unitOfWork.UsersRepo.Find(x => x.UserName == txtLogin.Text, lazyLoad: false,
                    proxyCreation: false);
                if (user == null)
                {
                    MessageBox.Show($"{txtLogin.Text} is not exist", "User not found", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (!await userManager.CheckPasswordAsync(user, txtPassword.Text))
                {
                    MessageBox.Show($"Password does not match", "Password does not match", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                this.isClosed = true;
                this.Close();
            }
            catch (Exception exception)
            {

            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.isClosed)
                Application.Exit();
        }
    }
}
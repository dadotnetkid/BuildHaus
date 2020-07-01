using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;

namespace Win
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(new Itms.UCItems()
            {
                Dock = DockStyle.Fill
            });
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(new UCCategories()
            {
                Dock = DockStyle.Fill
            });
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(new UCCustomers()
            {
                Dock = DockStyle.Fill
            });
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(new UCInventory()
            {
                Dock = DockStyle.Fill
            });
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(new UCSales()
            {
                Dock = DockStyle.Fill
            });
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(new UCMaintenance()
            {
                Dock = DockStyle.Fill
            });
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (pnlBody.Controls.Count > 0)
                if (pnlBody.Controls[0] is UCSales item)
                {

                    if (keyData == Keys.F3)
                    {
                        item.New();
                    }

                    if (keyData == Keys.F4 && item.transactionNumber != null)
                    {
                        item.End();
                    }

                    if (keyData == Keys.F5 && item.transactionNumber != null)
                    {
                        item.Cancel();
                    }

                    if (keyData == Keys.Enter && item.transactionNumber != null)
                    {
                        item.btnSubmit.PerformClick();
                    }
                }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(new UCSuppliers()
            {
                Dock = DockStyle.Fill
            });
        }
    }
}

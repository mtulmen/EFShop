using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFShop
{
    public partial class FrmUserOldEdit : Form
    {
        UserOldRepository rep;
        int id;
        public FrmUserOldEdit()
        {
            id = -1;
            InitializeComponent();
            rep = new UserOldRepository();
        }
        public FrmUserOldEdit(UsersOld entity)
        {
            id = entity.Id;
            InitializeComponent();
            rep = new UserOldRepository();
            txtCredit.Text = entity.Bakiye.ToString();
            txtUsername.Text = entity.UserName;
            txtPassword.Text = entity.Password;
            txtFullname.Text = entity.FullName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UsersOld usr = new UsersOld();
            usr.FullName = txtFullname.Text;
            usr.UserName = txtUsername.Text;
            usr.Password = txtPassword.Text;
            usr.Bakiye = Convert.ToDecimal(txtCredit.Text);
            if (id == -1)
            {
                rep.Add(usr);
            }
            else
            {
                usr.Id = id;
                rep.Edit(usr);
            }
            Close();
        }
    }
}

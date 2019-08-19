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
    public partial class FrmUserEdit : Form
    {
        int id;
        public FrmUserEdit()
        {
            id = -1;
            InitializeComponent();
        }
        public FrmUserEdit(Users usr)
        {
            InitializeComponent();
            id = usr.Id;
            txtFullname.Text = usr.FullName;
            txtUsername.Text = usr.UserName;
            txtPassword.Text = usr.Password;
            txtCredit.Text = usr.Credit.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Users usr = new Users();
            usr.FullName = txtFullname.Text;
            usr.UserName = txtUsername.Text;
            usr.Password = txtPassword.Text;
            usr.Credit = Convert.ToDecimal(txtCredit.Text);

            UserRepository rep = new UserRepository();

            if(id == -1)
            {
                rep.Add(usr);
            }
            else
            {
                usr.Id = id;
                rep.Update(usr);
            }
            
            Close();
        }
    }
}

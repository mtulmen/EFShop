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
    public partial class FrmUsersOld : BaseForm<UsersOld>
    {
        public FrmUsersOld()
        {
            InitializeComponent();
            rep = new UserOldRepository();
            refresh();
        }
        //protected override void refresh()
        //{
        //    dataGridView1.DataSource = rep.List();
        //}
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            FrmUserOldEdit frm = new FrmUserOldEdit();
            frm.ShowDialog();
            refresh();
        }
        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Satır seçiniz");
                return;
            }
            UsersOld usr = new UsersOld();
            usr = (UsersOld)dataGridView1.SelectedRows[0].DataBoundItem;
            FrmUserOldEdit frm = new FrmUserOldEdit(usr);
            frm.ShowDialog();
            refresh();
        }
        
    }
}

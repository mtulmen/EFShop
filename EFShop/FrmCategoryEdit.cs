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
    public partial class FrmCategoryEdit : Form
    {
        int id;
        public FrmCategoryEdit()
        {
            id = -1;
            InitializeComponent();
        }
        public FrmCategoryEdit(Categories ct)
        {
            InitializeComponent();
            id = ct.Id;
            txtName.Text = ct.Name;
            txtDesc.Text = ct.Description;
            txtOrder.Text = ct.CatOrder.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Categories ct = new Categories();
            ct.CatOrder = Convert.ToInt32(txtOrder.Text);
            ct.Name = txtName.Text;
            ct.Description = txtDesc.Text;
            CategoryRepository rep = new CategoryRepository();

            if(id == -1)
            {
                rep.Add(ct);
            }
            else
            {
                ct.Id = id;
                rep.Edit(ct);
            }
            Close();
        }
    }
}

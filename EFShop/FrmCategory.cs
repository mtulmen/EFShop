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
    public partial class FrmCategory : BaseForm<Categories>
    {
        
        public FrmCategory()
        {
            InitializeComponent();
            rep = new CategoryRepository();
            refresh();
        }

        //protected override void refresh()
        //{
        //    dataGridView1.DataSource = rep.List();
        //}

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCategoryEdit frm = new FrmCategoryEdit();
            frm.ShowDialog();
            refresh();
        }
        
        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select row to edit");
                return;
            }
            Categories entity = (Categories)dataGridView1.SelectedRows[0].DataBoundItem;
            FrmCategoryEdit frm = new FrmCategoryEdit(entity);
            frm.ShowDialog();
            refresh();
        }
    }
}

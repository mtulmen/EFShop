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
    public partial class FrmProduct : BaseForm<Products>
    {
        
        public FrmProduct()
        {
            InitializeComponent();
            rep = new ProductRepository();
            refresh();
        }
       

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            FrmProductEdit frm = new FrmProductEdit();
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
            Products entity = (Products)dataGridView1.SelectedRows[0].DataBoundItem;
            FrmProductEdit frm = new FrmProductEdit(entity);
            frm.ShowDialog();
            refresh();
        }
    }
}

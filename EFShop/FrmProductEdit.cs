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
    public partial class FrmProductEdit : Form
    {
        int id;
        CategoryRepository catRep = new CategoryRepository();
        ProductRepository rep = new ProductRepository();
        public FrmProductEdit()
        {
            id = -1;
            InitializeComponent();
            comboBoxCategory.DataSource = catRep.List();
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
        }
        public FrmProductEdit(Products entity)
        {
            id = entity.Id;
            InitializeComponent();
            txtName.Text = entity.Name;
            txtStock.Text = entity.stocks.ToString();
            txtPrice.Text = entity.Price.ToString();
            txtProCode.Text = entity.productCode;
            comboBoxCategory.DataSource = catRep.List();
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
            comboBoxCategory.Text = entity.Categories.Name;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            Categories cat = new Categories();
            pro.Name = txtName.Text;
            pro.stocks =Convert.ToInt32(txtStock.Text);
            pro.productCode = txtProCode.Text;
            pro.Price = Convert.ToDecimal(txtPrice.Text);
            cat = (Categories)comboBoxCategory.SelectedItem;
            pro.categoryId = cat.Id;
            if(id == -1)
            {
                rep.Add(pro);
            }
            else
            {
                pro.Id = id;
                rep.Edit(pro);
            }
            Close();
        }
    }
}

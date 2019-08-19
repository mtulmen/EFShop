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
    public partial class BaseForm<T> : Form where T: class,IBaseEntity
    {

        protected BaseRepository<T> rep;
        public BaseForm()
        {
            InitializeComponent();
        }

        protected virtual void refresh()
        {
            dataGridView1.DataSource = rep.List();
        }

        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnEdit_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select row to delete");
                return;
            }
            T entity = (T)dataGridView1.SelectedRows[0].DataBoundItem;

            rep.Delete(entity.Id);
            refresh();
        }
    }
}

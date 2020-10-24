using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Compact_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtRollNumber.Text == string.Empty) return;
            using (var context = new CRUD_Context.CRUDAppDBContext())
            {
                context.Students.Add(new Entities.Student { Name = txtName.Text, RollNumber = txtRollNumber.Text });
                context.SaveChanges();
            }
            PopulateGrid();
        }

        void PopulateGrid()
        {
            using (var context = new CRUD_Context.CRUDAppDBContext())
            {
                var Students=context.Students.ToList();

                dataGridView1.DataSource = Students;
            }

        }
    }
}

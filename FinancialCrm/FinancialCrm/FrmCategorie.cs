using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmCategorie : Form
    {
        public FrmCategorie()
        {
            InitializeComponent();
        }

        FinansialCrmDbEntities db = new FinansialCrmDbEntities();
        private void FrmCategorie_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categories = db.Categorie.Select(x => new
            {
                x.CategoryId,
                x.CategoryName
            }).ToList();

            dataGridView1.DataSource = categories;
            dataGridView1.ColumnHeadersVisible = false;

            // CategoryId sütununu gizlemek için
            dataGridView1.Columns["CategoryId"].Visible = false;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            Categorie categorie = new Categorie();
            categorie.CategoryName = name;
            db.Categorie.Add(categorie);
            db.SaveChanges();
            MessageBox.Show("Yeni Kategori Başarılı Bir Şekilde Sisteme Eklendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categorie.ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns["CategoryId"].Visible = false;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            int id = int.Parse(txtCategoryId.Text);

            var values = db.Categorie.Find(id);

            values.CategoryName = name;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı Bir Şekilde Sisteme Güncellendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values2 = db.Categorie.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamadan çıkmak istediğinizden emin misiniz?",
                                 "Çıkış",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Uygulama tamamen kapanır
            }
        }
    }
}

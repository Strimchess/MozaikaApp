using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozaicaApp
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void accessBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accessBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kozlov1091UPDataSet);

        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.warehouse". При необходимости она может быть перемещена или удалена.
            this.warehouseTableAdapter.Fill(this.kozlov1091UPDataSet.warehouse);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.kozlov1091UPDataSet.suppliers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.sale_places". При необходимости она может быть перемещена или удалена.
            this.sale_placesTableAdapter.Fill(this.kozlov1091UPDataSet.sale_places);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.reuests_products". При необходимости она может быть перемещена или удалена.
            this.reuests_productsTableAdapter.Fill(this.kozlov1091UPDataSet.reuests_products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.kozlov1091UPDataSet.requests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.kozlov1091UPDataSet.products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.products_materials". При необходимости она может быть перемещена или удалена.
            this.products_materialsTableAdapter.Fill(this.kozlov1091UPDataSet.products_materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.materials_log". При необходимости она может быть перемещена или удалена.
            this.materials_logTableAdapter.Fill(this.kozlov1091UPDataSet.materials_log);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.kozlov1091UPDataSet.materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.kozlov1091UPDataSet.employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.rating_log". При необходимости она может быть перемещена или удалена.
            this.rating_logTableAdapter.Fill(this.kozlov1091UPDataSet.rating_log);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.discounts". При необходимости она может быть перемещена или удалена.
            this.discountsTableAdapter.Fill(this.kozlov1091UPDataSet.discounts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.partners". При необходимости она может быть перемещена или удалена.
            this.partnersTableAdapter.Fill(this.kozlov1091UPDataSet.partners);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.access_control". При необходимости она может быть перемещена или удалена.
            this.access_controlTableAdapter.Fill(this.kozlov1091UPDataSet.access_control);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.access". При необходимости она может быть перемещена или удалена.
            this.accessTableAdapter.Fill(this.kozlov1091UPDataSet.access);

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "ВЫХОД")
            {
                this.Close();
            }
        }
    }
}

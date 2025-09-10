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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void managersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.managersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kozlov1091UPDataSet);

        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.auth". При необходимости она может быть перемещена или удалена.
            this.authTableAdapter.Fill(this.kozlov1091UPDataSet.auth);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kozlov1091UPDataSet.managers". При необходимости она может быть перемещена или удалена.
            this.managersTableAdapter.Fill(this.kozlov1091UPDataSet.managers);

        }

        private void tabPage2_Click(object sender, EventArgs e)
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

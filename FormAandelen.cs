using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AandelenBeheer
{
    public partial class FormAandelen : Form
    {
        public FormAandelen()
        {
            InitializeComponent();
        }

        private void andelenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.andelenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aandeelBeheerDataSet);

        }

        private void FormAandelen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aandeelBeheerDataSet.Transacties' table. You can move, or remove it, as needed.
            this.transactiesTableAdapter.Fill(this.aandeelBeheerDataSet.Transacties);
            // TODO: This line of code loads data into the 'aandeelBeheerDataSet.Andelen' table. You can move, or remove it, as needed.
            this.andelenTableAdapter.Fill(this.aandeelBeheerDataSet.Andelen);

        }
    }
}

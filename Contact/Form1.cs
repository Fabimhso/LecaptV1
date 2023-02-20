using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lecaptDBDataSet.People'. Você pode movê-la ou removê-la conforme necessário.
            this.peopleTableAdapter.Fill(this.lecaptDBDataSet.People);
            MessageBox.Show("Lecapt 1.0\nMade by Syintema Softwares", "About");
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lecaptDBDataSet);

        }

        private void contactIDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

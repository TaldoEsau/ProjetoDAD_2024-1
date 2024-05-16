using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaUinifunec2024.Forms
{
    public partial class FrmBairro : Form
    {
        public FrmBairro()
        {
            InitializeComponent();
        }

        private void FrmBairro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_Unifunec.bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.bD_Unifunec.bairro);

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            bairroTableAdapter.FillByNomeBairro(bD_Unifunec.bairro, txtBuscar.Text + "%");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bairroBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bairroBindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bairroBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bairroBindingSource.MoveLast();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bairroBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bairroBindingSource.CancelEdit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bairroBindingSource.RemoveCurrent();
            bairroBindingSource.EndEdit();
            bairroTableAdapter.Update(bD_Unifunec.bairro);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bairroBindingSource.EndEdit();
            bairroTableAdapter.Update(bD_Unifunec.bairro);
        }
    }
}

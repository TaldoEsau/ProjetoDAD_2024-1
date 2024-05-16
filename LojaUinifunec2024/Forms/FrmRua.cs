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
    public partial class FrmRua : Form
    {
        public FrmRua()
        {
            InitializeComponent();
        }

        private void FrmRua_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_Unifunec.rua'. Você pode movê-la ou removê-la conforme necessário.
            this.ruaTableAdapter.Fill(this.bD_Unifunec.rua);

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            ruaTableAdapter.FillByNomeRua(bD_Unifunec.rua,txtBuscar.Text+"%");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ruaBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ruaBindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ruaBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ruaBindingSource.MoveNext();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ruaBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ruaBindingSource.CancelEdit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ruaBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ruaBindingSource.EndEdit();
            ruaTableAdapter.Update(bD_Unifunec);

            ruaBindingSource.EndEdit();
            ruaTableAdapter.Update(bD_Unifunec);
        }
    }
}

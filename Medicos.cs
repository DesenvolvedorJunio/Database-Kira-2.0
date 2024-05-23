using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Kira
{
    public partial class FrmMedicos : Form
    {
        public FrmMedicos()
        {
            InitializeComponent();
        }

        private void mEDICOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mEDICOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cONSULTORIODataSet);


        }

        private void FrmMedicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cONSULTORIODataSet.MEDICO'. Você pode movê-la ou removê-la conforme necessário.
            this.mEDICOTableAdapter.Fill(this.cONSULTORIODataSet.MEDICO);
            // TODO: esta linha de código carrega dados na tabela 'cONSULTORIODataSet.MEDICO'. Você pode movê-la ou removê-la conforme necessário.
            this.mEDICOTableAdapter.Fill(this.cONSULTORIODataSet.MEDICO);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void mEDICOBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.mEDICOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cONSULTORIODataSet);
            MessageBox.Show("Médico Salvo Com Sucesso");


        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Médico Excluido Com Sucesso");
        }

        private void PesquisarVS2_Click(object sender, EventArgs e)
        {
            if (rbMedicoVS2.Checked)
            {
                RGVResult.DataSource = mEDICOTableAdapter.MedicoReturnX2(TextPesquisa.Text);
                TextPesquisa.Clear();
            }
            else
            {
                RGVResult.DataSource = mEDICOTableAdapter.ExpecialidadePesquisarX2(TextPesquisa.Text);
                TextPesquisa.Clear();
            }
        
            










        }
    }
}

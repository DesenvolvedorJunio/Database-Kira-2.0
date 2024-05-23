using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Kira
{
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
        }

        private void pACIENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pACIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cONSULTORIODataSet);
            MessageBox.Show("Registro Salvo Com Sucesso");

        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cONSULTORIODataSet.PACIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.pACIENTETableAdapter.Fill(this.cONSULTORIODataSet.PACIENTE);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro Excluido Com Sucesso");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rbPaciente.Checked)
            {
                dgvResultado.DataSource = pACIENTETableAdapter.PesquisaPaciente(txtPesquisa.Text);
                txtPesquisa.Clear();
                
            }
            else
            {
                dgvResultado.DataSource = pACIENTETableAdapter.PesquisaCidade(txtPesquisa.Text); 
                txtPesquisa.Clear();
                
            }
        }
    }
}

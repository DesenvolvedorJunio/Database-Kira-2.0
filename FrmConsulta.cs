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
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void cONSULTABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cONSULTABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cONSULTORIODataSet);
            //Mostra Uma Menssagem De Comfirmação.
            MessageBox.Show("Agendamento Salvo Com Sucesso");

        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cONSULTORIODataSet.CONSULTA'. Você pode movê-la ou removê-la conforme necessário.
            this.cONSULTATableAdapter.Fill(this.cONSULTORIODataSet.CONSULTA);

        }
                  //btnPesquisarX2 é o Botão Para Pesquisar.
        private void btnPesquisarX2_Click(object sender, EventArgs e)
        {
            if (rbPaciente.Checked)
            {   //Pesquisa o Paciente Na Tabela Consultas No Database Consultorio.
                DataResult.DataSource = cONSULTATableAdapter.RetornaPaciente(txtPesquisarConsulta.Text);
                txtPesquisarConsulta.Clear();
            }
            else
            {   //Pesquisa o Médico Na Tabela MEDICO No Database Consultorio.
                DataResult.DataSource = cONSULTATableAdapter.MedicoRetornar(txtPesquisarConsulta.Text);
                txtPesquisarConsulta.Clear();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {   //Mostra Uma Menssagem De Comfirmação.
            MessageBox.Show("Registro Excluido Com Sucesso");
        }
    }
}

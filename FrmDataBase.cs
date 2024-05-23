using Database_Kira.CONSULTORIODataSetTableAdapters;
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
    public partial class FrmDataBase : Form
    {
        public FrmDataBase()
        {
            InitializeComponent();
        }

        private void Button_Pacientes_Click(object sender, EventArgs e)
        {
            Pacientes Chamada = new Pacientes();
            Chamada.ShowDialog();
        }

        private void Bottun_Consultas_Click(object sender, EventArgs e)
        {
            FrmConsulta Chamada = new FrmConsulta();
            Chamada.ShowDialog();
        }

        private void Bottun_Medico_Click(object sender, EventArgs e)
        {
            FrmMedicos Chamada = new FrmMedicos();
            Chamada.ShowDialog();
        }

        private void FrmDataBase_Load(object sender, EventArgs e)
        {
            

        }

      
    }




    
    }
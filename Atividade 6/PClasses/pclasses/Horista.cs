using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pclasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //cria ou instancia o objeto da classe horista
            Horista objHorista = new Horista();

            //set
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.DatadeEntradadaEmpresa = Convert.ToDateTime(txtDatEntEmpr.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtHora.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFalta.Text);
            if (rbtnSim.Checked)
                objHorista.HomeOficie = 'S';
            else
                objHorista.HomeOficie = 'N';
            MessageBox.Show("matricula: " + objHorista.Matricula + "\n" + "Nome: " + objHorista.NomeEmpregado + "\n" + "Data Entrada: " + objHorista.DatadeEntradadaEmpresa.ToShortDateString() + "\n" + "Salario Bruto " + objHorista.SalarioBruto().ToString("N2") + '\n' + objHorista.VerificaHome());

        }
    }
}

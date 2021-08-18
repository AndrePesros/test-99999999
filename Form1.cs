using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_99999999
{
    public partial class Form1 : Form
    {
        Despesas x = new Despesas();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPronto_Click(object sender, EventArgs e)
        {
            x.Cpf = int.Parse(textcpf.Text);
            x.Dia = int.Parse(textdia.Text);
            x.Valor = double.Parse(textvalordia.Text);
        }
    }
}

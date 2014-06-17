using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///
/// O código usado pelo Form1 está distribuido pelos seguintes documentos:
/// -> Ac.cs
/// -> Apagador.cs
/// -> EventoClique.cs
/// -> Numeros.cs
/// -> Operadores.cs
/// -> ResultadoFinal.cs
/// 
/// Na qual todos os documentos utilizam a mesma classe Form1
///

namespace Calculadora
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        


        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string mensagem = "";
            mensagem += "Calculadora Versão 1.0\n";
            mensagem += "Criado em Visual C#,";
            mensagem += " 2014\n";
            mensagem += "Licenciado com uma licença\n";
            mensagem += "Creative Commons Atribuição 3.0 Brasil.";
            MessageBox.Show(mensagem, "Sobre:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void desenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensagem = "Roberto Oliveira.\n http://www.estudandoprog.blogspot.com.br/";
            MessageBox.Show(mensagem, "Sobre o Desenvolvidor:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

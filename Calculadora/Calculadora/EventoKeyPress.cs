using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    partial class FormPrincipal
    {
        private void FormPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (Convert.ToInt32(e.KeyChar))
            {
                    //Números
                case 48: // ASCII Para o número 0
                    NumeroParaTela(btnNumero0.Text);
                    break;
                case 49: // ASCII Para o número 1
                    NumeroParaTela(btnNumero1.Text);
                    break;
                case 50: // ASCII Para o número 2
                    NumeroParaTela(btnNumero2.Text);
                    break;
                case 51: // ASCII Para o número 3
                    NumeroParaTela(btnNumero3.Text);
                    break;
                case 52: // ASCII Para o número 4
                    NumeroParaTela(btnNumero4.Text);
                    break;
                case 53: // ASCII Para o número 5
                    NumeroParaTela(btnNumero5.Text);
                    break;
                case 54: // ASCII Para o número 6
                    NumeroParaTela(btnNumero6.Text);
                    break;
                case 55: // ASCII Para o número 7
                    NumeroParaTela(btnNumero7.Text);
                    break;
                case 56: // ASCII Para o número 8
                    NumeroParaTela(btnNumero8.Text);
                    break;
                case 57: // ASCII Para o número 9
                    NumeroParaTela(btnNumero9.Text);
                    break;
                case 44:
                    VirgulaParaTela();
                    break;
                    //Fim Numeros

                    //Operadores
                case 47: //Divisão
                    OperadorParaTela(" / ");
                    break;
                case 63: //Divisão
                    OperadorParaTela(" / ");
                    break;
                case 42: //Multiplicação
                    OperadorParaTela(" * ");
                    break;
                case 45: //Subtração
                    OperadorParaTela(" - ");
                    break;
                case 43: //Soma
                    OperadorParaTela(" + ");
                    break;
                    //Fim Operadores

                    //Comandos
                case 61: //Igual
                    MostrarResultado();
                    break;
                case 8: //BackSpace
                    Apagar();
                    break;
                case 27: //AC (ESC)
                    ResetarTudoAC();
                    break;;
            }
        }

    }
}

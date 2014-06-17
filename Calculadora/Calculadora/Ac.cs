///
/// O código desse documento é responsável pelo funcionamento do botão AC.
/// O botão AC reseta todos os valores e todas as variáveis do programa.
/// O método ResetarTudo é usado pelo código do botão "igual"
///

namespace Calculadora
{
    partial class FormPrincipal
    {
        void ResetarTudoAC()
        {
            txtTelaResultado.Text = default(string);
            numero1 = default(int);
            numero2 = default(int);
            numero2String = default(string);
            umaVirgula = false;
            segundoNumero = false;
        }
    }
}

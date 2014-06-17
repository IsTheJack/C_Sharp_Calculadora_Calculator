///
/// Código responsável pelo funcionamento dos operadores.
///

namespace Calculadora
{
    partial class FormPrincipal
    {
        string tipoDeOperador; // + = soma -> - = subtração -> * = multiplicação -> / = divisão   :)
        
        private void OperadorParaTela(string operador)
        {
            if (txtTelaResultado.Text.Length == 0) //Se nenhum número for digitado antes de acionar algum operador
            {
                txtTelaResultado.Text = "0" + operador; // Será aceito como valor 0 e o operador
                numero1String = "0";
                numero1 = 0;
            }
            else
            {
                if (segundoNumero == false)
                {
                    txtTelaResultado.Text = numero1.ToString() + operador;    
                }
                else //Para o caso de vários números serem somados em sequência
                {
                    MostrarResultado();
                    txtTelaResultado.Text = numero1.ToString() + operador;
                }
            }
            segundoNumero = true; // Passa ao sistema que agora será a vez de inserir o segundo número
            tipoDeOperador = operador;
        }
	}
}

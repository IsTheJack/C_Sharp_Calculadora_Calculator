using System;

///
/// Código responsável pelo funcionamento do botão de igual e por calculos em sequência
/// feitos utilzando apenas os botões de operação
///

namespace Calculadora
{
    partial class FormPrincipal
    {
        double resultado;
        private void MostrarResultado()
        {
            if ((numero1String != default(string)) & (numero2String == default(String)))
            {
                resultado = numero1;
                ResetarTudoAC();
                numero1 = resultado;
                numero1String = numero1.ToString();
                txtTelaResultado.Text = resultado.ToString();
                numero1 = resultado;
            }
            else
            {
                switch (tipoDeOperador)
                {
                    case " + ":
                        resultado = numero1 + numero2;
                        break;
                    case " - ":
                        resultado = numero1 - numero2;
                        break;
                    case " * ":
                        resultado = numero1 * numero2;
                        break;
                    case " / ":
                        resultado = numero1 / numero2;
                        break;
                }

                ResetarTudoAC();
                numero1 = resultado;
                numero1String = numero1.ToString();
                txtTelaResultado.Text = resultado.ToString();
                numero1 = resultado;
            }
        }
    }
}

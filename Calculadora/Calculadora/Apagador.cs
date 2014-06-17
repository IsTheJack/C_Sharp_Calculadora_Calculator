using System;

///
/// Neste documento encontra-se todo código responsável pelo funcionamento do botão AC
///

namespace Calculadora
{
    partial class FormPrincipal
    {
        private void Apagar() // Esse é o método principal que diferencia o primeiro do segundo número
        {
            if (segundoNumero == false)
            {
                ApagarPrimeiroNumero();              
            }
            else
            {
                ApagarSegundoNumero();
            }
        }

        private void ApagarPrimeiroNumero() //Método especializado em apagar o primeiro número
        {
            if (txtTelaResultado.Text.Length > 1) //Fiquei muito feliz de ter descoberto isso :) (Método Remove)
            {
                try
                {
                    ///
                    ///Método Remove : Retorna uma nova cadeia de caracteres em que todos os caracteres na instância atual, 
                    ///começando na posição especificada e continuando com a posição a última, foram excluídos.
                    ///
                    txtTelaResultado.Text = txtTelaResultado.Text.Remove(txtTelaResultado.Text.Length - 1);
                    numero1String = txtTelaResultado.Text;
                    numero1 = double.Parse(numero1String);
                }
                catch (Exception)
                {
                    ResetarTudoAC();
                }
                
            }
            else //Tratamento de exceção
            {
                if (txtTelaResultado.Text.Length == 1)
                {
                    try
                    {
                        ResetarTudoAC();
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void ApagarSegundoNumero() //Método especializado em apagar o segundo número
        {
            if (txtTelaResultado.Text.Length >= (Convert.ToString(numero1).Length + 4)) // Tratamento de exceção
            {
                if (txtTelaResultado.Text.Length == Convert.ToString(numero1).Length + 4)
                {
                    try
                    {
                        txtTelaResultado.Text = txtTelaResultado.Text.Remove(txtTelaResultado.Text.Length - 1);
                        numero2 = 0;
                    }
                    catch (Exception)
                    {
                     
                    }
                    
                }
                else
                {
                    try
                    {
                        txtTelaResultado.Text = txtTelaResultado.Text.Remove(txtTelaResultado.Text.Length - 1);
                        numero2String = numero2String.Remove(numero2String.Length - 1);
                        numero2 = int.Parse(numero2String);
                    }
                    catch (Exception)
                    {
 
                    }                    
                }

            }
        }
    }
}

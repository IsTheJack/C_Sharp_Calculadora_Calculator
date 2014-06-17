using System;

///
/// Neste documento se encontram todo código por trás dos números.
/// Em grande parte do código os números serão tratados como strings.
///

namespace Calculadora
{
    partial class FormPrincipal
    {
        double numero1 = 0; // Vide comentário abaixo
        double numero2 = 0; // 2 numeros por vez (numero1 -operador- numero2)
        string numero1String; // Vide comentário abaixo
        string numero2String; // Gambiarra pra conseguir separar numero1 de numero2
        bool umaVirgula = false; //Gambiarra para controlar apenas uma vírgula por número
        bool segundoNumero = false;

        private void NumeroParaTela(string numero) //Responsável por jogar o número para tela de resultado (txtTelaResultado)
        {
            if (segundoNumero == false)
            {
                NumeroParaTela1(numero);
            }
            else
            {
                NumeroParaTela2(numero);
            }
        }

        private void NumeroParaTela1(string numero) // Joga o numero1 pra tela e salva na variável
        {
            if (txtTelaResultado.Text.Length < 6)
            {
                txtTelaResultado.Text = txtTelaResultado.Text + numero; // Concatenação das Strings
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
            }
            try
            {
                numero1String = txtTelaResultado.Text;
                numero1 = double.Parse(numero1String);
            }
            catch (Exception)
            {
                System.Media.SystemSounds.Exclamation.Play();
                ResetarTudoAC();
            }
            
        }

        private void NumeroParaTela2(string numero) // Joga o numero2 pra tela e salva na variável
        {
            if (txtTelaResultado.Text.Length < Convert.ToString(numero1).Length + 3 + 6)
            {
                txtTelaResultado.Text = txtTelaResultado.Text + numero;
                numero2String = numero2String + numero;
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
            }
            try
            {
                numero2 = double.Parse(numero2String);
            }
            catch (Exception)
            {
                numero2 = default(double);
                numero2String = default(string);
                System.Media.SystemSounds.Exclamation.Play();
                txtTelaResultado.Text = txtTelaResultado.Text.Remove(txtTelaResultado.Text.Length - 1);
            }
        }
       
        private void VirgulaParaTela() //Específico para a vírgula porém usa o método NumeroParaTela() também.
        {
            if ((numero1 != default(double)) & (numero2 == default(double) & (segundoNumero == false)))
            {
                for (int i = 0; i < numero1String.Length; i++)
                {
                    if (numero1String.Substring(i, 1) == ",")
                    {
                        umaVirgula = true;
                        break;
                    }
                    else
                    {
                        umaVirgula = false;
                    }
                }
            }
            else
            {
                if (numero2 != default(double))
                {
                    for (int i = 0; i < numero2String.Length; i++)
                    {
                        if (numero2String.Substring(i, 1) == ",")
                        {
                            umaVirgula = true;
                            break;
                        }
                        else
                        {
                            umaVirgula = false;
                        }
                    }
                }
            }
            
            if (umaVirgula == false)
            {
                NumeroParaTela(",");
                umaVirgula = true; //Determina que ja foi colocado uma vírgula no número
            }
        }
    }
}

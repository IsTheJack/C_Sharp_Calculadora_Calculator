using System;

///
/// Esse documento comporta o código de todos os Eventos de Clique de todos os botões
///

namespace Calculadora
{
    partial class FormPrincipal
    {
        // EVENTO DE CLIQUE DE TODOS OS BOTÕES DE NÚMEROS E VÍRGULA

        private void btnNumero0_Click(object sender, EventArgs e) // Numero 0
        {
            NumeroParaTela(btnNumero0.Text);
        }

        private void btnNumero1_Click(object sender, EventArgs e) // Numero 1
        {
            NumeroParaTela(btnNumero1.Text);
        }

        private void btnNumero2_Click(object sender, EventArgs e) // Numero 2
        {
            NumeroParaTela(btnNumero2.Text);
        }

        private void btnNumero3_Click(object sender, EventArgs e) // Numero 3
        {
            NumeroParaTela(btnNumero3.Text);
        }

        private void btnNumero4_Click(object sender, EventArgs e) // Numero 4
        {
            NumeroParaTela(btnNumero4.Text);
        }

        private void btnNumero5_Click(object sender, EventArgs e) // Numero 5
        {
            NumeroParaTela(btnNumero5.Text);
        }

        private void btnNumero6_Click(object sender, EventArgs e) // Numero 6
        {
            NumeroParaTela(btnNumero6.Text);
        }

        private void btnNumero7_Click(object sender, EventArgs e) // Numero 7
        {
            NumeroParaTela(btnNumero7.Text);
        }

        private void btnNumero8_Click(object sender, EventArgs e) // Numero 8
        {
            NumeroParaTela(btnNumero8.Text);
        }

        private void btnNumero9_Click(object sender, EventArgs e) // Numero 9
        {
            NumeroParaTela(btnNumero9.Text);
        }

        private void btnVirgula_Click(object sender, EventArgs e) // Vírgula
        {
            VirgulaParaTela(); // Vai em formato de ponto para ser aceito pelo sistema
        }

        // FIM DO EVENTO DE CLIQUE DE TODOS OS NUMEROS
        // INICIO DO EVENTO DE CLIQUE DOS OPERADORES

        private void btnDivisao_Click(object sender, EventArgs e) // Divisão
        {
            OperadorParaTela(" / ");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e) // Multiplicação
        {
            OperadorParaTela(" * ");
        }

        private void btnSubtracao_Click(object sender, EventArgs e) // Subtração
        {
            OperadorParaTela(" - ");
        }

        private void btnSoma_Click(object sender, EventArgs e) // Soma
        {
            OperadorParaTela(" + ");
        }


        //FIM DO EVENTO DE CLIQUE DOS OPERADORES
        //EVENTO DO CLIQUE DO BOTÃO APAGA

        private void btnApaga_Click(object sender, EventArgs e)
        {
            Apagar();
        }

        //EVENTO DO CLIQUE DO BOTÃO AC
        private void button5_Click(object sender, EventArgs e)
        {
            ResetarTudoAC();
        }

        //EVENTO DO CLIQUE DO BOTÃO DE IGUAL
        private void btnIgual_Click(object sender, EventArgs e)
        {
            MostrarResultado();
        }
    }
}

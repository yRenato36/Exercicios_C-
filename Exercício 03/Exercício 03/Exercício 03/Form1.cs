using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_03
{
    public partial class Form1 : Form
    {
        /* Uma empresa contratou 15 funcionários temporários. De acordo com o valor das vendas mensais, 
         * os funcionários adquirem pontos que determinarão seus salários ao final de cada mês. 
         * Sabe-se que esses funcionários trabalharão nos meses de novembro a janeiro do ano subsequente. 
         * 
            Faça um programa que:
            a) Leia as pontuações nos três meses de cada funcionário.
            b) Calcule e mostre a pontuação geral de cada funcionário nos três meses.
            c) Calcule e mostre a média das pontuações de cada funcionário nos três meses.
            d) Determine e mostre a maior pontuação atingida entre todos os funcionários nos três meses. */
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //definindo variáveis
            int valor = 0, mediaGeral = 0, pontos = 0, acum = 0, total = 0, media = 0, num = 0;

            //conta os 15 funcionários
            for (int funcio = 1; funcio <= 15; funcio++)
            {
                //numera a posição do funcionário
                num++;
                //zera os pontos quando passa para o próximo funcionário
                pontos = 0;
                //conta os meses
                for (int mes = 1; mes <= 3; mes++)
                {
                    //recebe o valor do inputbox e converte para int
                    valor = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("insira a pontuação"));

                    //soma todos os valores digitados no input
                    pontos = pontos + valor;
                    //faz a média desses valores
                    media = pontos / mes;
                    //acumula o maior valor digitado
                    if (valor > acum)
                    {
                        acum = valor;
                    }
                }
                //apresenta na tela a posição do funcionário, soma da pontuação e a média
                MessageBox.Show(Convert.ToString($"{num}º Funcionário\nO total: {pontos}\nmédia: {media}"));
                
                //soma e faz a média das pontuações de todos os funcionários
                total += pontos;
                mediaGeral = total / funcio;

            }
            //apresenta na tela o total de pontuações, média e o maior valor digitado
            MessageBox.Show(Convert.ToString($"O total geral é : {total}\nA média geral é : {mediaGeral}\nMaior valor: {acum}"));

        }
    }
}

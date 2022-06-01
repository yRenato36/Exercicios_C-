using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_05
{
    public partial class Form1 : Form
    {
        /* Leia um número indeterminado de linhas contendo cada uma a idade de um indivíduo.
         * A última linha, que não entrará nos cálculos, contém o valor da idade igual a zero;
         * Calcule e mostre a idade média desse grupo de indivíduos.  */
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //iniciando variáveis
            int idade = 0, num = 0, media = 0, contMedia = 0, acum = 0;

            do
            {
                //conta a posição do valor que será recebido
                num++;
                //recebe a idade
                idade = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox($"Insira a {num}º idade"));
                //soma todas as idades recebidas
                acum += idade;
                
                //conta quantas idades foram recebidas se forem diferentes de zero
                if (idade != 0)
                {
                    contMedia++;
                }
            } while (idade != 0);
            //faz a média das idades recebidas
            media = acum / contMedia;
            
            //apresenta na telas a média das idades recebidas
            MessageBox.Show($"Média das idades digitadas: {media}");
        }
    }
}

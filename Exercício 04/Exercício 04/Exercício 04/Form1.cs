using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //recebe os valor dos textboxes
            int valorX = Convert.ToInt16(textBoxX.Text);
            int valorY = Convert.ToInt16(textBoxY.Text);
            
            //variável iniciada com um para poder fazer a multiplicação
            int potencia = 1;

            //variável valorY diz quantas vezes será repetido essa estrutura
            for(int contagem = 0; contagem < valorY; contagem++)
            {
                //resultado da multiplicação armazena na variável potência
                potencia = valorX * potencia;
            }
            //apresenta na tela o resultado da multiplicação
            MessageBox.Show($"Resultado: {potencia}");

        }
    }
}

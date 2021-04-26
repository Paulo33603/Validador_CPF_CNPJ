using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidaCPFeCNPJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerifica_Click(object sender, EventArgs e)
        {
            string caracteres = txtDocumento.Text;

            caracteres = caracteres.Replace(".", String.Empty).Replace("/", String.Empty).Replace("-", String.Empty);
            
            if (caracteres.Length == 11 && RadioCPF.Checked)
            {
                string cpf = caracteres;
                
                int digito1 = int.Parse(cpf.Substring(0, 1));
                int digito2 = int.Parse(cpf.Substring(1, 1));
                int digito3 = int.Parse(cpf.Substring(2, 1));
                int digito4 = int.Parse(cpf.Substring(3, 1));
                int digito5 = int.Parse(cpf.Substring(4, 1));
                int digito6 = int.Parse(cpf.Substring(5, 1));
                int digito7 = int.Parse(cpf.Substring(6, 1));
                int digito8 = int.Parse(cpf.Substring(7, 1));
                int digito9 = int.Parse(cpf.Substring(8, 1));
                int digito10 = int.Parse(cpf.Substring(9, 1));
                int digito11 = int.Parse(cpf.Substring(10, 1));

                int total = digito1 * 10 + digito2 * 9 + digito3 * 8 + digito4 * 7 + digito5 * 6 + digito6 * 5 + digito7 * 4 + digito8 * 3 + digito9 * 2;

                int resto = total % 11;

                int verificado1;

                if (resto == 0 || resto == 1)
                {
                    verificado1 = 0;
                }
                else
                {
                    verificado1 = 11 - resto;
                }

                total = digito1 * 11 + digito2 * 10 + digito3 * 9 + digito4 * 8 + digito5 * 7 + digito6 * 6 + digito7 * 5 + digito8 * 4 + digito9 * 3 + digito10 * 2;

                resto = total % 11;

                int verificado2;

                if (resto == 0 || resto == 1)
                {
                    verificado2 = 0;
                }
                else
                {
                    verificado2 = 11 - resto;
                }

                if (verificado1 == digito10 && verificado2 == digito11)
                {
                    MessageBox.Show("O CPF " + digito1 + digito2 + digito3 + "." + digito4 + digito5 + digito6 + "." + digito7 + digito8 + digito9 + "-" + digito10 + digito11 + " é válido");
                }
                else
                {
                    MessageBox.Show("O CPF não é válido");
                }
            }
            else if (caracteres.Length == 14 && RadioCNPJ.Checked)
            {
                string cnpj = Convert.ToString(caracteres);

                int digito1 = int.Parse(cnpj.Substring(0, 1));
                int digito2 = int.Parse(cnpj.Substring(1, 1));
                int digito3 = int.Parse(cnpj.Substring(2, 1));
                int digito4 = int.Parse(cnpj.Substring(3, 1));
                int digito5 = int.Parse(cnpj.Substring(4, 1));
                int digito6 = int.Parse(cnpj.Substring(5, 1));
                int digito7 = int.Parse(cnpj.Substring(6, 1));
                int digito8 = int.Parse(cnpj.Substring(7, 1));
                int digito9 = int.Parse(cnpj.Substring(8, 1));
                int digito10 = int.Parse(cnpj.Substring(9, 1));
                int digito11 = int.Parse(cnpj.Substring(10, 1));
                int digito12 = int.Parse(cnpj.Substring(11, 1));
                int digito13 = int.Parse(cnpj.Substring(12, 1));
                int digito14 = int.Parse(cnpj.Substring(13, 1));

                int total = digito1 * 5 + digito2 * 4 + digito3 * 3 + digito4 * 2 + digito5 * 9 + digito6 * 8 + digito7 * 7 + digito8 * 6 + digito9 * 5 + digito10 * 4 + digito11 * 3 + digito12 * 2;

                int resto = total % 11;

                int verificador1;

                if (resto < 2)
                {
                    verificador1 = 0;
                }
                else
                {
                    verificador1 = 11 - resto;
                }

                total = digito1 * 6 + digito2 * 5 + digito3 * 4 + digito4 * 3 + digito5 * 2 + digito6 * 9 + digito7 * 8 + digito8 * 7 + digito9 * 6 + digito10 * 5 + digito11 * 4 + digito12 * 3 + digito13 * 2;

                resto = total % 11;

                int verificador2;

                if (resto < 2)
                {
                    verificador2 = 0;
                }
                else
                {
                    verificador2 = 11 - resto;
                }

                if (verificador1 == digito13 && verificador2 == digito14)
                {
                    MessageBox.Show("O CNPJ " + digito1 + digito2 + "." + digito3 + digito4 + digito5 + "." + digito6 + digito7 + digito8 + "/" + digito9 + digito10 + digito11 + digito12 + "-" + digito13 + digito14 + " é válido");
                }
                else
                {
                    MessageBox.Show("O CNPJ não existe");
                }
            }
            else
            {
                MessageBox.Show("O formato não é válido ou o documento não foi selecionado");
            }
        }

        private void BtnGerador_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            if (radioGerarCPF.Checked)
            {
                int digito1 = rnd.Next(10);
                int digito2 = rnd.Next(10);
                int digito3 = rnd.Next(10);
                int digito4 = rnd.Next(10);
                int digito5 = rnd.Next(10);
                int digito6 = rnd.Next(10);
                int digito7 = rnd.Next(10);
                int digito8 = rnd.Next(10);
                int digito9 = rnd.Next(10);

                if (comboEstados.Text == "RS")
                {
                    digito9 = 0;
                }
                else if (comboEstados.Text == "DF" || comboEstados.Text == "GO" || comboEstados.Text == "MG" || comboEstados.Text == "MS" || comboEstados.Text == "TO")
                {
                    digito9 = 1;
                }
                else if (comboEstados.Text == "AM" || comboEstados.Text == "PA" || comboEstados.Text == "RR" || comboEstados.Text == "AP" || comboEstados.Text == "AC" || comboEstados.Text == "RO")
                {
                    digito9 = 2;
                }
                else if (comboEstados.Text == "CE" || comboEstados.Text == "MA" || comboEstados.Text == "PI")
                {
                    digito9 = 3;
                }
                else if (comboEstados.Text == "PB" || comboEstados.Text == "PE" || comboEstados.Text == "AL" || comboEstados.Text == "RN")
                {
                    digito9 = 4;
                }
                else if (comboEstados.Text == "BA" || comboEstados.Text == "SE")
                {
                    digito9 = 5;
                }
                else if (comboEstados.Text == "MG")
                {
                    digito9 = 6;
                }
                else if (comboEstados.Text == "RJ" || comboEstados.Text == "ES")
                {
                    digito9 = 7;
                }
                else if (comboEstados.Text == "SP")
                {
                    digito9 = 8;
                }
                else if(comboEstados.Text == "PR" || comboEstados.Text == "SC")
                {
                    digito9 = 9;
                }

                int total = digito1 * 10 + digito2 * 9 + digito3 * 8 + digito4 * 7 + digito5 * 6 + digito6 * 5 + digito7 * 4 + digito8 * 3 + digito9 * 2;

                int resto = total % 11;

                int verificado1;

                if (resto == 0 || resto == 1)
                {
                    verificado1 = 0;
                }
                else
                {
                    verificado1 = 11 - resto;
                }

                total = digito1 * 11 + digito2 * 10 + digito3 * 9 + digito4 * 8 + digito5 * 7 + digito6 * 6 + digito7 * 5 + digito8 * 4 + digito9 * 3 + verificado1 * 2;

                resto = total % 11;

                int verificado2;

                if (resto == 0 || resto == 1)
                {
                    verificado2 = 0;
                }
                else
                {
                    verificado2 = 11 - resto;
                }

                txtDocumentoGerado.Text = $"{digito1}{digito2}{digito3}.{digito4}{digito5}{digito6}.{digito7}{digito8}{digito9}-{verificado1}{verificado2}";
            }
            else if (radioGerarCNPJ.Checked)
            {
                int digito1 = rnd.Next(10);
                int digito2 = rnd.Next(10);
                int digito3 = rnd.Next(10);
                int digito4 = rnd.Next(10);
                int digito5 = rnd.Next(10);
                int digito6 = rnd.Next(10);
                int digito7 = rnd.Next(10);
                int digito8 = rnd.Next(10);
                int digito9 = rnd.Next(10);
                int digito10 = rnd.Next(10);
                int digito11 = rnd.Next(10);
                int digito12 = rnd.Next(10);

                int total = digito1 * 5 + digito2 * 4 + digito3 * 3 + digito4 * 2 + digito5 * 9 + digito6 * 8 + digito7 * 7 + digito8 * 6 + digito9 * 5 + digito10 * 4 + digito11 * 3 + digito12 * 2;

                int resto = total % 11;

                int verificador1;

                if (resto < 2)
                {
                    verificador1 = 0;
                }
                else
                {
                    verificador1 = 11 - resto;
                }

                total = digito1 * 6 + digito2 * 5 + digito3 * 4 + digito4 * 3 + digito5 * 2 + digito6 * 9 + digito7 * 8 + digito8 * 7 + digito9 * 6 + digito10 * 5 + digito11 * 4 + digito12 * 3 + verificador1 * 2;

                resto = total % 11;

                int verificador2;

                if (resto >= 2)
                {
                    verificador2 = 11 - resto;
                }
                else
                {
                    verificador2 = 0;
                }

                txtDocumentoGerado.Text = $"{digito1}{digito2}.{digito3}{digito4}{digito5}.{digito6}{digito7}{digito8}/{digito9}{digito10}{digito11}{digito12}-{verificador1}{verificador2}";
            }
        }
    }
}
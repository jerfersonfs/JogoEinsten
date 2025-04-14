using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace einsten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cbx_Amarelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Amarelo.SelectedItem != null)
            {
                string selecionar = cbx_Amarelo.SelectedItem.ToString();
                if (selecionar == "Amarela")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta errada! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }
        private void cbx_Azul_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Azul.SelectedItem != null)
            {
                string selecionar = cbx_Azul.SelectedItem.ToString();

                if (selecionar == "Azul")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta errada! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }
        private void cbx_Vermelha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Vermelha.SelectedItem != null)
            {
                string selecionar = cbx_Vermelha.SelectedItem.ToString();

                if (selecionar == "Vermelha")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta errada! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_Verde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Verde.SelectedItem != null)
            {
                string selecionar = cbx_Verde.SelectedItem.ToString();

                if (selecionar == "Verde")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta errada! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }
        private void cbx_Branca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Branca.SelectedItem != null)
            {
                string selecionar = cbx_Branca.SelectedItem.ToString();

                if (selecionar == "Branca")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta errada! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }
        private void cbx_Noroega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Noroega.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Noroega.SelectedItem.ToString();

                if (selecionar == "Noruegues")
                {
                    MessageBox.Show("Resposta certa!");
                    //dicasdojogo.cckbox9

                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_Dinamarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Dinamarca.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Dinamarca.SelectedItem.ToString();

                if (selecionar == "Dinamarques")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_Ingles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Ingles.SelectedItem != null)
            {
                string selecionar = cbx_Ingles.SelectedItem.ToString();

                if (selecionar == "Inglês")
                {
                    MessageBox.Show("Resposta certa!");
                    // Update all verifications when a correct answer is given
                    //AtualizarTodasVerificacoes();
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_Alemanha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Alemanha.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Alemanha.SelectedItem.ToString();

                if (selecionar == "Alemão")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_Sueco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Sueco.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Sueco.SelectedItem.ToString();

                if (selecionar == "Sueco")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_Agua_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Agua.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Agua.SelectedItem.ToString();

                if (selecionar == "Água")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_Cha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Cha.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Cha.SelectedItem.ToString();

                if (selecionar == "Chá")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }
        private void cbx_Leite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Leite.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Leite.SelectedItem.ToString();

                if (selecionar == "Leite")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_Cafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Cafe.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Cafe.SelectedItem.ToString();

                if (selecionar == "Café")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void Cerveja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cerveja.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = Cerveja.SelectedItem.ToString();

                if (selecionar == "Cerveja")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_Dunhill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Dunhill.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Dunhill.SelectedItem.ToString();

                if (selecionar == "Dunhiill")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_Blends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Blends.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Blends.SelectedItem.ToString();

                if (selecionar == "Blends")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_PallMall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_PallMall.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_PallMall.SelectedItem.ToString();

                if (selecionar == "PallMall")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_Prince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Prince.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Prince.SelectedItem.ToString();

                if (selecionar == "Prince")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_BlueMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_BlueMaster.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_BlueMaster.SelectedItem.ToString();

                if (selecionar == "BlueMaster")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_Gatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Gatos.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Gatos.SelectedItem.ToString();

                if (selecionar == "Gatos")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_Cavalo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Cavalo.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Cavalo.SelectedItem.ToString();

                if (selecionar == "Cavalos")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_Passaro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Passaro.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Passaro.SelectedItem.ToString();

                if (selecionar == "Pássaros")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbx_Peixe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Peixe.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Peixe.SelectedItem.ToString();

                if (selecionar == "Peixes")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void cbx_Cachorro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Cachorro.SelectedItem != null)
            {
                //Conversão de bool para string
                string selecionar = cbx_Cachorro.SelectedItem.ToString();

                if (selecionar == "Cachorros")
                {
                    MessageBox.Show("Resposta certa!");
                }
                else
                {
                    MessageBox.Show("Resposta incorreta! Tente novamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            cbx_Amarelo_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Azul_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Vermelha_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Verde_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Branca_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Noroega_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Dinamarca_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Ingles_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Alemanha_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Sueco_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Agua_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Cha_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Leite_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Cafe_SelectedIndexChanged(null, EventArgs.Empty);
            Cerveja_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Dunhill_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Blends_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_PallMall_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Prince_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_BlueMaster_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Gatos_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Cavalo_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Passaro_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Peixe_SelectedIndexChanged(null, EventArgs.Empty);
            cbx_Cachorro_SelectedIndexChanged(null, EventArgs.Empty);

            checkBox1_CheckedChanged(null, EventArgs.Empty);
            checkBox2_CheckedChanged(null, EventArgs.Empty);
            checkBox3_CheckedChanged(null, EventArgs.Empty);
            checkBox4_CheckedChanged(null, EventArgs.Empty);
            checkBox5_CheckedChanged(null, EventArgs.Empty);
            checkBox6_CheckedChanged(null, EventArgs.Empty);
            checkBox7_CheckedChanged(null, EventArgs.Empty);
            checkBox8_CheckedChanged(null, EventArgs.Empty);
            checkBox9_CheckedChanged(null, EventArgs.Empty);
            checkBox10_CheckedChanged(null, EventArgs.Empty);
            checkBox11_CheckedChanged(null, EventArgs.Empty);
            checkBox12_CheckedChanged(null, EventArgs.Empty);
            checkBox13_CheckedChanged(null, EventArgs.Empty);
            checkBox14_CheckedChanged(null, EventArgs.Empty);
            checkBox15_CheckedChanged(null, EventArgs.Empty);
        }

        private void cbx_Vermelha_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Dinamarca.SelectedItem != null && cbx_Cha.SelectedItem != null)
            {
                if (cbx_Dinamarca.SelectedItem.ToString() == "Dinamarques" && cbx_Cha.SelectedItem.ToString() == "Chá")
                {
                    checkBox3.Checked = true;
                }
                else
                {
                    checkBox3.Checked = false;
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Ingles.SelectedItem != null && cbx_Vermelha.SelectedItem != null)
            {
                if (cbx_Ingles.SelectedItem.ToString() == "Inglês" && cbx_Vermelha.SelectedItem.ToString() == "Vermelha")
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
                if (cbx_Sueco.SelectedItem != null && cbx_Cachorro.SelectedItem != null)
                {
                    if (cbx_Sueco.SelectedItem.ToString() == "Sueco" && cbx_Cachorro.SelectedItem.ToString() == "Cachorros")
                    {
                        checkBox2.Checked = true;
                    }
                    else
                    {
                        checkBox2.Checked = false;
                    }
                }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Verde.SelectedItem != null && cbx_Branca.SelectedItem != null)
            {
                if (cbx_Verde.SelectedItem.ToString() == "Verde" && cbx_Branca.SelectedItem.ToString() == "Branca")
                {
                    checkBox4.Checked = true;
                }
                else
                {
                    checkBox4.Checked = false;
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_PallMall.SelectedItem != null && cbx_Passaro.SelectedItem != null)
            {
                if (cbx_PallMall.SelectedItem.ToString() == "PallMall" && cbx_Passaro.SelectedItem.ToString() == "Pássaros")
                {
                    checkBox6.Checked = true;
                }
                else
                {
                    checkBox6.Checked = false;
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Verde.SelectedItem != null && cbx_Cafe.SelectedItem != null)
            {
                if (cbx_Verde.SelectedItem.ToString() == "Verde" && cbx_Cafe.SelectedItem.ToString() == "Café")
                {
                    checkBox5.Checked = true;
                }
                else
                {
                    checkBox5.Checked = false;
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Amarelo.SelectedItem != null && cbx_Dunhill.SelectedItem != null)
            {
                if (cbx_Amarelo.SelectedItem.ToString() == "Amarela" && cbx_Dunhill.SelectedItem.ToString() == "Dunhill")
                {
                    checkBox7.Checked = true;
                }
                else
                {
                    checkBox7.Checked = false;
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Vermelha.SelectedItem != null && cbx_Leite.SelectedItem != null)
            {
                if (cbx_Vermelha.SelectedItem.ToString() == "Vermelha" && cbx_Leite.SelectedItem.ToString() == "Leite")
                {
                    checkBox8.Checked = true;
                }
                else
                {
                    checkBox8.Checked = false;
                }
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Amarelo.SelectedItem != null && cbx_Noroega.SelectedItem != null)
            {
                if (cbx_Amarelo.SelectedItem.ToString() == "Amarela" && cbx_Noroega.SelectedItem.ToString() == "Noruegues")
                {
                    checkBox9.Checked = true;
                }
                else
                {
                    checkBox9.Checked = false;
                }
            }
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Blends.SelectedItem != null && cbx_Gatos.SelectedItem != null)
            {
                if (cbx_Blends.SelectedItem.ToString() == "Blends" && cbx_Gatos.SelectedItem.ToString() == "Gatos")
                {
                    checkBox10.Checked = true;
                }
                else
                {
                    checkBox10.Checked = false;
                }
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Cavalo.SelectedItem != null && cbx_Dunhill.SelectedItem != null)
            {
                if (cbx_Cavalo.SelectedItem.ToString() == "Cavalos" && cbx_Dunhill.SelectedItem.ToString() == "Dunhill")
                {
                    checkBox11.Checked = true;
                }
                else
                {
                    checkBox11.Checked = false;
                }
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_BlueMaster.SelectedItem != null && Cerveja.SelectedItem != null)
            {
                if (cbx_BlueMaster.SelectedItem.ToString() == "BlueMaster" && Cerveja.SelectedItem.ToString() == "Cerveja")
                {
                    checkBox12.Checked = true;
                }
                else
                {
                    checkBox12.Checked = false;
                }
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Alemanha.SelectedItem != null && cbx_Prince.SelectedItem != null)
            {
                if (cbx_Alemanha.SelectedItem.ToString() == "Alemão" && cbx_Prince.SelectedItem.ToString() == "Prince")
                {
                    checkBox13.Checked = true;
                }
                else
                {
                    checkBox13.Checked = false;
                }
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Noroega.SelectedItem != null && cbx_Azul.SelectedItem != null)
            {
                if (cbx_Noroega.SelectedItem.ToString() == "Noruegues" && cbx_Azul.SelectedItem.ToString() == "Azul")
                {
                    checkBox14.Checked = true;
                }
                else
                {
                    checkBox14.Checked = false;
                }
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Blends.SelectedItem != null && cbx_Agua.SelectedItem != null)
            {
                if (cbx_Blends.SelectedItem.ToString() == "Blends" && cbx_Agua.SelectedItem.ToString() == "Água")
                {
                    checkBox15.Checked = true;
                }
                else
                {
                    checkBox15.Checked = false;
                }
            }
        }
    }
}
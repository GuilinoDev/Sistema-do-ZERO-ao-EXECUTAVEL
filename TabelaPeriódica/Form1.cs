using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TabelaPeriódica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SoundPlayer somnaometais = new SoundPlayer(@"C:\Users\Doug_\OneDrive\Área de Trabalho\Audios Tabela periódica\naometais.wav");
        SoundPlayer sommetaisalcalinos = new SoundPlayer(@"C:\Users\Doug_\OneDrive\Área de Trabalho\Audios Tabela periódica\metaisalcalinos.wav");
        SoundPlayer somsemimetais = new SoundPlayer(@"C:\Users\Doug_\OneDrive\Área de Trabalho\Audios Tabela periódica\semimetais.wav");
        SoundPlayer somoutrosmetais = new SoundPlayer(@"C:\Users\Doug_\OneDrive\Área de Trabalho\Audios Tabela periódica\Outrosmetais.wav");
        SoundPlayer somlantanideos = new SoundPlayer(@"C:\Users\Doug_\OneDrive\Área de Trabalho\Audios Tabela periódica\lantanideos.wav");
        SoundPlayer somactinideos = new SoundPlayer(@"C:\Users\Doug_\OneDrive\Área de Trabalho\Audios Tabela periódica\actinideos.wav");
        SoundPlayer somgasesnobres = new SoundPlayer(@"C:\Users\Doug_\OneDrive\Área de Trabalho\Audios Tabela periódica\gasesnobres");
        SoundPlayer sommetaisalcalinosterrosos = new SoundPlayer(@"C:\Users\Doug_\OneDrive\Área de Trabalho\Audios Tabela periódica\metaisalcalinosterrosos.wav");
        SoundPlayer somhalogenios = new SoundPlayer(@"C:\Users\Doug_\OneDrive\Área de Trabalho\Audios Tabela periódica\halogenios.wav");
        SoundPlayer sommetaisdetransicao = new SoundPlayer(@"C:\Users\Doug_\OneDrive\Área de Trabalho\Audios Tabela periódica\metaisdetransicao.wav");

        private void radioButtonNãoMetais_CheckedChanged(object sender, EventArgs e)
        {
            somnaometais.Play();           
            timer1.Enabled = true;          
        }

        private void radioButtonSemimetais_CheckedChanged(object sender, EventArgs e)
        {            
            somsemimetais.Play();
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButtonNãoMetais.Checked == true)
            {
                // condicao ? consequencia: alternativa
                linkHidrogenio.LinkColor = linkHidrogenio.LinkColor == Color.White ? Color.Black : Color.White;
                linkCarbono.LinkColor = linkCarbono.LinkColor == Color.White ? Color.Black : Color.White;
                linkEnxofre.LinkColor = linkEnxofre.LinkColor == Color.White ? Color.Black : Color.White;
                linkFosforo.LinkColor = linkFosforo.LinkColor == Color.White ? Color.Black : Color.White;
                linkOxigenio.LinkColor = linkOxigenio.LinkColor == Color.White ? Color.Black : Color.White;
                linkNitrogenio.LinkColor = linkNitrogenio.LinkColor == Color.White ? Color.Black : Color.White;
                linkSelenio.LinkColor = linkSelenio.LinkColor == Color.White ? Color.Black : Color.White;

            }

            else if (radioButtonNãoMetais.Checked == false)
            {
                
                linkHidrogenio.LinkColor = Color.Black;
                linkCarbono.LinkColor = Color.Black;
                linkEnxofre.LinkColor = Color.Black;
                linkFosforo.LinkColor = Color.Black;
                linkOxigenio.LinkColor = Color.Black;
                linkNitrogenio.LinkColor = Color.Black;
                linkSelenio.LinkColor = Color.Black;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(radioButtonSemimetais.Checked == true)
            {
                linkBoro.LinkColor = linkBoro.LinkColor == Color.LightSkyBlue ? Color.White : Color.LightSkyBlue;
                linkSilicio.LinkColor = linkSilicio.LinkColor == Color.LightSkyBlue ? Color.White : Color.LightSkyBlue;
                linkGermanio.LinkColor = linkGermanio.LinkColor == Color.LightSkyBlue ? Color.White : Color.LightSkyBlue;
                linkArsenio.LinkColor = linkArsenio.LinkColor == Color.LightSkyBlue ? Color.White : Color.LightSkyBlue;
                linkAntimonio.LinkColor = linkAntimonio.LinkColor == Color.LightSkyBlue ? Color.White : Color.LightSkyBlue;
                linkTelurio.LinkColor = linkTelurio.LinkColor == Color.LightSkyBlue ? Color.White : Color.LightSkyBlue;
                linkPolonio.LinkColor = linkPolonio.LinkColor == Color.LightSkyBlue ? Color.White : Color.LightSkyBlue;
            }

            else if(radioButtonSemimetais.Checked == false)
            {
                
                linkBoro.LinkColor =  Color.Black;
                linkSilicio.LinkColor =  Color.Black;
                linkGermanio.LinkColor = Color.Black;
                linkArsenio.LinkColor = Color.Black;
                linkAntimonio.LinkColor =  Color.Black;
                linkTelurio.LinkColor =  Color.Black;
                linkPolonio.LinkColor = Color.Black;
            }
        }

        private void radioButtonMetaisAlcalinos_CheckedChanged(object sender, EventArgs e)
        {
            sommetaisalcalinos.Play();
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(radioButtonMetaisAlcalinos.Checked == true)
            {
                linkLitio.LinkColor = linkLitio.LinkColor == Color.White ? Color.LightSalmon : Color.White;
                linkSodio.LinkColor = linkSodio.LinkColor == Color.White ? Color.LightSalmon : Color.White;
                linkPotassio.LinkColor = linkPotassio.LinkColor == Color.White ? Color.LightSalmon : Color.White;
                linkRubidio.LinkColor = linkRubidio.LinkColor == Color.White ? Color.LightSalmon : Color.White;
                linkCesio.LinkColor = linkCesio.LinkColor == Color.White ? Color.LightSalmon : Color.White;
                linkFrancio.LinkColor = linkFrancio.LinkColor == Color.White ? Color.LightSalmon : Color.White;


            }
            else if(radioButtonMetaisAlcalinos.Checked == false)
            {
                linkLitio.LinkColor = Color.Black;
                linkSodio.LinkColor = Color.Black;
                linkPotassio.LinkColor = Color.Black;
                linkRubidio.LinkColor = Color.Black;
                linkCesio.LinkColor = Color.Black;
                linkFrancio.LinkColor = Color.Black;
            }
        }
    }
}

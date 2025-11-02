using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace EntregaFinal.Secante
{
    public partial class Form2 : Form
    {
        SpeechSynthesizer voz;

        public Form2()
        {
            InitializeComponent();

            // Configurar la voz al iniciar
            voz = new SpeechSynthesizer();
            voz.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("es-MX"));
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            voz.SpeakAsync("¡Bienvenido a la calculadora del método de la secante!");
        }
        private void btnAbrirCalculadora_Click(object sender, EventArgs e)
        {
            Secante1 calculadora = new Secante1(); 
            calculadora.Show();
            this.Hide(); 
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

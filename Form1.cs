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

namespace TTSI
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            if (checkedListBox1.SelectedIndex == 0)
            {
                synth.SetOutputToDefaultAudioDevice();
                synth.Speak(textBox1.Text);
            }
            else if(checkedListBox1.SelectedIndex == 1)
            {
                synth.SetOutputToWaveFile(textBox2.Text);
                synth.Speak(textBox1.Text);
            }
        }
    }
}

using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox1.Items.Clear();
            getAudioDevices().ForEach(x => { comboBox1.Items.Add(x); comboBox2.Items.Add(x); });
        }


        private void button3_Click(object sender, EventArgs e)
        {

            onRecordingStart(sender, e);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            onStopRecording(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

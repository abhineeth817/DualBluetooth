using System.Diagnostics;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //number of newly added comboBoxes
        private int dynamicComboCount = 0;
        private List<ComboBox> comboBoxes;

        public Form1()
        {
            InitializeComponent();
            comboBoxes = new List<ComboBox> { comboBox1, comboBox2 };
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // clears all the current comboBoxes
            foreach (var comboBox in comboBoxes)
            {
                comboBox.Items.Clear();
            }

            var devices = getAudioDeviceIds();
            for (int i = 0; i < devices.Count; i++)
            {
                var device = devices[i];
                foreach (var comboBox in comboBoxes)
                {
                    comboBox.Items.Add(device);
                }
            }
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

        private void add_button_Click(object sender, EventArgs e)
        {
            AddDeviceComboBox();
            Console.WriteLine("Button5 clicked");
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

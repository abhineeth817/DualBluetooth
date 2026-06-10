namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox1.Items.Clear();
            AudioDeviceManager ad = new AudioDeviceManager();
            ad.getAudioDevices().ForEach(x => { comboBox1.Items.Add(x); comboBox2.Items.Add(x); });
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

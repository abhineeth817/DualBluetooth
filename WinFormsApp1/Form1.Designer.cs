using NAudio.CoreAudioApi;
using NAudio.Wave;
using System.Text.RegularExpressions;


//public class DeviceAudioPlayer
//{
    
//}


namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            add_button = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(461, 412);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(461, 464);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 3;
            button2.Text = "Connect";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 4;
            label1.Text = "Devices";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Device1", "Device2" });
            comboBox1.Location = new Point(195, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(770, 40);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedIndexChanged += DynamicCombo_SelectedIndexChanged;

            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(195, 82);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(770, 40);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += DynamicCombo_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(259, 464);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 7;
            button3.Text = "Play Audio";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(666, 464);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 8;
            button4.Text = "Stop Audio";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // add_button
            // 
            add_button.Location = new Point(461, 360);
            add_button.Name = "add_button";
            add_button.Size = new Size(150, 46);
            add_button.TabIndex = 9;
            add_button.Text = "New device";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(12, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 216);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 35);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 11;
            label2.Text = "Device 1 :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 90);
            label3.Name = "label3";
            label3.Size = new Size(118, 32);
            label3.TabIndex = 12;
            label3.Text = "Device 2 :";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 574);
            Controls.Add(panel1);
            Controls.Add(add_button);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "DualBluetooth";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button3;
        private Button button4;


        //Start of NAaudio related fuction declarations

        public List<string> getAudioDevices()
        {
            var devices = new List<string>();

            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                var deviceInfo = WaveOut.GetCapabilities(i);
                var deviceID = deviceInfo.ProductGuid.ToString();
                devices.Add($"{i} : {deviceInfo.ProductName}");

            }

            return devices;
        }

        public MMDeviceCollection getAudioDeviceIds()
        {

            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();

            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);

            return devices;

        }

        private BufferedWaveProvider bufferedWaveProvider;
        private WasapiOut player;
        private WasapiCapture recorder;

        public void onRecordingStart(Object sender, EventArgs e)
        {
            recorder = new WasapiLoopbackCapture();
            recorder.DataAvailable += RecorderOnDataAvailable;

            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            MMDevice targetDevice = (MMDevice)comboBox2.SelectedItem;

            var mixFormat = targetDevice.AudioClient.MixFormat;
            bufferedWaveProvider = new BufferedWaveProvider(mixFormat);

            Console.WriteLine(targetDevice.FriendlyName);
            Console.WriteLine(targetDevice.AudioClient.MixFormat.SampleRate);
            Console.WriteLine(targetDevice.AudioClient.MixFormat.Channels);


            player = new WasapiOut(targetDevice, AudioClientShareMode.Shared, false, 50);

            SilenceProvider sp = new SilenceProvider(mixFormat);
            player.Init(sp);

            player.Play();
            recorder.StartRecording();
        }

        private void RecorderOnDataAvailable(Object sender, WaveInEventArgs waveInEventArgs)
        {
            bufferedWaveProvider.AddSamples(waveInEventArgs.Buffer, 0, waveInEventArgs.BytesRecorded);
        }

        public void onStopRecording(Object sender, EventArgs e)
        {
            recorder.StopRecording();
            player.Stop();
        }

        //End of NAudio related function declarations


        // Start of dynamic comboBox related function declaration
        private void AddDeviceComboBox()
        {
            // add a new combobox to the form and fill it with audio devices
            dynamicComboCount++;
            var devices = getAudioDeviceIds();
            var comboBox = new ComboBox();
            var label = new Label();

            comboBox.FormattingEnabled = true;
            comboBox.Size = new Size(comboBox2.Width, comboBox2.Height);

            //seting the posittion of new comboBox below the last one
            int padding = 15;
            int y = comboBox2.Bottom + padding + (dynamicComboCount - 1) * (comboBox2.Height + padding);
            comboBox.Location = new Point(comboBox2.Left, y);
            Console.WriteLine($"Adding new comboBox at {comboBox.Location}");
            label.Location = new Point(comboBox.Left - 150, y);
            label.Size = new Size(150, comboBox.Height);
            label.Text = $"Device {dynamicComboCount + 2} : ";

            comboBox.Name = $"dynamicComboBox_" + dynamicComboCount;
            comboBox.TabIndex = 100 + dynamicComboCount;
            comboBox.SelectedIndexChanged += DynamicCombo_SelectedIndexChanged;

            foreach (var d in devices)
            {
                comboBox.Items.Add(d);

            }

            //select the next device not already selected in other comboBoxes
            if (comboBox.Items.Count > 0) comboBox.SelectedIndex = -1;

            //add the new comboBox to the control of the form and the list of comboBoxes
            panel1.Controls.Add(label);
            panel1.Controls.Add(comboBox);
            comboBoxes.Add(comboBox);
        }

        public void DynamicCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("DynamicCombo_SelectedIndexChanged called");
            var comboBox = sender as ComboBox;
            if (comboBox == null || comboBox.SelectedItem == null) return;

            foreach (var c in comboBoxes)
            {
                if (c != comboBox && c.SelectedItem == comboBox.SelectedItem)
                {
                    comboBox.SelectedIndex = -1;
                    MessageBox.Show("This device is already selected");
                    return;
                }
            }
        }

        //End of dynamic comboBox related function declaration

        private Button add_button;
        private Panel panel1;
        private Label label2;
        private Label label3;
    }
}

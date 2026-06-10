using NAudio;
using NAudio.Wave;
using System.CodeDom;

public class AudioDeviceManager
{
    public List<string> getAudioDevices()
    {
        var devices = new List<string>();
        for (int i = 0; i< WaveOut.DeviceCount; i++)
        {
            var deviceInfo = WaveOut.GetCapabilities(i);
            devices.Add($"{i} : {deviceInfo.ProductName}");
        }

        return devices;
    }


}


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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(313, 255);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(313, 316);
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
            comboBox1.Location = new Point(12, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(776, 40);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 126);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(776, 40);
            comboBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "DualBluetooth";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}

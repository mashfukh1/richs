
namespace MQTT_RICHS
{
    partial class FeedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.T_Alarm1 = new System.Windows.Forms.Timer(this.components);
            this.btn_stop = new System.Windows.Forms.Button();
            this.txtStream = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MACHINE_STATUS = new System.Windows.Forms.Button();
            this.ALARM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(8, 77);
            this.txtTopic.Multiline = true;
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(338, 26);
            this.txtTopic.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TOPIC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPublish
            // 
            this.btnPublish.BackColor = System.Drawing.Color.Lime;
            this.btnPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublish.Location = new System.Drawing.Point(707, 11);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(104, 28);
            this.btnPublish.TabIndex = 6;
            this.btnPublish.Text = "PROCESS";
            this.btnPublish.UseVisualStyleBackColor = false;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(707, 77);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(104, 28);
            this.btn_close.TabIndex = 18;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 38);
            this.label6.TabIndex = 25;
            this.label6.Text = "MIXING 1A";
            // 
            // T_Alarm1
            // 
            this.T_Alarm1.Interval = 1500;
            this.T_Alarm1.Tick += new System.EventHandler(this.T_Alarm1_Tick);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(707, 45);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(104, 28);
            this.btn_stop.TabIndex = 27;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // txtStream
            // 
            this.txtStream.Location = new System.Drawing.Point(4, 10);
            this.txtStream.Name = "txtStream";
            this.txtStream.Size = new System.Drawing.Size(805, 135);
            this.txtStream.TabIndex = 0;
            this.txtStream.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStream);
            this.groupBox1.Location = new System.Drawing.Point(5, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 148);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // MACHINE_STATUS
            // 
            this.MACHINE_STATUS.Location = new System.Drawing.Point(651, 27);
            this.MACHINE_STATUS.Name = "MACHINE_STATUS";
            this.MACHINE_STATUS.Size = new System.Drawing.Size(15, 15);
            this.MACHINE_STATUS.TabIndex = 30;
            this.MACHINE_STATUS.UseVisualStyleBackColor = true;
            this.MACHINE_STATUS.Click += new System.EventHandler(this.MACHINE_STATUS_Click);
            // 
            // ALARM
            // 
            this.ALARM.Location = new System.Drawing.Point(651, 48);
            this.ALARM.Name = "ALARM";
            this.ALARM.Size = new System.Drawing.Size(15, 15);
            this.ALARM.TabIndex = 31;
            this.ALARM.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "MySql";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mqtt";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(721, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 9);
            this.label7.TabIndex = 36;
            this.label7.Text = "Citia Engineering Indonesia";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubscribe.Location = new System.Drawing.Point(352, 77);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(120, 28);
            this.btnSubscribe.TabIndex = 38;
            this.btnSubscribe.Text = "Connect";
            this.btnSubscribe.UseVisualStyleBackColor = false;
            // 
            // FeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(823, 269);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ALARM);
            this.Controls.Add(this.MACHINE_STATUS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(894, 544);
            this.Name = "FeedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIXING PROCESS";
            this.Load += new System.EventHandler(this.FeedForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer T_Alarm1;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.RichTextBox txtStream;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MACHINE_STATUS;
        private System.Windows.Forms.Button ALARM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSubscribe;
    }
}
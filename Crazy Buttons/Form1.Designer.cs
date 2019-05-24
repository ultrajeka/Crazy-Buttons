namespace Crazy_Buttons
{
    partial class Form1
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
            this.btn_first = new Crazy_Buttons.ButtonCompare();
            this.btn_second = new Crazy_Buttons.ButtonCompare();
            this.btn_third = new Crazy_Buttons.ButtonCompare();
            this.btn_fourth = new Crazy_Buttons.ButtonCompare();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_first
            // 
            this.btn_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_first.Location = new System.Drawing.Point(12, 25);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(98, 36);
            this.btn_first.TabIndex = 0;
            this.btn_first.Text = "Button 1";
            this.btn_first.UseVisualStyleBackColor = true;
            // 
            // btn_second
            // 
            this.btn_second.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_second.Location = new System.Drawing.Point(12, 90);
            this.btn_second.Name = "btn_second";
            this.btn_second.Size = new System.Drawing.Size(98, 36);
            this.btn_second.TabIndex = 1;
            this.btn_second.Text = "Button 2";
            this.btn_second.UseVisualStyleBackColor = true;
            // 
            // btn_third
            // 
            this.btn_third.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_third.Location = new System.Drawing.Point(12, 158);
            this.btn_third.Name = "btn_third";
            this.btn_third.Size = new System.Drawing.Size(98, 36);
            this.btn_third.TabIndex = 2;
            this.btn_third.Text = "Button 3";
            this.btn_third.UseVisualStyleBackColor = true;
            // 
            // btn_fourth
            // 
            this.btn_fourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_fourth.Location = new System.Drawing.Point(12, 221);
            this.btn_fourth.Name = "btn_fourth";
            this.btn_fourth.Size = new System.Drawing.Size(98, 36);
            this.btn_fourth.TabIndex = 3;
            this.btn_fourth.Text = "Button 4";
            this.btn_fourth.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_start.Location = new System.Drawing.Point(26, 32);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(170, 55);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Enabled = false;
            this.btn_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_pause.Location = new System.Drawing.Point(274, 32);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(170, 55);
            this.btn_pause.TabIndex = 5;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_stop.Location = new System.Drawing.Point(526, 32);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(170, 55);
            this.btn_stop.TabIndex = 6;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_pause);
            this.groupBox1.Controls.Add(this.btn_stop);
            this.groupBox1.Controls.Add(this.btn_start);
            this.groupBox1.Location = new System.Drawing.Point(310, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 116);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Crazy_Buttons.Properties.Resources.Finish2;
            this.pictureBox1.Location = new System.Drawing.Point(1438, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 314);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_fourth);
            this.Controls.Add(this.btn_third);
            this.Controls.Add(this.btn_second);
            this.Controls.Add(this.btn_first);
            this.Name = "Form1";
            this.Text = "Гонки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonCompare  btn_first;
        private ButtonCompare  btn_second;
        private ButtonCompare  btn_third;
        private ButtonCompare  btn_fourth;

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


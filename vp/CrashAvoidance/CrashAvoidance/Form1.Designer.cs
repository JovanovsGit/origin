namespace CrashAvoidance
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RoadMover = new System.Windows.Forms.Timer(this.components);
            this.Left_mover = new System.Windows.Forms.Timer(this.components);
            this.Right_mover = new System.Windows.Forms.Timer(this.components);
            this.enemy1_mover = new System.Windows.Forms.Timer(this.components);
            this.enemy2_mover = new System.Windows.Forms.Timer(this.components);
            this.enemy3_mover = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.CAR = new System.Windows.Forms.PictureBox();
            this.enemyCar1 = new System.Windows.Forms.PictureBox();
            this.enemyCar2 = new System.Windows.Forms.PictureBox();
            this.enemyCar3 = new System.Windows.Forms.PictureBox();
            this.enemyCar4 = new System.Windows.Forms.PictureBox();
            this.enemy4_mover = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCar4)).BeginInit();
            this.SuspendLayout();
            // 
            // RoadMover
            // 
            this.RoadMover.Enabled = true;
            this.RoadMover.Interval = 10;
            this.RoadMover.Tick += new System.EventHandler(this.RoadMover_Tick);
            // 
            // Left_mover
            // 
            this.Left_mover.Interval = 10;
            this.Left_mover.Tick += new System.EventHandler(this.Left_mover_Tick);
            // 
            // Right_mover
            // 
            this.Right_mover.Interval = 10;
            this.Right_mover.Tick += new System.EventHandler(this.Right_mover_Tick);
            // 
            // enemy1_mover
            // 
            this.enemy1_mover.Enabled = true;
            this.enemy1_mover.Interval = 10;
            this.enemy1_mover.Tick += new System.EventHandler(this.enemy1_mover_Tick);
            // 
            // enemy2_mover
            // 
            this.enemy2_mover.Enabled = true;
            this.enemy2_mover.Interval = 10;
            this.enemy2_mover.Tick += new System.EventHandler(this.enemy2_mover_Tick);
            // 
            // enemy3_mover
            // 
            this.enemy3_mover.Enabled = true;
            this.enemy3_mover.Interval = 10;
            this.enemy3_mover.Tick += new System.EventHandler(this.enemy3_mover_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(193, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 116);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(502, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 116);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(193, 244);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 116);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(502, 244);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 116);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(190, 492);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 116);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(502, 492);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 116);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(190, 719);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(29, 116);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(502, 719);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(29, 116);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // CAR
            // 
            this.CAR.Image = ((System.Drawing.Image)(resources.GetObject("CAR.Image")));
            this.CAR.Location = new System.Drawing.Point(347, 668);
            this.CAR.Name = "CAR";
            this.CAR.Size = new System.Drawing.Size(66, 143);
            this.CAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CAR.TabIndex = 8;
            this.CAR.TabStop = false;
            // 
            // enemyCar1
            // 
            this.enemyCar1.Image = ((System.Drawing.Image)(resources.GetObject("enemyCar1.Image")));
            this.enemyCar1.Location = new System.Drawing.Point(12, 323);
            this.enemyCar1.Name = "enemyCar1";
            this.enemyCar1.Size = new System.Drawing.Size(66, 137);
            this.enemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyCar1.TabIndex = 9;
            this.enemyCar1.TabStop = false;
            // 
            // enemyCar2
            // 
            this.enemyCar2.Image = ((System.Drawing.Image)(resources.GetObject("enemyCar2.Image")));
            this.enemyCar2.Location = new System.Drawing.Point(302, 2);
            this.enemyCar2.Name = "enemyCar2";
            this.enemyCar2.Size = new System.Drawing.Size(66, 137);
            this.enemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyCar2.TabIndex = 10;
            this.enemyCar2.TabStop = false;
            // 
            // enemyCar3
            // 
            this.enemyCar3.Image = ((System.Drawing.Image)(resources.GetObject("enemyCar3.Image")));
            this.enemyCar3.Location = new System.Drawing.Point(543, 153);
            this.enemyCar3.Name = "enemyCar3";
            this.enemyCar3.Size = new System.Drawing.Size(66, 137);
            this.enemyCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyCar3.TabIndex = 11;
            this.enemyCar3.TabStop = false;
            // 
            // enemyCar4
            // 
            this.enemyCar4.Image = ((System.Drawing.Image)(resources.GetObject("enemyCar4.Image")));
            this.enemyCar4.Location = new System.Drawing.Point(228, 223);
            this.enemyCar4.Name = "enemyCar4";
            this.enemyCar4.Size = new System.Drawing.Size(66, 137);
            this.enemyCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyCar4.TabIndex = 12;
            this.enemyCar4.TabStop = false;
            // 
            // enemy4_mover
            // 
            this.enemy4_mover.Enabled = true;
            this.enemy4_mover.Interval = 10;
            this.enemy4_mover.Tick += new System.EventHandler(this.enemy4_mover_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(219, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 54);
            this.label1.TabIndex = 13;
            this.label1.Text = "Game Over";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(277, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 54);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pause";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(732, 833);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enemyCar4);
            this.Controls.Add(this.enemyCar3);
            this.Controls.Add(this.enemyCar2);
            this.Controls.Add(this.enemyCar1);
            this.Controls.Add(this.CAR);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(750, 880);
            this.MinimumSize = new System.Drawing.Size(750, 880);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer RoadMover;
        private System.Windows.Forms.Timer Left_mover;
        private System.Windows.Forms.Timer Right_mover;
        private System.Windows.Forms.Timer enemy1_mover;
        private System.Windows.Forms.Timer enemy2_mover;
        private System.Windows.Forms.Timer enemy3_mover;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox CAR;
        private System.Windows.Forms.PictureBox enemyCar1;
        private System.Windows.Forms.PictureBox enemyCar2;
        private System.Windows.Forms.PictureBox enemyCar3;
        private System.Windows.Forms.PictureBox enemyCar4;
        private System.Windows.Forms.Timer enemy4_mover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


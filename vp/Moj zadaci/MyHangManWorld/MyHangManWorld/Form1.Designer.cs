namespace MyHangManWorld
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
            this.lblWord = new System.Windows.Forms.Label();
            this.lblMask = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pbTime = new System.Windows.Forms.ProgressBar();
            this.pbWrong = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPogodeniBukvi = new System.Windows.Forms.TextBox();
            this.txtBukva = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(13, 98);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(0, 17);
            this.lblWord.TabIndex = 0;
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Font = new System.Drawing.Font("Courier New", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMask.Location = new System.Drawing.Point(12, 61);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(197, 54);
            this.lblMask.TabIndex = 1;
            this.lblMask.Text = "label1";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTimer.Location = new System.Drawing.Point(602, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(134, 43);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "10:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbTime
            // 
            this.pbTime.Location = new System.Drawing.Point(12, 498);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(724, 36);
            this.pbTime.TabIndex = 3;
            // 
            // pbWrong
            // 
            this.pbWrong.Location = new System.Drawing.Point(12, 457);
            this.pbWrong.Name = "pbWrong";
            this.pbWrong.Size = new System.Drawing.Size(724, 35);
            this.pbWrong.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPogodeniBukvi);
            this.groupBox1.Location = new System.Drawing.Point(21, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pogodeni bukvi";
            // 
            // txtPogodeniBukvi
            // 
            this.txtPogodeniBukvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPogodeniBukvi.Location = new System.Drawing.Point(6, 32);
            this.txtPogodeniBukvi.Name = "txtPogodeniBukvi";
            this.txtPogodeniBukvi.ReadOnly = true;
            this.txtPogodeniBukvi.Size = new System.Drawing.Size(702, 49);
            this.txtPogodeniBukvi.TabIndex = 0;
            // 
            // txtBukva
            // 
            this.txtBukva.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBukva.Location = new System.Drawing.Point(27, 189);
            this.txtBukva.MaxLength = 1;
            this.txtBukva.Name = "txtBukva";
            this.txtBukva.Size = new System.Drawing.Size(145, 143);
            this.txtBukva.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(188, 189);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(138, 143);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 540);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtBukva);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbWrong);
            this.Controls.Add(this.pbTime);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.lblWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ProgressBar pbTime;
        private System.Windows.Forms.ProgressBar pbWrong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPogodeniBukvi;
        private System.Windows.Forms.TextBox txtBukva;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Timer timer1;
    }
}


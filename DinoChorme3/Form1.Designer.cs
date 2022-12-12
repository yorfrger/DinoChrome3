namespace DinoChorme3
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.dino1 = new System.Windows.Forms.PictureBox();
            this.dinocrouch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinocrouch)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DinoChorme3.Properties.Resources.obstacle_1_1_;
            this.pictureBox2.Location = new System.Drawing.Point(397, 359);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "obstacle";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DinoChorme3.Properties.Resources.obstacle_2_2_;
            this.pictureBox3.Location = new System.Drawing.Point(523, 372);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "obstacle";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(32, 19);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(106, 24);
            this.txtScore.TabIndex = 2;
            this.txtScore.Tag = "txtScore";
            this.txtScore.Text = "Score: 0";
            // 
            // gametimer
            // 
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // dino1
            // 
            this.dino1.Image = global::DinoChorme3.Properties.Resources.running_1_;
            this.dino1.Location = new System.Drawing.Point(133, 359);
            this.dino1.Name = "dino1";
            this.dino1.Size = new System.Drawing.Size(40, 43);
            this.dino1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dino1.TabIndex = 1;
            this.dino1.TabStop = false;
            this.dino1.Tag = "dino";
            this.dino1.Click += new System.EventHandler(this.dino1_Click);
            // 
            // dinocrouch
            // 
            this.dinocrouch.Image = global::DinoChorme3.Properties.Resources.crouch6dino;
            this.dinocrouch.Location = new System.Drawing.Point(133, 377);
            this.dinocrouch.Name = "dinocrouch";
            this.dinocrouch.Size = new System.Drawing.Size(61, 28);
            this.dinocrouch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dinocrouch.TabIndex = 3;
            this.dinocrouch.TabStop = false;
            this.dinocrouch.Click += new System.EventHandler(this.dinocrouch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dinocrouch);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dino1);
            this.Name = "Form1";
            this.Tag = "obstacle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinocrouch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label txtScore;
        private System.Windows.Forms.Timer gametimer;
        private PictureBox dino1;
        private PictureBox dinocrouch;
    }
}
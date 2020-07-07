namespace Shooter
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
            this.tRender = new System.Windows.Forms.Timer(this.components);
            this.tBullet = new System.Windows.Forms.Timer(this.components);
            this.DoubleBullet = new System.Windows.Forms.Timer(this.components);
            this.Observer = new System.Windows.Forms.Timer(this.components);
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            this.SuspendLayout();
            // 
            // tRender
            // 
            this.tRender.Enabled = true;
            this.tRender.Interval = 50;
            this.tRender.Tick += new System.EventHandler(this.tRender_Tick);
            // 
            // tBullet
            // 
            this.tBullet.Enabled = true;
            this.tBullet.Interval = 10;
            this.tBullet.Tick += new System.EventHandler(this.tBullet_Tick);
            // 
            // enemy1
            // 
            this.enemy1.Image = global::Shooter.Properties.Resources.enemy;
            this.enemy1.Location = new System.Drawing.Point(26, 28);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(100, 93);
            this.enemy1.TabIndex = 0;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = global::Shooter.Properties.Resources.enemy;
            this.enemy2.Location = new System.Drawing.Point(246, 28);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(100, 93);
            this.enemy2.TabIndex = 1;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = global::Shooter.Properties.Resources.enemy;
            this.enemy3.Location = new System.Drawing.Point(501, 28);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(100, 93);
            this.enemy3.TabIndex = 2;
            this.enemy3.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.Image = global::Shooter.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(286, 380);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(10, 32);
            this.bullet.TabIndex = 3;
            this.bullet.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(571, 321);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(0, 108);
            this.scoreText.TabIndex = 4;
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Tick += new System.EventHandler(this.Player_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 819);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tRender;
        private System.Windows.Forms.Timer tBullet;
        private System.Windows.Forms.Timer DoubleBullet;
        private System.Windows.Forms.Timer Observer;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer Player;
    }
}


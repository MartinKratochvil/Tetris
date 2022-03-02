
namespace Tetris_v._1._1
{
    partial class Endless
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Endless));
            this.LabelCoins = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelNickname = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gravity = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Grid = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GridPiece = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelCoins
            // 
            this.LabelCoins.AutoSize = true;
            this.LabelCoins.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCoins.Location = new System.Drawing.Point(93, 223);
            this.LabelCoins.Name = "LabelCoins";
            this.LabelCoins.Size = new System.Drawing.Size(56, 31);
            this.LabelCoins.TabIndex = 7;
            this.LabelCoins.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Coins:";
            // 
            // LabelNickname
            // 
            this.LabelNickname.AutoSize = true;
            this.LabelNickname.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNickname.Location = new System.Drawing.Point(14, 178);
            this.LabelNickname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelNickname.Name = "LabelNickname";
            this.LabelNickname.Size = new System.Drawing.Size(186, 43);
            this.LabelNickname.TabIndex = 5;
            this.LabelNickname.Text = "Nitram293";
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelScore.Location = new System.Drawing.Point(93, 254);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(28, 31);
            this.LabelScore.TabIndex = 9;
            this.LabelScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Score:";
            // 
            // Gravity
            // 
            this.Gravity.Interval = 1000;
            this.Gravity.Tick += new System.EventHandler(this.Gravity_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Grid
            // 
            this.Grid.Image = ((System.Drawing.Image)(resources.GetObject("Grid.Image")));
            this.Grid.Location = new System.Drawing.Point(345, 35);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(310, 610);
            this.Grid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Grid.TabIndex = 10;
            this.Grid.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 541);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // GridPiece
            // 
            this.GridPiece.ErrorImage = null;
            this.GridPiece.Image = ((System.Drawing.Image)(resources.GetObject("GridPiece.Image")));
            this.GridPiece.Location = new System.Drawing.Point(715, 75);
            this.GridPiece.Name = "GridPiece";
            this.GridPiece.Size = new System.Drawing.Size(130, 130);
            this.GridPiece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GridPiece.TabIndex = 29;
            this.GridPiece.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(707, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 43);
            this.label3.TabIndex = 30;
            this.label3.Text = "Next Piece";
            // 
            // Endless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridPiece);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelCoins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelNickname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Grid);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Endless";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endless";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Endless_FormClosed);
            this.Load += new System.EventHandler(this.Endless_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Endless_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Endless_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCoins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelNickname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Gravity;
        private System.Windows.Forms.PictureBox Grid;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox GridPiece;
        private System.Windows.Forms.Label label3;
    }
}
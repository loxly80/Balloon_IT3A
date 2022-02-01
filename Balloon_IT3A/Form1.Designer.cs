namespace Balloon_IT3A
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pboxBasket = new System.Windows.Forms.PictureBox();
            this.pboxBalloonColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pboxCanvas = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBalloonColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numSize);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pboxBasket);
            this.panel1.Controls.Add(this.pboxBalloonColor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 144);
            this.panel1.TabIndex = 0;
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(269, 94);
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(117, 31);
            this.numSize.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Velikost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barva koše";
            // 
            // pboxBasket
            // 
            this.pboxBasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pboxBasket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxBasket.Location = new System.Drawing.Point(269, 51);
            this.pboxBasket.Name = "pboxBasket";
            this.pboxBasket.Size = new System.Drawing.Size(59, 34);
            this.pboxBasket.TabIndex = 2;
            this.pboxBasket.TabStop = false;
            this.pboxBasket.Click += new System.EventHandler(this.pboxBasket_Click);
            // 
            // pboxBalloonColor
            // 
            this.pboxBalloonColor.BackColor = System.Drawing.Color.Lime;
            this.pboxBalloonColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxBalloonColor.Location = new System.Drawing.Point(269, 11);
            this.pboxBalloonColor.Name = "pboxBalloonColor";
            this.pboxBalloonColor.Size = new System.Drawing.Size(59, 34);
            this.pboxBalloonColor.TabIndex = 2;
            this.pboxBalloonColor.TabStop = false;
            this.pboxBalloonColor.Click += new System.EventHandler(this.pboxBalloonColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barva balónu";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 11);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(112, 34);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generuj";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pboxCanvas
            // 
            this.pboxCanvas.BackColor = System.Drawing.Color.White;
            this.pboxCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxCanvas.Location = new System.Drawing.Point(0, 0);
            this.pboxCanvas.Name = "pboxCanvas";
            this.pboxCanvas.Size = new System.Drawing.Size(895, 456);
            this.pboxCanvas.TabIndex = 1;
            this.pboxCanvas.TabStop = false;
            this.pboxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxCanvas_Paint);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 600);
            this.Controls.Add(this.pboxCanvas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBalloonColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pboxBasket;
        private System.Windows.Forms.PictureBox pboxBalloonColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pboxCanvas;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}


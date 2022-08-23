namespace Actividad_3
{
    partial class infGrafo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aristaListbox = new System.Windows.Forms.ListBox();
            this.verticeListbox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.particulaButton = new System.Windows.Forms.Button();
            this.mensajeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vertice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(684, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Aristas";
            // 
            // aristaListbox
            // 
            this.aristaListbox.FormattingEnabled = true;
            this.aristaListbox.HorizontalScrollbar = true;
            this.aristaListbox.Location = new System.Drawing.Point(486, 41);
            this.aristaListbox.Name = "aristaListbox";
            this.aristaListbox.Size = new System.Drawing.Size(451, 329);
            this.aristaListbox.TabIndex = 7;
            // 
            // verticeListbox
            // 
            this.verticeListbox.FormattingEnabled = true;
            this.verticeListbox.Location = new System.Drawing.Point(435, 41);
            this.verticeListbox.Name = "verticeListbox";
            this.verticeListbox.Size = new System.Drawing.Size(43, 329);
            this.verticeListbox.TabIndex = 6;
            this.verticeListbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.verticeListbox_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // particulaButton
            // 
            this.particulaButton.Location = new System.Drawing.Point(862, 376);
            this.particulaButton.Name = "particulaButton";
            this.particulaButton.Size = new System.Drawing.Size(75, 23);
            this.particulaButton.TabIndex = 10;
            this.particulaButton.Text = "Particula";
            this.particulaButton.UseVisualStyleBackColor = true;
            this.particulaButton.Click += new System.EventHandler(this.particulaButton_Click);
            // 
            // mensajeLabel
            // 
            this.mensajeLabel.AutoSize = true;
            this.mensajeLabel.Location = new System.Drawing.Point(439, 376);
            this.mensajeLabel.Name = "mensajeLabel";
            this.mensajeLabel.Size = new System.Drawing.Size(0, 13);
            this.mensajeLabel.TabIndex = 11;
            // 
            // infGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 403);
            this.Controls.Add(this.mensajeLabel);
            this.Controls.Add(this.particulaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aristaListbox);
            this.Controls.Add(this.verticeListbox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "infGrafo";
            this.Text = "infGrafo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox aristaListbox;
        private System.Windows.Forms.ListBox verticeListbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button particulaButton;
        private System.Windows.Forms.Label mensajeLabel;
    }
}
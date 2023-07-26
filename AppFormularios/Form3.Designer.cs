namespace AppFormularios
{
    partial class frmMenu
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
            this.btnAreaQuadrado = new System.Windows.Forms.Button();
            this.btnAreaRetangulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAreaQuadrado
            // 
            this.btnAreaQuadrado.Location = new System.Drawing.Point(47, 53);
            this.btnAreaQuadrado.Name = "btnAreaQuadrado";
            this.btnAreaQuadrado.Size = new System.Drawing.Size(104, 23);
            this.btnAreaQuadrado.TabIndex = 0;
            this.btnAreaQuadrado.Text = "Area Quadrado";
            this.btnAreaQuadrado.UseVisualStyleBackColor = true;
            this.btnAreaQuadrado.Click += new System.EventHandler(this.btnAreaQuadrado_Click);
            // 
            // btnAreaRetangulo
            // 
            this.btnAreaRetangulo.Location = new System.Drawing.Point(193, 53);
            this.btnAreaRetangulo.Name = "btnAreaRetangulo";
            this.btnAreaRetangulo.Size = new System.Drawing.Size(95, 23);
            this.btnAreaRetangulo.TabIndex = 1;
            this.btnAreaRetangulo.Text = "Area Retangulo";
            this.btnAreaRetangulo.UseVisualStyleBackColor = true;
            this.btnAreaRetangulo.Click += new System.EventHandler(this.btnAreaRetangulo_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAreaRetangulo);
            this.Controls.Add(this.btnAreaQuadrado);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAreaQuadrado;
        private System.Windows.Forms.Button btnAreaRetangulo;
    }
}
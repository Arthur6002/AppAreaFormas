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
            this.components = new System.ComponentModel.Container();
            this.btnAreaQuadrado = new System.Windows.Forms.Button();
            this.btnAreaRetangulo = new System.Windows.Forms.Button();
            this.bntFechar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAreaQuadrado
            // 
            this.btnAreaQuadrado.Location = new System.Drawing.Point(221, 173);
            this.btnAreaQuadrado.Name = "btnAreaQuadrado";
            this.btnAreaQuadrado.Size = new System.Drawing.Size(109, 90);
            this.btnAreaQuadrado.TabIndex = 0;
            this.btnAreaQuadrado.Text = "Area Quadrado";
            this.btnAreaQuadrado.UseVisualStyleBackColor = true;
            // 
            // btnAreaRetangulo
            // 
            this.btnAreaRetangulo.Location = new System.Drawing.Point(444, 173);
            this.btnAreaRetangulo.Name = "btnAreaRetangulo";
            this.btnAreaRetangulo.Size = new System.Drawing.Size(109, 90);
            this.btnAreaRetangulo.TabIndex = 1;
            this.btnAreaRetangulo.Text = "Area Retangulo";
            this.btnAreaRetangulo.UseVisualStyleBackColor = true;
            // 
            // bntFechar
            // 
            this.bntFechar.Location = new System.Drawing.Point(0, 27);
            this.bntFechar.Name = "bntFechar";
            this.bntFechar.Size = new System.Drawing.Size(87, 28);
            this.bntFechar.TabIndex = 2;
            this.bntFechar.Text = "Fechar";
            this.bntFechar.UseVisualStyleBackColor = true;
            this.bntFechar.Click += new System.EventHandler(this.bntFechar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quadradoToolStripMenuItem,
            this.retanguloToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 20);
            this.toolStripMenuItem1.Text = "Calculo de Areas";
            // 
            // quadradoToolStripMenuItem
            // 
            this.quadradoToolStripMenuItem.Name = "quadradoToolStripMenuItem";
            this.quadradoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quadradoToolStripMenuItem.Text = "Quadrado";
            this.quadradoToolStripMenuItem.Click += new System.EventHandler(this.quadradoToolStripMenuItem_Click);
            // 
            // retanguloToolStripMenuItem
            // 
            this.retanguloToolStripMenuItem.Name = "retanguloToolStripMenuItem";
            this.retanguloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.retanguloToolStripMenuItem.Text = "Retangulo";
            this.retanguloToolStripMenuItem.Click += new System.EventHandler(this.retanguloToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bntFechar);
            this.Controls.Add(this.btnAreaRetangulo);
            this.Controls.Add(this.btnAreaQuadrado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAreaQuadrado;
        private System.Windows.Forms.Button btnAreaRetangulo;
        private System.Windows.Forms.Button bntFechar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retanguloToolStripMenuItem;
    }
}
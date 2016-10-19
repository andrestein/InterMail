namespace InterMail
{
    partial class BandejaEntrada
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lMensajes = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMostrarNombre = new System.Windows.Forms.Label();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReceptor = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 417);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRecargar);
            this.tabPage1.Controls.Add(this.lMensajes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(657, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bandeja de entrada";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lMensajes
            // 
            this.lMensajes.Location = new System.Drawing.Point(6, 46);
            this.lMensajes.Name = "lMensajes";
            this.lMensajes.Size = new System.Drawing.Size(644, 339);
            this.lMensajes.TabIndex = 0;
            this.lMensajes.UseCompatibleStateImageBehavior = false;
            this.lMensajes.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEnviar);
            this.tabPage2.Controls.Add(this.txtDescrip);
            this.tabPage2.Controls.Add(this.txtAsunto);
            this.tabPage2.Controls.Add(this.txtReceptor);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(657, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear mensaje";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hola";
            // 
            // lbMostrarNombre
            // 
            this.lbMostrarNombre.AutoSize = true;
            this.lbMostrarNombre.Location = new System.Drawing.Point(53, 13);
            this.lbMostrarNombre.Name = "lbMostrarNombre";
            this.lbMostrarNombre.Size = new System.Drawing.Size(0, 13);
            this.lbMostrarNombre.TabIndex = 2;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(7, 17);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(75, 23);
            this.btnRecargar.TabIndex = 1;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Para :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Asunto :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripcion :";
            // 
            // txtReceptor
            // 
            this.txtReceptor.Location = new System.Drawing.Point(104, 25);
            this.txtReceptor.Name = "txtReceptor";
            this.txtReceptor.Size = new System.Drawing.Size(519, 20);
            this.txtReceptor.TabIndex = 3;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(104, 59);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(519, 20);
            this.txtAsunto.TabIndex = 4;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(104, 99);
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(519, 179);
            this.txtDescrip.TabIndex = 5;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(309, 343);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // BandejaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 469);
            this.Controls.Add(this.lbMostrarNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "BandejaEntrada";
            this.Text = "Intern E-Mail";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lMensajes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMostrarNombre;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtReceptor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
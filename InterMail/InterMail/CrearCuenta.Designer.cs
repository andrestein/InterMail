namespace InterMail
{
    partial class CrearCuenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.mtxtFecha = new System.Windows.Forms.MaskedTextBox();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario :";
            // 
            // txtNewUser
            // 
            this.txtNewUser.Location = new System.Drawing.Point(147, 34);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(319, 20);
            this.txtNewUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmar contraseña :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de nacimiento :";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(147, 87);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(319, 20);
            this.txtNewPass.TabIndex = 5;
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Location = new System.Drawing.Point(147, 145);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.Size = new System.Drawing.Size(319, 20);
            this.txtPassConfirm.TabIndex = 6;
            // 
            // mtxtFecha
            // 
            this.mtxtFecha.Location = new System.Drawing.Point(263, 198);
            this.mtxtFecha.Mask = "00/00/0000";
            this.mtxtFecha.Name = "mtxtFecha";
            this.mtxtFecha.Size = new System.Drawing.Size(100, 20);
            this.mtxtFecha.TabIndex = 7;
            this.mtxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Location = new System.Drawing.Point(184, 281);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(156, 23);
            this.btnCrearCuenta.TabIndex = 8;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 352);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.mtxtFecha);
            this.Controls.Add(this.txtPassConfirm);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewUser);
            this.Controls.Add(this.label1);
            this.Name = "CrearCuenta";
            this.Text = "Intern E-Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtPassConfirm;
        private System.Windows.Forms.MaskedTextBox mtxtFecha;
        private System.Windows.Forms.Button btnCrearCuenta;
    }
}
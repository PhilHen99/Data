namespace AlmacenamientoDeDatos
{
    partial class ArchivoTXT
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.rtbLectura = new System.Windows.Forms.RichTextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(34, 73);
            this.txtDato.Margin = new System.Windows.Forms.Padding(4);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(188, 158);
            this.txtDato.TabIndex = 0;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(51, 267);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(139, 36);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear y Carga";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // rtbLectura
            // 
            this.rtbLectura.Location = new System.Drawing.Point(263, 48);
            this.rtbLectura.Name = "rtbLectura";
            this.rtbLectura.Size = new System.Drawing.Size(412, 198);
            this.rtbLectura.TabIndex = 2;
            this.rtbLectura.Text = "";
            // 
            // btnLeer
            // 
            this.btnLeer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.Location = new System.Drawing.Point(322, 267);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(114, 36);
            this.btnLeer.TabIndex = 3;
            this.btnLeer.Text = "Leer archivo";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(500, 267);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(127, 36);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar archivo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(57, 48);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(130, 22);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Ingrese Datos";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(365, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Visualización del archivo";
            // 
            // ArchivoTXT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(698, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.rtbLectura);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtDato);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArchivoTXT";
            this.Text = "ArchivoTXT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.RichTextBox rtbLectura;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
    }
}
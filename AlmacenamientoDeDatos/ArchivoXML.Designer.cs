namespace AlmacenamientoDeDatos
{
    partial class ArchivoXML
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
            this.txtDatos1 = new System.Windows.Forms.TextBox();
            this.txtDatos2 = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.llb1 = new System.Windows.Forms.Label();
            this.dgdLectura = new System.Windows.Forms.DataGridView();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtDatos3 = new System.Windows.Forms.TextBox();
            this.txtDatos4 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgdLectura)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDatos1
            // 
            this.txtDatos1.Location = new System.Drawing.Point(35, 120);
            this.txtDatos1.Name = "txtDatos1";
            this.txtDatos1.Size = new System.Drawing.Size(47, 26);
            this.txtDatos1.TabIndex = 0;
            // 
            // txtDatos2
            // 
            this.txtDatos2.Location = new System.Drawing.Point(107, 120);
            this.txtDatos2.Name = "txtDatos2";
            this.txtDatos2.Size = new System.Drawing.Size(118, 26);
            this.txtDatos2.TabIndex = 1;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(55, 206);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(144, 38);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear y Cargar";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // llb1
            // 
            this.llb1.AutoSize = true;
            this.llb1.Location = new System.Drawing.Point(77, 35);
            this.llb1.Name = "llb1";
            this.llb1.Size = new System.Drawing.Size(105, 18);
            this.llb1.TabIndex = 3;
            this.llb1.Text = "Ingrese Datos";
            // 
            // dgdLectura
            // 
            this.dgdLectura.AllowUserToAddRows = false;
            this.dgdLectura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdLectura.Location = new System.Drawing.Point(257, 49);
            this.dgdLectura.Name = "dgdLectura";
            this.dgdLectura.Size = new System.Drawing.Size(244, 204);
            this.dgdLectura.TabIndex = 4;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(257, 276);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(120, 38);
            this.btnLeer.TabIndex = 5;
            this.btnLeer.Text = "Leer archivo";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(401, 276);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(120, 38);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar archivo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtDatos3
            // 
            this.txtDatos3.Location = new System.Drawing.Point(35, 152);
            this.txtDatos3.Name = "txtDatos3";
            this.txtDatos3.Size = new System.Drawing.Size(47, 26);
            this.txtDatos3.TabIndex = 7;
            // 
            // txtDatos4
            // 
            this.txtDatos4.Location = new System.Drawing.Point(107, 152);
            this.txtDatos4.Name = "txtDatos4";
            this.txtDatos4.Size = new System.Drawing.Size(118, 26);
            this.txtDatos4.TabIndex = 8;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(43, 81);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(23, 18);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "ID";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(136, 81);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(64, 18);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "Nombre";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(285, 18);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(179, 18);
            this.lbl4.TabIndex = 11;
            this.lbl4.Text = "Visualización del archivo";
            // 
            // ArchivoXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 351);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtDatos4);
            this.Controls.Add(this.txtDatos3);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.dgdLectura);
            this.Controls.Add(this.llb1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtDatos2);
            this.Controls.Add(this.txtDatos1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArchivoXML";
            this.Text = "ArchivoXML";
            ((System.ComponentModel.ISupportInitialize)(this.dgdLectura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatos1;
        private System.Windows.Forms.TextBox txtDatos2;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label llb1;
        private System.Windows.Forms.DataGridView dgdLectura;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtDatos3;
        private System.Windows.Forms.TextBox txtDatos4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
    }
}
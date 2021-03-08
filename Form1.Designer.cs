
namespace Laboratorio_2_repaso
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.txt_tarifa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dataGridView_vehiculos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_km = new System.Windows.Forms.Label();
            this.lbl_marca1 = new System.Windows.Forms.Label();
            this.lbl_km1 = new System.Windows.Forms.Label();
            this.btn_alquilar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_placa
            // 
            this.txt_placa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_placa.Location = new System.Drawing.Point(119, 36);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(100, 20);
            this.txt_placa.TabIndex = 0;
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(119, 62);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(100, 20);
            this.txt_marca.TabIndex = 1;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(119, 88);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(100, 20);
            this.txt_modelo.TabIndex = 2;
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(119, 114);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(100, 20);
            this.txt_color.TabIndex = 3;
            // 
            // txt_tarifa
            // 
            this.txt_tarifa.Location = new System.Drawing.Point(119, 140);
            this.txt_tarifa.Name = "txt_tarifa";
            this.txt_tarifa.Size = new System.Drawing.Size(100, 20);
            this.txt_tarifa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tarifa por km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ingreso de vehiculos";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(85, 166);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 11;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dataGridView_vehiculos
            // 
            this.dataGridView_vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_vehiculos.Location = new System.Drawing.Point(14, 229);
            this.dataGridView_vehiculos.Name = "dataGridView_vehiculos";
            this.dataGridView_vehiculos.Size = new System.Drawing.Size(553, 187);
            this.dataGridView_vehiculos.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vehiculos de Empresa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Vehiculo con mas km";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(345, 62);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(47, 13);
            this.lbl_marca.TabIndex = 15;
            this.lbl_marca.Text = "**********";
            // 
            // lbl_km
            // 
            this.lbl_km.AutoSize = true;
            this.lbl_km.Location = new System.Drawing.Point(345, 88);
            this.lbl_km.Name = "lbl_km";
            this.lbl_km.Size = new System.Drawing.Size(47, 13);
            this.lbl_km.TabIndex = 16;
            this.lbl_km.Text = "**********";
            // 
            // lbl_marca1
            // 
            this.lbl_marca1.AutoSize = true;
            this.lbl_marca1.Location = new System.Drawing.Point(302, 62);
            this.lbl_marca1.Name = "lbl_marca1";
            this.lbl_marca1.Size = new System.Drawing.Size(37, 13);
            this.lbl_marca1.TabIndex = 17;
            this.lbl_marca1.Text = "Marca";
            this.lbl_marca1.Click += new System.EventHandler(this.lbl_marca1_Click);
            // 
            // lbl_km1
            // 
            this.lbl_km1.AutoSize = true;
            this.lbl_km1.Location = new System.Drawing.Point(268, 88);
            this.lbl_km1.Name = "lbl_km1";
            this.lbl_km1.Size = new System.Drawing.Size(71, 13);
            this.lbl_km1.TabIndex = 18;
            this.lbl_km1.Text = "Km recorridos";
            // 
            // btn_alquilar
            // 
            this.btn_alquilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alquilar.Location = new System.Drawing.Point(459, 114);
            this.btn_alquilar.Name = "btn_alquilar";
            this.btn_alquilar.Size = new System.Drawing.Size(108, 62);
            this.btn_alquilar.TabIndex = 19;
            this.btn_alquilar.Text = "Alquilar";
            this.btn_alquilar.UseVisualStyleBackColor = true;
            this.btn_alquilar.Click += new System.EventHandler(this.btn_alquilar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 425);
            this.Controls.Add(this.btn_alquilar);
            this.Controls.Add(this.lbl_km1);
            this.Controls.Add(this.lbl_marca1);
            this.Controls.Add(this.lbl_km);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView_vehiculos);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tarifa);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.txt_placa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.TextBox txt_tarifa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dataGridView_vehiculos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_km;
        private System.Windows.Forms.Label lbl_marca1;
        private System.Windows.Forms.Label lbl_km1;
        private System.Windows.Forms.Button btn_alquilar;
    }
}


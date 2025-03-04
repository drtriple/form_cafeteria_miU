namespace mainCafeteriaMiU
{
    partial class frmCafeteriaMiU
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
            this.background1 = new System.Windows.Forms.PictureBox();
            this.texTitle1 = new System.Windows.Forms.TextBox();
            this.grpEntrance = new System.Windows.Forms.GroupBox();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkValor = new System.Windows.Forms.CheckedListBox();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.TextBox();
            this.lblCantidadNormal = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCantidadAdicional = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCantidadTotal = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblValorTotal = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).BeginInit();
            this.grpEntrance.SuspendLayout();
            this.grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // background1
            // 
            this.background1.BackColor = System.Drawing.Color.Black;
            this.background1.Location = new System.Drawing.Point(0, -1);
            this.background1.Name = "background1";
            this.background1.Size = new System.Drawing.Size(516, 57);
            this.background1.TabIndex = 0;
            this.background1.TabStop = false;
            // 
            // texTitle1
            // 
            this.texTitle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.texTitle1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texTitle1.Font = new System.Drawing.Font("Gelitte", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texTitle1.ForeColor = System.Drawing.Color.White;
            this.texTitle1.Location = new System.Drawing.Point(105, 13);
            this.texTitle1.Name = "texTitle1";
            this.texTitle1.Size = new System.Drawing.Size(293, 41);
            this.texTitle1.TabIndex = 1;
            this.texTitle1.Text = "Cafetería Mi U";
            this.texTitle1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpEntrance
            // 
            this.grpEntrance.Controls.Add(this.btnSalir);
            this.grpEntrance.Controls.Add(this.btnLimpiar);
            this.grpEntrance.Controls.Add(this.btnCalcular);
            this.grpEntrance.Controls.Add(this.chkValor);
            this.grpEntrance.Controls.Add(this.textBox1);
            this.grpEntrance.Controls.Add(this.cmbDia);
            this.grpEntrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEntrance.ForeColor = System.Drawing.Color.Black;
            this.grpEntrance.Location = new System.Drawing.Point(12, 76);
            this.grpEntrance.Name = "grpEntrance";
            this.grpEntrance.Size = new System.Drawing.Size(490, 144);
            this.grpEntrance.TabIndex = 2;
            this.grpEntrance.TabStop = false;
            this.grpEntrance.Text = "Ingrese los siguientes valores:";
            // 
            // cmbDia
            // 
            this.cmbDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(167, 38);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(174, 26);
            this.cmbDia.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 17);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Día de la Semana:";
            // 
            // chkValor
            // 
            this.chkValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkValor.FormattingEnabled = true;
            this.chkValor.Items.AddRange(new object[] {
            "Quincena",
            "Festivo"});
            this.chkValor.Location = new System.Drawing.Point(362, 32);
            this.chkValor.MultiColumn = true;
            this.chkValor.Name = "chkValor";
            this.chkValor.Size = new System.Drawing.Size(122, 42);
            this.chkValor.TabIndex = 2;
            // 
            // grpResultados
            // 
            this.grpResultados.Controls.Add(this.lblValorTotal);
            this.grpResultados.Controls.Add(this.textBox7);
            this.grpResultados.Controls.Add(this.pictureBox5);
            this.grpResultados.Controls.Add(this.lblCantidadTotal);
            this.grpResultados.Controls.Add(this.textBox6);
            this.grpResultados.Controls.Add(this.pictureBox4);
            this.grpResultados.Controls.Add(this.lblCantidadAdicional);
            this.grpResultados.Controls.Add(this.textBox5);
            this.grpResultados.Controls.Add(this.pictureBox3);
            this.grpResultados.Controls.Add(this.lblCantidadNormal);
            this.grpResultados.Controls.Add(this.textBox4);
            this.grpResultados.Controls.Add(this.pictureBox2);
            this.grpResultados.Controls.Add(this.lblValorUnitario);
            this.grpResultados.Controls.Add(this.textBox2);
            this.grpResultados.Controls.Add(this.pictureBox1);
            this.grpResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResultados.ForeColor = System.Drawing.Color.Black;
            this.grpResultados.Location = new System.Drawing.Point(50, 247);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new System.Drawing.Size(410, 254);
            this.grpResultados.TabIndex = 3;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(19, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 32);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(32, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 17);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Valor Unitario/Lb:";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorUnitario.Location = new System.Drawing.Point(19, 59);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.ReadOnly = true;
            this.lblValorUnitario.Size = new System.Drawing.Size(189, 26);
            this.lblValorUnitario.TabIndex = 6;
            // 
            // lblCantidadNormal
            // 
            this.lblCantidadNormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCantidadNormal.Location = new System.Drawing.Point(218, 59);
            this.lblCantidadNormal.Name = "lblCantidadNormal";
            this.lblCantidadNormal.ReadOnly = true;
            this.lblCantidadNormal.Size = new System.Drawing.Size(172, 26);
            this.lblCantidadNormal.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(226, 36);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 17);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Cantidad Normal Lb:";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(218, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 32);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(10, 92);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(156, 38);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(170, 92);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(156, 38);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(328, 92);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(156, 38);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCantidadAdicional
            // 
            this.lblCantidadAdicional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCantidadAdicional.Location = new System.Drawing.Point(30, 133);
            this.lblCantidadAdicional.Name = "lblCantidadAdicional";
            this.lblCantidadAdicional.ReadOnly = true;
            this.lblCantidadAdicional.Size = new System.Drawing.Size(174, 26);
            this.lblCantidadAdicional.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(40, 110);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(164, 17);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Cantidad Adicional:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(30, 103);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(174, 32);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // lblCantidadTotal
            // 
            this.lblCantidadTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCantidadTotal.Location = new System.Drawing.Point(217, 133);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.ReadOnly = true;
            this.lblCantidadTotal.Size = new System.Drawing.Size(156, 26);
            this.lblCantidadTotal.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Black;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(226, 110);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(147, 17);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "Cantidad Total Lb:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(217, 103);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(156, 32);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorTotal.Location = new System.Drawing.Point(88, 204);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.ReadOnly = true;
            this.lblValorTotal.Size = new System.Drawing.Size(215, 26);
            this.lblValorTotal.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Black;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(96, 181);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(207, 19);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "Valor Total A Pagar:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(88, 174);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(215, 32);
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.Location = new System.Drawing.Point(0, 526);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(516, 79);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(69, 538);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(380, 49);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Calculadora de la cantidad de jamón normal, adicional y total que debe comprar la" +
    " cafetería para un día determinado, junto con el valor total a pagar al proveedo" +
    "r.";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // frmCafeteriaMiU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 599);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.grpEntrance);
            this.Controls.Add(this.texTitle1);
            this.Controls.Add(this.background1);
            this.Name = "frmCafeteriaMiU";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCafeteriaMiU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background1)).EndInit();
            this.grpEntrance.ResumeLayout(false);
            this.grpEntrance.PerformLayout();
            this.grpResultados.ResumeLayout(false);
            this.grpResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background1;
        private System.Windows.Forms.TextBox texTitle1;
        private System.Windows.Forms.GroupBox grpEntrance;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.CheckedListBox chkValor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.TextBox lblValorUnitario;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lblCantidadNormal;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox lblValorTotal;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox lblCantidadTotal;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox lblCantidadAdicional;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox textBox3;
    }
}


namespace banco
{
    partial class Cuentas
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
            this.LblTittulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblIdCliente = new System.Windows.Forms.Label();
            this.CmbCiudad = new System.Windows.Forms.ComboBox();
            this.TxtNomApe = new System.Windows.Forms.TextBox();
            this.id_cliente = new System.Windows.Forms.TextBox();
            this.TxtNumCuent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbTipCuent = new System.Windows.Forms.ComboBox();
            this.BtnCli = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LBConsig = new System.Windows.Forms.Label();
            this.TxtRet = new System.Windows.Forms.TextBox();
            this.TxtConsig = new System.Windows.Forms.TextBox();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.BntMovi = new System.Windows.Forms.Button();
            this.BtnConsulCli = new System.Windows.Forms.Button();
            this.TextLoadName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.LblInfo = new System.Windows.Forms.Label();
            this.Inf_Cargo = new System.Windows.Forms.Label();
            this.Txt_Inf_Carg = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTittulo
            // 
            this.LblTittulo.AutoSize = true;
            this.LblTittulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTittulo.Location = new System.Drawing.Point(424, 9);
            this.LblTittulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTittulo.Name = "LblTittulo";
            this.LblTittulo.Size = new System.Drawing.Size(288, 31);
            this.LblTittulo.TabIndex = 0;
            this.LblTittulo.Text = "Informacion de Cargos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblIdCliente);
            this.groupBox1.Controls.Add(this.CmbCiudad);
            this.groupBox1.Controls.Add(this.TxtNomApe);
            this.groupBox1.Controls.Add(this.id_cliente);
            this.groupBox1.Controls.Add(this.TxtNumCuent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CmbTipCuent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(397, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion General Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cuidad del Cargo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripcion Cargo ";
            // 
            // LblIdCliente
            // 
            this.LblIdCliente.AutoSize = true;
            this.LblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdCliente.Location = new System.Drawing.Point(8, 23);
            this.LblIdCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdCliente.Name = "LblIdCliente";
            this.LblIdCliente.Size = new System.Drawing.Size(121, 17);
            this.LblIdCliente.TabIndex = 3;
            this.LblIdCliente.Text = "Codigo del Cargo ";
            this.LblIdCliente.Click += new System.EventHandler(this.LblIdCliente_Click);
            // 
            // CmbCiudad
            // 
            this.CmbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCiudad.FormattingEnabled = true;
            this.CmbCiudad.Items.AddRange(new object[] {
            "BOGOTA",
            "CALI",
            "MEDELLIN",
            "BARRANQUILLA",
            "SANTA MARTA",
            "CARTAGENA",
            "BUCARAMANGA",
            "PASTO",
            "CUCUTA "});
            this.CmbCiudad.Location = new System.Drawing.Point(8, 145);
            this.CmbCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.CmbCiudad.Name = "CmbCiudad";
            this.CmbCiudad.Size = new System.Drawing.Size(360, 26);
            this.CmbCiudad.TabIndex = 2;
            // 
            // TxtNomApe
            // 
            this.TxtNomApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomApe.Location = new System.Drawing.Point(8, 92);
            this.TxtNomApe.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNomApe.Name = "TxtNomApe";
            this.TxtNomApe.Size = new System.Drawing.Size(360, 24);
            this.TxtNomApe.TabIndex = 1;
            // 
            // id_cliente
            // 
            this.id_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_cliente.Location = new System.Drawing.Point(8, 44);
            this.id_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.Size = new System.Drawing.Size(289, 24);
            this.id_cliente.TabIndex = 0;
            this.id_cliente.TextChanged += new System.EventHandler(this.id_cliente_TextChanged);
            this.id_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_cliente_KeyPress);
            // 
            // TxtNumCuent
            // 
            this.TxtNumCuent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumCuent.Location = new System.Drawing.Point(8, 272);
            this.TxtNumCuent.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumCuent.Name = "TxtNumCuent";
            this.TxtNumCuent.Size = new System.Drawing.Size(160, 24);
            this.TxtNumCuent.TabIndex = 3;
            this.TxtNumCuent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumCuent_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de Cargo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero Plazas Ocupadas";
            // 
            // CmbTipCuent
            // 
            this.CmbTipCuent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipCuent.FormattingEnabled = true;
            this.CmbTipCuent.Items.AddRange(new object[] {
            "ADMINISTRATIVO",
            "OPERATIVO",
            "ESTRATEGICO",
            "GERENCIAL"});
            this.CmbTipCuent.Location = new System.Drawing.Point(8, 208);
            this.CmbTipCuent.Margin = new System.Windows.Forms.Padding(4);
            this.CmbTipCuent.Name = "CmbTipCuent";
            this.CmbTipCuent.Size = new System.Drawing.Size(160, 26);
            this.CmbTipCuent.TabIndex = 1;
            // 
            // BtnCli
            // 
            this.BtnCli.BackColor = System.Drawing.Color.Silver;
            this.BtnCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCli.Location = new System.Drawing.Point(51, 388);
            this.BtnCli.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCli.Name = "BtnCli";
            this.BtnCli.Size = new System.Drawing.Size(160, 28);
            this.BtnCli.TabIndex = 6;
            this.BtnCli.Text = "Registrar Cargo";
            this.BtnCli.UseVisualStyleBackColor = false;
            this.BtnCli.Click += new System.EventHandler(this.BtnCli_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.Txt_Inf_Carg);
            this.groupBox2.Controls.Add(this.Inf_Cargo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.LBConsig);
            this.groupBox2.Controls.Add(this.TxtRet);
            this.groupBox2.Controls.Add(this.TxtConsig);
            this.groupBox2.Controls.Add(this.LblSaldo);
            this.groupBox2.Controls.Add(this.TxtSaldo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(464, 57);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(577, 309);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Actividades";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Restar Presupuesto";
            // 
            // LBConsig
            // 
            this.LBConsig.AutoSize = true;
            this.LBConsig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBConsig.Location = new System.Drawing.Point(198, 23);
            this.LBConsig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBConsig.Name = "LBConsig";
            this.LBConsig.Size = new System.Drawing.Size(151, 17);
            this.LBConsig.TabIndex = 8;
            this.LBConsig.Text = "Adicionar Presupuesto";
            // 
            // TxtRet
            // 
            this.TxtRet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRet.Location = new System.Drawing.Point(392, 44);
            this.TxtRet.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRet.Name = "TxtRet";
            this.TxtRet.Size = new System.Drawing.Size(142, 24);
            this.TxtRet.TabIndex = 7;
            this.TxtRet.Text = "0";
            this.TxtRet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRet_KeyPress);
            // 
            // TxtConsig
            // 
            this.TxtConsig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConsig.Location = new System.Drawing.Point(201, 44);
            this.TxtConsig.Margin = new System.Windows.Forms.Padding(4);
            this.TxtConsig.Name = "TxtConsig";
            this.TxtConsig.Size = new System.Drawing.Size(148, 24);
            this.TxtConsig.TabIndex = 6;
            this.TxtConsig.Text = "0";
            this.TxtConsig.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConsig_KeyPress);
            // 
            // LblSaldo
            // 
            this.LblSaldo.AutoSize = true;
            this.LblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldo.Location = new System.Drawing.Point(9, 23);
            this.LblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(130, 17);
            this.LblSaldo.TabIndex = 5;
            this.LblSaldo.Text = "Presupuesto Cargo";
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Enabled = false;
            this.TxtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSaldo.Location = new System.Drawing.Point(15, 44);
            this.TxtSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(139, 24);
            this.TxtSaldo.TabIndex = 4;
            this.TxtSaldo.Text = "0";
            this.TxtSaldo.TextChanged += new System.EventHandler(this.TxtSaldo_TextChanged);
            // 
            // BntMovi
            // 
            this.BntMovi.BackColor = System.Drawing.Color.Silver;
            this.BntMovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntMovi.Location = new System.Drawing.Point(528, 388);
            this.BntMovi.Margin = new System.Windows.Forms.Padding(4);
            this.BntMovi.Name = "BntMovi";
            this.BntMovi.Size = new System.Drawing.Size(175, 28);
            this.BntMovi.TabIndex = 10;
            this.BntMovi.Text = "Modificar Presupuesto";
            this.BntMovi.UseVisualStyleBackColor = false;
            this.BntMovi.Click += new System.EventHandler(this.BntMovi_Click);
            // 
            // BtnConsulCli
            // 
            this.BtnConsulCli.Location = new System.Drawing.Point(51, 423);
            this.BtnConsulCli.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConsulCli.Name = "BtnConsulCli";
            this.BtnConsulCli.Size = new System.Drawing.Size(160, 30);
            this.BtnConsulCli.TabIndex = 3;
            this.BtnConsulCli.Text = "Consultar Cargo";
            this.BtnConsulCli.UseVisualStyleBackColor = true;
            this.BtnConsulCli.Click += new System.EventHandler(this.BtnConsulCli_Click);
            // 
            // TextLoadName
            // 
            this.TextLoadName.Location = new System.Drawing.Point(219, 423);
            this.TextLoadName.Margin = new System.Windows.Forms.Padding(4);
            this.TextLoadName.Name = "TextLoadName";
            this.TextLoadName.Size = new System.Drawing.Size(291, 22);
            this.TextLoadName.TabIndex = 4;
            this.TextLoadName.TextChanged += new System.EventHandler(this.TextLoadName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 457);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(469, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Coloque el codigo del cargo+.Xml ejemplo 123.Xml";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(51, 492);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir de la Aplicacion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Silver;
            this.BtnGuardar.Location = new System.Drawing.Point(729, 388);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(177, 28);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar Cambios";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Location = new System.Drawing.Point(648, 421);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 34);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Limpiar Forma";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblInfo.Location = new System.Drawing.Point(812, 443);
            this.LblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(255, 102);
            this.LblInfo.TabIndex = 13;
            this.LblInfo.Text = "Instruccciones Basicas\r\n\r\n1. Registrar Cargo\r\n2. Guardar movimiento \r\n3. Guardar " +
    "Cambios\r\n4. Consultar cliente y Guardar Cambios";
            this.LblInfo.Click += new System.EventHandler(this.LblInfo_Click);
            // 
            // Inf_Cargo
            // 
            this.Inf_Cargo.AutoSize = true;
            this.Inf_Cargo.Location = new System.Drawing.Point(11, 92);
            this.Inf_Cargo.Name = "Inf_Cargo";
            this.Inf_Cargo.Size = new System.Drawing.Size(216, 25);
            this.Inf_Cargo.TabIndex = 10;
            this.Inf_Cargo.Text = "Informacion De Cargo";
            // 
            // Txt_Inf_Carg
            // 
            this.Txt_Inf_Carg.Location = new System.Drawing.Point(15, 124);
            this.Txt_Inf_Carg.Name = "Txt_Inf_Carg";
            this.Txt_Inf_Carg.Size = new System.Drawing.Size(537, 144);
            this.Txt_Inf_Carg.TabIndex = 11;
            this.Txt_Inf_Carg.Text = "";
            // 
            // Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 550);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BntMovi);
            this.Controls.Add(this.BtnCli);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextLoadName);
            this.Controls.Add(this.BtnConsulCli);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblTittulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cuentas";
            this.Text = "Aplicacion de Cargos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTittulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblIdCliente;
        private System.Windows.Forms.ComboBox CmbCiudad;
        private System.Windows.Forms.TextBox TxtNomApe;
        private System.Windows.Forms.TextBox id_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbTipCuent;
        private System.Windows.Forms.TextBox TxtNumCuent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.Button BtnCli;
        private System.Windows.Forms.Button BntMovi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBConsig;
        private System.Windows.Forms.TextBox TxtRet;
        private System.Windows.Forms.TextBox TxtConsig;
        private System.Windows.Forms.Label LblSaldo;
        private System.Windows.Forms.Button BtnConsulCli;
        private System.Windows.Forms.TextBox TextLoadName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.RichTextBox Txt_Inf_Carg;
        private System.Windows.Forms.Label Inf_Cargo;
    }
}


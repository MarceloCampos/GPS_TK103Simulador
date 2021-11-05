namespace GPS_TK103Simulador
{
    partial class frmGPS_TK103Simulador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGPS_TK103Simulador));
            this.lblUTCTime = new System.Windows.Forms.Label();
            this.chkIgnit = new System.Windows.Forms.CheckBox();
            this.radBtnIgnitOn = new System.Windows.Forms.RadioButton();
            this.radBtnIgnitOff = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtSentenca = new System.Windows.Forms.TextBox();
            this.chkPosValida = new System.Windows.Forms.CheckBox();
            this.chkIntervalo = new System.Windows.Forms.CheckBox();
            this.numUpDwIntervalo = new System.Windows.Forms.NumericUpDown();
            this.pctBoxEnvio = new System.Windows.Forms.PictureBox();
            this.txtEmei = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLng = new System.Windows.Forms.TextBox();
            this.txtIp1 = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.tmrEnvioLoop = new System.Windows.Forms.Timer(this.components);
            this.txtIp2 = new System.Windows.Forms.TextBox();
            this.chkIp1 = new System.Windows.Forms.RadioButton();
            this.chkIp2 = new System.Windows.Forms.RadioButton();
            this.tmrPisca = new System.Windows.Forms.Timer(this.components);
            this.pnlPisca = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkRfid = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDMotorista = new System.Windows.Forms.TextBox();
            this.txtIdConsole = new System.Windows.Forms.TextBox();
            this.chkEnviaConsole = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAvisochkIgnit = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.chkBoxEnviaStatus = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwIntervalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxEnvio)).BeginInit();
            this.pnlPisca.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUTCTime
            // 
            this.lblUTCTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUTCTime.Enabled = false;
            this.lblUTCTime.Location = new System.Drawing.Point(334, 265);
            this.lblUTCTime.Name = "lblUTCTime";
            this.lblUTCTime.Size = new System.Drawing.Size(95, 23);
            this.lblUTCTime.TabIndex = 0;
            this.lblUTCTime.Text = "00:00:00";
            this.lblUTCTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkIgnit
            // 
            this.chkIgnit.AutoSize = true;
            this.chkIgnit.Location = new System.Drawing.Point(12, 14);
            this.chkIgnit.Name = "chkIgnit";
            this.chkIgnit.Size = new System.Drawing.Size(94, 17);
            this.chkIgnit.TabIndex = 3;
            this.chkIgnit.Text = "Enviar Ignição";
            this.chkIgnit.UseVisualStyleBackColor = true;
            this.chkIgnit.CheckedChanged += new System.EventHandler(this.chkIgnit_CheckedChanged);
            // 
            // radBtnIgnitOn
            // 
            this.radBtnIgnitOn.AutoSize = true;
            this.radBtnIgnitOn.Checked = true;
            this.radBtnIgnitOn.Location = new System.Drawing.Point(12, 37);
            this.radBtnIgnitOn.Name = "radBtnIgnitOn";
            this.radBtnIgnitOn.Size = new System.Drawing.Size(57, 17);
            this.radBtnIgnitOn.TabIndex = 4;
            this.radBtnIgnitOn.TabStop = true;
            this.radBtnIgnitOn.Text = "Ligada";
            this.radBtnIgnitOn.UseVisualStyleBackColor = true;
            this.radBtnIgnitOn.CheckedChanged += new System.EventHandler(this.radBtnIgnitOn_CheckedChanged);
            // 
            // radBtnIgnitOff
            // 
            this.radBtnIgnitOff.AutoSize = true;
            this.radBtnIgnitOff.Location = new System.Drawing.Point(75, 37);
            this.radBtnIgnitOff.Name = "radBtnIgnitOff";
            this.radBtnIgnitOff.Size = new System.Drawing.Size(72, 17);
            this.radBtnIgnitOff.TabIndex = 5;
            this.radBtnIgnitOff.Text = "Desligada";
            this.radBtnIgnitOff.UseVisualStyleBackColor = true;
            this.radBtnIgnitOff.CheckedChanged += new System.EventHandler(this.radBtnIgnitOff_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBtnIgnitOn);
            this.groupBox1.Controls.Add(this.radBtnIgnitOff);
            this.groupBox1.Controls.Add(this.chkIgnit);
            this.groupBox1.Location = new System.Drawing.Point(259, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 60);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(468, 264);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 25);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtSentenca
            // 
            this.txtSentenca.BackColor = System.Drawing.SystemColors.Control;
            this.txtSentenca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSentenca.Location = new System.Drawing.Point(12, 294);
            this.txtSentenca.Name = "txtSentenca";
            this.txtSentenca.Size = new System.Drawing.Size(531, 20);
            this.txtSentenca.TabIndex = 8;
            // 
            // chkPosValida
            // 
            this.chkPosValida.AutoSize = true;
            this.chkPosValida.Checked = true;
            this.chkPosValida.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPosValida.Location = new System.Drawing.Point(189, 268);
            this.chkPosValida.Name = "chkPosValida";
            this.chkPosValida.Size = new System.Drawing.Size(96, 17);
            this.chkPosValida.TabIndex = 9;
            this.chkPosValida.Text = "Posição Válida";
            this.chkPosValida.UseVisualStyleBackColor = true;
            // 
            // chkIntervalo
            // 
            this.chkIntervalo.AutoSize = true;
            this.chkIntervalo.Location = new System.Drawing.Point(48, 268);
            this.chkIntervalo.Name = "chkIntervalo";
            this.chkIntervalo.Size = new System.Drawing.Size(84, 17);
            this.chkIntervalo.TabIndex = 14;
            this.chkIntervalo.Text = "Intervalo(s): ";
            this.chkIntervalo.UseVisualStyleBackColor = true;
            // 
            // numUpDwIntervalo
            // 
            this.numUpDwIntervalo.BackColor = System.Drawing.SystemColors.Control;
            this.numUpDwIntervalo.Location = new System.Drawing.Point(124, 267);
            this.numUpDwIntervalo.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numUpDwIntervalo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDwIntervalo.Name = "numUpDwIntervalo";
            this.numUpDwIntervalo.Size = new System.Drawing.Size(39, 20);
            this.numUpDwIntervalo.TabIndex = 15;
            this.numUpDwIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDwIntervalo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // pctBoxEnvio
            // 
            this.pctBoxEnvio.Location = new System.Drawing.Point(15, 12);
            this.pctBoxEnvio.Name = "pctBoxEnvio";
            this.pctBoxEnvio.Size = new System.Drawing.Size(47, 46);
            this.pctBoxEnvio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxEnvio.TabIndex = 16;
            this.pctBoxEnvio.TabStop = false;
            this.pctBoxEnvio.Visible = false;
            // 
            // txtEmei
            // 
            this.txtEmei.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmei.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmei.Location = new System.Drawing.Point(48, 57);
            this.txtEmei.Name = "txtEmei";
            this.txtEmei.Size = new System.Drawing.Size(153, 22);
            this.txtEmei.TabIndex = 18;
            this.txtEmei.Text = "865067020906883";
            this.txtEmei.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmei.TextChanged += new System.EventHandler(this.txtEmei_TextChanged);
            // 
            // txtLat
            // 
            this.txtLat.BackColor = System.Drawing.SystemColors.Control;
            this.txtLat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLat.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLat.Location = new System.Drawing.Point(48, 92);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(153, 22);
            this.txtLat.TabIndex = 19;
            this.txtLat.Text = "2334.5881";
            this.txtLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLat.TextChanged += new System.EventHandler(this.txtLat_TextChanged);
            // 
            // txtLng
            // 
            this.txtLng.BackColor = System.Drawing.SystemColors.Control;
            this.txtLng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLng.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLng.Location = new System.Drawing.Point(48, 127);
            this.txtLng.Name = "txtLng";
            this.txtLng.Size = new System.Drawing.Size(153, 22);
            this.txtLng.TabIndex = 20;
            this.txtLng.Text = "04637.5122";
            this.txtLng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLng.TextChanged += new System.EventHandler(this.txtLng_TextChanged);
            // 
            // txtIp1
            // 
            this.txtIp1.BackColor = System.Drawing.SystemColors.Control;
            this.txtIp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIp1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIp1.Location = new System.Drawing.Point(71, 200);
            this.txtIp1.Name = "txtIp1";
            this.txtIp1.Size = new System.Drawing.Size(92, 22);
            this.txtIp1.TabIndex = 21;
            this.txtIp1.Text = "192.168.0.144";
            this.txtIp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.SystemColors.Control;
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(169, 200);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(32, 22);
            this.txtPort.TabIndex = 22;
            this.txtPort.Text = "5001";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrEnvioLoop
            // 
            this.tmrEnvioLoop.Interval = 1000;
            this.tmrEnvioLoop.Tick += new System.EventHandler(this.tmrEnvioLoop_Tick);
            // 
            // txtIp2
            // 
            this.txtIp2.BackColor = System.Drawing.SystemColors.Control;
            this.txtIp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIp2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIp2.Location = new System.Drawing.Point(71, 228);
            this.txtIp2.Name = "txtIp2";
            this.txtIp2.Size = new System.Drawing.Size(130, 22);
            this.txtIp2.TabIndex = 23;
            this.txtIp2.Text = "marcelocampos.ddns.net";
            this.txtIp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkIp1
            // 
            this.chkIp1.AutoSize = true;
            this.chkIp1.Location = new System.Drawing.Point(48, 204);
            this.chkIp1.Name = "chkIp1";
            this.chkIp1.Size = new System.Drawing.Size(14, 13);
            this.chkIp1.TabIndex = 24;
            this.chkIp1.UseVisualStyleBackColor = true;
            // 
            // chkIp2
            // 
            this.chkIp2.AutoSize = true;
            this.chkIp2.Checked = true;
            this.chkIp2.Location = new System.Drawing.Point(48, 232);
            this.chkIp2.Name = "chkIp2";
            this.chkIp2.Size = new System.Drawing.Size(14, 13);
            this.chkIp2.TabIndex = 25;
            this.chkIp2.TabStop = true;
            this.chkIp2.UseVisualStyleBackColor = true;
            // 
            // tmrPisca
            // 
            this.tmrPisca.Interval = 250;
            this.tmrPisca.Tick += new System.EventHandler(this.tmrPisca_Tick);
            // 
            // pnlPisca
            // 
            this.pnlPisca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPisca.Controls.Add(this.pctBoxEnvio);
            this.pnlPisca.Location = new System.Drawing.Point(481, 8);
            this.pnlPisca.Name = "pnlPisca";
            this.pnlPisca.Size = new System.Drawing.Size(73, 71);
            this.pnlPisca.TabIndex = 26;
            this.pnlPisca.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "EMEI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Lat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Lng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(303, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "UTC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(20, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "IP 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(19, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "IP 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(200, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Porta";
            // 
            // chkRfid
            // 
            this.chkRfid.AutoSize = true;
            this.chkRfid.Location = new System.Drawing.Point(270, 122);
            this.chkRfid.Name = "chkRfid";
            this.chkRfid.Size = new System.Drawing.Size(116, 17);
            this.chkRfid.TabIndex = 34;
            this.chkRfid.Text = "Enviar ID Motorista";
            this.chkRfid.UseVisualStyleBackColor = true;
            this.chkRfid.CheckedChanged += new System.EventHandler(this.chkRfid_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(259, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 36;
            // 
            // txtIDMotorista
            // 
            this.txtIDMotorista.BackColor = System.Drawing.SystemColors.Control;
            this.txtIDMotorista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDMotorista.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMotorista.Location = new System.Drawing.Point(378, 119);
            this.txtIDMotorista.Name = "txtIDMotorista";
            this.txtIDMotorista.Size = new System.Drawing.Size(97, 22);
            this.txtIDMotorista.TabIndex = 35;
            this.txtIDMotorista.Text = "16180339887";
            this.txtIDMotorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdConsole
            // 
            this.txtIdConsole.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdConsole.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdConsole.Location = new System.Drawing.Point(378, 147);
            this.txtIdConsole.Name = "txtIdConsole";
            this.txtIdConsole.Size = new System.Drawing.Size(97, 22);
            this.txtIdConsole.TabIndex = 38;
            this.txtIdConsole.Text = "9004700";
            this.txtIdConsole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdConsole.Visible = false;
            // 
            // chkEnviaConsole
            // 
            this.chkEnviaConsole.AutoSize = true;
            this.chkEnviaConsole.Location = new System.Drawing.Point(270, 150);
            this.chkEnviaConsole.Name = "chkEnviaConsole";
            this.chkEnviaConsole.Size = new System.Drawing.Size(111, 17);
            this.chkEnviaConsole.TabIndex = 37;
            this.chkEnviaConsole.Text = "Enviar ID Console";
            this.chkEnviaConsole.UseVisualStyleBackColor = true;
            this.chkEnviaConsole.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAvisochkIgnit);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.chkBoxEnviaStatus);
            this.groupBox2.Location = new System.Drawing.Point(258, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 60);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // lblAvisochkIgnit
            // 
            this.lblAvisochkIgnit.AutoSize = true;
            this.lblAvisochkIgnit.ForeColor = System.Drawing.Color.Red;
            this.lblAvisochkIgnit.Location = new System.Drawing.Point(108, 15);
            this.lblAvisochkIgnit.Name = "lblAvisochkIgnit";
            this.lblAvisochkIgnit.Size = new System.Drawing.Size(136, 13);
            this.lblAvisochkIgnit.TabIndex = 28;
            this.lblAvisochkIgnit.Text = "Enviar Ignição Desabilitado";
            this.lblAvisochkIgnit.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(197, 37);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 17);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.Text = "Fad. 3";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(136, 37);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.Text = "Fad. 2";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "help me";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(75, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Fad. 1";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // chkBoxEnviaStatus
            // 
            this.chkBoxEnviaStatus.AutoSize = true;
            this.chkBoxEnviaStatus.Location = new System.Drawing.Point(13, 14);
            this.chkBoxEnviaStatus.Name = "chkBoxEnviaStatus";
            this.chkBoxEnviaStatus.Size = new System.Drawing.Size(89, 17);
            this.chkBoxEnviaStatus.TabIndex = 3;
            this.chkBoxEnviaStatus.Text = "Enviar Status";
            this.chkBoxEnviaStatus.UseVisualStyleBackColor = true;
            this.chkBoxEnviaStatus.CheckedChanged += new System.EventHandler(this.chkBoxEnviaStatus_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(21, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Vel";
            // 
            // txtVel
            // 
            this.txtVel.BackColor = System.Drawing.SystemColors.Control;
            this.txtVel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVel.Location = new System.Drawing.Point(48, 162);
            this.txtVel.Name = "txtVel";
            this.txtVel.Size = new System.Drawing.Size(73, 22);
            this.txtVel.TabIndex = 40;
            this.txtVel.Text = "10.00";
            this.txtVel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVel.Leave += new System.EventHandler(this.txtVel_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(121, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Km/h";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(121, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(328, 33);
            this.label11.TabIndex = 43;
            this.label11.Text = "GPS TK103 Simulador";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(343, 42);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 13);
            this.linkLabel1.TabIndex = 44;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "marcelocampos.cc";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "by: ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label13.Location = new System.Drawing.Point(20, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Server:";
            // 
            // frmGPS_TK103Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 333);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtIdConsole);
            this.Controls.Add(this.chkEnviaConsole);
            this.Controls.Add(this.txtIDMotorista);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkRfid);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlPisca);
            this.Controls.Add(this.chkIp2);
            this.Controls.Add(this.chkIp1);
            this.Controls.Add(this.txtIp2);
            this.Controls.Add(this.txtIp1);
            this.Controls.Add(this.txtLng);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.txtEmei);
            this.Controls.Add(this.numUpDwIntervalo);
            this.Controls.Add(this.chkIntervalo);
            this.Controls.Add(this.chkPosValida);
            this.Controls.Add(this.txtSentenca);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUTCTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGPS_TK103Simulador";
            this.Text = "GPS_TK103Simulador";
            this.Load += new System.EventHandler(this.frmGPS_TK103Simulador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwIntervalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxEnvio)).EndInit();
            this.pnlPisca.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUTCTime;
        private System.Windows.Forms.CheckBox chkIgnit;
        private System.Windows.Forms.RadioButton radBtnIgnitOn;
        private System.Windows.Forms.RadioButton radBtnIgnitOff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtSentenca;
        private System.Windows.Forms.CheckBox chkPosValida;
        private System.Windows.Forms.CheckBox chkIntervalo;
        private System.Windows.Forms.NumericUpDown numUpDwIntervalo;
        private System.Windows.Forms.PictureBox pctBoxEnvio;
        private System.Windows.Forms.TextBox txtEmei;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLng;
        private System.Windows.Forms.TextBox txtIp1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Timer tmrEnvioLoop;
        private System.Windows.Forms.TextBox txtIp2;
        private System.Windows.Forms.RadioButton chkIp1;
        private System.Windows.Forms.RadioButton chkIp2;
        private System.Windows.Forms.Timer tmrPisca;
        private System.Windows.Forms.Panel pnlPisca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkRfid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDMotorista;
        private System.Windows.Forms.TextBox txtIdConsole;
        private System.Windows.Forms.CheckBox chkEnviaConsole;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox chkBoxEnviaStatus;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label lblAvisochkIgnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}


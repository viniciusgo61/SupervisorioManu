
namespace SupervisorioDeManutençao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnlMsg = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDes = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.cbcBoxParity = new System.Windows.Forms.ComboBox();
            this.lblPar = new System.Windows.Forms.Label();
            this.cbcBoxStop = new System.Windows.Forms.ComboBox();
            this.lblStop = new System.Windows.Forms.Label();
            this.cbcBoxData = new System.Windows.Forms.ComboBox();
            this.lblBau = new System.Windows.Forms.Label();
            this.cbcBoxBaud = new System.Windows.Forms.ComboBox();
            this.lblBaud = new System.Windows.Forms.Label();
            this.cbBoxPort = new System.Windows.Forms.ComboBox();
            this.lblport = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRec = new System.Windows.Forms.TextBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBoxEnviar = new System.Windows.Forms.CheckBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.BarPWM = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLed2 = new System.Windows.Forms.Panel();
            this.lblLed2 = new System.Windows.Forms.Label();
            this.btnBotao2 = new System.Windows.Forms.Button();
            this.btnBotao1 = new System.Windows.Forms.Button();
            this.pnlLed1 = new System.Windows.Forms.Panel();
            this.lblLed1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pgBar3 = new System.Windows.Forms.ProgressBar();
            this.pgBar2 = new System.Windows.Forms.ProgressBar();
            this.pg1Bar1 = new System.Windows.Forms.ProgressBar();
            this.lblSensor3 = new System.Windows.Forms.Label();
            this.lblSensor2 = new System.Windows.Forms.Label();
            this.lblSensor1 = new System.Windows.Forms.Label();
            this.lblS3 = new System.Windows.Forms.Label();
            this.lblS2 = new System.Windows.Forms.Label();
            this.lblS1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnl1.SuspendLayout();
            this.pnlMsg.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarPWM)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLed2.SuspendLayout();
            this.pnlLed1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl1.Controls.Add(this.pnlMsg);
            this.pnl1.Controls.Add(this.btnExit);
            this.pnl1.Controls.Add(this.btnDes);
            this.pnl1.Controls.Add(this.btnCon);
            this.pnl1.Controls.Add(this.cbcBoxParity);
            this.pnl1.Controls.Add(this.lblPar);
            this.pnl1.Controls.Add(this.cbcBoxStop);
            this.pnl1.Controls.Add(this.lblStop);
            this.pnl1.Controls.Add(this.cbcBoxData);
            this.pnl1.Controls.Add(this.lblBau);
            this.pnl1.Controls.Add(this.cbcBoxBaud);
            this.pnl1.Controls.Add(this.lblBaud);
            this.pnl1.Controls.Add(this.cbBoxPort);
            this.pnl1.Controls.Add(this.lblport);
            this.pnl1.Location = new System.Drawing.Point(2, 1);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(204, 466);
            this.pnl1.TabIndex = 0;
            // 
            // pnlMsg
            // 
            this.pnlMsg.BackColor = System.Drawing.Color.Red;
            this.pnlMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMsg.Controls.Add(this.lblMsg);
            this.pnlMsg.Location = new System.Drawing.Point(3, 388);
            this.pnlMsg.Name = "pnlMsg";
            this.pnlMsg.Size = new System.Drawing.Size(194, 55);
            this.pnlMsg.TabIndex = 13;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(36, 15);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(111, 22);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Abrir Porta";
            this.lblMsg.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(19, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDes
            // 
            this.btnDes.Enabled = false;
            this.btnDes.Location = new System.Drawing.Point(112, 235);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(75, 23);
            this.btnDes.TabIndex = 11;
            this.btnDes.Text = "Fechar Porta";
            this.btnDes.UseVisualStyleBackColor = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(6, 235);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 10;
            this.btnCon.Text = "Abrir Porta";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // cbcBoxParity
            // 
            this.cbcBoxParity.FormattingEnabled = true;
            this.cbcBoxParity.Location = new System.Drawing.Point(76, 199);
            this.cbcBoxParity.Name = "cbcBoxParity";
            this.cbcBoxParity.Size = new System.Drawing.Size(121, 21);
            this.cbcBoxParity.TabIndex = 9;
            // 
            // lblPar
            // 
            this.lblPar.AutoSize = true;
            this.lblPar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPar.Location = new System.Drawing.Point(3, 204);
            this.lblPar.Name = "lblPar";
            this.lblPar.Size = new System.Drawing.Size(45, 16);
            this.lblPar.TabIndex = 8;
            this.lblPar.Text = "Parity";
            // 
            // cbcBoxStop
            // 
            this.cbcBoxStop.FormattingEnabled = true;
            this.cbcBoxStop.Location = new System.Drawing.Point(76, 153);
            this.cbcBoxStop.Name = "cbcBoxStop";
            this.cbcBoxStop.Size = new System.Drawing.Size(121, 21);
            this.cbcBoxStop.TabIndex = 7;
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStop.Location = new System.Drawing.Point(3, 158);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(64, 16);
            this.lblStop.TabIndex = 6;
            this.lblStop.Text = "Stop Bits";
            // 
            // cbcBoxData
            // 
            this.cbcBoxData.FormattingEnabled = true;
            this.cbcBoxData.Location = new System.Drawing.Point(76, 109);
            this.cbcBoxData.Name = "cbcBoxData";
            this.cbcBoxData.Size = new System.Drawing.Size(121, 21);
            this.cbcBoxData.TabIndex = 5;
            // 
            // lblBau
            // 
            this.lblBau.AutoSize = true;
            this.lblBau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBau.Location = new System.Drawing.Point(3, 114);
            this.lblBau.Name = "lblBau";
            this.lblBau.Size = new System.Drawing.Size(64, 16);
            this.lblBau.TabIndex = 4;
            this.lblBau.Text = "Data Bits";
            this.lblBau.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbcBoxBaud
            // 
            this.cbcBoxBaud.FormattingEnabled = true;
            this.cbcBoxBaud.Location = new System.Drawing.Point(76, 64);
            this.cbcBoxBaud.Name = "cbcBoxBaud";
            this.cbcBoxBaud.Size = new System.Drawing.Size(121, 21);
            this.cbcBoxBaud.TabIndex = 3;
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaud.Location = new System.Drawing.Point(3, 69);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(66, 16);
            this.lblBaud.TabIndex = 2;
            this.lblBaud.Text = "Baud Rat";
            // 
            // cbBoxPort
            // 
            this.cbBoxPort.FormattingEnabled = true;
            this.cbBoxPort.Location = new System.Drawing.Point(76, 19);
            this.cbBoxPort.Name = "cbBoxPort";
            this.cbBoxPort.Size = new System.Drawing.Size(121, 21);
            this.cbBoxPort.TabIndex = 1;
            this.cbBoxPort.Click += new System.EventHandler(this.cbBoxPort_Click);
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblport.Location = new System.Drawing.Point(3, 24);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(67, 16);
            this.lblport.TabIndex = 0;
            this.lblport.Text = "Com Port";
            this.lblport.Click += new System.EventHandler(this.lblport_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(210, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(565, 460);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(557, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor Serial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txtRec);
            this.groupBox2.Controls.Add(this.btnApagar);
            this.groupBox2.Location = new System.Drawing.Point(7, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recepção";
            // 
            // txtRec
            // 
            this.txtRec.Location = new System.Drawing.Point(1, 46);
            this.txtRec.Multiline = true;
            this.txtRec.Name = "txtRec";
            this.txtRec.Size = new System.Drawing.Size(546, 298);
            this.txtRec.TabIndex = 1;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(267, 19);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(87, 23);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.chBoxEnviar);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.txtEnviar);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transmissão";
            // 
            // chBoxEnviar
            // 
            this.chBoxEnviar.AutoSize = true;
            this.chBoxEnviar.Location = new System.Drawing.Point(6, 45);
            this.chBoxEnviar.Name = "chBoxEnviar";
            this.chBoxEnviar.Size = new System.Drawing.Size(41, 17);
            this.chBoxEnviar.TabIndex = 2;
            this.chBoxEnviar.Text = "CR";
            this.chBoxEnviar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(271, 19);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(84, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(6, 19);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(259, 20);
            this.txtEnviar.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.BarPWM);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.pnlLed2);
            this.tabPage2.Controls.Add(this.btnBotao2);
            this.tabPage2.Controls.Add(this.btnBotao1);
            this.tabPage2.Controls.Add(this.pnlLed1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(557, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Botões/Leds";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "LED_PWM";
            // 
            // BarPWM
            // 
            this.BarPWM.BackColor = System.Drawing.SystemColors.Control;
            this.BarPWM.Location = new System.Drawing.Point(27, 354);
            this.BarPWM.Maximum = 5;
            this.BarPWM.Name = "BarPWM";
            this.BarPWM.RightToLeftLayout = true;
            this.BarPWM.Size = new System.Drawing.Size(342, 45);
            this.BarPWM.TabIndex = 5;
            this.BarPWM.Scroll += new System.EventHandler(this.BarPWM_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(231, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 234);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 204);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlLed2
            // 
            this.pnlLed2.BackColor = System.Drawing.Color.Maroon;
            this.pnlLed2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLed2.Controls.Add(this.lblLed2);
            this.pnlLed2.Location = new System.Drawing.Point(106, 51);
            this.pnlLed2.Name = "pnlLed2";
            this.pnlLed2.Size = new System.Drawing.Size(75, 52);
            this.pnlLed2.TabIndex = 2;
            // 
            // lblLed2
            // 
            this.lblLed2.AutoSize = true;
            this.lblLed2.Location = new System.Drawing.Point(20, 18);
            this.lblLed2.Name = "lblLed2";
            this.lblLed2.Size = new System.Drawing.Size(34, 13);
            this.lblLed2.TabIndex = 1;
            this.lblLed2.Text = "Led 2";
            // 
            // btnBotao2
            // 
            this.btnBotao2.Location = new System.Drawing.Point(105, 7);
            this.btnBotao2.Name = "btnBotao2";
            this.btnBotao2.Size = new System.Drawing.Size(75, 37);
            this.btnBotao2.TabIndex = 1;
            this.btnBotao2.Text = "Botão 2";
            this.btnBotao2.UseVisualStyleBackColor = true;
            this.btnBotao2.Click += new System.EventHandler(this.btnBotao2_Click);
            // 
            // btnBotao1
            // 
            this.btnBotao1.Location = new System.Drawing.Point(6, 7);
            this.btnBotao1.Name = "btnBotao1";
            this.btnBotao1.Size = new System.Drawing.Size(75, 37);
            this.btnBotao1.TabIndex = 0;
            this.btnBotao1.Text = "Botão 1";
            this.btnBotao1.UseVisualStyleBackColor = true;
            this.btnBotao1.Click += new System.EventHandler(this.BtnBotao1_Click);
            // 
            // pnlLed1
            // 
            this.pnlLed1.BackColor = System.Drawing.Color.Maroon;
            this.pnlLed1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLed1.Controls.Add(this.lblLed1);
            this.pnlLed1.Location = new System.Drawing.Point(6, 50);
            this.pnlLed1.Name = "pnlLed1";
            this.pnlLed1.Size = new System.Drawing.Size(75, 52);
            this.pnlLed1.TabIndex = 0;
            // 
            // lblLed1
            // 
            this.lblLed1.AutoSize = true;
            this.lblLed1.Location = new System.Drawing.Point(16, 20);
            this.lblLed1.Name = "lblLed1";
            this.lblLed1.Size = new System.Drawing.Size(34, 13);
            this.lblLed1.TabIndex = 0;
            this.lblLed1.Text = "Led 1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(557, 434);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sensores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.pgBar3);
            this.groupBox3.Controls.Add(this.pgBar2);
            this.groupBox3.Controls.Add(this.pg1Bar1);
            this.groupBox3.Controls.Add(this.lblSensor3);
            this.groupBox3.Controls.Add(this.lblSensor2);
            this.groupBox3.Controls.Add(this.lblSensor1);
            this.groupBox3.Controls.Add(this.lblS3);
            this.groupBox3.Controls.Add(this.lblS2);
            this.groupBox3.Controls.Add(this.lblS1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(16, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(535, 401);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // pgBar3
            // 
            this.pgBar3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pgBar3.ForeColor = System.Drawing.Color.DarkRed;
            this.pgBar3.Location = new System.Drawing.Point(23, 271);
            this.pgBar3.Maximum = 1024;
            this.pgBar3.Name = "pgBar3";
            this.pgBar3.Size = new System.Drawing.Size(481, 54);
            this.pgBar3.TabIndex = 9;
            // 
            // pgBar2
            // 
            this.pgBar2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pgBar2.ForeColor = System.Drawing.Color.DarkRed;
            this.pgBar2.Location = new System.Drawing.Point(23, 142);
            this.pgBar2.MarqueeAnimationSpeed = 1024;
            this.pgBar2.Name = "pgBar2";
            this.pgBar2.Size = new System.Drawing.Size(481, 54);
            this.pgBar2.TabIndex = 8;
            // 
            // pg1Bar1
            // 
            this.pg1Bar1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pg1Bar1.ForeColor = System.Drawing.Color.DarkRed;
            this.pg1Bar1.Location = new System.Drawing.Point(23, 38);
            this.pg1Bar1.Maximum = 1024;
            this.pg1Bar1.Name = "pg1Bar1";
            this.pg1Bar1.Size = new System.Drawing.Size(481, 50);
            this.pg1Bar1.TabIndex = 7;
            // 
            // lblSensor3
            // 
            this.lblSensor3.AutoSize = true;
            this.lblSensor3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensor3.Location = new System.Drawing.Point(112, 232);
            this.lblSensor3.Name = "lblSensor3";
            this.lblSensor3.Size = new System.Drawing.Size(45, 19);
            this.lblSensor3.TabIndex = 6;
            this.lblSensor3.Text = "0000";
            // 
            // lblSensor2
            // 
            this.lblSensor2.AutoSize = true;
            this.lblSensor2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensor2.Location = new System.Drawing.Point(112, 109);
            this.lblSensor2.Name = "lblSensor2";
            this.lblSensor2.Size = new System.Drawing.Size(45, 19);
            this.lblSensor2.TabIndex = 5;
            this.lblSensor2.Text = "0000";
            // 
            // lblSensor1
            // 
            this.lblSensor1.AutoSize = true;
            this.lblSensor1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensor1.Location = new System.Drawing.Point(112, 16);
            this.lblSensor1.Name = "lblSensor1";
            this.lblSensor1.Size = new System.Drawing.Size(45, 19);
            this.lblSensor1.TabIndex = 4;
            this.lblSensor1.Text = "0000";
            // 
            // lblS3
            // 
            this.lblS3.AutoSize = true;
            this.lblS3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS3.Location = new System.Drawing.Point(20, 233);
            this.lblS3.Name = "lblS3";
            this.lblS3.Size = new System.Drawing.Size(79, 18);
            this.lblS3.TabIndex = 3;
            this.lblS3.Text = "Sensor 3 :";
            // 
            // lblS2
            // 
            this.lblS2.AutoSize = true;
            this.lblS2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS2.Location = new System.Drawing.Point(20, 110);
            this.lblS2.Name = "lblS2";
            this.lblS2.Size = new System.Drawing.Size(79, 18);
            this.lblS2.TabIndex = 2;
            this.lblS2.Text = "Sensor 2 :";
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS1.Location = new System.Drawing.Point(20, 16);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(79, 18);
            this.lblS1.TabIndex = 1;
            this.lblS1.Text = "Sensor 1 :";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(557, 434);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Gráfico";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(15, 22);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Sensor 1";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.Name = "Sensor 2";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "Sensor 3";
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Size = new System.Drawing.Size(300, 338);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "ChartSensores";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 479);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Supervisório de Manutenção";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnlMsg.ResumeLayout(false);
            this.pnlMsg.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarPWM)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLed2.ResumeLayout(false);
            this.pnlLed2.PerformLayout();
            this.pnlLed1.ResumeLayout(false);
            this.pnlLed1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lblport;
        private System.Windows.Forms.ComboBox cbcBoxParity;
        private System.Windows.Forms.Label lblPar;
        private System.Windows.Forms.ComboBox cbcBoxStop;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.ComboBox cbcBoxData;
        private System.Windows.Forms.Label lblBau;
        private System.Windows.Forms.ComboBox cbcBoxBaud;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.ComboBox cbBoxPort;
        private System.Windows.Forms.Panel pnlMsg;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDes;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chBoxEnviar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRec;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Panel pnlLed2;
        private System.Windows.Forms.Label lblLed2;
        private System.Windows.Forms.Button btnBotao2;
        private System.Windows.Forms.Button btnBotao1;
        private System.Windows.Forms.Panel pnlLed1;
        private System.Windows.Forms.Label lblLed1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblS1;
        private System.Windows.Forms.Label lblSensor3;
        private System.Windows.Forms.Label lblSensor2;
        private System.Windows.Forms.Label lblSensor1;
        private System.Windows.Forms.Label lblS3;
        private System.Windows.Forms.Label lblS2;
        private System.Windows.Forms.TrackBar BarPWM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pgBar3;
        private System.Windows.Forms.ProgressBar pgBar2;
        private System.Windows.Forms.ProgressBar pg1Bar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}


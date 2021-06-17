using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace SupervisorioDeManutençao
{
    public partial class Form1 : Form
    {

        delegate void funcaoRecepcao();
        public Form1()
        {
            InitializeComponent();

            serialPort1.DataReceived += SerialPort1_DataReceived;
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            funcaoRecepcao recepcaodelegate = new funcaoRecepcao(RecepcaoSerial);
            Invoke(recepcaodelegate);
        }
        String chtxt = null, str = null;
        long tempox = 0;
        bool flagTIME = false;
        public void RecepcaoSerial()
        {
            chtxt += serialPort1.ReadExisting();
            txtRec.Text += chtxt;
            str += chtxt;
            chtxt = null;

            //Texto [LeD1ON] liga led [LeD1OF] desliga led
            if(txtRec.Text.Length>776)
            {
                txtRec.Clear();
            }
            if (str.Substring(0, 1).Equals("["))
                {
                if(str.Length >= 8)
                {
                    if(str.Substring(1,0).Equals("L") &&
                        str.Substring(2,0).Equals("e") &&
                        str.Substring(3, 0).Equals("D") &&
                        str.Substring(5, 0).Equals("O") &&
                        str.Substring(7, 0).Equals("]"))
                        {
                        if(str.Substring(6,1).Equals("N"))
                        {
                            switch(str.Substring(4,1))
                            {
                                case "1":pnlLed1.BackColor = Color.Red;
                                    break;
                                case "2":
                                    pnlLed2.BackColor = Color.Red;
                                    break;
                                case "3":
                                    pictureBox1.Image = Properties.Resources.led2;
                                    break;

                            }

                        }
                        else
                        {
                            if (str.Substring(6, 1).Equals("F"))
                            {
                                switch (str.Substring(4, 1))
                                {
                                    case "1":
                                        pnlLed1.BackColor = Color.Maroon;
                                        break;
                                    case "2":
                                        pnlLed2.BackColor = Color.Maroon;
                                        break;
                                    case "3":
                                        pictureBox1.Image = Properties.Resources.led;
                                        break;

                                }

                            }
                        }
                    } str = null;
                }
                else
                {
                    if (str.Substring(1, 1).Equals("A") && str.Substring(7, 1).Equals("]"))
                    {
                        if (str.Substring(2, 1).Equals("1"))
                        {
                            lblSensor1.Text = str.Substring(3, 4);
                            pg1Bar1.Value = int.Parse (str.Substring(3, 4));
                            if (chart1.Series[0].Points.Count > 5)
                            {
                                chart1.Series[0].Points.RemoveAt(0);
                                chart1.Update();
                            }
                            chart1.Series[0].Points.AddXY(tempox , int.Parse(str.Substring(3, 4)));
                        }
                        if(str.Substring(2, 1).Equals("2"))
                        {
                           
                            lblSensor2.Text = str.Substring(3, 4);
                            pgBar2.Value = int.Parse(str.Substring(3, 4));
                            if (chart1.Series[1].Points.Count > 5)
                            {
                                chart1.Series[1].Points.RemoveAt(0);
                                chart1.Update();
                            }
                            chart1.Series[1].Points.AddXY(tempox, int.Parse(str.Substring(3, 4)));
                        }
                        else
                        {
                            if (str.Substring(2, 1).Equals("3"))
                            {
                                lblSensor3.Text = str.Substring(3, 4);
                                pgBar3.Value = int.Parse(str.Substring(3, 4));
                                if (chart1.Series[2].Points.Count > 5)
                                {
                                    chart1.Series[2].Points.RemoveAt(0);
                                    chart1.Update();
                                }
                                chart1.Series[2].Points.AddXY(tempox, int.Parse(str.Substring(3, 4)));
                            }
                        }
                        tempox++;
                        str = null;
                    }
                    else
                    {
                        if (str.Substring(1, 0).Equals("T") && //[TIMEOK]
                        str.Substring(2, 0).Equals("I") &&
                        str.Substring(3, 0).Equals("M") &&
                        str.Substring(4, 0).Equals("E") &&
                        str.Substring(5, 0).Equals("O") &&
                        str.Substring(6, 0).Equals("K") &&
                        str.Substring(7, 0).Equals("]"))
                        {
                            flagTIME = false;
                            str = null;
                        }
                    }
                }

            }
                
        }
        private void lblport_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            #region Config_Port
            String[] valoresPort = SerialPort.GetPortNames();
            for (int i = 0; i < valoresPort.Length; i++)
            {
                cbBoxPort.Items.Add(valoresPort[i]);
            }
            cbBoxPort.Text = "COM1";
            #endregion

            #region Config_Baud
            int[] valoresBaud ={2400, 4800, 9600, 19200, 57600, 115200};
            for (int i = 0; i < valoresBaud.Length; i++) 
            {
                cbcBoxBaud.Items.Add(valoresBaud[i]);
            }
            cbcBoxBaud.Text = "9600";
            #endregion

            #region Config_Data
            cbcBoxData.Items.Add("7");
            cbcBoxData.Items.Add("5");
            cbcBoxData.Text="8";
            #endregion

            #region Config_Stop
            cbcBoxStop.Items.Add("None");
            cbcBoxStop.Items.Add("One");
            cbcBoxStop.Items.Add("Two");
            cbcBoxStop.Text = "One";
            #endregion

            #region Config_Parity
            cbcBoxParity.Items.Add("None");
            cbcBoxParity.Items.Add("Even");
            cbcBoxParity.Items.Add("Cod");
            cbcBoxParity.Items.Add("Mark");
            cbcBoxParity.Items.Add("Space");
            cbcBoxParity.Text = "None";
            #endregion

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true) serialPort1.Close();
            else
            {
                serialPort1.PortName = cbBoxPort.Text;
                serialPort1.BaudRate = int.Parse(cbcBoxBaud.Text);
                serialPort1.DataBits = int.Parse(cbcBoxData.Text);
                serialPort1.StopBits = (StopBits)(cbcBoxStop.SelectedIndex);
                serialPort1.Parity = (Parity)(cbcBoxParity.SelectedIndex);
            }

            try
            {
                serialPort1.Open();
                btnCon.Enabled = false;
                btnDes.Enabled = true;
                btnExit.Enabled = false;
                cbBoxPort.Enabled = false;
                cbcBoxBaud.Enabled = false;
                cbcBoxData.Enabled = false;
                cbcBoxStop.Enabled = false;
                cbcBoxParity.Enabled = false;
                pnlMsg.BackColor = Color.Green;
                lblMsg.Text = "Fechar Porta";
                serialPort1.Write("[Início!]");
                timer1.Start();
            }
            catch
            {
                MessageBox.Show("ERRO de Comunicação com a porta");
                serialPort1.Open();
                btnCon.Enabled = true;
                btnDes.Enabled = false;
                btnExit.Enabled = true;
                cbBoxPort.Enabled = true;
                cbcBoxBaud.Enabled = true;
                cbcBoxData.Enabled = true;
                cbcBoxStop.Enabled = true;
                cbcBoxParity.Enabled = true;
                pnlMsg.BackColor = Color.Red;
                lblMsg.Text = "Abrir Porta";
            }
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true) serialPort1.Close();
            else
            {
                serialPort1.PortName = cbBoxPort.Text;
                serialPort1.BaudRate = int.Parse(cbcBoxBaud.Text);
                serialPort1.DataBits = int.Parse(cbcBoxData.Text);
                serialPort1.StopBits = (StopBits)(cbcBoxStop.SelectedIndex);
                serialPort1.Parity = (Parity)(cbcBoxParity.SelectedIndex);
            }

            try
            {
                serialPort1.Write("[Pare!!]");
                timer1.Stop();
                serialPort1.Close();
                btnCon.Enabled = true;
                btnDes.Enabled = false;
                btnExit.Enabled = true;
                cbBoxPort.Enabled = true;
                cbcBoxBaud.Enabled = true;
                cbcBoxData.Enabled = true;
                cbcBoxStop.Enabled = true;
                cbcBoxParity.Enabled = true;
                pnlMsg.BackColor = Color.Red;
                lblMsg.Text = "Abrir Porta";
                pg1Bar1.Value = 0;
                pgBar2.Value = 0;
                pgBar3.Value = 0;
                lblSensor1.Text = "0000";
                lblSensor2.Text = "0000";
                lblSensor3.Text = "0000";
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();
                pnlLed1.BackColor = Color.Maroon;
                pnlLed2.BackColor = Color.Maroon;
                pictureBox1.Image = Properties.Resources.led;
                flagTIME = false;
                contTIME = 0;
                BarPWM.Value = 0;
                tempox = 0;
            }
            catch
            {
                MessageBox.Show("ERRO de Comunicação com a porta");
                serialPort1.Open();
                btnCon.Enabled = false;
                btnDes.Enabled = true;
                btnExit.Enabled = false;
                cbBoxPort.Enabled = false;
                cbcBoxBaud.Enabled = false;
                cbcBoxData.Enabled = false;
                cbcBoxStop.Enabled = false;
                cbcBoxParity.Enabled = false;
                pnlMsg.BackColor = Color.Green;
                lblMsg.Text = "Fechar Porta";
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen ==  true)
            {
                if (chBoxEnviar.Checked)
                {
                    serialPort1.Write(txtEnviar.Text + "\r");
                }
                else
                {
                    serialPort1.Write(txtEnviar.Text);
                }
                txtEnviar.Text = null;
            }
            else
            {
                MessageBox.Show("Erro de comunicação com a porta !");
            }
        }
        // Texto [Botao1]
        private void BtnBotao1_Click(object sender, EventArgs e)
        {
           if(serialPort1.IsOpen==true) serialPort1.Write("[Botao1]");
        }

        private void btnBotao2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true) serialPort1.Write("[Botao2]");
        }
        bool auxiLamp = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("[Botao3]");
                if(auxiLamp==false)
                {
                    pictureBox1.Image = Properties.Resources.led2;
                    auxiLamp = !auxiLamp;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.led;
                    auxiLamp = !auxiLamp;
                }
            

            }




        }

        private void BarPWM_Scroll(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                int valorPWM = BarPWM.Value * 50;
                if(valorPWM>=100) serialPort1.Write("[PWM0" + valorPWM.ToString() + "]");
                else
                    serialPort1.Write("[PWM00" + valorPWM.ToString() + "]");
            }
            
        }
        int contTIME = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            contTIME++;
            if (contTIME >= 40)
            {
                if (flagTIME == false)
                {
                    serialPort1.Write("[TIMEOK]");
                    contTIME = 0;
                }
                else
                {
                    try
                    {
                        serialPort1.Write("[Parar!!]");
                        serialPort1.Close();
                        btnCon.Enabled = true;
                        btnDes.Enabled = false;
                        btnExit.Enabled = true;
                        cbBoxPort.Enabled = true;
                        cbcBoxBaud.Enabled = true;
                        cbcBoxData.Enabled = true;
                        cbcBoxStop.Enabled = true;
                        cbcBoxParity.Enabled = true;
                        pnlMsg.BackColor = Color.Red;
                        lblMsg.Text = "Abrir Porta";
                        pg1Bar1.Value = 0;
                        pgBar2.Value = 0;
                        pgBar3.Value = 0;
                        lblSensor1.Text = "0000";
                        lblSensor2.Text = "0000";
                        lblSensor3.Text = "0000";
                        chart1.Series[0].Points.Clear();
                        chart1.Series[1].Points.Clear();
                        chart1.Series[2].Points.Clear();
                        pnlLed1.BackColor = Color.Maroon;
                        pnlLed2.BackColor = Color.Maroon;
                        pictureBox1.Image = Properties.Resources.led;
                        flagTIME = false;
                        BarPWM.Value = 0;
                        contTIME = 0;
                        tempox = 0;
                        MessageBox.Show("ERRO TIMER");
                    }
                    catch
                    {
                        serialPort1.Write("[Parar!!]");
                        serialPort1.Close();
                        btnCon.Enabled = true;
                        btnDes.Enabled = false;
                        btnExit.Enabled = true;
                        cbBoxPort.Enabled = true;
                        cbcBoxBaud.Enabled = true;
                        cbcBoxData.Enabled = true;
                        cbcBoxStop.Enabled = true;
                        cbcBoxParity.Enabled = true;
                        pnlMsg.BackColor = Color.Red;
                        lblMsg.Text = "Abrir Porta";
                        pg1Bar1.Value = 0;
                        pgBar2.Value = 0;
                        pgBar3.Value = 0;
                        lblSensor1.Text = "0000";
                        lblSensor2.Text = "0000";
                        lblSensor3.Text = "0000";
                        chart1.Series[0].Points.Clear();
                        chart1.Series[1].Points.Clear();
                        chart1.Series[2].Points.Clear();
                        pnlLed1.BackColor = Color.Maroon;
                        pnlLed2.BackColor = Color.Maroon;
                        pictureBox1.Image = Properties.Resources.led;
                        flagTIME = false;
                        BarPWM.Value = 0;
                        contTIME = 0;
                        tempox = 0;
                        MessageBox.Show("ERRO TIMER");
                    }

                }   
            }
            else
            {
                if (contTIME == 20) ;
                {
                    serialPort1.Write("[TIMEOK");
                    flagTIME = true;
                }
            }
        }

        private void cbBoxPort_Click(object sender, EventArgs e)
        {
            cbBoxPort.Items.Clear();
            String[] valoresPort = SerialPort.GetPortNames();
            for (int i = 0; i < valoresPort.Length; i++)
            {
                cbBoxPort.Items.Add(valoresPort[i]);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtRec.Text = null;
        }
    }
}

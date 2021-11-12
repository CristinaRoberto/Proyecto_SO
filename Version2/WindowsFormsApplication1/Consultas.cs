using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class Consultas : Form
    {
        Socket server;
        public Consultas()
        {
            InitializeComponent();
        }

        public void setServer(Socket servidor)
        {
            this.server = servidor;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string mensaje = "3/" + textBox1.Text + "";
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
                MessageBox.Show(mensaje);

                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split(',')[0];

                if (mensaje == "SI")
                {
                    MessageBox.Show("Registrado correctamente");
                    Close();

                }
                else if (mensaje == "NO")
                {
                    MessageBox.Show("No se ha podido registrar");
                }
            }
            if (radioButton2.Checked)
            {
                string mensaje = "4/" + textBox1.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
                MessageBox.Show(mensaje);

                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split(',')[0];

               
                
                    MessageBox.Show("Puntuación:"+mensaje);
                    Close();

                
                
            }
        }
    }

}

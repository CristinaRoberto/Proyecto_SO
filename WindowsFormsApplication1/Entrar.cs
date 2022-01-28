using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Entrar : Form
    {
        Socket server;
        Thread atender;
        int numero_conectados = 0;
        string[] conectados;
        string invitador;
        string usuario;
        Image fondo = Image.FromFile("dorso.jpeg");
        int puntos;
        int[] pos = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
        int contador;
        int tg1;
        int tg2;
        int n1;
        int n2;
        int tim;
        PictureBox pc1 = new PictureBox();
        int IDjugador;
        int IDturno = 1;
       

        //Delegados para realizar acciones
        delegate void DelegadoParaEscribir(string mensaje);
        delegate void DelegadoParaActualizar(string mensaje);
        delegate void DelegadoParaEscribirAlChat(string mensaje);
        delegate void DelegadoParaConectar();
        delegate void DelegadoParaDesconectar();
        delegate void DelegadoParaEliminarCuenta();
        
        public Entrar()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        public void setServidor(Socket Servidor)
        {
            this.server = Servidor;
        
        }

        public static void Shuffle(int[] vector)
        {
            var n = vector.Length;
            var rnd = new Random();
            for(int i = n - 1; i>0; i--)
            {
                var j = rnd.Next(0,i);
                var temp = vector[i];
                vector[i] = vector[j];
                vector[j] = temp;
            }

         }

        public void seleccionarTag(PictureBox pb, int idp)
        {
            if (contador == 1)
            {
                tg1 = Convert.ToInt32(pb.Tag);
                n1 = idp;
            }
            if(contador==2)
            {

                tg2 = Convert.ToInt32(pb.Tag);
                n2 = idp;
                timer1.Start();
               // Comparador(tg1, tg2, puntos, n1, n2);
                contador = 0;
                
                

            }
        }
        
        public int Comparador(int tag1, int tag2,int punts,int np1,int np2)
        {

            if (tag1 == tag2 && np1!=np2)
            {
                punts = punts + 1;
                string mensaje = "21/" + np1 + "/" + np2 + "/" + IDjugador + "/" + puntos;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
                
                
               
                if (np1 == 1 || np2 == 1)
                {
                    pictureBox1.Enabled = false;
                }
                if (np1 == 2 || np2 == 2)
                {
                    pictureBox2.Enabled = false;
                }
                if (np1 == 3 || np2 == 3)
                {
                    pictureBox3.Enabled = false;
                }
                if (np1 == 4 || np2 == 4)
                {
                    pictureBox4.Enabled = false;
                }
                if (np1 == 5 || np2 == 5)
                {
                    pictureBox5.Enabled = false;
                }
                if (np1 == 6 || np2 == 6)
                {
                    pictureBox6.Enabled = false;
                }
                if (np1 == 7 || np2 == 7)
                {
                    pictureBox7.Enabled = false;
                }
                if (np1 == 8 || np2 == 8)
                {
                    pictureBox8.Enabled = false;
                }
                if (np1 == 9 || np2 == 9)
                {
                    pictureBox9.Enabled = false;
                }
                if (np1 == 10 || np2 == 10)
                {
                    pictureBox10.Enabled = false;
                }
                if (np1 == 11 || np2 == 11)
                {
                    pictureBox11.Enabled = false;
                }
                if (np1 == 12 || np2 == 12)
                {
                    pictureBox12.Enabled = false;
                }
                if (np1 == 13 || np2 == 13)
                {
                    pictureBox13.Enabled = false;
                }
                if (np1 == 14 || np2 == 14)
                {
                    pictureBox14.Enabled = false;
                }
                if (np1 == 15 || np2 == 15)
                {
                    pictureBox15.Enabled = false;
                }
                if (np1 == 16 || np2 == 16)
                {
                    pictureBox16.Enabled = false;
                }
                if (np1 == 17 || np2 == 17)
                {
                    pictureBox17.Enabled = false;
                }
                if (np1 == 18 || np2 == 18)
                {
                    pictureBox18.Enabled = false;
                }
                if (np1 == 19 || np2 == 19)
                {
                    pictureBox19.Enabled = false;
                }
                if (np1 == 20 || np2 == 20)
                {
                    pictureBox20.Enabled = false;
                }
                if (np1 == 21 || np2 == 21)
                {
                    pictureBox21.Enabled = false;
                }
                if (np1 == 22 || np2 == 22)
                {
                    pictureBox22.Enabled = false;
                }
                if (np1 == 23 || np2 == 23)
                {
                    pictureBox23.Enabled = false;
                }
                if (np1 == 24 || np2 == 24)
                {
                    pictureBox24.Enabled = false;
                }
                if (np1 == 25 || np2 == 25)
                {
                    pictureBox25.Enabled = false;
                }
                if (np1 == 26 || np2 == 26)
                {
                    pictureBox26.Enabled = false;
                }
                if (np1 == 27 || np2 == 27)
                {
                    pictureBox27.Enabled = false;
                }
                if (np1 == 28 || np2 == 28)
                {
                    pictureBox28.Enabled = false;
                }
                if (np1 == 29 || np2 == 29)
                {
                    pictureBox29.Enabled = false;
                }
                if (np1 == 30 || np2 == 30)
                {
                    pictureBox30.Enabled = false;
                }
                if (np1 == 31 || np2 == 31)
                {
                    pictureBox31.Enabled = false;
                }
                if (np1 == 32 || np2 == 32)
                {
                    pictureBox32.Enabled = false;
                }
                if (np1 == 33 || np2 == 33)
                {
                    pictureBox33.Enabled = false;
                }
                if (np1 == 34 || np2 == 34)
                {
                    pictureBox34.Enabled = false;
                }
                if (np1 == 35 || np2 == 35)
                {
                    pictureBox35.Enabled = false;
                }
                if (np1 == 36 || np2 == 36)
                {
                    pictureBox36.Enabled = false;
                }
                return 1;
            }
            else {
                string mensaje = "13/" + IDjugador;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                return 0;
            }
            
        }

        public void mientrasTimer(int np1, int np2) {
            if (np1 == 1 || np2 == 1)
            {
                pictureBox1.Enabled = false;
            }
            if (np1 == 2 || np2 == 2)
            {
                pictureBox2.Enabled = false;
            }
            if (np1 == 3 || np2 == 3)
            {
                pictureBox3.Enabled = false;
            }
            if (np1 == 4 || np2 == 4)
            {
                pictureBox4.Enabled = false;
            }
            if (np1 == 5 || np2 == 5)
            {
                pictureBox5.Enabled = false;
            }
            if (np1 == 6 || np2 == 6)
            {
                pictureBox6.Enabled = false;
            }
            if (np1 == 7 || np2 == 7)
            {
                pictureBox7.Enabled = false;
            }
            if (np1 == 8 || np2 == 8)
            {
                pictureBox8.Enabled = false;
            }
            if (np1 == 9 || np2 == 9)
            {
                pictureBox9.Enabled = false;
            }
            if (np1 == 10 || np2 == 10)
            {
                pictureBox10.Enabled = false;
            }
            if (np1 == 11 || np2 == 11)
            {
                pictureBox11.Enabled = false;
            }
            if (np1 == 12 || np2 == 12)
            {
                pictureBox12.Enabled = false;
            }
            if (np1 == 13 || np2 == 13)
            {
                pictureBox13.Enabled = false;
            }
            if (np1 == 14 || np2 == 14)
            {
                pictureBox14.Enabled = false;
            }
            if (np1 == 15 || np2 == 15)
            {
                pictureBox15.Enabled = false;
            }
            if (np1 == 16 || np2 == 16)
            {
                pictureBox16.Enabled = false;
            }
            if (np1 == 17 || np2 == 17)
            {
                pictureBox17.Enabled = false;
            }
            if (np1 == 18 || np2 == 18)
            {
                pictureBox18.Enabled = false;
            }
            if (np1 == 19 || np2 == 19)
            {
                pictureBox19.Enabled = false;
            }
            if (np1 == 20 || np2 == 20)
            {
                pictureBox20.Enabled = false;
            }
            if (np1 == 21 || np2 == 21)
            {
                pictureBox21.Enabled = false;
            }
            if (np1 == 22 || np2 == 22)
            {
                pictureBox22.Enabled = false;
            }
            if (np1 == 23 || np2 == 23)
            {
                pictureBox23.Enabled = false;
            }
            if (np1 == 24 || np2 == 24)
            {
                pictureBox24.Enabled = false;
            }
            if (np1 == 25 || np2 == 25)
            {
                pictureBox25.Enabled = false;
            }
            if (np1 == 26 || np2 == 26)
            {
                pictureBox26.Enabled = false;
            }
            if (np1 == 27 || np2 == 27)
            {
                pictureBox27.Enabled = false;
            }
            if (np1 == 28 || np2 == 28)
            {
                pictureBox28.Enabled = false;
            }
            if (np1 == 29 || np2 == 29)
            {
                pictureBox29.Enabled = false;
            }
            if (np1 == 30 || np2 == 30)
            {
                pictureBox30.Enabled = false;
            }
            if (np1 == 31 || np2 == 31)
            {
                pictureBox31.Enabled = false;
            }
            if (np1 == 32 || np2 == 32)
            {
                pictureBox32.Enabled = false;
            }
            if (np1 == 33 || np2 == 33)
            {
                pictureBox33.Enabled = false;
            }
            if (np1 == 34 || np2 == 34)
            {
                pictureBox34.Enabled = false;
            }
            if (np1 == 35 || np2 == 35)
            {
                pictureBox35.Enabled = false;
            }
            if (np1 == 36 || np2 == 36)
            {
                pictureBox36.Enabled = false;
            }
        
        
        }

        public void despuesTimer(int np1, int np2) {
            
            
            if (np1 == 1 || np2 == 1)
            {
                pictureBox1.Image = fondo;
                pictureBox1.Enabled = true;
            }
            if (np1 == 2 || np2 == 2)
            {
                pictureBox2.Image = fondo;
                pictureBox2.Enabled = true;
            }
            if (np1 == 3 || np2 == 3)
            {
                pictureBox3.Image = fondo;
                pictureBox3.Enabled = true;
            }
            if (np1 == 4 || np2 == 4)
            {
                pictureBox4.Image = fondo;
                pictureBox4.Enabled = true;
            }
            if (np1 == 5 || np2 == 5)
            {
                pictureBox5.Image = fondo;
                pictureBox5.Enabled = true;
            }
            if (np1 == 6 || np2 == 6)
            {
                pictureBox6.Image = fondo;
                pictureBox6.Enabled = true;
            }
            if (np1 == 7 || np2 == 7)
            {
                pictureBox7.Image = fondo;
                pictureBox7.Enabled = true;
            }
            if (np1 == 8 || np2 == 8)
            {
                pictureBox8.Image = fondo;
                pictureBox8.Enabled = true;
            }
            if (np1 == 9 || np2 == 9)
            {
                pictureBox9.Image = fondo;
                pictureBox9.Enabled = true;
            }
            if (np1 == 10 || np2 == 10)
            {
                pictureBox10.Image = fondo;
                pictureBox10.Enabled = true;
            }
            if (np1 == 11 || np2 == 11)
            {
                pictureBox11.Image = fondo;
                pictureBox11.Enabled = true;
            }
            if (np1 == 12 || np2 == 12)
            {
                pictureBox12.Image = fondo;
                pictureBox12.Enabled = true;
            }
            if (np1 == 13 || np2 == 13)
            {
                pictureBox13.Image = fondo;
                pictureBox13.Enabled = true;
            }
            if (np1 == 14 || np2 == 14)
            {
                pictureBox14.Image = fondo;
                pictureBox14.Enabled = true;
            }
            if (np1 == 15 || np2 == 15)
            {
                pictureBox15.Image = fondo;
                pictureBox15.Enabled = true;
            }
            if (np1 == 16 || np2 == 16)
            {
                pictureBox16.Image = fondo;
                pictureBox16.Enabled = true;
            }
            if (np1 == 17 || np2 == 17)
            {
                pictureBox17.Image = fondo;
                pictureBox17.Enabled = true;
            }
            if (np1 == 18 || np2 == 18)
            {
                pictureBox18.Image = fondo;
                pictureBox18.Enabled = true;
            }
            if (np1 == 19 || np2 == 19)
            {
                pictureBox19.Image = fondo;
                pictureBox19.Enabled = true;
            }
            if (np1 == 20 || np2 == 20)
            {
                pictureBox20.Image = fondo;
                pictureBox20.Enabled = true;
            }
            if (np1 == 21 || np2 == 21)
            {
                pictureBox21.Image = fondo;
                pictureBox21.Enabled = true;
            }
            if (np1 == 22 || np2 == 22)
            {
                pictureBox22.Image = fondo;
                pictureBox22.Enabled = true;
            }
            if (np1 == 23 || np2 == 23)
            {
                pictureBox23.Image = fondo;
                pictureBox23.Enabled = true;
            }
            if (np1 == 24 || np2 == 24)
            {
                pictureBox24.Image = fondo;
                pictureBox24.Enabled = true;
            }
            if (np1 == 25 || np2 == 25)
            {
                pictureBox25.Image = fondo;
                pictureBox25.Enabled = true;
            }
            if (np1 == 26 || np2 == 26)
            {
                pictureBox26.Image = fondo;
                pictureBox26.Enabled = true;
            }
            if (np1 == 27 || np2 == 27)
            {
                pictureBox27.Image = fondo;
                pictureBox27.Enabled = true;
            }
            if (np1 == 28 || np2 == 28)
            {
                pictureBox28.Image = fondo;
                pictureBox28.Enabled = true;
            }
            if (np1 == 29 || np2 == 29)
            {
                pictureBox29.Image = fondo;
                pictureBox29.Enabled = true;
            }
            if (np1 == 30 || np2 == 30)
            {
                pictureBox30.Image = fondo;
                pictureBox30.Enabled = true;
            }
            if (np1 == 31 || np2 == 31)
            {
                pictureBox31.Image = fondo;
                pictureBox31.Enabled = true;
            }
            if (np1 == 32 || np2 == 32)
            {
                pictureBox32.Image = fondo;
                pictureBox32.Enabled = true;
            }
            if (np1 == 33 || np2 == 33)
            {
                pictureBox33.Image = fondo;
                pictureBox33.Enabled = true;
            }
            if (np1 == 34 || np2 == 34)
            {
                pictureBox34.Image = fondo;
                pictureBox34.Enabled = true;
            }
            if (np1 == 35 || np2 == 35)
            {
                pictureBox35.Image = fondo;
                pictureBox35.Enabled = true;
            }
            if (np1 == 36 || np2 == 36)
            {
                pictureBox36.Image = fondo;
                pictureBox36.Enabled = true;
            }
        
        
        }
        public void Acertado(int id1, int id2) {
            if (id1 == 1 || id2 == 1)
            {
                pictureBox1.Image = Image.FromFile(Convert.ToInt32(pictureBox1.Tag).ToString() + ".jpeg");
                pictureBox1.Enabled = false;
            }
            if (id1 == 2 || id2 == 2)
            {
                pictureBox2.Image = Image.FromFile(Convert.ToInt32(pictureBox2.Tag).ToString() + ".jpeg");
                pictureBox2.Enabled = false;
            }
            if (id1 == 3 || id2 == 3)
            {
                pictureBox3.Image = Image.FromFile(Convert.ToInt32(pictureBox3.Tag).ToString() + ".jpeg");
                pictureBox3.Enabled = false;
            }
            if (id1 == 4 || id2 == 4)
            {
                pictureBox4.Image = Image.FromFile(Convert.ToInt32(pictureBox4.Tag).ToString() + ".jpeg");
                pictureBox4.Enabled = false;
            }
            if (id1 == 5 || id2 == 5)
            {
                pictureBox5.Image = Image.FromFile(Convert.ToInt32(pictureBox5.Tag).ToString() + ".jpeg");
                pictureBox5.Enabled = false;
            }
            if (id1 == 6 || id2 == 6)
            {
                pictureBox6.Image = Image.FromFile(Convert.ToInt32(pictureBox6.Tag).ToString() + ".jpeg");
                pictureBox6.Enabled = false;
            }
            if (id1 == 7 || id2 == 7)
            {
                pictureBox7.Image = Image.FromFile(Convert.ToInt32(pictureBox7.Tag).ToString() + ".jpeg");
                pictureBox7.Enabled = false;
            }
            if (id1 == 8 || id2 == 8)
            {
                pictureBox8.Image = Image.FromFile(Convert.ToInt32(pictureBox8.Tag).ToString() + ".jpeg");
                pictureBox8.Enabled = false;
            }
            if (id1 == 9 || id2 == 9)
            {
                pictureBox9.Image = Image.FromFile(Convert.ToInt32(pictureBox9.Tag).ToString() + ".jpeg");
                pictureBox9.Enabled = false;
            }
            if (id1 == 10 || id2 == 10)
            {
                pictureBox10.Image = Image.FromFile(Convert.ToInt32(pictureBox10.Tag).ToString() + ".jpeg");
                pictureBox10.Enabled = false;
            }
            if (id1 == 11 || id2 == 11)
            {
                pictureBox11.Image = Image.FromFile(Convert.ToInt32(pictureBox11.Tag).ToString() + ".jpeg");
                pictureBox11.Enabled = false;
            }
            if (id1 == 12 || id2 == 12)
            {
                pictureBox12.Image = Image.FromFile(Convert.ToInt32(pictureBox12.Tag).ToString() + ".jpeg");
                pictureBox12.Enabled = false;
            }
            if (id1 == 13 || id2 == 13)
            {
                pictureBox13.Image = Image.FromFile(Convert.ToInt32(pictureBox13.Tag).ToString() + ".jpeg");
                pictureBox13.Enabled = false;
            }
            if (id1 == 14 || id2 == 14)
            {
                pictureBox14.Image = Image.FromFile(Convert.ToInt32(pictureBox14.Tag).ToString() + ".jpeg");
                pictureBox14.Enabled = false;
            }
            if (id1 == 15 || id2 == 15)
            {
                pictureBox15.Image = Image.FromFile(Convert.ToInt32(pictureBox15.Tag).ToString() + ".jpeg");
                pictureBox15.Enabled = false;
            }
            if (id1 == 16 || id2 == 16)
            {
                pictureBox16.Image = Image.FromFile(Convert.ToInt32(pictureBox16.Tag).ToString() + ".jpeg");
                pictureBox16.Enabled = false;
            }
            if (id1 == 17 || id2 == 17)
            {
                pictureBox17.Image = Image.FromFile(Convert.ToInt32(pictureBox17.Tag).ToString() + ".jpeg");
                pictureBox17.Enabled = false;
            }
            if (id1 == 18 || id2 == 18)
            {
                pictureBox18.Image = Image.FromFile(Convert.ToInt32(pictureBox18.Tag).ToString() + ".jpeg");
                pictureBox18.Enabled = false;
            }
            if (id1 == 19 || id2 == 19)
            {
                pictureBox19.Image = Image.FromFile(Convert.ToInt32(pictureBox19.Tag).ToString() + ".jpeg");
                pictureBox19.Enabled = false;
            }
            if (id1 == 20 || id2 == 20)
            {
                pictureBox20.Image = Image.FromFile(Convert.ToInt32(pictureBox20.Tag).ToString() + ".jpeg");
                pictureBox20.Enabled = false;
            }
            if (id1 == 21 || id2 == 21)
            {
                pictureBox21.Image = Image.FromFile(Convert.ToInt32(pictureBox21.Tag).ToString() + ".jpeg");
                pictureBox21.Enabled = false;
            }
            if (id1 == 22 || id2 == 22)
            {
                pictureBox22.Image = Image.FromFile(Convert.ToInt32(pictureBox22.Tag).ToString() + ".jpeg");
                pictureBox22.Enabled = false;
            }
            if (id1 == 23 || id2 == 23)
            {
                pictureBox23.Image = Image.FromFile(Convert.ToInt32(pictureBox23.Tag).ToString() + ".jpeg");
                pictureBox23.Enabled = false;
            }
            if (id1 == 24 || id2 == 24)
            {
                pictureBox24.Image = Image.FromFile(Convert.ToInt32(pictureBox24.Tag).ToString() + ".jpeg");
                pictureBox24.Enabled = false;
            }
            if (id1 == 25 || id2 == 25)
            {
                pictureBox25.Image = Image.FromFile(Convert.ToInt32(pictureBox25.Tag).ToString() + ".jpeg");
                pictureBox25.Enabled = false;
            }
            if (id1 == 26 || id2 == 26)
            {
                pictureBox26.Image = Image.FromFile(Convert.ToInt32(pictureBox26.Tag).ToString() + ".jpeg");
                pictureBox26.Enabled = false;
            }
            if (id1 == 27 || id2 == 27)
            {
                pictureBox27.Image = Image.FromFile(Convert.ToInt32(pictureBox27.Tag).ToString() + ".jpeg");
                pictureBox27.Enabled = false;
            }
            if (id1 == 28 || id2 == 28)
            {
                pictureBox28.Image = Image.FromFile(Convert.ToInt32(pictureBox28.Tag).ToString() + ".jpeg");
                pictureBox28.Enabled = false;
            }
            if (id1 == 29 || id2 == 29)
            {
                pictureBox29.Image = Image.FromFile(Convert.ToInt32(pictureBox29.Tag).ToString() + ".jpeg");
                pictureBox29.Enabled = false;
            }
            if (id1 == 30 || id2 == 30)
            {
                pictureBox30.Image = Image.FromFile(Convert.ToInt32(pictureBox30.Tag).ToString() + ".jpeg");
                pictureBox30.Enabled = false;
            }
            if (id1 == 31 || id2 == 31)
            {
                pictureBox31.Image = Image.FromFile(Convert.ToInt32(pictureBox31.Tag).ToString() + ".jpeg");
                pictureBox31.Enabled = false;
            }
            if (id1 == 32 || id2 == 32)
            {
                pictureBox32.Image = Image.FromFile(Convert.ToInt32(pictureBox32.Tag).ToString() + ".jpeg");
                pictureBox32.Enabled = false;
            }
            if (id1 == 33 || id2 == 33)
            {
                pictureBox33.Image = Image.FromFile(Convert.ToInt32(pictureBox33.Tag).ToString() + ".jpeg");
                pictureBox33.Enabled = false;
            }
            if (id1 == 34 || id2 == 34)
            {
                pictureBox34.Image = Image.FromFile(Convert.ToInt32(pictureBox34.Tag).ToString() + ".jpeg");
                pictureBox34.Enabled = false;
            }
            if (id1 == 35 || id2 == 35)
            {
                pictureBox35.Image = Image.FromFile(Convert.ToInt32(pictureBox35.Tag).ToString() + ".jpeg");
                pictureBox35.Enabled = false;
            }
            if (id1 == 36 || id2 == 36)
            {
                pictureBox36.Image = Image.FromFile(Convert.ToInt32(pictureBox36.Tag).ToString() + ".jpeg");
                pictureBox36.Enabled = false;
            }

        
        
        }



        public void Comparador2(PictureBox pb, PictureBox pc,int contador)
        {
            if (contador == 1)
            {
                pc.Tag = pb.Tag;
            }
            else
            {
                //tag2 = Convert.ToInt32(pb.Tag);
                if (Convert.ToInt32(pb.Tag) == Convert.ToInt32(pc.Tag))
                {
                    puntos = puntos + 1;
                    
                }
                else
                {
                    pb.Image = fondo;
                    pc.Image = fondo;
                    contador = 0;
                }
            }

        }





        private void AtenderServidor()
        {
            while (true)
            {
                byte[] msg2 = new byte[200];
                server.Receive(msg2);
                string mensaje1 = Encoding.ASCII.GetString(msg2).Split('\0')[0];

                string[] trozos = mensaje1.Split('/');
               
                

                    int codigo = Convert.ToInt32(trozos[0]);
                    string mensaje = trozos[1].Split('\0')[0];
                
               
                
               

                switch (codigo)
                {

                    case 1:
                        if (codigo == 1)
                        {


                            if (mensaje == "SI,")
                            {
                                MessageBox.Show("Acceso a la aplicación");
                                textBox5.Show();
                                radioButton1.Show();
                                radioButton2.Show();
                                radioButton3.Show();
                                button5.Show();
                                button7.Show();
                                button8.Show();
                                Crear_Partida.Show();

                                button3.Hide();
                                label3.Hide();
                                label1.Hide();
                                textBox1.Hide();
                                label2.Hide();
                                textBox2.Hide();
                                button2.Hide();
                                button1.Hide();
                                



                            }
                            else if (mensaje == "NO,")
                            {
                                MessageBox.Show("Acceso denegado. Revise los parámetros de entrada o regístrese");
                            }
                        }
                        break;

                    case 2:
                        if (codigo == 2)
                        {




                            if (mensaje == "SI,")
                            {
                                MessageBox.Show("Registrado correctamente");


                            }
                            else if (mensaje == "NO,")
                            {
                                MessageBox.Show("No se ha podido registrar");
                            }
                        }
            break;
                    case 3:
            if (codigo == 3)
            {
                MessageBox.Show("El jugador ganador de esta fecha es:" + mensaje);
            }
            break;
                    case 4:
            if (codigo == 4)
            {
                if (mensaje == "NO")
                {
                    MessageBox.Show("No existe ningún jugador con este nombre");

                }
                else
                {
                    MessageBox.Show("Puntuación total del jugador:" + mensaje);

                }
            }
            break;
                    case 5:
            if (codigo == 5)
            {
                if (mensaje == "NO")
                {
                    MessageBox.Show("No existe ningún jugador con este nombre");

                }
                else
                {
                    MessageBox.Show("Fecha y hora:" + mensaje);

                }
            }
            break;
                    case 6:
            if (codigo == 6)
            {
                string[] trozos2 = mensaje.Split('-');
                //if (trozos2[0] != "")
               // {
                    Conectados.RowCount = trozos2.Length - 1;
                    Conectados.Columns[0].HeaderText = "Conectados";

                    int i = 1;
                    while (i < trozos2.Length)
                    {
                        Conectados[0, i - 1].Value = trozos2[i];
                        i++;

                    }
              //  }
            }
            break;
                    case 7:
            if (codigo == 7)
            {
                textBox5.Hide();

                radioButton1.Hide();
                radioButton2.Hide();
                radioButton3.Hide();
                button7.Hide();
                button5.Hide();
                button8.Hide();

                label1.Show();
                textBox1.Show();
                label2.Show();
                textBox2.Show();
                button2.Show();
                button1.Show();
            }
            break;
                    case 8:
            if (codigo == 8)
            {
                int not = Convert.ToInt32(mensaje);
                if (not == 0)
                {
                    MessageBox.Show("Han rechazado tu invitación");
                }
                else if(not == 1)
                {

                    MessageBox.Show("invitacion aceptada");
                   
                    button12.Show();
                   // string pos2 = String.Join(",", pos);
                   // string mensaje2 = "20/" + pos2;
                   // byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje2);
                   // server.Send(msg);

                    //string mensaje3 = "12/" + pos2;
                   // byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje2);
                   // server.Send(msg);


                }
                



            }
            break;

                    case 9:
            if (codigo == 9)
            {
                Invitacion.Show();
                string[] trozos3 = mensaje.Split('-');
                string[] mensajePos2 = trozos3[1].Split(',');
                IDjugador = Convert.ToInt32(trozos3[2]);
                MessageBox.Show(mensaje);

                int t = 0;
                while (t < 36)
                {
                    pos[t] = Convert.ToInt32(mensajePos2[t]);
                    t++;

                    label6.Text = trozos3[0] + " te ha invitado";
                    invitador = trozos3[0];
                }
            }
            break;
                    
                    case 10:
            if (codigo == 10)
            {

                listBox1.Invoke(new DelegadoParaEscribirAlChat(Chat), new object[] { mensaje });
            }
            break;
                    case 11:
                        

            break;
                    case 12:
            IDjugador = Convert.ToInt32(mensaje);
            MessageBox.Show("Su ID de partida es:"+ IDjugador.ToString());


            
                        
                        
            break;
                    case 13:
            IDturno = Convert.ToInt32(mensaje);
            if (IDturno == IDjugador)
            {
                label8.Show();

            }
            else {
                label8.Hide();
            
            }


            break;


                    
                    
                    
                    
                    
                    case 20:

            MessageBox.Show(mensaje);
           string [] mensajePos = mensaje.Split(',');
           int m = 0;
           while (m < 36) {
               pos[m] = Convert.ToInt32(mensajePos[m]);
               m++;
           
           }

            break;
                    case 21:
            string[] mensajeID = mensaje.Split(',');
                        int ID1 = Convert.ToInt32(mensajeID[0]); 
                        int ID2 = Convert.ToInt32(mensajeID[1]);
                        puntos = Convert.ToInt32(mensajeID[3]);
                        Acertado(ID1, ID2);
                        label7.Text = puntos.ToString();
            
                



            break;

                }
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            IPAddress direc = IPAddress.Parse("147.83.117.22");//192.168.56.102 147.83.117.22
            IPEndPoint ipep = new IPEndPoint(direc, 50030);
            

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");

            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }
            ThreadStart ts = delegate { AtenderServidor(); };
            atender = new Thread(ts);
            atender.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Show();
            textBox3.Show();
            label4.Show();
            textBox4.Show();
            button4.Show();
            button6.Show();

            button3.Hide();
            label1.Hide();
            textBox1.Hide();
            label2.Hide();
            textBox2.Hide();
            button2.Hide();
            button1.Hide();

            


            
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            invitador = textBox1.Text;
            usuario = textBox1.Text;

            string mensaje = "1/" + textBox1.Text + "/" + textBox2.Text + "";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
           

           
           
            
           // this.BackColor = Color.Gray;
            //server.Shutdown(SocketShutdown.Both);
            //server.Close();
        }

        private void Entrar_Load(object sender, EventArgs e)
        {
           
            label3.Hide();
            textBox3.Hide();
            label4.Hide();
            textBox4.Hide();
            button4.Hide();
            button6.Hide();
            button5.Hide();
            button7.Hide();
            button8.Hide();
            
            
            textBox5.Hide();

            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            button5.Hide();
            
          
            pictureBox1.Image = fondo;
            pictureBox2.Image = fondo;
            pictureBox3.Image = fondo;
            pictureBox4.Image = fondo;
            pictureBox5.Image = fondo;
            pictureBox6.Image = fondo;
            pictureBox7.Image = fondo;
            pictureBox8.Image = fondo;
            pictureBox9.Image = fondo;
            pictureBox10.Image = fondo;
            pictureBox11.Image = fondo;
            pictureBox12.Image = fondo;
            pictureBox13.Image = fondo;
            pictureBox14.Image = fondo;
            pictureBox15.Image = fondo;
            pictureBox16.Image = fondo;
            pictureBox17.Image = fondo;
            pictureBox18.Image = fondo;
            pictureBox19.Image = fondo;
            pictureBox20.Image = fondo;
            pictureBox21.Image = fondo;
            pictureBox22.Image = fondo;
            pictureBox23.Image = fondo;
            pictureBox24.Image = fondo;
            pictureBox25.Image = fondo;
            pictureBox26.Image = fondo;
            pictureBox27.Image = fondo;
            pictureBox28.Image = fondo;
            pictureBox29.Image = fondo;
            pictureBox30.Image = fondo;
            pictureBox31.Image = fondo;
            pictureBox32.Image = fondo;
            pictureBox33.Image = fondo;
            pictureBox34.Image = fondo;
            pictureBox35.Image = fondo;
            pictureBox36.Image = fondo;
            Shuffle(pos);

            Invitacion.Hide();
           // button11.Hide();
            //button12.Hide();
            Invita.Hide();
            listBox1.Hide();
            textBox6.Hide();
            button9.Hide();
            Crear_Partida.Hide();
            label8.Hide();


           





        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mensaje = "2/" + textBox3.Text + "/" + textBox4.Text + "";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);


           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Show();
            textBox1.Show();
            label2.Show();
            textBox2.Show();
            button2.Show();
            button1.Show();

            label3.Hide();
            textBox3.Hide();
            label4.Hide();
            textBox4.Hide();
            button4.Hide();
            button6.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string mensaje = "3/" + textBox5.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);


               
               

            }
            if (radioButton2.Checked)
            {
                string mensaje = "4/" + textBox5.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);


                

             

            }
            if (radioButton3.Checked)
            {
                string mensaje = "5/" + textBox5.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);


               


             

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string mensaje = "7/" + textBox1.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);


           
            
            
            
            textBox5.Hide();

            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            button7.Hide();
            button5.Hide();
            button8.Hide();

            label1.Show();
            textBox1.Show();
            label2.Show();
            textBox2.Show();
            button2.Show();
            button1.Show();


        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            string mensaje = "6/" ;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);    

          
          


            //MessageBox.Show( "Estos son los usuarios conectados: "+ mensaje);


        }
        
        // private void Actualiza_Grid(string mensaje)
            //actualiza lista de conectados cada vez que se conecte un usuario
        // {
           //  Conectados.ColumnCount = 1;
           //  Conectados.RowCount = numero_conectados;
          //   Conectados.Columns[0].HeaderText = "\r\n conectados";

          //   conectados = mensaje.Split(',');

          //   for (int i = 0; i < numero_conectados; i++)
          //       Conectados.Rows[i].Cells[0].Value = conectados[i];
        //  }
        
        private void Invitacion_lbl(string mensaje)
        {
            this.label6.Text = mensaje + " te ha invitado";
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            string mensaje = "8/" + invitador +"/"+ usuario + "/1";
            
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);



            
            button12.Show();
            listBox1.Show();
            textBox6.Show();
            button9.Show();
        }

        private void Rechazar_Click(object sender, EventArgs e)
        {
            string mensaje = "8/" + invitador + "/" + usuario + "/0";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            Invitacion.Hide();
        }

        private void Invitar_Click(object sender, EventArgs e)
        {
            if (nombre_invitado.Text != "")
            {
                string pos2 = String.Join(",", pos);

                string mensaje = "9/" + nombre_invitado.Text +"/"+pos2;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

               // MessageBox.Show(mensaje);


                
            }
            else {
                MessageBox.Show("No ha invitado a nadie");
            
            
            }
        }

        private void Invitacion_Enter(object sender, EventArgs e)
        {

        }

        private void Chat(string mensaje)
        {

            this.listBox1.Items.Add(mensaje);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text != null)
                {
                    string mensaje = "10/" + textBox6.Text;
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);
                    textBox6.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Escribe un mensaje");
                }
            }
            catch
            {
                MessageBox.Show("Error al enviar mensaje");
            }
        }

        private void Crear_Partida_Click(object sender, EventArgs e)
        {
            string mensaje = "12/" + invitador;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            Invita.Show();
            listBox1.Show();
            textBox6.Show();
            button9.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
                //label7.Text = pos.Length.ToString();
                contador++;
                int i = Convert.ToInt32(pictureBox1.Tag);

                string nombrefichero = i.ToString() + ".jpeg";
               
                pictureBox1.Image = Image.FromFile(nombrefichero);
                seleccionarTag(pictureBox1, 1);

            }
           
            
            
            
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
                contador++;

                int i = Convert.ToInt32(pictureBox2.Tag);

                string nombrefichero = i.ToString() + ".jpeg";
               
                pictureBox2.Image = Image.FromFile(nombrefichero);
                seleccionarTag(pictureBox2, 2);
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox3.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox3.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox3, 3);
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox4.Tag);
            
            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox4.Image = Image.FromFile(nombrefichero);
            label7.Text = Convert.ToString(i);
            seleccionarTag(pictureBox4, 4);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox5.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox5.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox5, 5);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox6.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox6.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox6, 6);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox7.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
           
            pictureBox7.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox7, 7);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox8.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox8.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox8, 8);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox9.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox9.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox9, 9);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox10.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
          
            pictureBox10.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox10, 10);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox11.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
           
            pictureBox11.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox11, 11);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox12.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox12.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox12, 12);
            }
        }
        
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox13.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
          
            pictureBox13.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox13, 13);
            }
            
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox14.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox14.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox14, 14);
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox15.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox15.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox15, 15);
            }
            
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox16.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox16.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox16, 16);
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox17.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox17.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox17, 17);
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox18.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
           
            pictureBox18.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox18, 18);
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox19.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
         
            pictureBox19.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox19, 19);
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox20.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox20.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox20, 20);
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox21.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox21.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox21, 21);
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox22.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
           
            pictureBox22.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox22, 22);
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox23.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
          
            pictureBox23.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox23, 23);
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox24.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox24.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox24, 24);
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox25.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox25.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox25, 25);
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox26.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
           
            pictureBox26.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox26, 26);
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox27.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
         
            pictureBox27.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox27, 27);
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox28.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
          
            pictureBox28.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox28, 28);
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox29.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
     
            pictureBox29.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox29, 29);
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox30.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
       
            pictureBox30.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox30, 30);
            }
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox31.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
          
            pictureBox31.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox31, 31);
            }
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox32.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
          
            pictureBox32.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox32, 32);
            }
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox33.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
           
            pictureBox33.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox33, 33);
            }
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox34.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
            
            pictureBox34.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox34, 34);
            }
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox35.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
           
            pictureBox35.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox35, 35);
            }
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            if (IDjugador == IDturno)
            {
            contador++;
            int i = Convert.ToInt32(pictureBox36.Tag);

            string nombrefichero = i.ToString() + ".jpeg";
           
            pictureBox36.Image = Image.FromFile(nombrefichero);
            seleccionarTag(pictureBox36, 36);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tim++;
           // label7.Text = tim.ToString();
           
            if (tim <= 1)
            {
                //label7.Text = tim.ToString();
                mientrasTimer(n1, n2);

            }
            else {
                timer1.Stop();
                tim = 0;
                int res = Comparador(tg1,tg2,puntos,n1,n2);
                if (res == 0)
                {
                    despuesTimer(n1, n2);
                }
            
            }
           
           
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //string[] test = { "Hello", "World" };
            //string result = String.Join(",",test);
            string pos2 = String.Join(",", pos);  
            string mensaje = "20/" + pos2 ;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            
            

        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox1.Tag = pos[0];
            pictureBox2.Tag = pos[1];
            pictureBox3.Tag = pos[2];
            pictureBox4.Tag = pos[3];
            pictureBox5.Tag = pos[4];
            pictureBox6.Tag = pos[5];
            pictureBox7.Tag = pos[6];
            pictureBox8.Tag = pos[7];
            pictureBox9.Tag = pos[8];
            pictureBox10.Tag = pos[9];
            pictureBox11.Tag = pos[10];
            pictureBox12.Tag = pos[11];
            pictureBox13.Tag = pos[12];
            pictureBox14.Tag = pos[13];
            pictureBox15.Tag = pos[14];
            pictureBox16.Tag = pos[15];
            pictureBox17.Tag = pos[16];
            pictureBox18.Tag = pos[17];
            pictureBox19.Tag = pos[18];
            pictureBox20.Tag = pos[19];
            pictureBox21.Tag = pos[20];
            pictureBox22.Tag = pos[21];
            pictureBox23.Tag = pos[22];
            pictureBox24.Tag = pos[23];
            pictureBox25.Tag = pos[24];
            pictureBox26.Tag = pos[25];
            pictureBox27.Tag = pos[26];
            pictureBox28.Tag = pos[27];
            pictureBox29.Tag = pos[28];
            pictureBox30.Tag = pos[29];
            pictureBox31.Tag = pos[30];
            pictureBox32.Tag = pos[31];
            pictureBox33.Tag = pos[32];
            pictureBox34.Tag = pos[33];
            pictureBox35.Tag = pos[34];
            pictureBox36.Tag = pos[35];
            if (IDjugador == IDturno) {
                label8.Show();
            
            
            }

        }

        private void Invita_Enter(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string mensaje = "12/" + invitador;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

       
        
        

        


       




        

        
    }
}

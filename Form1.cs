using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhofinal
{

    public partial class Form1 : Form
    {
        public static bool andar1 = false;
        public static bool andar2 = false;
        public static bool andar3 = false;
        public static bool andar4 = false;
        public static bool andar5 = false;
        public static bool andarem = false;

        public static bool cb_m = false;
        public static bool cb_a = false;

        public static bool andar1s = false;
        public static bool andar2s = false;
        public static bool andar3s = false;
        public static bool andar4s = false;

        public static bool andar2d = false;
        public static bool andar3d = false;
        public static bool andar4d = false;
        public static bool andar5d = false;

        public static int logA = 1;
        public static int valorA = 1;
        public static int andaratt = 2;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        Elevador elevador;
        Task pisca;
        Task teste;
 
        public Form1()
        {
            InitializeComponent();
        }

        public Tuple<bool, bool, bool, bool, bool> sendAndar()
        {
            return Tuple.Create(andar1, andar2, andar3, andar4, andar5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.elevador = new Elevador();
            Console.WriteLine("código rodando....");
            this.pisca = new Task(elevador.receive);
            this.teste = new Task(changeColor);
            this.pisca.Start();
            this.teste.Start();

            log.Info("Aplicação iniciada.");
        }

        private void changeColor()
        {
            while (true)
            {
                // ------ Painel interno ------

                if (andar1 == false)
                {
                    btANDAR1.BackColor = Color.Green;
                }

                if (andar2 == false)
                {
                    btANDAR2.BackColor = Color.Green;
                }

                if (andar3 == false)
                {
                    btANDAR3.BackColor = Color.Green;
                }

                if (andar4 == false)
                {
                    btANDAR4.BackColor = Color.Green;
                }

                if (andar5 == false)
                {
                    btANDAR5.BackColor = Color.Green;
                }

                if (andarem == false)
                {
                    btANDARem.BackColor = Color.Orange;
                }

                // ------ Painel externo subir ------

                if (andar1s == false)
                {
                    bt1s.BackColor = Color.Blue;
                }

                if (andar2s == false)
                {
                    bt2s.BackColor = Color.Blue;
                }

                if (andar3s == false)
                {
                    bt3s.BackColor = Color.Blue;
                }

                if (andar4s == false)
                {
                    bt4s.BackColor = Color.Blue;
                }

                // --- Painel externo descer ---

                if (andar2d == false)
                {
                    bt2d.BackColor = Color.Blue;
                }

                if (andar3d == false)
                {
                    bt3d.BackColor = Color.Blue;
                }

                if (andar4d == false)
                {
                    bt4d.BackColor = Color.Blue;
                }

                if (andar5d == false)
                {
                    bt5d.BackColor = Color.Blue;
                }
                Thread.Sleep(100);
            }
        }

        // ----------- Apertar Botões -----------
        // ----------- Botões Internos ----------

        private void btANDAR1_Click(object sender, EventArgs e)
        {
            if(cb_m != cb_a)
            {
                andar1 = true;
                btANDAR1.BackColor = Color.Red;
            }
        }

        private void btANDAR2_Click(object sender, EventArgs e)
        {
            if(cb_m != cb_a)
            {
                andar2 = true;
                btANDAR2.BackColor = Color.Red;
            }
        }

        private void btANDAR3_Click(object sender, EventArgs e)
        {
            if (cb_m != cb_a)
            {
                andar3 = true;
                btANDAR3.BackColor = Color.Red;
            }

        }

        private void btANDAR4_Click(object sender, EventArgs e)
        {
            if (cb_m != cb_a)
            {
                andar4 = true;
                btANDAR4.BackColor = Color.Red;
            }

        }

        private void btANDAR5_Click(object sender, EventArgs e)
        {
            if (cb_m != cb_a)
            {
                andar5 = true;
                btANDAR5.BackColor = Color.Red;
            }

        }

        // ----------- Botões Internos ----------
        // ----------- Botões Subir ----------

        private void bt1s_Click(object sender, EventArgs e)
        {
            if(cb_m != cb_a)
            {
                if (cb_m == true)
                {
                    andar1 = true;
                    andar1s = true;
                    bt1s.BackColor = Color.Red;
                }
            }
        }

        private void bt2s_Click(object sender, EventArgs e)
        {
            if (cb_m != cb_a)
            {
                if (cb_m == true)
                {
                    andar2 = true;
                    andar2s = true;
                    bt2s.BackColor = Color.Red;
                }
            }
        }

        private void bt3s_Click(object sender, EventArgs e)
        {
            if (cb_m != cb_a)
            {
                if (cb_m == true)
                {
                    andar3 = true;
                    andar3s = true;
                    bt3s.BackColor = Color.Red;
                }
            }
        }

        private void bt4s_Click(object sender, EventArgs e)
        {
            if (cb_m != cb_a)
            {
                if (cb_m == true)
                {
                    andar4 = true;
                    andar4s = true;
                    bt4s.BackColor = Color.Red;
                }
            }
        }

        // ----------- Botões Internos ----------
        // ----------- Botões Descer ------------

        private void bt2d_Click(object sender, EventArgs e)
        {
            if (cb_m != cb_a)
            {
                if (cb_m == true)
                {
                    andar2 = true;
                    andar2d = true;
                    bt2d.BackColor = Color.Red;
                }
            }
        }

        private void bt3d_Click(object sender, EventArgs e)
        {
            if (cb_m != cb_a)
            {
                if (cb_m == true)
                {
                    andar3 = true;
                    andar3d = true;
                    bt3d.BackColor = Color.Red;
                }
            }
        }

        private void bt4d_Click(object sender, EventArgs e)
        {
            if (cb_m != cb_a)
            {
                if (cb_m == true)
                {
                    andar4 = true;
                    andar4d = true;
                    bt4d.BackColor = Color.Red;
                }
            }
        }

        private void bt5d_Click(object sender, EventArgs e)
        {
            if (cb_m != cb_a)
            {
                if (cb_m == true)
                {
                    andar5 = true;
                    andar5d = true;
                    bt5d.BackColor = Color.Red;
                }
            }
        }

        // ----------- Clear Botões ----------

        public void clearAndar1()
        {
            andar1 = false;
            andar1s = false;
        }

        public void clearAndar2()
        {
            andar2 = false;
            andar2s = false;
            andar2d = false;
        }

        public void clearAndar3()
        {
            andar3 = false;
            andar3s = false;
            andar3d = false;
        }

        public void clearAndar4()
        {
            andar4 = false;
            andar4s = false;
            andar4d = false;
        }

        public void clearAndar5()
        {
            andar5 = false;
            andar5d = false;
        }

        // ----------- Botão Emergência ----------

        private void button1_Click(object sender, EventArgs e)
        {
                andar1 = false;
                andar1s = false;
                andar2 = false;
                andar2s = false;
                andar2d = false;
                andar3 = false;
                andar3s = false;
                andar3d = false;
                andar4 = false;
                andar4s = false;
                andar4d = false;
                andar5 = false;
                andar5d = false;
                btANDARem.BackColor = Color.Red;
        }

        // ----------- Botão Check ----------
        // ----------- Manual ---------------

        private void cb_M_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_M.Checked)
            {
                cb_m = true;
            }
            else
            {
                cb_m = false;
            }
        }

        // ----------- Automático ----------

        private void cb_A_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_A.Checked)
            {
                cb_a = true;

            }
            else
            {
                cb_a = false;
            }
                       
        }

        private void tBandar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBs_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btA_Click(object sender, EventArgs e)
        {
            // ------ VISOR ANDAR ATUAL ------

            andaratt = Elevador.andar_atual;
            andaratt = andaratt - 1;
            tBandar.Text = andaratt.ToString();

            // ----- VISOR SITUAÇÃO ANDAR ------

            if (Elevador.target != Elevador.andar_atual)
            {
                if(Elevador.target > Elevador.andar_atual)
                {
                    tBs.Text = "SUBINDO";
                }
                else
                {
                    tBs.Text = "DESCENDO";
                }
            }
            else
            {
                tBs.Text = "PARADO";
            }

            if (cb_a == true)
            {

                
                // ----- Lógica Para Número Aleatório (1 a 5) ------

                Random logA = new Random();
                int valorA = logA.Next(1, 6);

            }
        }
    }

}

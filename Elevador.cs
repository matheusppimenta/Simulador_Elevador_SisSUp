using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace trabalhofinal
{
    internal class Elevador
    {
        Form1 form;
        public static bool andar1 = false;
        public static bool andar2 = false;
        public static bool andar3 = false;
        public static bool andar4 = false;
        public static bool andar5 = false;
        public static bool[] andares = new bool[5];
        public static int andar_atual = 1;
        public static double veolcidade = 0.25;

        public static bool movimento = false;
        public static bool subindo = false;
        public static bool descendo = false;
        public static int target = 1;


        public void receive()
        {   
            this.form = new Form1();
            

            while (true)
            {
                updateAndar();
                setTarget();
                checkElevator();
                clearForm();
                Console.WriteLine("target: " + target);
                Console.WriteLine("andar_atual: " + andar_atual);            
                Thread.Sleep(10);
            }

        }
        public void checkElevator()
        {   
            if (target != andar_atual)
            {
                if(target > andar_atual)
                {
                    subindo = true;
                    descendo = false;
                    andar_atual++;
                    Console.WriteLine("subindo elevador.....");
                    Thread.Sleep(2000);
                    
                } else
                {
                    subindo = false;
                    descendo = true;
                    andar_atual--;
                    Console.WriteLine("descendo elevador.....");
                    Thread.Sleep(2000);
                }
            } else
            {
                //andares[target - 1] = false;
            }
        }

        public void setTarget()
        {
            for(int i = 0; i < andares.Length; i++)
            {
                if(andares[i] == true)
                {
                    target = i + 1;
                }
            }
        }

        public void updateAndar()
        {
            Tuple<bool, bool, bool, bool, bool> recebido = form.sendAndar();
            Console.WriteLine(recebido);
            andares[0] = recebido.Item1;
            andares[1] = recebido.Item2;
            andares[2] = recebido.Item3;
            andares[3] = recebido.Item4;
            andares[4] = recebido.Item5;
        }
        
        public void clearForm()
        {
            if (andares[andar_atual-1] == true)
            {
                switch (andar_atual)
                {
                    case 1:
                        form.clearAndar1();                             
                        break;

                    case 2:
                        form.clearAndar2();
                        break;

                    case 3:
                        form.clearAndar3();
                        break;

                    case 4:
                        form.clearAndar4();
                        break;

                    case 5:
                        form.clearAndar5();
                        break;
                }
            }
        }
    }
}

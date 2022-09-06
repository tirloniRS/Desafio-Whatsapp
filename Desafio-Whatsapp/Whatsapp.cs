using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Whatsapp
{
    internal class Whatsapp
    {
        public List<Contatinho> contatinhos = new List<Contatinho>();
        public List<Mensagem> mensagens = new List<Mensagem>();    



        public void listarContatos()
        {
            foreach (Contatinho contatinho in contatinhos)
            {
                Console.WriteLine(contatinho.Nome + " " + contatinho.Celular);
            }
        }

        public void listarMensagens()
        {
            foreach (Mensagem msg in mensagens)
            {
                msg.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Whatsapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Whatsapp w = new Whatsapp();

            Contatinho cont = new Contatinho();
            cont.Nome = "Ana";
            cont.Celular = "998260243";

            w.contatinhos.Add(cont);

            Contatinho cont2 = new Contatinho();
            cont2.Nome = "Paula";
            cont2.Celular = "998260247";

            w.contatinhos.Add(cont2);

            MsgTexto mt = new MsgTexto();
            mt.Destinatario = cont;
            mt.Conteudo = "Boa noite!";

            w.mensagens.Add(mt);

            MsgTexto mt2 = new MsgTexto();
            mt2.Destinatario = cont2;
            mt2.Conteudo = "Olá, tudo bem?";

            w.mensagens.Add(mt2);

            w.listarContatos();
            w.listarMensagens();
            
        }
    }
}

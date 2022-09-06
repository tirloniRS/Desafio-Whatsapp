using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Whatsapp
{
    public abstract class Mensagem
    {
        public Contatinho Destinatario { get; set; }
        public string HoraEnvio { get; set; }
        public string Conteudo { get; set; }

        public void ToString()
        {
            Console.WriteLine("Destinatário: " + this.Destinatario.Nome + "Conteúdo: " + this.Conteudo);
        }
    }
}
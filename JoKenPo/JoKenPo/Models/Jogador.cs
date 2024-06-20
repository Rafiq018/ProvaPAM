using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo.Models
{
    public class Jogador
    {
        public string Nome { get; set; }
        public int Pontuacao { get; set; }
        public Escolha Escolha { get; set; }

        public void MakeChoice()
        {
            Escolha = (Escolha)new Random().Next(3);
        }
    }
}
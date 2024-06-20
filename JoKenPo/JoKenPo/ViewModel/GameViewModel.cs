using CommunityToolkit.Mvvm.ComponentModel;
using JoKenPo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo.ViewModels
{
    public partial class GameViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _nome;

        [ObservableProperty]
        private int _pontuacao;

        [ObservableProperty]
        private string _jogadorimg;

        [ObservableProperty]
        private string _inimigoimg;

        [ObservableProperty]
        private string _resultado;

        [ObservableProperty]
        private Escolha _EscolhaJogador;

        Jogador Jogador = new Jogador();

        public void Play()
        {
            Jogador enemy = new Jogador();
            enemy.MakeChoice();
            Jogador.Escolha = _EscolhaJogador;
            if (enemy.Escolha == Jogador.Escolha)
            {
                _resultado = "Empatou";
            }
        }

        public GameViewModel()
        {

        }
    }
}
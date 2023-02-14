using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OttoMicrowave.entities
{
    public class Microwave
    {
        public List<QuickMode> Modes  = new List<QuickMode>();
        public int Time { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public int Power { get; set; }
        public bool Working { get; set; }
        public QuickMode ActualMode { get; set; }

        public void CreationOfQuickModes()
        {
            QuickMode qm1 = new QuickMode { Name = "Pipoca", Food = "Pipoca (de micro-ondas)", code = "P" , Time = 180, Power = 7, Instruction = "Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento", Initial = true };
            QuickMode qm2 = new QuickMode { Name = "Leite", Food = "Leite", code = "L", Time = 300, Power = 5, Instruction = "Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras", Initial = true };
            QuickMode qm3 = new QuickMode { Name = "Carnes de boi", code = "C", Food = "Carne em pedaço ou fatias", Time = 840, Power = 4, Instruction = "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.", Initial = true };
            QuickMode qm4 = new QuickMode { Name = "Frango", code = "F", Food = "Frango (qualquer corte)", Time = 480, Power = 7, Instruction = "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.", Initial = true };
            QuickMode qm5 = new QuickMode { Name = "Feijão", code = "E", Food = "Feijão congelado", Time = 480, Power = 9, Instruction = " Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo pode perder resistência em altas temperaturas.", Initial = true };
            Modes.Add(qm1);
            Modes.Add(qm2);
            Modes.Add(qm3);
            Modes.Add(qm4);
            Modes.Add(qm5);
        }

        public Microwave()
        {

        }
    }
}

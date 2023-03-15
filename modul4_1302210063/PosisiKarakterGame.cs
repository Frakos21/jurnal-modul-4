using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302210063
{
    internal class PosisiKarakterGame
    {
        public enum stateKarakter {Jongkok, Berdiri, Tengkurap, Terbang }
        public enum Trigger { TombolW, TombolS, TombolX}

        public class game
        {
            public stateKarakter currentState = stateKarakter.Jongkok;
            public class Transition
            {
                public stateKarakter stateAwal;
                public stateKarakter stateAkhir;
                public Trigger trigger;

                public Transition(stateKarakter stateAwal, stateKarakter stateAkhir, Trigger trigger)
                {
                    this.stateAwal = stateAwal;
                    this.stateAkhir = stateAkhir;
                    this.trigger = trigger;
                }
            }
            Transition[] transisi =
            {
                new Transition(stateKarakter.Berdiri, stateKarakter.Terbang, Trigger.TombolW),
                new Transition(stateKarakter.Terbang, stateKarakter.Berdiri, Trigger.TombolS),
                new Transition(stateKarakter.Berdiri, stateKarakter.Jongkok, Trigger.TombolS),
                new Transition(stateKarakter.Jongkok, stateKarakter.Berdiri, Trigger.TombolW),
                new Transition(stateKarakter.Terbang, stateKarakter.Jongkok, Trigger.TombolX),
                new Transition(stateKarakter.Jongkok, stateKarakter.Tengkurap, Trigger.TombolS),
                new Transition(stateKarakter.Tengkurap, stateKarakter.Jongkok, Trigger.TombolW)

            };
            public stateKarakter nextState(stateKarakter stateAwal, Trigger trigger) {
                stateKarakter finalState = stateAwal;
                for(int i = 0;i<transisi.Length;i++)
                {
                    Transition temp = transisi[i];
                    if(stateAwal == temp.stateAwal && trigger == temp.trigger)
                    {
                        finalState = temp.stateAkhir;
                    }
                }
                return finalState;
            }
            public void activateTrigger(Trigger trigger)
            {
                
            }
        }
    }
}

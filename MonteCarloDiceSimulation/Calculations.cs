using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloDiceSimulation
{
    internal class Calculations
    {
        //private values for handling calculations
        private float diceSideTotal;
        private float diceSideAverage;
        private float diceRollTotal;
        private float diceRollAverage;
        private float diceRollSingleValue;
        private float diceRollSingleMax;

        //private values for handling user input
        private int diceSides;
        private int diceCount;
        private int simIterations;
        private bool isSaveResult;

        //public values for handling user input
        public int DiceSides { get => diceSides; set => diceSides = value; }
        public int DiceCount { get => diceCount; set => diceCount = value; }
        public int SimIterations { get => simIterations; set => simIterations = value; }
        public bool IsSaveResult { get => isSaveResult; set => isSaveResult = value; }

    }
}

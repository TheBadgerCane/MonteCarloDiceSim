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
        private int diceSideTotal;
        private int diceRollTotal;
        private float diceRollAverage;
        private int diceRollSingleValue;
        private int diceRollSingleMax;
        private List<int> diceRollResultsList = new List<int>();
        private Random rng = new Random();
        private SavingFiles save = new SavingFiles();

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

        private int SingleRoll()
        {
            diceRollResultsList.Clear();
            for (int i = 0; i < diceCount; i++)
            {
                diceRollSingleValue = rng.Next(1, diceSides + 1);
                diceRollResultsList.Add(diceRollSingleValue);
            }
            diceRollSingleMax = diceRollResultsList.Max();
            return diceRollSingleMax;
        }

        public float CalculateResult()
        {
            for (int i = 0; i < simIterations; i++)
            {
                diceRollTotal += SingleRoll();
            }
            diceRollAverage = (float)diceRollTotal / (float)simIterations;
            if (isSaveResult)
            {
                Task task = SavingFiles.SaveFileAsync(diceSides, diceCount, diceRollAverage, simIterations);
            }
            return diceRollAverage;
         }
    }
}

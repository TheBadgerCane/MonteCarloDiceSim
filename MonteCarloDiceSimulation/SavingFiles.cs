using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloDiceSimulation
{
    internal class SavingFiles
    {
        private static string[] consoleLines = {"The average roll result for a die with ",
                                         " sides, being rolled ",
                                         " times then chosing the highest roll, is: ",
                                         ". This result was obtained after simulating the experiment ",
                                         " times and calculating the average."};

        public static async Task SaveFileAsync(int sides, int count, float average, int iterations)
        {
            string finalOutputToFile = consoleLines[0] + sides + consoleLines[1] + count + consoleLines[2] + average + consoleLines[3] + iterations + consoleLines[4];
            await File.WriteAllTextAsync("DiceRollResult.txt", finalOutputToFile);
        }
    }
}

using System.IO;

namespace CMP1903_A1_2324
{
    public class Statistics
    {
        private string filePath = "statistics.txt"; // Path to the statistics file

        public void UpdateGameStatistics(string gameType, int plays, int highScore)
        {
            // Check if the statistics file exists
            if (!File.Exists(filePath))
            {
                // If not, create a new file and write header
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("GameType,Plays,HighScore");
                }
            }

            // Write game statistics to the file
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"{gameType},{plays},{highScore}");
            }
        }
    }
}
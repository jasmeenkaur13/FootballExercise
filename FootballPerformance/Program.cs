using FootballPerformance.ImportEngine;
using FootballPerformance.ProcessResults;
using System;

/// <summary>
/// namespace to hold all the component for the exercise
/// </summary>
namespace FootballPerformance
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method executed when the console app is initially started.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string continueAnswer = "y";
            do
            {
                try
                {
                    string filePath;
                    Console.WriteLine("Enter the Path of the file");
                    filePath = Console.ReadLine();
                    File72ByteImportEngine engine = new File72ByteImportEngine();
                    var results = engine.EvaluateFileContents(filePath);
                    string bestPermormerTeam = ProcessFileResult.GetBestPerformer(results);
                    Console.WriteLine("The team which have minimum difference of for and against goal is " + bestPermormerTeam);
                    Console.ReadLine();
                    Console.WriteLine("Do you wish to evaluate another file (y/n)");
                    continueAnswer = Console.ReadLine();

                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    Console.WriteLine("Do you wish to evaluate another file (y/n)");
                    continueAnswer = Console.ReadLine();
                }
            } while (continueAnswer.Trim().ToLower().Equals("y"));

        }
    }
}

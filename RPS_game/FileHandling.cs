using System;
using System.Collections.Generic;
using System.Text.Json;

namespace RPS_game;

   public static class JsonHelper
    {

    private static JsonSerializerOptions options = new JsonSerializerOptions
    {
        WriteIndented = true
    };

    public static void saveScores(string filePath, int points)
    {
        try
        {
            string directory = Path.GetDirectoryName("scoreboard.json");

            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var json = JsonSerializer.Serialize(points, options);
            File.WriteAllText(filePath, json);
        }catch(Exception e)
        {
            throw new Exception($"Error saving to JSON file: {e.Message}", e);
        }
    }

    //
    public static ScoreData loadScores(string filePath)
    {

        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("File does not exist!");
        }

        var json = File.ReadAllText(filePath);
        ScoreData scores = JsonSerializer.Deserialize<ScoreData>(json, options);

        if(scores == null)
        {
            throw new Exception("Deserialized scores are null");
        }

        return scores;
    }

        //string filePath = @"C:\Users\abril\source\repos\RPS_game\results.txt";

        //File.Create(filePath).Close();

        //if (File.Exists(filePath));
        //{
        //   // Console.WriteLine("File exists!");

        //    string[] lines = File.ReadAllLines(filePath);
        //    foreach (string line in lines)
        //    {
        //        Console.WriteLine(line);
        //    }
        //}
        //else { Console.WriteLine("Error with creating or reading file content"); }
        

    
    //public static void addWins()
    //{

    //    string test = "fish tacos";
    //    string filePath = @"C:\Users\abril\source\repos\RPS_game\results.txt";

    //    var text = new StringBuilder();
    //    foreach (string s in File.ReadAllLines(filePath))
    //    {
    //        text.AppendLine(s.Replace("Player: ", "Player: " + test));


    //    }
    //    using (var file = new StreamWriter(File.Create(filePath)))
    //    {
    //        file.Write(text.ToString());
    //    }

    }



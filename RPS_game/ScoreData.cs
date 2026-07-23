using System;
using System.Text.Json.Serialization;
public class ScoreData
{  public string userName
    { get; private set; }
    public int points
    { get; private set; }

    public ScoreData(string userName)
    {
        this.userName = userName; 
        points = 0;
    }

    public void AddPoint(int currentPoints)
    {
        points += currentPoints;
      
    }
}


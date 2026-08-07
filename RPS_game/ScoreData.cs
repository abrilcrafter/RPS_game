using System;
using System.Text.Json.Serialization;
public class ScoreData
{  public string userName
    { get; private set; }
    public int totalPoints
    { get; private set; }

    public ScoreData(string userName)
    {
        this.userName = userName;
        totalPoints = 0;
    }

    public void AddPoint()
    {
        totalPoints++;
      
    }
}


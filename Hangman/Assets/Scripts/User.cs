using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User
{
    public int totalWins;
    public int totalLosses;

    public int gamesPlayed;
    public float winRatio;
    public int fastestTime;

    public User(int totalWins, int totalLosses, int gamesPlayed, float winRatio, int fastestTime)
    {
        this.totalWins = totalWins;
        this.totalLosses = totalLosses;
        this.gamesPlayed = gamesPlayed;
        this.winRatio = winRatio;
        this.fastestTime = fastestTime;
    }


}

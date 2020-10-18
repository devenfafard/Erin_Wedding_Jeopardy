using System.Collections;
using System.Collections.Generic;

public class Player 
{
    private string name = null;
    private int score   = 0;

    public Player(string _name)
    {
        name = _name;
    }

    public void UpdateScore(int amount)
    {
        score += amount;
    }
}

/*
Added a level system where users gain 1 level at every 500 points 
and receive a Level up alert when the user reach a new level. I 
implemented this in GoalManager.cs within DisplayPlayerInfo() and RecordEvent().
*/
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
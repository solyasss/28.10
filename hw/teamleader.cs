using System;

public class TeamLeader : IWorker
{
    public void work(House house)
    {
        Console.WriteLine("Team leader has arrived...");
        Console.WriteLine("Team leader: Completed so far: " + house.get_status());

    }
}
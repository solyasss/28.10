using System;
using System.Collections;

public class Team
{
    private ArrayList workers;

    public Team()
    {
        workers = new ArrayList();
        workers.Add(new Worker("Max"));
        workers.Add(new Worker("Oleg"));
        workers.Add(new Worker("Kirill"));
        workers.Add(new Worker("Danny"));
        workers.Add(new TeamLeader());
    }

    public void build_house(House house)
    {
        int step = 0;
        foreach (IWorker worker in workers)
        {
            worker.work(house);
            step++;
            
            if (step % 4 == 0 && !house.ready()) // создаю репорт каждые 4 шага
            {
                TeamLeader leader = new TeamLeader();
                leader.work(house);
            }
            
            if (house.ready())
            {
                Console.WriteLine("Team leader: Your house is ready!");
                display_house();
                break;
            }
        }
    }

    private void display_house()
    {
        Console.WriteLine("           ■■■■■■■■■■■");
        Console.WriteLine("          ■           ■");
        Console.WriteLine("         ■             ■");
        Console.WriteLine("        ■               ■");
        Console.WriteLine("       ■■■■■■■■■■■■■■■■■■");
        Console.WriteLine("       ■      ■■      ■");
        Console.WriteLine("       ■      ■■      ■");
        Console.WriteLine("       ■  ■■■■■■■■■■  ■");
        Console.WriteLine("       ■  ■        ■  ■");
        Console.WriteLine("       ■  ■        ■  ■");
        Console.WriteLine("       ■  ■  ■■    ■  ■");
        Console.WriteLine("       ■  ■  ■■    ■  ■");
        Console.WriteLine("       ■■■■■■■■■■■■■■■■");
    }
}
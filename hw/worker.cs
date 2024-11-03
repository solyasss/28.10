using System;

public class Worker : IWorker
{
    private string name;

    public Worker(string name)
    {
        this.name = name;
    }

    public void work(House house)
    {
        if (!house.get_basement().constructed)
        {
            Console.WriteLine($"Worker {name}: Currently building the basement");
            house.get_basement().build();
        }
        else
        {
            foreach (var wall in house.get_walls())
            {
                if (!wall.constructed)
                {
                    Console.WriteLine($"Worker {name}: Currently building a wall");
                    wall.build();
                    return;
                }
            }

            if (!house.get_door().constructed)
            {
                Console.WriteLine($"Worker {name}: Currently building the door");
                house.get_door().build();
            }
            else
            {
                foreach (var window in house.get_windows())
                {
                    if (!window.constructed)
                    {
                        Console.WriteLine($"Worker {name}: Currently building a window");
                        window.build();
                        return;
                    }
                }

                if (!house.get_roof().constructed)
                {
                    Console.WriteLine($"Worker {name}: Currently building the roof");
                    house.get_roof().build();
                }
            }
        }
    }
}
using System;

namespace hw;
public class Program
{
    public static void Main()
    {
        House house = new House();
        Team team = new Team();

        try
        {
            while (!house.ready())
            {
                team.build_house(house);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}



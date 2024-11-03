using System;

public class House
{
    private Basement basement;
    private Wall[] walls;
    private Door door;
    private Window[] windows;
    private Roof roof;

    public House()
    {
        basement = new Basement();
        walls = new Wall[4] { new Wall(), new Wall(), new Wall(), new Wall() };
        door = new Door();
        windows = new Window[4] { new Window(), new Window(), new Window(), new Window() };
        roof = new Roof();
    }

    public Basement get_basement()
    {
        return basement;
    }

    public Wall[] get_walls()
    {
        return walls;
    }

    public Door get_door()
    {
        return door;
    }

    public Window[] get_windows()
    {
        return windows;
    }

    public Roof get_roof()
    {
        return roof;
    }

    public bool ready()
    {
        return basement.constructed && 
               walls[0].constructed && walls[1].constructed && 
               walls[2].constructed && walls[3].constructed &&
               door.constructed &&
               windows[0].constructed && windows[1].constructed &&
               windows[2].constructed && windows[3].constructed &&
               roof.constructed;
    }

    public string get_status()
    {
        string status = "";
        if (basement.constructed) status += "basement, ";
        int walls_built = counts(walls);
        if (walls_built > 0) status += $"wall({walls_built}), ";
        if (door.constructed) status += "door, ";
        int windows_built = counts(windows);
        if (windows_built > 0) status += $"window({windows_built}), ";
        if (roof.constructed) status += "roof";
        return status.TrimEnd(',', ' ');
    }

    private int counts(IPart[] parts)
    {
        int count = 0;
        foreach (var part in parts)
        {
            if (part.constructed) count++;
        }
        return count;
    }
    
}

public class Basement : IPart
{
    public bool constructed { get; set; } = false;

    public void build()
    {
        constructed = true;
    }
}

public class Wall : IPart
{
    public bool constructed { get; set; } = false;

    public void build()
    {
        constructed = true;
    }
}

public class Door : IPart
{
    public bool constructed { get; set; } = false;

    public void build()
    {
        constructed = true;
    }
}

public class Window : IPart
{
    public bool constructed { get; set; } = false;

    public void build()
    {
        constructed = true;
    }
}

public class Roof : IPart
{
    public bool constructed { get; set; } = false;

    public void build()
    {
        constructed = true;
    }
}
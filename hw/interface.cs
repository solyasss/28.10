using System;
public interface IPart
{
    bool constructed { get; set; }
    void build();
}

public interface IWorker
{
    void work(House house);
}
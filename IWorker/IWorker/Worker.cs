using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IWork
{
    void Work();
}
public interface IEat
{
    void Eat();
}

public class HumanWorker : IWork, IEat
{
    public void Work()
    {
        Console.WriteLine("Human working...");
    }


    public void Eat()
    {
        Console.WriteLine("Human eating...");
    }
}


public class RobotWorker : IWork
{
    public void Work()
    {
        Console.WriteLine("Robot working...");
    }
}

public class WorkerHandling
{
    private List<IWork> _workers;
    public WorkerHandling(List<IWork> workers)
    {
        _workers = workers;
    }

    public void HandleWorkers()
    {
        foreach (var worker in _workers)
        {
            worker.Work();
        }
    }
}
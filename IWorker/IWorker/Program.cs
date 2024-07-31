using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<IWork> work = new List<IWork>()
        {
            new HumanWorker(),
            new RobotWorker()
        };

        WorkerHandling handling = new WorkerHandling(work);
        handling.HandleWorkers();

        List<IEat> eat = new List<IEat>()
        {
            new HumanWorker()
        };

        foreach (var worker in eat)
        {
            worker.Eat();
        }
    }
}
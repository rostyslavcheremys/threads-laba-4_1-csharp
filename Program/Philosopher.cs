namespace Program;

class Philosopher
{
    private readonly int _id;
    private readonly int _leftFork;
    private readonly int _rightFork;
    
    private readonly Table _table;

    public Philosopher(int id, Table table)
    {
        _id = id;
        _table = table;

        if (id == 0)
        {
            _leftFork = id;
            _rightFork = (id + 1) % 5;
        }
        else
        {
            _rightFork = id;
            _leftFork = (id + 1) % 5;
        }

        Thread thread = new Thread(Run);
        thread.Start();
    }

    void Run()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Philosopher {_id} is thinking {i + 1} times");
            _table.GetFork(_rightFork);
            _table.GetFork(_leftFork);
            
            Console.WriteLine($"Philosopher {_id} is eating {i + 1} times");
            _table.PutFork(_leftFork);
            _table.PutFork(_rightFork);
        }
    }
}
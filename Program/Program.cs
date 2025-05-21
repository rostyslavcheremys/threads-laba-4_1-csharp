namespace Program;

static class Program
{
    static void Main()
    {
        Table table = new Table();
        
        for (int i = 0; i < 5; i++)
        {
            new Philosopher(i, table);
        }
    }
}
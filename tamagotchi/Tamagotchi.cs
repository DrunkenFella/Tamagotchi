namespace Namespace;
public class bobby
{

    private int hunger = 0;
    private int boredom = 40;
    private List<string> words = new List<string>() { "Hello there" };
    private bool isAlive = true;
    private bool mood = true;

    private Random generator;

    public List<string> name;


    public void Feed()
    {
        Console.WriteLine($" {name} is now less hungry");
        hunger -= 10;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }
    public void Hi()
    {
    }
    public void Teach()
    {

    }
    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 10)
        {
            isAlive = false;
        }
        if (boredom < 30)
        {
            mood = true;
        }
        else
        {
            mood = false;
        }
    }
    public void PrintStats()
    {

        if (mood == true)
        {
            Console.WriteLine($"{name} is happy || Hunger =  {hunger} || Boredom = {boredom} ");
        }
        else if (mood == false)
        {
            Console.WriteLine($"{name} is bored || Hunger =  {hunger} || Boredom = {boredom} ");
        }
    }
    public bool GetAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom()
    {
        Console.WriteLine($" {name} is now less bored!");

        boredom -= 2;
        if (boredom < 0)
        {
            boredom = 0;
        }

    }
}

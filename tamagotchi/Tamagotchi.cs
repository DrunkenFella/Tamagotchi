namespace Namespace;
public class Tama
{

    private int hunger = 0;
    private int boredom = 40;
    private List<string> words = new List<string>() { "Hello there" };
    private bool isAlive = true;
    private bool mood = true;

    private Random generator;

    public string name;


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
        int wordNum = generator.Next(words.Count);
        Console.WriteLine($" {name} says: {words}");

        ReduceBoredom();
    }
    public void Teach(string word)
    {
        Console.WriteLine($" {name} learns: {word}");
        words.Add(word);
        ReduceBoredom();

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
            Console.WriteLine($"{name} is happy || Hunger =  {hunger} /100 || Boredom = {boredom} /100 ");
        }
        else if (mood == false)
        {
            Console.WriteLine($"{name} is bored || Hunger =  {hunger} /100 || Boredom = {boredom} /100 ");
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

    public void game()
    {


        Console.WriteLine("Name your Tamagotchi!");
        name = Console.ReadLine();


        if (name == "Bobby")
        {
            Console.WriteLine($" {name} is a good fucking name. You have won even if Bobby dies. ");
        }
        else
        {
            Console.WriteLine($" {name} is a ugly fucking name. That was stupid ");
        }

        while (GetAlive() == true)
        {
            Console.Clear();
            PrintStats();
            Console.WriteLine("Now what do you want to do?");
            Console.WriteLine($"1. Teach {name} a bad word");
            Console.WriteLine($"2. Yell at {name}");
            Console.WriteLine($"3. Give {name} a nuckle sandwich");
            Console.WriteLine($"4. Ignore them");

            string doWhat = Console.ReadLine();
            if (doWhat == "1")
            {
                Console.WriteLine("What word?");
                string word = Console.ReadLine();

                Teach(word);
            }
            else if (doWhat == "2")
            {
                Hi();
            }
            else if (doWhat == "3")
            {
                Feed();
            }
            else if (doWhat == "4")
            {
                Console.WriteLine("Doing nothing...");
            }
            Tick();


            Console.Clear(); //efter varje val
        }

        Console.WriteLine($"ohno your stupid ass killed {name}. Well done dumbass");

        Console.WriteLine($"You failed to keep {name} alive [Press enter]");
        Console.ReadLine();
    }
}

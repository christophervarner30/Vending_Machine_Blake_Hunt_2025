namespace Vending_Machine_Blake_Hunt
{
    public class Program
    {
        static void Main(string[] args)
        {
            //functions
            //ListMethod.InitData
            //ListMethod.PrintAll
            //ListMethod.PrintOne
            //ListMethod.Add

            List<Item> Items = new List<Item>();
            ListMethods.InitData(Items);

            bool on = true;

            while (on)
            {
                bool mainmenu = true;
                bool add = false;
                if (mainmenu)
                {
                    Console.Clear();
                    Console.WriteLine("'/add' to add new item");
                    Console.WriteLine();
                    Console.WriteLine("Please Make a Selection");
                    Console.WriteLine();
                    ListMethods.PrintAll(Items);
                    string input = ("" + Console.ReadLine());

                    if (Convert.ToInt16(input) > 0 && Convert.ToInt16(input) < (Items.Count + 1))
                    {
                        Console.Clear();
                        ListMethods.PrintOne(Items, Convert.ToInt16(input));
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please input the ID of an available chip");
                        Console.ReadLine();
                    }

                    if (input == "/add")
                    {
                        mainmenu = false;
                        add = true;
                    }
                }

                if (add)
                {
                    Console.Clear();
                    Console.WriteLine("enter new item name");
                    string name = ("" + Console.ReadLine());

                    ListMethods.Add(Items, name);

                    add = false;
                    mainmenu = true;
                }
            }

        }
    }
}

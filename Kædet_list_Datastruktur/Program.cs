using Kædet_list_Datastruktur;

LinkedList Ll = new();
bool _exit = false;
do
{
    Console.WriteLine("Linked List Operations");
    Console.WriteLine("------------------------------");
    Console.WriteLine("1. Add a value");
    Console.WriteLine("2. Remove First");
    Console.WriteLine("3. Remove Element with value");
    Console.WriteLine("4. Show the list");
    Console.WriteLine("5. Sort the list");
    Console.WriteLine("6. Exit");

    int userChoice;
    if (int.TryParse(Console.ReadLine(), out userChoice))
    {
        switch (userChoice)
        {
            case 1:
                AddValue(Ll);
                break;
            case 2:
                Ll.Remove();
                break;
            case 3:
                RemoveSpecificValue(Ll);
                break;
            case 4:
                Console.WriteLine(Ll.To_String());
                break;
            case 5:
                break;
            case 6:
                _exit = true;
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }

} while (!_exit);

static void AddValue(LinkedList ll)
{
    bool continueAdding = true;
    do
    {
        Console.Write("Insert a value: ");
        object value = Console.ReadLine();
        Element element = new(value);

        ll.Add_first(element);

        Console.Write("Do you want to insert more values? (1 for Yes, 2 for No): ");
        int userContinue;
        if (int.TryParse(Console.ReadLine(), out userContinue))
        {
            continueAdding = (userContinue == 1);
        }
        else
        {
            Console.WriteLine("Invalid input. Stopping addition.");
            continueAdding = false;
        }

    } while (continueAdding);
}

static void RemoveSpecificValue(LinkedList ll)
{
    Console.Write("Insert a value to remove: ");
    object value = Console.ReadLine();
    ll.RemoveElementWithValue(value);

}












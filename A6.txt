public static void Q1_RandStats()
    {
        // Declaration
        int[] counts = new int[10];
        int numberCount = 0;
        Random rand = new Random();
        string choice = "";
        bool exit = false;

        while (!exit)
        {
            // Input
            Console.WriteLine("\n1. Assign New Set of Integers");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            // Processing
            if (choice == "1")
            {
                Console.Write("Enter the number of random numbers to generate: ");
                numberCount = int.Parse(Console.ReadLine());

                for (int i = 0; i < counts.Length; i++)
                    counts[i] = 0;

                for (int i = 0; i < numberCount; i++)
                    counts[rand.Next(10)]++;

                // Output
                Console.WriteLine($"\nGenerated {numberCount} random numbers.");
                for (int i = 0; i < counts.Length; i++)
                    Console.WriteLine($"{i}: {counts[i]} times");
            }
            else if (choice == "2")
            {
                exit = true;
                Console.WriteLine("Exiting Random Stats...");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }

    public static void Q2_GradeMngr()
    {
        // Declaration
        int[] grades = new int[15];
        int count = 0;
        int inputGrade = 0;
        string choice = "";
        bool exit = false;

        // Input
        Console.WriteLine("Enter up to 15 grades (-99 to stop early):");
        while (count < 15)
        {
            Console.Write($"Grade {count + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out inputGrade))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            if (inputGrade == -99)
            {
                if (count < 5)
                {
                    Console.WriteLine("You must enter at least 5 grades.");
                    continue;
                }
                break;
            }

            grades[count++] = inputGrade;
        }

        Array.Resize(ref grades, count);

        while (!exit)
        {
            // Input
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Number of values");
            Console.WriteLine("2. List the values");
            Console.WriteLine("3. Average");
            Console.WriteLine("4. Delete a specific value");
            Console.WriteLine("5. Change a specific value");
            Console.WriteLine("6. Add a value");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            // Processing + Output
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"There are {grades.Length} grades.");
                    break;
                case "2":
                    Console.WriteLine("Grades:");
                    foreach (int g in grades)
                        Console.WriteLine(g);
                    break;
                case "3":
                    double sum = 0;
                    foreach (int g in grades)
                        sum += g;
                    Console.WriteLine($"Average: {sum / grades.Length:F2}");
                    break;
                case "4":
                    Console.Write("Enter value to delete: ");
                    int del = int.Parse(Console.ReadLine());
                    int index = Array.IndexOf(grades, del);
                    if (index != -1)
                    {
                        int[] newGrades = new int[grades.Length - 1];
                        for (int i = 0, j = 0; i < grades.Length; i++)
                            if (i != index) newGrades[j++] = grades[i];
                        grades = newGrades;
                        Console.WriteLine("Value deleted.");
                    }
                    else Console.WriteLine("Value not found.");
                    break;
                case "5":
                    Console.Write("Enter index: ");
                    int idx = int.Parse(Console.ReadLine());
                    if (idx >= 0 && idx < grades.Length)
                    {
                        Console.Write("Enter new value: ");
                        grades[idx] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Value updated.");
                    }
                    else Console.WriteLine("Invalid index.");
                    break;
                case "6":
                    Console.Write("Enter new grade: ");
                    int add = int.Parse(Console.ReadLine());
                    int[] resized = new int[grades.Length + 1];
                    for (int i = 0; i < grades.Length; i++) resized[i] = grades[i];
                    resized[grades.Length] = add;
                    grades = resized;
                    Console.WriteLine("Value added.");
                    break;
                case "7":
                    exit = true;
                    Console.WriteLine("Exiting Grade Manager...");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    public static void Q3_DeckMngr()
    {
        // Declaration
        string[] deck = new string[52];
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] faces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        Random rand = new Random();
        bool exit = false;

        // Processing
        int index = 0;
        for (int i = 0; i < suits.Length; i++)
            for (int j = 0; j < faces.Length; j++)
                deck[index++] = $"{faces[j]} {suits[i]}";

        while (!exit)
        {
            Console.WriteLine("\nDeck Menu:");
            Console.WriteLine("1. Show current deck");
            Console.WriteLine("2. Shuffle deck");
            Console.WriteLine("3. Reset deck");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Current Deck:");
                    foreach (string card in deck)
                        Console.WriteLine(card);
                    break;
                case "2":
                    for (int i = 0; i < deck.Length; i++)
                    {
                        int r = rand.Next(deck.Length);
                        string temp = deck[i];
                        deck[i] = deck[r];
                        deck[r] = temp;
                    }
                    Console.WriteLine("Deck shuffled.");
                    break;
                case "3":
                    index = 0;
                    for (int i = 0; i < suits.Length; i++)
                        for (int j = 0; j < faces.Length; j++)
                            deck[index++] = $"{faces[j]} {suits[i]}";
                    Console.WriteLine("Deck reset.");
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Exiting Deck Manager...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    public static void Q4_ClassMngr()
    {
        // Declaration
        string[] students = new string[1] { "DEFAULT" };
        bool exit = false;

        while (!exit)
        {
            // Input
            Console.WriteLine("\nClass Manager Menu:");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Delete Student");
            Console.WriteLine("3. Reset List");
            Console.WriteLine("4. Show Students");
            Console.WriteLine("5. Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            // Processing + Output
            switch (choice)
            {
                case "1":
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();
                    string[] bigger = new string[students.Length + 1];
                    for (int i = 0; i < students.Length; i++)
                        bigger[i] = students[i];
                    bigger[students.Length] = name;
                    students = bigger;
                    Console.WriteLine("Student added.");
                    break;
                case "2":
                    Console.Write("Enter student name to delete: ");
                    string delName = Console.ReadLine();
                    int index = Array.IndexOf(students, delName);
                    if (index != -1)
                    {
                        string[] smaller = new string[students.Length - 1];
                        for (int i = 0, j = 0; i < students.Length; i++)
                            if (i != index) smaller[j++] = students[i];
                        students = smaller;
                        Console.WriteLine("Student deleted.");
                    }
                    else Console.WriteLine("Student not found.");
                    break;
                case "3":
                    students = new string[1] { "DEFAULT" };
                    Console.WriteLine("Class list reset.");
                    break;
                case "4":
                    Console.WriteLine("Students:");
                    foreach (string s in students)
                        Console.WriteLine(s);
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Exiting Class Manager...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

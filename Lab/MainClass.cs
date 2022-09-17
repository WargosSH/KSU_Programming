using System;
using System.Collections.Generic;

class MainClass
{
    public List<Human> mList = new List<Human>();
    public string settings =   "1 -- Add new Human\n" +
                        "2 -- Find All Humans by:\n" +
                        "\t1 -- Name\n" + 
                        "\t2 -- Surname\n" + 
                        "\t3 -- Age\n" + 
                        "\t4 -- Nation\n" + 
                        "\t5 -- Address\n" +
                        "9 -- Write this settings\n" +
                        "0 -- Exit";
    

     //////////////////////////////////////////////////////////
    static void Main()
    {
        MainClass mainClass = new MainClass();
        
        Console.WriteLine(mainClass.settings);
        mainClass.printLength("Humans", mainClass.mList);
        while(true)
        {
            Console.Write("Enter your query: ");

            int query = 0;
                query = Int32.Parse( Console.ReadLine() );
            switch (query)
            {
                case 1:
                    mainClass.mList.Add(new Human());
                    mainClass.printLength("Human", mainClass.mList);
                    break;

                case 2:
                    mainClass.FindQuery();
                    break;

                case 9:
                    Console.WriteLine(mainClass.settings);
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Invalid query!");
                    break;
            }
        }
    }
    
    //////////////////////////////////////////////////////////
    private void printList(List<Human> inList)
    {
        if(inList.Count == 0)
        {
            Console.WriteLine("Nothing founded");
            return;
        }

        foreach(Human item in inList)
            item.printInfo();
    }


    private void printLength(
        string nameOfList,
        List<Human> inList )
    {
        Console.WriteLine("\n\nNow " + nameOfList + " list have " + inList.Count.ToString() + " length.");
    }


    private Nation readEnum()
    {
        Nation result;

        string value = Console.ReadLine();
        switch (value)
        {
            case "Ukrainian":
                result = Nation.Ukrainian;
                break;

            case "French":
                result = Nation.French;
                break;

            case "Polish":
                result = Nation.Polish;
                break;
        
            default:
                result = Nation.Ukrainian;
                break;
        }

        return result;
    }


    //////////////////////////////////////////////////////////
    private void FindQuery()
    {
        Console.Write("Enter your query: ");
        int query2 = Int32.Parse( Console.ReadLine() );

        List<Human> findList = new List<Human>();
        switch (query2)
        {
            case 1:
                Console.Write("Enter Name: ");
                string value1 = Console.ReadLine();
                findList = findByName(value1);
                break;

            case 2:
                Console.Write("Enter Surname: ");
                string value2 = Console.ReadLine();
                findList = findBySurname(value2);
                break;

            case 3:
                Console.Write("Enter Age: ");
                int value3 = Int32.Parse(Console.ReadLine());
                findList = findByAge(value3);
                break;

            case 4:
                Nation value4 = readEnum();
                findList = findByNation(value4);
                break;

            case 5:
                Console.Write("Enter Street: ");
                string value5 = Console.ReadLine();
                findList = findByStreet(value5);
                break;

            default:
                Console.WriteLine("Invalid query!");
                break;
        }

        printLength("Find", findList);
        printList(findList);
    }


    //////////////////////////////////////////////////////////
    public List<Human> findByName(string inValue)
    {
        List<Human> result = new List<Human>();

        foreach(Human item in mList)
            if(item.Name == inValue)
                result.Add(item);

        return result;
    }


    public List<Human> findBySurname(string inValue)
    {
        List<Human> result = new List<Human>();

        foreach(Human item in mList)
            if(item.Surname == inValue)
                result.Add(item);

        return result;
    }


    public List<Human> findByAge(int inValue)
    {
        List<Human> result = new List<Human>();

        foreach(Human item in mList)
            if(item.Age == inValue)
                result.Add(item);

        return result;
    }


    public List<Human> findByNation(Nation inValue)
    {
        List<Human> result = new List<Human>();

        foreach(Human item in mList)
            if(item.Nation == inValue)
                result.Add(item);

        return result;
    }   


    public List<Human> findByStreet(string inValue)
    {
        List<Human> result = new List<Human>();

        foreach(Human item in mList)
            if(item.Address.Street == inValue)
                result.Add(item);

        return result;
    }
}
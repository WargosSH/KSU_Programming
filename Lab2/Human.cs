using System;
using System.Collections.Generic;

namespace @class
{
    enum Nation 
    { 
        Ukrainian, 
        French, 
        Polish 
    };


    //////////////////////////////////////////////////////////////
    class Human
    {
        protected string mName;
        protected string mSurname;
        protected int mAge;
        protected double mHeight;
        protected double mWeight;
        protected bool mHabbits;
        protected Nation mNation;
        protected Address mAddress;


        //////////////////////////////////////////////////////////
        public Human() 
        {
            inputInfo();
        }


        public Human( 
            string inName, 
            string inSurname, 
            int inAge, 
            double inHeight, 
            double inWeight, 
            bool inHabbits, 
            Nation inNation, 
            Address inAddress ) 
        {
            Initialize(inName, inSurname, inAge, inHeight, inWeight, inHabbits, inNation, inAddress);
        }


        public Human( int a ) 
        {
            inputInfo();
        } 
        
        public static Human operator +(Human one, Human two)
        {
            Human result = new Human();
            result.mAge = one.mAge + two.mAge;
            result.mHabbits = one.mHabbits && two.mHabbits;

            return result;
        }


        public static bool operator >(Human one, Human two)
        {
            bool result = one.mAge > two.mAge;

            return result;
        }


        public static bool operator <(Human one, Human two)
        {
            bool result = one.mAge < two.mAge;

            return result;
        }


        private void Initialize( 
            string inName, 
            string inSurname, 
            int inAge, 
            double inHeight, 
            double inWeight, 
            bool inHabbits, 
            Nation inNation, 
            Address inAddress ) 
        {
            this.mName = inName;
            this.mSurname = inSurname;
            this.mAge = inAge;
            this.mHeight = inHeight;
            this.mWeight = inWeight;
            this.mHabbits = inHabbits;
            this.mNation = inNation;
            this.mAddress = inAddress;
        }


        //////////////////////////////////////////////////////////
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


        public virtual void printInfo() 
        {
            string data = 
                "Name: " + this.mName + "\n" +
                "Surname: " + this.mSurname + "\n" +
                "Age: " + this.mAge.ToString() + "\n" +
                "Height: " + this.mHeight.ToString() + "\n" +
                "Weight: " + this.mWeight.ToString() + "\n" +
                "Is Habbits: " + this.mHabbits.ToString() + "\n" +
                "Nation: " + this.mNation.ToString() + "\n" +
                "Address: " + this.mAddress.toString();

            Console.WriteLine( data );
        }


        public string getInfo() 
        {
            return 
                "Name: " + this.mName + "\n" +
                "Surname: " + this.mSurname + "\n" +
                "Age: " + this.mAge.ToString() + "\n" +
                "Height: " + this.mHeight.ToString() + "\n" +
                "Weight: " + this.mWeight.ToString() + "\n" +
                "Is Habbits: " + this.mHabbits.ToString() + "\n" +
                "Nation: " + this.mNation.ToString() + "\n" + 
                "Address: " + this.mAddress.toString();
        }


        public void inputInfo() 
        {
            //////////////////////////////////////////////////////
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();


            Console.Write("Age: ");
            int age = Int32.Parse( Console.ReadLine() );
            Console.Write("Height: ");
            double height = Double.Parse( Console.ReadLine() );
            Console.Write("Weight: ");
            double weight = Double.Parse( Console.ReadLine() );


            Console.Write("Habbits: ");
            bool habbits = Boolean.Parse( Console.ReadLine() );


            //////////////////////////////////////////////////////
            Console.Write("Nation (Ukrainian, French, Polish): ");
            Nation nation = readEnum();


            //////////////////////////////////////////////////////
            Address address = new Address();


            //////////////////////////////////////////////////////
            Initialize(name, surname, age, height, weight, habbits, nation, address);
        }

        
        //////////////////////////////////////////////////////////
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }


        public string Surname 
        {
            get { return mSurname; }
            set { mSurname = value; }
        }


        public int Age 
        {
            get { return mAge; }
            set { mAge = value; }
        }


        public double Height 
        {
            get { return mHeight; }
            set { mHeight = value; }
        }


        public double Weight 
        {
            get { return mWeight; }
            set { mWeight = value; }
        }


        public bool Habbits 
        {
            get { return mHabbits; }
            set { mHabbits = value; }
        }


        public Nation Nation 
        {
            get { return mNation; }
            set { mNation = value; }
        }


        public Address Address 
        {
            get { return mAddress; }
            set { mAddress = value; }
        }
    }
}
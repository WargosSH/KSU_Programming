class Address 
{
    private string mCountry;
    private string mCity;
    private string mStreet;
    private int mHouse;


    public Address()
    {
        readAddress();
    }


    public Address( 
        string country, 
        string city, 
        string street, 
        int house ) 
    {
        Initialize(country, city, street, house);
    }


    private void Initialize( 
        string country, 
        string city, 
        string street, 
        int house ) 
    {
        this.mCountry = country;
        this.mCity = city;
        this.mStreet = street;
        this.mHouse = house;
    }


    public void readAddress()
    {
        Console.Write("Country: ");
        string country = Console.ReadLine();

        Console.Write("City: ");
        string city = Console.ReadLine();

        Console.Write("Street: ");
        string street = Console.ReadLine();

        Console.Write("House: ");
        int house = Int32.Parse( Console.ReadLine() );

        Initialize(country, city, street, house);
    }


    public string toString() 
    {
        return 
            "Country: " + this.mCountry + "\n" +
            "City: " + this.mCity + "\n" + 
            "Street: " + this.mStreet + "\n" + 
            "House: " + this.mHouse.ToString() + "\n";
    }


    public string Country 
    {
        get { return mCountry; }
        set { mCountry = value; }
    }


    public string City 
    {
        get { return mCity; }
        set { mCity = value; }
    }


    public string Street 
    {
        get { return mStreet; }
        set { mStreet = value; }
    }


    public int House 
    {
        get { return mHouse; }
        set { mHouse = value; }
    }
}
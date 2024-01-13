internal class Client
{
    public int? Id { get; set; }
    public string Email { get; set; }
    public string Pass { get; set; }
    public double Dinheiro { get; set; }

    // Default Constructor
    public Client()
    {
    }

    // Parameterized Constructor without Id
    public Client(string email, string pass, double dinheiro)
    {
        Email = email;
        Pass = pass;
        Dinheiro = dinheiro;
    }

    // Parameterized Constructor with Id
    public Client(int id, string email, string pass, double dinheiro)
    {
        Id = id;
        Email = email;
        Pass = pass;
        Dinheiro = dinheiro;
    }

    // Copy Constructor (Cloning)
    public Client(Client other)
    {
        Id = other.Id;
        Email = other.Email;
        Pass = other.Pass;
        Dinheiro = other.Dinheiro;
    }

    // Clone method
    public Client Clone()
    {
        return new Client(this);
    }

    // ToString method
    public override string ToString()
    {
        return $"Id: {Id}, Email: {Email}, Pass: {Pass}, Dinheiro: {Dinheiro:C}";
    }
}

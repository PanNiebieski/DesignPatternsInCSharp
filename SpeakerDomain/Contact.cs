public class Contact
{
    public string Phone { get; }
    public string Email { get; }

    public Contact(string phone, string email)
    {
        if (phone == null)
            throw new ArgumentException("phone cannot be null");
        if (email == null)
            throw new ArgumentException("email cannot be null");

        Phone = phone;
        Email = email;
    }

    protected Contact()
    {

    }
}

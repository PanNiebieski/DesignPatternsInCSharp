public class Name
{
    public Name(string first, string last)
    {
        if (string.IsNullOrWhiteSpace(first))
            throw new ArgumentException("First name cannot be empty");
        if (string.IsNullOrWhiteSpace(last))
            throw new ArgumentException("First name cannot be empty");

        First = first;
        Last = last;
    }

    public string First { get; }
    public string Last { get; }
}

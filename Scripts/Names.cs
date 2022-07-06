public class Names
{
    // This will contain the value when the program runs. Don't edit it!
    public string name = "";

    // Include your name here!
    public string myName = "Leonardo"; //

    public string SayHello()
    {
        // Return the exact string 'Hello World'
        // EDIT THIS METHOD
        return "Hello World";
    }

    public string UseGreeting(string greeting)
    {
        // EDIT THIS METHOD by changing "Greeting" to use the name and the argument above.
        // You'll want to use the concatenate operator (+) and combine it in an 
        // expression with "name"
        return greeting + name;
    }

    // Return true if the "name" variable is your name.
    public bool MyName()
    {
        // EDIT THIS CODE 
        // Use a logical compariso (== will compare two values to one another and 
        // return true if they are the same.
        // You can reference both "name" and "myName" above as they are both in this class.
        if (name == myName)
            return true;
        else
            return false;
    }
}
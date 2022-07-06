public class Numbers
{
    public int memberA;
    public int memberB;
    public int sum;

    // This function should take two arguments and return their sum as an integer.
    public int SumTwoArguments(int a, int b)
    {
        // EDIT THIS CODE
        // Use a and b to create the sum of a and b. Use the "+" operator.
        // hint: 4 + 9 is a valid expression in C#!
        return a + b;
    }

    // This function should sum the two class instance variables, memberA and memberB
    // and store the result in "sum"
    public int SumTwoIntMembers()
    {
        // EDIT THIS CODE
        // Just like before, except you should incorporate the member variables above on lines 2 and 3
        // Include them into the same expression and return it (replace sum)
        sum = memberA + memberB;
        return sum;
    }

    public bool GreaterThan()
    {
        // EDIT THIS CODE
        // You'll want to use the ">" operator to compare the two member variables here and return 
        // the resulting boolean value.
        if (memberA > memberB)
            return true;
        else
            return false;
    }
}
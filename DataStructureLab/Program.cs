using System.Collections;
using System.Collections.Generic;
//Data Structures
//take in user input and display it back in Reverse
Console.WriteLine("Welcome!\n");
do
{
    //take user input
    Console.Write("Please enter a number, word or sentence you would like to reverse: ");
    string userInput = Console.ReadLine();
    Console.WriteLine("Now in Reverse: ");
    Console.WriteLine(ReverseThePhrase(userInput));
}
while (GoAgain());

//Methods

//method for reversing string
//	reverse the inputted string w/ a stack
static string ReverseThePhrase(string userInput)
{
    char[] charArr = userInput.ToCharArray();
    int size = charArr.Length;
    //1) Create an empty stack.
    //empty stack
    Stack stack = new Stack(size);

    int i;
    for (i = 0; i < size; ++i)
    {
        //2) One by one push all characters of string to stack.
        stack.Push(charArr[i]);
    }
    for (i = 0; i < size; ++i)
    {
        //3) One by one pop all characters from stack and put them back to string.
        charArr[i] = (char)stack.Pop();
    }
    //		display reversed string to console
    return String.Join("", charArr);
}
static bool GoAgain()
{
    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("Do you want to go again (y/n)?");
        string input = Console.ReadLine();
        try
        {
            if (input.ToLower().Trim() == "y")
            {
                Console.WriteLine("Okay!");
                Console.WriteLine();
                return true;
            }
            else if (input.ToLower().Trim() == "n")
            {
                Console.WriteLine("Okay bye!");
                return false;
            }
            else
            {
                throw new Exception("Not a valid option, please try again.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}


//char[] letters = { 'a', 'e', 'i', 'o', 'u' };
//string result = new string(letters);
//Console.WriteLine(result);

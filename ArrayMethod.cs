/* 
Josh Bartlett
11July2019
Assignment 4.2
Declare 3 integer arrays of different sizes, loop displaying a menu each time
until the number 4 is entered, for each selection 1-3 display the integers of 
the array chosen and the sum of those integers, if any other number is entered 
ask for a valid input.
*/

using System;
using static System.Console;

class ArrayMethod
{
    // Declare and fill arrays and declare userSelected variable for use in the program
    static int[] array1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
    static int[] array2 = {2, 4, 6, 8, 10, 12, 14, 16, 18, 20};
    static int[] array3 = {3, 6, 9, 12, 15};
    static int userSelected;

    static void Main()
    {
        // Calls the MenuList method
        MenuList();
        // While loop to keep program running while 4 is not entered and to call
        // the ProcessArray method when 1, 2, or 3 is entered
        while (userSelected != 4)
        {
            if (userSelected == 1)
            {
                // Calls the FirstArray method and passes array1 and total to the method
                ProcessArray(array1);
            }
            else if (userSelected == 2)
            {
                // Calls the SecondArray method and passes array1 and total to the method
                ProcessArray(array2);
            }
            else if (userSelected == 3)
            {
                // Calls the FirstArray method and passes array1 and total to the method
                ProcessArray(array3);
            }
            // else user enters an integer outside of 1-4
            else
            {
                WriteLine("Please enter an valid selection.");
            }

            WriteLine();
            // Calls the MenuList method
            MenuList();
        }
    }

    // Method to display the list of menu items, asks user to choose one and then
    // converts the user input to an integer 
    private static void MenuList()
    {
        WriteLine("(1) To view the list of the first array and the sum of the integers");
        WriteLine("(2) To view the list of the second array and the sum if the integers");
        WriteLine("(3) To view the list of the third array and the sum of the integers");
        WriteLine("(4) To quit the application");
        Write("Please enter the number of your selection: ");
        userSelected = Convert.ToInt16(ReadLine());
        WriteLine();
    }

    // Method for the process the arrays
    private static void ProcessArray(int[] arrayM)
    {
        int sum = 0;
        WriteLine("List:");
        // foreach loop to run through the entire array and display the contents
        // and keeps a running total for the sum
        foreach (int i in arrayM)
        {
            WriteLine(i);
            sum += i;
        }
        WriteLine();
        // Displays the sum of the contents of the array
        WriteLine("Sum:");
        WriteLine(sum);
    }

    // fun alternate
    /*
    private static void ProcessArray(int[] arrayM)
    {
        string items = string.Join(", ", arrayM);

        int sum = arrayM.Aggregate((x, y) => x + y);
        // or
        int sum = arrayM.Sum();

        WriteLine("List:" + items + ", Sum: " + sum.toString());
    }
    */
}
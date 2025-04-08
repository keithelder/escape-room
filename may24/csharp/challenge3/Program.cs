
using System;

/*
 * This program decodes an encoded message and prints it to the console.
 * In order to escape, your task is to decode the message within the array and type it into the chat. 
 */
class Program 
{
    static void Main() 
    {
        int[] encodedMessage = {78, 122, 33, 119, 112, 106, 100, 102, 33, 106, 116, 33, 110, 122, 33, 113, 98, 116, 116, 113, 112, 115, 117, 47, 33, 87, 102, 115, 106, 103, 122, 47};
        string message = DecodeMessage(encodedMessage);
        Console.WriteLine("Secret Message: " + message);
    }

   static string DecodeMessage(int[] data)
   {
        // decode the message and return it as a string
        string message = "";
        // foreach (int i in data)
        // {
        //         message += (char)(i -1);
        // }
        return message;
   }
}

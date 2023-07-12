using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        public static void Main(string [] args)
        {
            Stack<UserAction> userActions = new Stack<UserAction>();
        //    {
        //      UserAction userAction = new UserAction
        //     {
        //         Description= " Wrote a report",
        //         Abbreviation = "wri-r",
        //         ObjectId=12,
        //     };
        //     userActions.Push(userAction);
        //    }
        //     {
        //      UserAction userAction = new UserAction
        //     {
        //         Description= " Wrote a text",
        //         Abbreviation = "wtt-t",
        //         ObjectId=123,
        //     };
        //     userActions.Push(userAction);
        //    }
        //     {
        //      UserAction userAction = new UserAction
        //     {
        //         // Description= " Wrote a line",
        //         // Abbreviation = "wll-l",
        //         // ObjectId = 1234,
        //     };
        //     userActions.Push(userAction);
        //    }
        //    Console.WriteLine("user action history");
        //    foreach( var userAction in userActions)
        //    {
        //     Console.WriteLine("." + userAction.ShowIt());
        //    }
        //    Console.WriteLine("last action was :");
        //    Console.WriteLine(userActions.Peek().ShowIt());

                
        //      UserAction undoneuserAction = userActions.Pop();
        //        Console.WriteLine("This action was undone: " + undoneuserAction.ShowIt());
                
        //      Console.WriteLine("user action history");
           
        //     foreach( var userAction in userActions)
        //    Console.WriteLine("." + userAction.ShowIt());
       

        //         Console.ReadLine();
         }

        
    }
           
    public class UserAction
    {
        public string Description{get; set;}
        public string Abbreviation {get; set;}
        public int ObjectId{get; set;}
       internal string ShowIt()
        {
            return string.Format("{0} ({1}) affecting object {2}", Description,Abbreviation,ObjectId);
        }
    }
}
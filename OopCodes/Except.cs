 internal class Except
 {
     static void Main(string[] args)
     {
         try
         {
             var s = ReadLine();
             int i = 0;
             int j= int.Parse(s);
             int k = i/j;
         }
         catch(ArithmeticException ex)
         {
             WriteLine("Alert");
             WriteLine(ex.Message);
         }
         catch(FormatException ex)
         {
             WriteLine(ex.Message);
         }
         finally { Console.WriteLine("This is final."); }

     }

 }
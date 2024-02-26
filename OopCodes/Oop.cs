internal class oop
{
  static void Main(string[] args)
    {
        BankAccount.InterestRate = 0.012M; // store a shared value
        var jonesAccount = new BankAccount();
        jonesAccount.AccountName = "Mrs. Jones";
        jonesAccount.Balance = 2400;
        WriteLine(format: "{0} earned {1:C} interest.",
         arg0: jonesAccount.AccountName,
         arg1: jonesAccount.Balance * BankAccount.InterestRate);
        var gerrierAccount = new BankAccount();
        gerrierAccount.AccountName = "Ms. Gerrier";
        gerrierAccount.Balance = 98;
        WriteLine(format: "{0} earned {1:C} interest.",
         arg0: gerrierAccount.AccountName,
         arg1: gerrierAccount.Balance * BankAccount.InterestRate);

        var bob = new Person();
        bob.Name = "Bob Smith";
        bob.DateOfBirth = new DateTime(2023, 04, 25);
        //bob.WriteToConsole();
        //WriteLine(bob.GetOrigin());

        //           WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
        //            arg0: bob.Name,
        //            arg1: bob.DateOfBirth);

        //           var alice = new Person
        //           {
        //               Name = "Alice Jones",
        //               DateOfBirth = new DateTime(1998, 3, 7)
        //           };
        //           WriteLine(
        //            format: "{0} was born on {1:dd MMM yy}",
        //            arg0: alice.Name,
        //            arg1: alice.DateOfBirth);
        //           bob.FavoriteAncientWonder =
        //WondersOfTheAncientWorld.Statue_Of_ZeusAt_Olympia;
        //           WriteLine(format:
        //            "{0}'s favorite wonder is {1}. It's integer is {2}.",
        //            arg0: bob.Name,
        //            arg1: bob.FavoriteAncientWonder,
        //            arg2: (int)bob.FavoriteAncientWonder);

        bob.Children.Add(new Person { Name = "Alfred" });
        bob.Children.Add(new Person { Name = "Zoe" });
        WriteLine(
         $"{bob.Name} has {bob.Children.Count} children, whose names are:");
        for (int child = 0; child < bob.Children.Count; child++)
        {
            WriteLine($" {bob.Children[child].Name}");
        }

    }
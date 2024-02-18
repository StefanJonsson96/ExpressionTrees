namespace ExpressionTrees
{
  internal class Delegates
  {
    public delegate bool Del(string message);
    public static bool WriteSomething(string message)
    {
      Console.WriteLine(message);
      return true;
    }

    public static bool WriteSomethingWithTime(string message)
    {
      Console.WriteLine(message + " " + DateTime.Now);
      return true;
    }
  }
}

UsingDelegatesExample();

ExtractFuncFromWhereClauseExample();

ExpressionTypeExample();

static void ExpressionTypeExample()
{
  var parameter = Expression.Parameter(typeof(int), "x");
  var constantExprression = Expression.Constant(12);
  var greaterThan = Expression.GreaterThan(parameter, constantExprression);

  var expression = Expression.Lambda<Func<int, bool>>(greaterThan, false, new List<ParameterExpression> { parameter });
  var func = expression.Compile();

  Console.WriteLine(func(11)); 
} 
static void ExtractFuncFromWhereClauseExample()
{
  List<Guitar> guitars =
  [
    new("Cheap acoustic guitar", PickupType.Acoustic, StringType.Brass),
    new("Cool electric guitar", PickupType.Electric, StringType.Steel),
    new("Expensive half-acoustic guitar", PickupType.HalfAcoustic, StringType.Nylon)
  ];

  Func<Guitar, bool> nylon = g => g.Strings == StringType.Nylon;

  var nylonGuitars = guitars.Where(nylon);

  foreach (var guitar in nylonGuitars)
  {
    Console.WriteLine(guitar.Name);
  }
}
static void UsingDelegatesExample()
{
  Del myCustomDeleGate = Console.ReadLine() == "1" ? WriteSomething : WriteSomethingWithTime;
  Func<string, bool> myFunc = Console.ReadLine() == "1" ? WriteSomething : WriteSomethingWithTime;
  Action<string> myAction = Console.ReadLine() == "1" ? x => WriteSomething(x) : y => WriteSomethingWithTime(y); // You can use lambdas within a delegate


  bool result2 = myFunc($"Hello World {nameof(Func<string, bool>)}"); // Func encapsulates a delegate with a return type
  myAction($"Hello World {nameof(Action<string>)}"); // Action encapsulates a delegate with no return type
  bool result3 = myCustomDeleGate($"Hello World {nameof(Del)}"); // You can use your own wrapper class around a delegate if you don't want to use Func or Action

  // Delegate is an abstract class so you have to use Func,Action or your own implementation. Cannot use it directly.
}
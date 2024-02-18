namespace ExpressionTrees
{
  public class Guitar
  {
    public Guitar(string name, PickupType pickup, StringType strings)
    {
      Name = name;
      Pickup = pickup;
      Strings = strings;
    }

    public string Name { get; set; }
    public PickupType Pickup { get; set; }
    public StringType Strings { get; set; }
  }
}

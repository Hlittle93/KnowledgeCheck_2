using KnowledgeCheck_2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<FireType>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            var fireType = new FireType();

            Console.WriteLine("Enter the value for the Pokemon's name.");
            fireType.Name = Console.ReadLine();

            Console.WriteLine("Enter the value for the Pokemon's type.");
            fireType.Type = Console.ReadLine();

            Console.WriteLine("Enter the value for the Pokemon's level.");
            fireType.Level = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for the Pokemon's basic attack.");
            fireType.BasicAttack = Console.ReadLine();

            Console.WriteLine("Enter the value for the fire Pokemon's first fire attack.");
            fireType.FireAttack1 = Console.ReadLine();

            Console.WriteLine("Enter the value for the fire Pokemon's second fire attack.");
            fireType.FireAttack2 = Console.ReadLine();

            recordList.Add(fireType);
        }

        foreach (var fireType in recordList) 
            {
            Console.WriteLine("You have a " + fireType.Name + " on your pokemon team.");
            }
 
    }
}
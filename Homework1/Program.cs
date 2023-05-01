namespace Homework1
{
    public class Program
    {
       public static void Main(string[] args)
        {
            MyCollection<User> myCollection = new MyCollection<User>();
            var john = new User() { Name = "Katya", Age = 19 };
            myCollection.Add(new User() { Name = "Maks", Age = 21 });
            myCollection.Add(new User() { Name = "Pasha", Age = 43 });
            myCollection.Add(john);
            myCollection.Add(new User() { Name = "Polya", Age = 33 });
            User[] myCollArr =
            {
                new User(){Name = "Taras", Age=52},
                new User(){Name = "Sasha", Age=18},

            };
            myCollection.AddRange(myCollArr);
            myCollection.Remove(john);
            myCollection.RemoveAt(1);
            myCollection.Sort();
            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
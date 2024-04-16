namespace _15_Operator_Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person ibrahim = new()
            {
                Name = "Ibrahim",
                Surname = "Xusmandi",
                Age = 20
            };

            Person qarib = new()
            {
                Name = "Qarib",
                Surname = "Qaribzade",
                Age = 21
            };

            Console.WriteLine(qarib!=ibrahim);
        }

        class Person 
        { 
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }

            public static bool operator >(Person left, Person right)
            {
                return left.Age > right.Age;
            }

            public static bool operator <(Person left, Person right)
            {
                return left.Age < right.Age;
            }

            public static bool operator ==(Person left, Person right)
            {
                if(left.Name!=right.Name || left.Surname != right.Surname || left.Age != right.Age)
                {
                    return false;
                }
                return true;
            }

            public static bool operator !=(Person left, Person right)
            {
                return !(left == right);
            }
        }
    }
}

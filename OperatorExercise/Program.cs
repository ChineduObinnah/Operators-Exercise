namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            AreaofCircle();

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} = {quotient} remainder {remainder}");
                //Thought Excerise
                var i = 3;
                var j = 4;
                var k = ++i * j++;
                Console.WriteLine(k);
            }
        }
        public static void AreaofCircle()
        {
            Console.Write("What is the radius of your circle? ");
            double rad = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * rad * rad;
            Console.WriteLine("Area of circle is: " + area);
        }
    }
}
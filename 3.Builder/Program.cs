using _3.Builder.Concrate;
using System;

namespace _3.Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder;
            // Create shop with vehicle builders
            Shop shop = new Shop();
            Console.WriteLine("Який т/з ви хочте побудувати 1- сутерб, 2 - авто, 3 - мотоцикол");
            int action = int.Parse(Console.ReadLine());
            switch(action)
            {
                case 1:
                    builder = new ScooterBuilder();
                    break;
                case 2:
                    builder = new CarBuilder();
                    break;
                default:
                    builder = new MotorCycleBuilder();
                    break;
            }

            shop.Construct(builder);
            builder.Vehicle.Show();
            // Wait for user
            Console.ReadKey();
        }
    }
}

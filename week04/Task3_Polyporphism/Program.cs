using Task3_Polyporphism.Models;

namespace Task3_Polyporphism;

internal class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[0];
        // car = vehicle + engine + wheel + transmission
        // plane = vehicle + engine         
        // bicycle = vehicle + wheel + transmission 
        
        byte flags;
        // none ->          000 = 0
        // wheel ->         001 = 1
        // engine ->        010 = 2
        // transmission ->  100 = 4
        do
        {
            Console.WriteLine("\n1. Create new car");
            Console.WriteLine("2. Create new Bicycle");
            Console.WriteLine("3. Create new plane");
            Console.WriteLine("4. List all vehicles");
            Console.WriteLine("5. Delete vehicle by index");
            Console.Write("What will be your choose mr.Wayne?: ");
            byte BInput;
            int IInput;
            float FInput;
            flags = 0;
            Vehicle vehicle = null;

            switch (Console.ReadLine())
            {
                case "1":
                    flags |= 1;
                    flags |= 2;
                    vehicle = new Car();

                    Console.Write("Door count: ");
                    Byte.TryParse(Console.ReadLine(), out BInput);
                    (vehicle as Car).DoorCount = BInput;

                    Console.Write("Win code: ");
                    (vehicle as Car).WinCode = Console.ReadLine();
                    break;
                case "2":
                    flags |= 1;
                    flags |= 4;
                    vehicle = new Bicycle();

                    Console.Write("Pedal kind: ");
                    (vehicle as Bicycle).PedalKind = Console.ReadLine();
                    break;
                case "3":
                    flags |= 2;
                    vehicle = new Plane();

                    Console.Write("Wing length: ");
                    float.TryParse(Console.ReadLine(), out FInput);
                    (vehicle as Plane).WingLength = FInput;
                    break;
                case "4":
                    for (int i = 0; i < vehicles.Length; i++)
                    {
                        Console.WriteLine("\n[" + i + "]: " + vehicles[i]);
                    }
                    break;
                case "5":
                    Console.Write("Give index of vehicle: ");
                    Int32.TryParse(Console.ReadLine(), out int index);

                    if (vehicles.Length > index)
                    {
                        Vehicle[] NewVehicles = new Vehicle[vehicles.Length - 1];
                        int index2 = 0;
                        for (int i = 0; i < vehicles.Length; i++)
                        {
                            if (i == index) continue;
                            NewVehicles[index2] = vehicles[i];
                            index2++;
                        }
                        vehicles = NewVehicles;
                    }
                    else
                    {
                        Console.WriteLine("no such index.");
                    }
                    break;
                default:
                    Console.WriteLine("Try Again.");
                    break;
            }

            if (flags > 0)
            {
                Console.Write("Meters drived: ");
                float.TryParse(Console.ReadLine(), out FInput);
                vehicle.DrivePath = FInput;

                Console.Write("Seconds it taked: ");
                Int32.TryParse(Console.ReadLine(), out IInput);
                vehicle.DriveTime = IInput;

                if ((flags & 1) > 0)
                {
                    IWheel mark = vehicle as IWheel;

                    Console.Write("Wheel tickness: ");
                    float.TryParse(Console.ReadLine(), out FInput);
                    mark.WheelThickness = FInput;

                }
                if ((flags & 2) > 0)
                {
                    IEngine mark = vehicle as IEngine;

                    Console.Write("Current Oil: ");
                    Int32.TryParse(Console.ReadLine(), out IInput);
                    mark.CurrentOil = IInput;

                    Console.Write("Tank size: ");
                    Int32.TryParse(Console.ReadLine(), out IInput);
                    mark.TankSize = IInput;

                    Console.Write("Horse power: ");
                    Int32.TryParse(Console.ReadLine(), out IInput);
                    mark.HorsePower = IInput;

                    Console.Write("Fuel type: ");
                    mark.FuelType = Console.ReadLine();
                }
                if ((flags & 4) > 0)
                {
                    ITransmission mark = vehicle as ITransmission;
                    Console.Write("Transmission kind: ");
                    mark.TransmissionKind = Console.ReadLine();
                }

                Vehicle[] NewVehicles = new Vehicle[vehicles.Length + 1];
                NewVehicles[vehicles.Length] = vehicle;

                for (int i = 0; i < vehicles.Length; i++)
                {
                    NewVehicles[i] = vehicles[i];
                }

                vehicles = NewVehicles;
            }
        } while (true);
    }
}
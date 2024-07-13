using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAS_STATION
{
    internal class FuelType
    {
        public static void Diesel(double amountDiesel)
        {

            string gastype = "";
            int priceliter = 0;
            double DieselPrice = 60.05;
            double JeepneyDieselEfficiency = 13.00;
            double TricycleDieselEfficiency = 30.00;
            double MotorDieselEfficiency = 40.00;
            double CarDieselEfficiency = 15.00;
            double BusDieselEfficiency = 10.00;
            double VanDieselEfficiency = 18.00;
            double TruckDieselEfficiency = 8.00;
            double liters = amountDiesel / DieselPrice;
            double kl = amountDiesel / JeepneyDieselEfficiency;
             kl = amountDiesel / TricycleDieselEfficiency;
             kl = amountDiesel / MotorDieselEfficiency;
             kl = amountDiesel / CarDieselEfficiency;
             kl = amountDiesel / BusDieselEfficiency;
             kl = amountDiesel / VanDieselEfficiency;
             kl = amountDiesel / TruckDieselEfficiency;

            Console.WriteLine("Enter the number corresponding to your vehicle type: ");
            Console.WriteLine("1. Jeepney");
            Console.WriteLine("2. Tricycle");
            Console.WriteLine("3. Motor");
            Console.WriteLine("4. Car");
            Console.WriteLine("5. Bus");
            Console.WriteLine("6. Van");
            Console.WriteLine("7. Truck");
            int vehicles = Convert.ToInt32(Console.ReadLine());
            if (vehicles >= 1 && vehicles <= 7)
            {
                switch (vehicles)
                {
                    case 1:// Jeepney
                        JeepneyDieselEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Diesel and it can go approximately {kl:F2} kilometers with the amount of {amountDiesel}");
                        break;
                    case 2: // Tricycle
                        TricycleDieselEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Diesel and it can go approximately {kl:F2} kilometers with the amount of {amountDiesel}");
                        break;
                    case 3: // Motor
                        MotorDieselEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Diesel and it can go approximately {kl:F2} kilometers with the amount of {amountDiesel}");
                        break;
                    case 4: // Car
                        CarDieselEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Diesel and it can go approximately {kl:F2} kilometers with the amount of {amountDiesel}");
                        break;
                    case 5://Busv
                        BusDieselEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Diesel and it can go approximately {kl:F2} kilometers with the amount of {amountDiesel}");
                        break;
                    case 6: // Van 
                        VanDieselEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Diesel and it can go approximately {kl:F2} kilometers with the amount of {amountDiesel}");
                        break;
                    case 7:// Truck
                        TruckDieselEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Diesel and it can go approximately {kl:F2} kilometers with the amount of {amountDiesel}");
                        break;
                    default:
                        Console.WriteLine("Sorry, your vehicle do not accept that kind of fuel.");

                        break;
                }

                Console.Write("Enter Plate Number for Fuel Receipt:");
                int platenum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nECB POWER GAS STATION");
                Console.WriteLine("888-888-8888");
                Console.WriteLine("--- Gas Station Receipt ---");
                DateTime purchasetime = DateTime.Now;
                Console.WriteLine($"Time of Purchase: {purchasetime.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Your Plate Number: {platenum}");
                Console.WriteLine($"Fuel Type: Diesel");
                Console.WriteLine($"Total amount: {amountDiesel}");
                Console.WriteLine($"No.Pump: {liters:F2}");
                Console.WriteLine("");

                Console.WriteLine("Thank you for your purchase!");
            }
            else
            {
                Console.WriteLine("Invalid vehicle number. Sorry, your vehicle do not accept that kind of fuel");
            }


        }
        public static void Premium(double amountPremium)
        {

            string gastype = "";
            double PremiumPrice = 68.00;

            double JeepneyPremiumEfficiency = 11.00;
            double TricyclePremiumEfficiency = 25.00;
            double MotorPremiumEfficiency = 35.00;
            double CarPremiumEfficiency = 13.00;
            double liters = amountPremium / PremiumPrice;
            double kl = amountPremium / JeepneyPremiumEfficiency;
             kl = amountPremium / TricyclePremiumEfficiency;
             kl = amountPremium / MotorPremiumEfficiency;
             kl = amountPremium / CarPremiumEfficiency;

            Console.WriteLine("Enter the number corresponding to your vehicle type: ");
            Console.WriteLine("1. Jeepney");
            Console.WriteLine("2. Tricycle");
            Console.WriteLine("3. Motor");
            Console.WriteLine("4. Car");
            Console.WriteLine("5. Bus");
            Console.WriteLine("6. Van");
            Console.WriteLine("7. Truck");
            int vehicles = Convert.ToInt32(Console.ReadLine());

            if (vehicles >= 1 && vehicles <= 4)
            {
                switch (vehicles)
                {
                    case 1:// Jeepney
                        JeepneyPremiumEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Premium and it can go approximately {kl:F2} kilometers with the amount of {amountPremium}");
                        break;
                    case 2: // Tricycle
                        TricyclePremiumEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Premium and it can go approximately {kl:F2} kilometers with the amount of {amountPremium}");
                        break;
                    case 3: // Motor
                        MotorPremiumEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Premium and it can go approximately {kl:F2} kilometers with the amount of {amountPremium}");
                        break;
                    case 4: // Car
                        CarPremiumEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Premium and it can go approximately {kl:F2} kilometers with the amount of {amountPremium}");
                        break;
                    default:
                        Console.WriteLine("Sorry, your vehicle do not accept that kind of fuel.");

                        break;
                }
                // Receipt Code
                Console.Write("Enter Plate Number for Fuel Receipt:");
                int platenum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nECB POWER GAS STATION");
                Console.WriteLine("888-888-8888");
                Console.WriteLine("--- Gas Station Receipt ---");
                DateTime purchasetime = DateTime.Now;
                Console.WriteLine($"Time of Purchase: {purchasetime.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Your Plate Number: {platenum}");
                Console.WriteLine($"Fuel Type: Premium ");
                Console.WriteLine($"Total amount: {amountPremium}");
                Console.WriteLine($"No.Pump: {liters:F2}");
                Console.WriteLine("");

                Console.WriteLine("Thank you for your purchase!");
            }
            else
            {
                Console.WriteLine("Invalid vehicle number. Sorry, your vehicle do not accept that kind of fuel");
            }


        }
        public static void Gasoline(double amountGasoline)
        {
            string gastype = "";
            double GasolinePrice = 64.40;
            double JeepneyGasolineEfficiency = 10.00;
            double TricycleGasolineEfficiency = 20.00;
            double MotorGasolineEfficiency = 30.00;
            double CarGasolineEfficiency = 13.5;
            double liters = amountGasoline / GasolinePrice;
            double kl = amountGasoline / JeepneyGasolineEfficiency;
             kl = amountGasoline / TricycleGasolineEfficiency;
             kl = amountGasoline / MotorGasolineEfficiency;
             kl = amountGasoline / CarGasolineEfficiency;

            Console.WriteLine("Enter the number corresponding to your vehicle type: ");
            Console.WriteLine("1. Jeepney");
            Console.WriteLine("2. Tricycle");
            Console.WriteLine("3. Motor");
            Console.WriteLine("4. Car");
            Console.WriteLine("5. Bus");
            Console.WriteLine("6. Van");
            Console.WriteLine("7. Truck");
            int vehicles = Convert.ToInt32(Console.ReadLine());
            if (vehicles >= 1 && vehicles <= 4)
            {
                switch (vehicles)
                {
                    case 1:// Jeepney
                        JeepneyGasolineEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Gasoline and it can go approximately {kl:F2} kilometers with the amount of {amountGasoline}");
                        break;
                    case 2: // Tricycle
                        TricycleGasolineEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Gasoline and it can go approximately {kl:F2} kilometers with the amount of {amountGasoline}");
                        break;
                    case 3: // Motor
                        MotorGasolineEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Gasoline and it can go approximately {kl:F2} kilometers with the amount of {amountGasoline}");
                        break;
                    case 4: // Car
                        CarGasolineEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Gasoline and it can go approximately {kl:F2} kilometers with the amount of {amountGasoline}");
                        break;
                    default:
                        Console.WriteLine("Sorry, your vehicle do not accept that kind of fuel.");

                        break;
                }
                Console.Write("Enter Plate Number for Fuel Receipt:");
                int platenum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nECB POWER GAS STATION");
                Console.WriteLine("888-888-8888");
                Console.WriteLine("--- Gas Station Receipt ---");
                DateTime purchasetime = DateTime.Now;
                Console.WriteLine($"Time of Purchase: {purchasetime.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Your Plate Number: {platenum}");
                Console.WriteLine($"Fuel Type: Gasoline");
                Console.WriteLine($"Total amount: {amountGasoline}");
                Console.WriteLine($"No.Pump: {liters:F2}");
                Console.WriteLine("");

                Console.WriteLine("Thank you for your purchase!");
            }
            else
            {
                Console.WriteLine("Invalid vehicle number. Sorry, your vehicle do not accept that kind of fuel");
            }


        }
        public static void Unleaded(double amountUnleaded)
        {

            string gastype = "";
            double UnleadedPrice = 65.40;
            double JeepneyUnleadedEfficiency = 8.00;
            double TricycleUnleadedEfficiency = 24.00;
            double MotorUnleadedEfficiency = 30.00;
            double CarUnleadedEfficiency = 12.5;

            double liters = amountUnleaded / UnleadedPrice;
            double kl = amountUnleaded  / JeepneyUnleadedEfficiency;
             kl = amountUnleaded  / TricycleUnleadedEfficiency;
             kl = amountUnleaded / MotorUnleadedEfficiency;
             kl = amountUnleaded / CarUnleadedEfficiency;

            Console.WriteLine("Enter the number corresponding to your vehicle type: ");
            Console.WriteLine("1. Jeepney");
            Console.WriteLine("2. Tricycle");
            Console.WriteLine("3. Motor");
            Console.WriteLine("4. Car");
            Console.WriteLine("5. Bus");
            Console.WriteLine("6. Van");
            Console.WriteLine("7. Truck");
            int vehicles = Convert.ToInt32(Console.ReadLine());
            if (vehicles >= 1 && vehicles <= 4)
            {
                switch (vehicles)
                {
                    case 1:// Jeepney
                        JeepneyUnleadedEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Unleaded and it can go approximately {kl:F2} kilometers with the amount of {amountUnleaded}");
                        break;
                    case 2: // Tricycle
                        TricycleUnleadedEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Unleaded and it can go approximately {kl:F2} kilometers with the amount of {amountUnleaded}");
                        break;
                    case 3: // Motor
                        MotorUnleadedEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Unleaded and it can go approximately {kl:F2} kilometers with the amount of {amountUnleaded}");
                        break;
                    case 4: // Car
                        CarUnleadedEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Unleaded and it can go approximately {kl:F2} kilometers with the amount of {amountUnleaded}");
                        break;
                    default:
                        Console.WriteLine("Sorry, your vehicle do not accept that kind of fuel.");

                        break;
                }
                Console.Write("Enter Plate Number for Fuel Receipt:");
                int platenum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nECB POWER GAS STATION");
                Console.WriteLine("888-888-8888");
                Console.WriteLine("--- Gas Station Receipt ---");
                DateTime purchasetime = DateTime.Now;
                Console.WriteLine($"Time of Purchase: {purchasetime.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Your Plate Number: {platenum}");
                Console.WriteLine($"Fuel Type: Unleaded");
                Console.WriteLine($"Total amount: {amountUnleaded}");
                Console.WriteLine($"No.Pump: {liters:F2}");
                Console.WriteLine("");

                Console.WriteLine("Thank you for your purchase!");
            }
            else
            {
                Console.WriteLine("Invalid vehicle number. Sorry, your vehicle do not accept that kind of fuel");
            }

        }
        public static void Kerosene(double amountKerosene)
        {

            string gastype = "";
            double KerosenePrice = 72.96;
            double TricycleKeroseneEfficiency = 15.00;
            double MotorKeroseneEfficiency = 25;
            double CarKeroseneEfficiency = 9.5;
            double liters = amountKerosene / KerosenePrice;
            double kl = amountKerosene / TricycleKeroseneEfficiency;
             kl = amountKerosene / MotorKeroseneEfficiency;
             kl = amountKerosene / CarKeroseneEfficiency;


            Console.WriteLine("Enter the number corresponding to your vehicle type: ");
            Console.WriteLine("1. Jeepney");
            Console.WriteLine("2. Tricycle");
            Console.WriteLine("3. Motor");
            Console.WriteLine("4. Car");
            Console.WriteLine("5. Bus");
            Console.WriteLine("6. Van");
            Console.WriteLine("7. Truck");
            int vehicles = Convert.ToInt32(Console.ReadLine());
            if (vehicles >= 2 && vehicles <= 4)
            {
                switch (vehicles)
                {

                    case 2:
                        TricycleKeroseneEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Kerosene and it can go approximately {kl:F2} kilometers with the amount of {amountKerosene}");
                        break;
                    case 3: // Motor
                        MotorKeroseneEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Kerosene and it can go approximately {kl:F2} kilometers with the amount of {amountKerosene}");
                        break;
                    case 4: // Car
                        CarKeroseneEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Kerosene and it can go approximately {kl:F2} kilometers with the amount of {amountKerosene}");
                        break;
                    default:
                        Console.WriteLine("Sorry, your vehicle do not accept that kind of fuel.");

                        break;
                }
                Console.Write("Enter Plate Number for Fuel Receipt:");
                int platenum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nECB POWER GAS STATION");
                Console.WriteLine("888-888-8888");
                Console.WriteLine("--- Gas Station Receipt ---");
                DateTime purchasetime = DateTime.Now;
                Console.WriteLine($"Time of Purchase: {purchasetime.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Your Plate Number: {platenum}");
                Console.WriteLine($"Fuel Type: Kerosene");
                Console.WriteLine($"Total amount: {amountKerosene}");
                Console.WriteLine($"No.Pump: {liters:F2}");
                Console.WriteLine("");

                Console.WriteLine("Thank you for your purchase!");
            }
            else
            {
                Console.WriteLine("Invalid vehicle number. Sorry, your vehicle do not accept that kind of fuel");
            }

        }
        public static void Petrol(double amountPetrol)
        {

            string gastype = "";
            double PetrolPrice = 60;
            double TricyclePetrolEfficiency = 28.00;
            double MotorPetrolEfficiency = 35.00;
            double CarPetrolEfficiency = 14.5;
            double liters = amountPetrol / PetrolPrice;
            double kl = amountPetrol / TricyclePetrolEfficiency;
             kl = amountPetrol / MotorPetrolEfficiency;
             kl = amountPetrol / CarPetrolEfficiency;

            Console.WriteLine("Enter the number corresponding to your vehicle type: ");
            Console.WriteLine("1. Jeepney");
            Console.WriteLine("2. Tricycle");
            Console.WriteLine("3. Motor");
            Console.WriteLine("4. Car");
            Console.WriteLine("5. Bus");
            Console.WriteLine("6. Van");
            Console.WriteLine("7. Truck");
            int vehicles = Convert.ToInt32(Console.ReadLine());
            if (vehicles >= 2 && vehicles <= 4)
            {
                switch (vehicles)
                {

                    case 2:
                        TricyclePetrolEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Petrol and it can go approximately {kl:F2} kilometers with the amount of {amountPetrol}");
                        break;
                    case 3: // Motor
                        MotorPetrolEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Petrol and it can go approximately {kl:F2} kilometers with the amount of {amountPetrol}");
                        break;
                    case 4: // Car
                        CarPetrolEfficiency = kl;
                        Console.WriteLine($"You have {liters:F2} liters of Petrol and it can go approximately {kl:F2} kilometers with the amount of {amountPetrol}");
                        break;
                    default:
                        Console.WriteLine("Sorry, your vehicle do not accept that kind of fuel.");
                        break;
                }
                Console.Write("Enter Plate Number for Fuel Receipt:");
                int platenum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nECB POWER GAS STATION");
                Console.WriteLine("888-888-8888");
                Console.WriteLine("--- Gas Station Receipt ---");
                DateTime purchasetime = DateTime.Now;
                Console.WriteLine($"Time of Purchase: {purchasetime.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Your Plate Number: {platenum}");
                Console.WriteLine($"Fuel Type: Petrol");
                Console.WriteLine($"Total amount: {amountPetrol}");
                Console.WriteLine($"No.Pump: {liters:F2}");
                Console.WriteLine("");

                Console.WriteLine("Thank you for your purchase!");
            }
            else
            {
                Console.WriteLine("Invalid vehicle number. Sorry, your vehicle do not accept that kind of fuel");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegate
{
    class Car
    {
        public event Action? EngineStarted;
        public event Action? EngineStopped;
        public event Action<int>? SpeedChanged;

        private bool isEngineOn = false;
        private int speed = 0;

        public void StartEngine()
        {
            if (!isEngineOn)
            {
                isEngineOn = true;
                Console.WriteLine("Engine started!");
                EngineStarted?.Invoke();
            }
            else
            {
                Console.WriteLine("Engine is already running!");
            }
        }
        public void StopEngine()
        {
            if (isEngineOn)
            {
                isEngineOn = false;
                Console.WriteLine("Engine stopped.");
                EngineStopped?.Invoke();
            }
            else
            {
                Console.WriteLine("Engine is already stopped!");
            }
        }
        public void ChangeSpeed(int newSpeed)
        {
            if (isEngineOn)
            {
                if(newSpeed >= 0)
                {
                    speed = newSpeed;
                    Console.WriteLine($"Speed changed to {speed} km/h.");
                    SpeedChanged?.Invoke(speed);
                }
                else
                {
                    Console.WriteLine("Speed can't be negative.");
                }
            }
            else
            {
                Console.WriteLine("Can't change the speed, first start the engine.");
            }
        }
    }
    class CarEventHandler
    {
        public static void OnEngineStarted()
        {
            Console.WriteLine("Log: Engine has been started!");
        }

        public static void OnEngineStopped()
        {
            Console.WriteLine("Log: Engine has been stopped!");
        }

        public static void OnSpeedChanged(int speed)
        {
            Console.WriteLine($"Log: Speed updated to {speed} km/h.");
        }
    }
    class Events
    {
        //static void Main(string[] args)
        //{
        //    Car car = new Car();
        //    car.EngineStarted += CarEventHandler.OnEngineStarted;
        //    car.EngineStopped += CarEventHandler.OnEngineStopped;
        //    car.SpeedChanged += CarEventHandler.OnSpeedChanged;

        //    car.StartEngine();
        //    car.ChangeSpeed(20);
        //    car.ChangeSpeed(30);
        //    car.StopEngine();
        //    car.ChangeSpeed(50);
        //}
    }
}

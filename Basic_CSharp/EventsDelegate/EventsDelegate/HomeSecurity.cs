using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegate
{
    class DoorSensor
    {
        public event Action? DoorOpened;
        public event Action? DoorClosed;
        public event Action? DoorLeftOpenAlert;

        private bool isDoorOpened = false;

        public async void OpenDoor()
        {
            if (!isDoorOpened)
            {
                isDoorOpened = true;
                Console.WriteLine("Door is Opened!");
                DoorOpened?.Invoke();
            }

            await Task.Delay(5000);
            if(isDoorOpened)
            {
                Console.WriteLine("ALERT: Door has been left open for too long!");
                DoorLeftOpenAlert?.Invoke();
            }
        }
        public void CloseDoor()
        {
            if (isDoorOpened)
            {
                isDoorOpened = false;
                Console.WriteLine("Door is closed!");
                DoorClosed?.Invoke();
            }
        }
    }

    class MotionSensor
    {
        public event Action? MotionDetected;
        public event Action? MotionStopped;

        private bool isMotionDetected = false;

        public void DetectMotion()
        {
            if(!isMotionDetected)
            {
                isMotionDetected = true;
                Console.WriteLine("Motion Detected!");
                MotionDetected?.Invoke();
            }
        }
        public void StopMotion()
        {
            if (isMotionDetected)
            {
                isMotionDetected = false;
                Console.WriteLine("No Motion Detected!");
                MotionStopped?.Invoke();
            }
        }
    }
    class SecuritySystem
    {
        private DoorSensor doorSensor;
        private MotionSensor motionSensor;

        public SecuritySystem(DoorSensor doorSensor, MotionSensor motionSensor)
        {
            this.doorSensor = doorSensor;
            this.motionSensor = motionSensor;

            doorSensor.DoorClosed += OnDoorClosed;
            doorSensor.DoorOpened += OnDoorOpened;
            doorSensor.DoorLeftOpenAlert += OnDoorLeftOpen;
            motionSensor.MotionDetected += OnMotionDetected;
            motionSensor.MotionStopped += OnMotionStopped;
        }

        private void OnDoorOpened()
        {
            Console.WriteLine("🔔 Security System: Door Opened Event Triggered!");
        }

        private void OnDoorClosed()
        {
            Console.WriteLine("🔔 Security System: Door Closed Event Triggered!");
        }

        private void OnDoorLeftOpen()
        {
            Console.WriteLine("🚨 Security Alert: Door has been open for too long!");
        }

        private void OnMotionDetected()
        {
            Console.WriteLine("🔔 Security System: Motion Detected Event Triggered!");
        }

        private void OnMotionStopped()
        {
            Console.WriteLine("🔔 Security System: No Motion Detected Event Triggered!");
        }
    }
    class HomeSecurity
    {
        static void Main(string[] args)
        {
            DoorSensor doorSensor = new DoorSensor();
            MotionSensor motionSensor = new MotionSensor();
            SecuritySystem securitySystem = new SecuritySystem(doorSensor, motionSensor);

            Console.WriteLine("\n🏠 Smart Home Security System Started!\n");
            doorSensor.OpenDoor();
            Task.Delay(3000);
            motionSensor.DetectMotion();
            Task.Delay(2000);
            motionSensor.StopMotion();
            Task.Delay(6000);
            doorSensor.CloseDoor();
        }
    }
}

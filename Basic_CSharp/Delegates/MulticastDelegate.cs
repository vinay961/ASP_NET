
namespace Delegates
{
    public delegate void RectDelegate(int a, int b);
    class MulticastDelegate
    {
        public void getArea(int a, int b)
        {
            Console.WriteLine("Area is : " + (a * b));
        }
        public void getPerimeter(int a, int b)
        {
            Console.WriteLine("Perimeter is : " + 2 * (a + b));
        }

        //static void Main(string[] args)
        //{
        //    MulticastDelegate obj = new MulticastDelegate();

        //    // Create an instance of the delegate and pass the method as an argument to the delegate
        //    RectDelegate rectDelegate = new RectDelegate(obj.getArea);
        //    rectDelegate += obj.getPerimeter;
        //    rectDelegate.Invoke(10, 20);
        // }
    }
}

// In the above code, we have created a multicast delegate RectDelegate that can point to two methods getArea and getPerimeter.
// While using multicast delegate, we can use += operator to add multiple methods to the delegate.
// Important point is that, methods used for multicast delegate should have the same signature as the delegate.
// While using the multicast delegate, make sure that all the methods have return type void. Otherwise, all the results get override by the last method.
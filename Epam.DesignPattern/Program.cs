using System;

class OuterClass
{
    private string outerData = "Outer class data";

    // Inner class
    public class InnerClass
    {
        private string message;

        // Method returning 'this' to enable method chaining
        public InnerClass SetMessage(string msg)
        {
            this.message = msg;
            return this; // Returning the same instance
        }

        public InnerClass PrintMessage()
        {
            Console.WriteLine("Message: " + message);
            return this;
        }

        public InnerClass ShowGreeting()
        {
            Console.WriteLine("Hello from Inner Class!");
            return this;
        }
    }

    // Method to create and return an instance of InnerClass
    public InnerClass GetInnerInstance()
    {
        return new InnerClass();
    }
}

class Program
{
    static void Main()
    {
        // Accessing inner class using fluent syntax
        new OuterClass
            .InnerClass()
            .SetMessage("Fluent API in Inner Class")
            .PrintMessage()
            .ShowGreeting();
    }
}

using System;

class Person
{
    // Auto-implemented property for Name
    public string Name { get; set; }

    // Property for Age with validation
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age must be a positive number.");
            }
            age = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Create a new Person object
            Person person = new Person();

            // Prompt for Name
            Console.Write("Enter your name: ");
            person.Name = Console.ReadLine();

            // Prompt for Age
            Console.Write("Enter your age: ");
            person.Age = int.Parse(Console.ReadLine());

            // Display the person's details
            Console.WriteLine($"Name: {person.Name} Age: {person.Age}");
        }
        catch (ArgumentException ex)
        {
            // Handle invalid age
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (FormatException)
        {
            // Handle invalid input format
            Console.WriteLine("Error: Please enter a valid number for age.");
        }
    }
}


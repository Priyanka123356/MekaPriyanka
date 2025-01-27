using System;

class Program
{
    static void Main(string[] args)
    {
        const string CorrectUsername = "Alice";
        const string CorrectPassword = "Wonderland123";

        try
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                throw new Exception("Username cannot be empty.");
            }

            Console.Write("Enter your password: ");
            string password = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Password cannot be empty.");
            }

            if (string.Equals(username, CorrectUsername, StringComparison.OrdinalIgnoreCase) &&
                password == CorrectPassword)
            {
                Console.WriteLine($"Welcome, {username}! You have successfully logged in.");
            }
            else
            {
                Console.WriteLine("Login failed. Please check your username and password.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unhandled Exception: {ex.Message}");
        }
    }
}


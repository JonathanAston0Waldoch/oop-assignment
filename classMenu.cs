﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAssignment
{
    class classMenu
    {
        public void mainMenu()
        {
            int input;
            bool error;

            Console.Clear();
            Console.WriteLine("XYZ Airlines Limited.");
            Console.WriteLine("Please select a choice from the menu below:");
            Console.WriteLine("\n1: Customers");
            Console.WriteLine("2: Flights");
            Console.WriteLine("3: Bookings");
            Console.WriteLine("4: Exit");

            do
            {
                error = false;
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        customerMenu();
                        break;
                    case 2:
                        flightMenu();
                        break;
                    case 3:
                        bookingMenu();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please try again:");
                        error = true;
                        break;
                }
            } while (error);

        }
        public void customerMenu()
        {
            int input;
            bool error;

            Console.Clear();
            Console.WriteLine("XYZ AirLines Limited.");
            Console.WriteLine(" Customer Menu");
            Console.WriteLine("Please select a choice from the menu below:");
            Console.WriteLine("\n1. Add Customer");
            Console.WriteLine("2. View Customers");
            Console.WriteLine("3. Delete Customer");
            Console.WriteLine("4. Back to main menu");

            do
            {
                error = false;
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1: // Add Customer
                        Console.Clear();
                        string fName;
                        string lName;
                        long phone;
                        Console.WriteLine("Adding new customer...\nPlease enter the following:");
                        Console.Write("First Name: ");
                        fName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        lName = Console.ReadLine();
                        Console.Write("Phone Number (no dashes or spaces): ");
                        phone = Convert.ToInt64(Console.ReadLine());
                        m.addCustomer(fName, lName, phone);
                        Console.WriteLine("\nPress any key to go back to the Customer Menu...");
                        Console.ReadKey();
                        customerMenu();
                        break;
                    case 2: // View All Customers
                        Console.Clear();
                        Console.WriteLine(m.listAllCustomers());
                        Console.WriteLine("\nPress any key to go back to the Customer Menu...");
                        Console.ReadKey();
                        customerMenu();
                        break;
                    case 3: // Delete Customer
                        Console.Clear();
                        int delete;
                        Console.WriteLine(m.listAllCustomers());
                        Console.WriteLine("Removing a customer...");
                        Console.Write("\nEnter a Customer ID to delete: ");
                        delete = Convert.ToInt32(Console.ReadLine());
                        m.deleteCustomer(delete);
                        Console.WriteLine("\nPress any key to go back to the Customer Menu...");
                        Console.ReadKey();
                        customerMenu();
                        break;
                    case 4:
                        mainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please try again:");
                        error = true;
                        break;
                }
            } while (error);
        }

        public void flightMenu()
        {
            int input;
            bool error;

            Console.Clear();
            Console.WriteLine("XYZ AirLines Limited.");
            Console.WriteLine(" Flight Menu");
            Console.WriteLine("Please select a choice from the menu below:");
            Console.WriteLine("\n1. Add Flights");
            Console.WriteLine("2. View Flights");
            Console.WriteLine("3. View a particular Flight");
            Console.WriteLine("4. Delete Flight");
            Console.WriteLine("5. Back to main menu");

            do
            {
                error = false;
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        // add flight function
                        break;
                    case 2:
                        // view flight function
                        break;
                    case 3:
                        // view specific flight function
                        break;
                    case 4:
                        // delete flight
                        break;
                    case 5:
                        mainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please try again:");
                        error = true;
                        break;
                }
            } while (error);
        }

        public void bookingMenu()
        {
            int input;
            bool error;

            Console.Clear();
            Console.WriteLine("XYZ AirLines Limited.");
            Console.WriteLine(" Booking Menu");
            Console.WriteLine("Please select a choice from the menu below:");
            Console.WriteLine("\n1. Make Booking");
            Console.WriteLine("2. View Bookings");
            Console.WriteLine("3. Back to main menu");

            do
            {
                error = false;
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        // add booking function
                        break;
                    case 2:
                        // view booking function
                        break;
                    case 3:
                        mainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please try again:");
                        error = true;
                        break;
                }
            } while (error);
        }
    }
}

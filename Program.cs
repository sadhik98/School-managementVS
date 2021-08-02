using System;
//Program about the Employee Management System.
//In this program verify the Employee ACE ID,Employee Name,Employee Age and Date Birth of the Employee.  
//In this program Verify Employee Mobile number and Employee Mail ID.
//Pragram is last modification done on 07-Jul-2021,at 23:06 IST.
//Program author Sadhik for ACE ID, DOB &Age, Email ID.

public class Employee
{
    int check = 0, check1 = 0, check2 = 0, age4 = 0;
    public void VerifyEmployeeACEDetail()
    {
        // verify ACE ID
        //Program author Sadhik.
        while (check == 0 || check1 == 0)
        {
            check = 0;
            check1 = 0;
            Console.WriteLine("Enter the Employee ID");
            string data = Console.ReadLine();
            string numbers = "";
            string alpha = "";
            foreach (char c in data)
            {


                if (Char.IsDigit(c))
                {
                    numbers = numbers + c;
                }
                else if (Char.IsLetter(c))
                {
                    alpha = alpha + c;

                }
            }
            if (alpha == "ACE")
            {
                check = 1;
            }
            else if (alpha != "ACE")
            {
                Console.WriteLine("Invalid User ID Please Enter your ID correctly");
            }
            int alphaconverttonum = int.Parse(numbers);
            if ((alphaconverttonum > 999) && (alphaconverttonum < 9999))
            {
                check1 = 1;
            }
            else
            {
                Console.WriteLine("Invalid User ID Please Enter your ID correctly");
            }
        }

    }
    public void verifyEmployeeName()
    {
        // verify Employee Name 

        while (check == 1)
        {
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();
            if (name != "" && name.Length >= 3)
            {
                Console.WriteLine("Username is: " + name);
                check = 0;
            }
            else
                Console.WriteLine("Enter the valid name");
        }
    }
    public void VerifyEmployeeDateOfBirth()
    {
        // verify Employee DOB
        //Program author Sadhik.
        while (check == 0 || check1 == 0 || check2 == 0)
        {
            check = 0;
            check1 = 0;
            check2 = 0;
            Console.WriteLine("Enter your Date of Birth Properly");
            Console.WriteLine("Like This Format dd/MM/yyyy");
            string strDate = Console.ReadLine();
            string[] arrDate = strDate.Split('/');
            int day1 = int.Parse(arrDate[0]);
            int month2 = int.Parse(arrDate[1]);
            int year3 = int.Parse(arrDate[2]);
            if (day1 > 0 && day1 <= 31)
            {
                check = 1;
                if ((month2 > 0 && month2 <= 12))
                {
                    check1 = 1;
                    age4 = 2021 - year3;
                    if (age4 > 18 && age4 <= 60)
                    {
                        check2 = 1;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter the Valid Age Limit");
                    }
                }

            }
        }
        Console.WriteLine("Approximately Your Age is " + age4);
    }
    public void VerifyEmployeeMobileNo()
    {
        //verify Mobile Number

        while (check == 1)
        {
            Console.WriteLine("Enter ph no.- Note:Don't enter the number between 0 to 4");
            string num = Console.ReadLine();
            if (num.Length == 10 && num[0] != '0' && num[0] != '1' && num[0] != '2' && num[0] != '3' && num[0] != '4')
            {
                Console.WriteLine("Valid Mobile number");
                check = 0;
            }
            else
                Console.WriteLine("Please enter the correct number");
        }
    }
    public void VerifyEmployeeMail()
    {
        //verify EmailID
        //Program author Sadhik.
        //Pragram is last modification done on 07-Jul-2021.
        while (check == 0)
        {
            Console.WriteLine("Enter your Mail ID Properly");
            string EmailID = Console.ReadLine();
            string[] EmailIDPart = EmailID.Split('@');
            string FirstPosition = EmailIDPart[0];
            foreach (char find in FirstPosition)
            {
                if ((find != '!') && (find != '#') && (find != '$') && (find != '%') && (find != '^') && (find != '&') && (find != '*') && (find != '(') && (find != ')'))
                {
                    check = 1;
                }
                else
                {
                    check = 0;
                    Console.WriteLine("Please Enter your Mail ID Correctly");
                    break;
                }

            }

        }
        Console.WriteLine("Valid Email ID");
        Console.WriteLine("Thanks For your time. All the data are stored.");
    }
    public static void Main(string[] args)
    {

        Employee employee = new Employee();
        employee.VerifyEmployeeACEDetail();
        employee.verifyEmployeeName();
        employee.VerifyEmployeeDateOfBirth();
        employee.VerifyEmployeeMobileNo();
        employee.VerifyEmployeeMail();


    }
}
﻿namespace assignment1
{
    class Employee
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public double Salary { get; set; }
        public DateTime Doj { get; set; }

        public virtual void AcceptDetails()
        {
            Console.WriteLine("Enter Employee ID:");
            EmpId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            EmpName = Console.ReadLine();

            Console.WriteLine("Enter Date of Joining (dd/mm/yyyy) :");
            Doj = Convert.ToDateTime(Console.ReadLine());
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {EmpId}");
            Console.WriteLine($"Employee Name: {EmpName}");
            Console.WriteLine($"Date of Joining: {Doj}");
        }

        public virtual double CalculateSalary()
        {
            return Salary;
        }
    }
    class Permanent : Employee
    {
        public double BasicPay { get; set; }
        public double HRA { get; set; }
        public double DA { get; set; }
        public double PF { get; set; }

        public override void AcceptDetails()
        {
            base.AcceptDetails();

            Console.WriteLine("Enter Basic Pay:");
            BasicPay = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter HRA:");
            HRA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter DA:");
            DA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter PF:");
            PF = Convert.ToDouble(Console.ReadLine());
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Basic Pay: {BasicPay}");
            Console.WriteLine($"HRA: {HRA}");
            Console.WriteLine($"DA: {DA}");
            Console.WriteLine($"PF: {PF}");
        }

        public override double CalculateSalary()
        {
            Salary = BasicPay + HRA + DA - PF;
            return Salary;
        }
    }
    class Trainee : Employee
{
    public double Bonus { get; set; }
    public string? ProjectName { get; set; }

    public override void AcceptDetails()
    {
        base.AcceptDetails();

        Console.WriteLine("Enter Project Name:");
        ProjectName = Console.ReadLine();
        Console.WriteLine("Enter Salary:");
        Salary = double.Parse(Console.ReadLine());
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Project Name: {ProjectName}");
        // Console.WriteLine($"Calculated Salary: {CalculateSalary()}");
    }

    public override double CalculateSalary()
    {
        if (ProjectName.ToLower() == "banking")
            Bonus = 0.05*Salary;
        else if (ProjectName.ToLower() == "insurance")
            Bonus = 0.1*Salary;
        return Salary + Bonus;
    }
}

}

// namespace assignment1{
//     class Employee{
//         public int Empid{get; set;}
//         public string? Empname{get; set;}
//         public double Salary{get; set;}
//         public DateTime Doj{get; set;}
//         public void AcceptDetails(){ //this function is for taking details from the employee
//         Console.WriteLine("Enter Employee ID");
//         Empid=Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter Employee name");
//         Empname=Console.ReadLine();
//         Console.WriteLine("Enter salary");
//         Salary=Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Enter Date Of joining");
//         Doj=Convert.ToDateTime(Console.ReadLine());
//         }
//         public void DisplayDetails(){
//          Console.WriteLine("The Employee's ID is"+Empid);
//          Console.WriteLine("The Employee's name is"+Empname);
//          Console.WriteLine("The Employee's salary is"+Salary);
//          Console.WriteLine("The Employee's date of joining is"+Empid);
//         }
//         public virtual double CalculateSalary(){
//            return Salary;
//         }
//    }
//     class Permanent:Employee{
//        public double BasicPay{get; set;}
//        public double DA{get; set;}
//        public double HRA{get; set;}
//        public double PF{get; set;}
//        public void GetDetails(){
//         base.AcceptDetails();
//         Console.WriteLine("Enter Basic pay");
//         BasicPay=Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Enter DA");
//         DA=Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Enter HRA");
//         HRA=Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Enter PF");
//         PF=Convert.ToDouble(Console.ReadLine());
//         }
//        public void ShowDetails(){
//         base.DisplayDetails();
//          Console.WriteLine("The Basic pay is"+BasicPay);
//          Console.WriteLine("The DA is"+DA);
//          Console.WriteLine("The HRA is"+ HRA);
//          Console.WriteLine("The PF is"+ PF);
//         }
//         public override double CalculateSalary()
//         {
//             return BasicPay+HRA+DA-PF;
//         }
//     }
//     class Trainee:Employee{
//      public double bonus{get; set;}
//      public string? ProjectName{get; set;}
//      public void GetTraineeDetails(){
//       base.AcceptDetails();
//       Console.WriteLine("Enter Bonus");
//       bonus=Convert.ToDouble(Console.ReadLine());
//       Console.WriteLine("Enter Project name");
//       ProjectName=Console.ReadLine();
//      }
//      public void ShowTraineeDetails(){
//      base.DisplayDetails();
//      Console.WriteLine("The Bonus is"+bonus);
//      Console.WriteLine("Project Name"+ProjectName);
//      }
//         public override double CalculateSalary()
//         {
//             if (ProjectName=="Banking")
//             {
//                bonus=0.05*Salary;
//             }
//             if (ProjectName=="Insurance")
//             {
//                 bonus=0.1*Salary;
//             }
//             return Salary+bonus;
//         }
//     }
// }
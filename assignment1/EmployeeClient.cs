namespace assignment1
{
    class Empclient
    {
        static void Main(string[] args)
        {
            Permanent permanentEmployee = new Permanent();
            Console.WriteLine("Enter Permanent Employee Details:");
            permanentEmployee.AcceptDetails();
            permanentEmployee.DisplayDetails();
            Console.WriteLine($"Calculated Salary: {permanentEmployee.CalculateSalary()}");

            Trainee traineeEmployee = new Trainee();
            Console.WriteLine("\nEnter Trainee Employee Details:");
            traineeEmployee.AcceptDetails();
            traineeEmployee.DisplayDetails();
            Console.WriteLine($"Calculated Salary: {traineeEmployee.CalculateSalary()}");
        }


    }
}

// namespace assignment1{
//     class EmployeeClient{
//         public static void Main(){
//             Permanent p1=new Permanent();
//             Trainee t1=new Trainee();
//             System.Console.WriteLine("If you are a permanent employee type P or if you are a Trainee type T");
//             char? val=Convert.ToChar(Console.ReadLine());
//             if (val=='P')
//             {
//             p1.GetDetails();
//             p1.ShowDetails();  
//             }
//            if (val=='T')
//            {
//             t1.GetTraineeDetails();
//             t1.ShowTraineeDetails();
//            }
//             else
//             {
//             Console.WriteLine("Try Again");
//             }
//         }
//     }
// }
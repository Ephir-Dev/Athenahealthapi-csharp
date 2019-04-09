using System;
using AndriiKurdiumov.AuthenaHealth.Client;
using Microsoft.Rest;

namespace sample
{
    class Program
    {

        private static string tokenKey = "";
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Specify <token>");
                return;
            }

            tokenKey = args[0];
            var api = GetApi(1);
            var practices = api.GetPracticeInfo();
            Console.WriteLine($"Practices available: {practices.TotalCount}");
            foreach (var practice in practices.Practiceinfo)
            {
                Console.WriteLine($"Name: {practice.Name}");
                var papi = GetApi(int.Parse(practice.Practiceid));
                var departments = papi.GetDepartments();
                Console.WriteLine($"Departments available: {departments.TotalCount}");
                foreach (var department in departments.Departments)
                {
                    Console.WriteLine($"{department.Name}");
                }
            }
        }

        private static IAthenaHealth GetApi(int practiceId)
        {
            EnsureTokenObtained();
            var credentials = new TokenCredentials(tokenKey);
            var api = new AthenaHealth(new Uri($"https://api.athenahealth.com/preview1/{practiceId}"), credentials);
            return api;
        }

        private static void EnsureTokenObtained()
        {
            // get token from client data
        }
    }
}

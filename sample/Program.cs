using System;
using System.Collections.Generic;
using AndriiKurdiumov.AuthenaHealth.Client;
using AndriiKurdiumov.AuthenaHealth.Client.Models;
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
            PrintDepartments();

            CreatePatient();
        }

        private static void CreatePatient()
        {
            var clientApi = GetApi(195900);
            var patientResponse = clientApi.CreatePatient(
                address1: "adress",
                address2: string.Empty,
                city: "Boston",
                departmentid: 1,
                email: "test@test.com",
                dob: "03/01/1959",
                firstname: "Andy",
                //homephone: "declined",
                lastname: "Doe",
                //mobilephone: "declined",
                state: "MA",
                zip: "02111");
            switch (patientResponse)
            {
                case Error error:
                    Console.WriteLine(error.ErrorProperty);
                    if (error.Missingfields != null)
                    {
                        Console.WriteLine(string.Join(", ", error.Missingfields));
                    }

                    return;
                case IList<PatientCreatedResponse> created:
                    Console.WriteLine("Patient created");
                    foreach (var item in created)
                    {
                        Console.WriteLine(item.PatientId);
                        var patient = clientApi.GetPatientById(item.PatientId.Value)[0];
                        Console.WriteLine($"{patient.Firstname}");
                        Console.WriteLine($"{patient.Lastname}");
                        Console.WriteLine($"{patient.Email}");
                        Console.WriteLine($"{patient.Emailexistsyn}");
                    }

                    return;
            }
        }

        private static void PrintDepartments()
        {
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

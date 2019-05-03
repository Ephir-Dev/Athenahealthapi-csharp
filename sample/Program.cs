using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AndriiKurdiumov.AuthenaHealth.Client;
using AndriiKurdiumov.AuthenaHealth.Client.Models;
using IdentityModel.Client;
using Microsoft.Rest;

namespace sample
{
    class Program
    {
        private static string tokenKey = "";
        private static string clientId = "";
        private static string clientSecret = "";
        private static DateTime expiresIn = DateTime.MinValue;

        static async Task Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Specify <client-id> <client-secret>");
                return;
            }

            clientId = args[0];
            clientSecret = args[1];

            await PrintDepartmentsAsync().ConfigureAwait(false);
            await PrintProvidersAsync().ConfigureAwait(false);
            await CreatePatientAsync().ConfigureAwait(false);
        }

        private static async Task CreatePatientAsync()
        {
            var clientApi = await GetApiAsync(195900);
            var patientResponse = await clientApi.CreatePatientAsync(
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
                zip: "02111").ConfigureAwait(false);
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

        private static async Task PrintDepartmentsAsync()
        {
            var api = await GetApiAsync(1).ConfigureAwait(false);
            var practices = api.GetPracticeInfo();
            Console.WriteLine($"Practices available: {practices.TotalCount}");
            foreach (var practice in practices.Practiceinfo)
            {
                Console.WriteLine($"Name: {practice.Name}");
                var papi = await GetApiAsync(int.Parse(practice.Practiceid)).ConfigureAwait(false);
                var departments = papi.GetDepartments();
                Console.WriteLine($"Departments available: {departments.TotalCount}");
                foreach (var department in departments.Departments)
                {
                    Console.WriteLine($"{department.Name}");
                }
            }
        }

        private static async Task PrintProvidersAsync()
        {
            var api = await GetApiAsync(195900).ConfigureAwait(false);
            var providers = await api.GetProvidersAsync();
            Console.WriteLine($"Practices available: {providers.TotalCount}");
            foreach (var provider in providers.Providers)
            {
                Console.WriteLine($"ID: {provider.Providerid}");
                Console.WriteLine($"Name: {provider.Providerusername}");
                Console.WriteLine($"NPI: {provider.Npi}");
                //var departments = papi.GetDepartments();
                //Console.WriteLine($"Departments available: {departments.TotalCount}");
                //foreach (var department in departments.Departments)
                //{
                //    Console.WriteLine($"{department.Name}");
                //}
            }
        }

        private static async Task<IAthenaHealth> GetApiAsync(int practiceId)
        {
            await EnsureTokenObtainedAsync();
            var api = new AthenaHealth(new Uri($"https://api.athenahealth.com/"));
            api.HttpClient.SetBearerToken(tokenKey);
            api.Apivariant = "preview1";
            api.Practiceid = practiceId;
            return api;
        }
        private static async Task EnsureTokenObtainedAsync()
        {
            if (!string.IsNullOrWhiteSpace(tokenKey) && DateTime.UtcNow < expiresIn)
            {
                return;
            }

            // get token from client data
            var client = new HttpClient();
            var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = "https://api.athenahealth.com/oauthpreview/token",

                ClientId = clientId,
                ClientSecret = clientSecret,
            });

            if (tokenResponse.IsError)
            {
                Console.WriteLine(tokenResponse.Error);
                return;
            }

            tokenKey = tokenResponse.AccessToken;
            expiresIn = new DateTime(tokenResponse.ExpiresIn);
        }
    }
}

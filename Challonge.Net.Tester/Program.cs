using Challonge.Net.Models;
using Microsoft.Rest;
using System;

namespace Challonge.Net.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ChallongeApi challongeApi = new ChallongeApi(new System.Net.Http.HttpClient(), null);


            challongeApi.ApiKey = "QmEFdJ0xtKy6TqcXoXm0YiTxXuONlYBxoYaC1WHM";

            Models.TournamentElement cr = null;

            try
            {
                cr = challongeApi.Tournaments.PostTournament(new Models.CreateTournament()
                {
                    Url = "eerrr"
                });
            }
            catch (HttpOperationException e)
            {
                var errors = Errors.FromJson(e.Response.Content);
                throw;
            }
            

            var c = challongeApi.Tournaments.GetTournament("692tf7fz", true, true);

            Console.ReadKey();
        }
    }
}

using System;
using System.Security.AccessControl;

using SampleFrontEnd.Services;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var htpService = new CardGameHttpService(new Uri("https://localhost:7049"));


            var startGame = await htpService.StartGame("hicard");
            Console.WriteLine($"Game of type {startGame.GameType} started at {startGame.StartTime}");

            var endGame = await htpService.EndGame();
            Console.WriteLine($"Game of type {startGame.GameType} end at {startGame.EndTime}");


        }
    }
}


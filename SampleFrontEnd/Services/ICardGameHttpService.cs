using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SampleFrontEnd.Models;


namespace SampleFrontEnd.Services
{
    public interface ICardGameHttpService
    {
        Task<GameStatus> StartGame(string gameType);
        /*
        Task<GameStatus> EndGame();

        Task<PlayingCard> DealCard();
        Task<IEnumerable<PlayingCard>> DealCards(int nrOfCards);

        Task<IEnumerable<PlayingCard>> WinningCards(IEnumerable<PlayingCard> hand);
        */
    }
}



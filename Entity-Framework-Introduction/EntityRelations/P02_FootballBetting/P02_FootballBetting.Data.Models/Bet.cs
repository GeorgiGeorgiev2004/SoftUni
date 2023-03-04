using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBetting.Data.Models;

public class Bet
{
    public int BetId { get; set; }
    public decimal Amount { get; set; }
    public Predictions Prediction { get; set; }
    public DateTime DateTime { get; set; }
    [ForeignKey(nameof(User))]
    public int UserId { get; set; }
    public User User { get; set; }

    [ForeignKey(nameof(Game))]
    public int GameId { get; set; }
    public Game Game { get; set; }

    public enum Predictions
    {
        HomeWin = 1,
        AwayWin = 2,
        Draw = 3
    }
}

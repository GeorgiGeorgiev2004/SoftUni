using System.ComponentModel.DataAnnotations.Schema;

namespace P02_FootballBetting.Data.Models;

public class Player
{
    public Player()
    {
        this.PlayersStatistics = new HashSet<PlayerStatistic>();
    }
    public int PlayerId { get; set; }
    public string Name { get; set; }
    public int SquadNumber { get; set; }
    [ForeignKey(nameof(Team))]
    public int TeamId { get; set; }
    public Team Team { get; set; }

    [ForeignKey(nameof(Position))]
    public int PositionId { get; set; }
    public Position Position { get; set; }
    public bool IsInjured { get; set; }
    public ICollection<PlayerStatistic> PlayersStatistics { get; set; }
}

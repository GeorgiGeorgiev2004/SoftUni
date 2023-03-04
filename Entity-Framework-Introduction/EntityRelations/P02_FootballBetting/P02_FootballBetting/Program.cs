namespace P02_FootballBetting
{
    using P02_FootballBetting.Data;
    using Microsoft.EntityFrameworkCore;
    public class Program
    {
        static void Main(string[] args)
        {
            using (FootballBettingContext context = new FootballBettingContext())
            {
                context.Database.EnsureDeleted(); 
                context.Database.EnsureCreated();
            }
        }
    }
}
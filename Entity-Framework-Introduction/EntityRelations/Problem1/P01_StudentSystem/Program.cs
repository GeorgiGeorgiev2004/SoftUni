using P01_StudentSystem.Data;

namespace P01_StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentSystemContext())
            {
                
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }
    }
}
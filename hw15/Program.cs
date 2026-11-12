namespace hw15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>()
            {
                new Player { Name = "Mari",   Score = 85,  IsActive = true },
                new Player { Name = "Nino",   Score = 92,  IsActive = false },
                new Player { Name = "Ana",    Score = 70,  IsActive = true },
                new Player { Name = "Giorgi", Score = 55,  IsActive = true },
                new Player { Name = "Luka",   Score = 100, IsActive = false },
                new Player { Name = "Dato",   Score = 63,  IsActive = true },
                new Player { Name = "Sandro", Score = 48,  IsActive = false },
                new Player { Name = "Tamar",  Score = 77,  IsActive = true },
                new Player { Name = "Keti",   Score = 90,  IsActive = true },
                new Player { Name = "Beka",   Score = 39,  IsActive = true }
            };

        
            Console.WriteLine("--- Sorted by score (descending) ---");
            var sorted = players.OrderByDescending(x => x.Score);

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

           
            Console.WriteLine("\n--- Active players ---");
            var activePlayers = players.Where(x => x.IsActive);

            foreach (var item in activePlayers)
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine("\n--- Max score player ---");
            var best = players.OrderByDescending(x => x.Score).First();
            Console.WriteLine(best);

        
            Console.WriteLine("\n--- Min score active player ---");
            var worstActive = players.Where(x => x.IsActive).OrderBy(x => x.Score).First();
            Console.WriteLine(worstActive);
        
    }
    }
}

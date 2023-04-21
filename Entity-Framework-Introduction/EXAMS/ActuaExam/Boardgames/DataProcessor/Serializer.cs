namespace Boardgames.DataProcessor
{
    using Boardgames.Data;
    using Boardgames.Data.Models;
    using Boardgames.Data.Models.Enums;
    using Boardgames.DataProcessor.ExportDto;
    using Boardgames.Utilities;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    public class Serializer
    {
        public static string ExportCreatorsWithTheirBoardgames(BoardgamesContext context)
        {
            StringBuilder sb = new StringBuilder();
            XmlRootAttribute xmlRoot =
                new XmlRootAttribute("Creators");
            XmlSerializer xmlSerializer =
                new XmlSerializer(typeof(ExportXmlDto[]), xmlRoot);
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            var creators = context.Creators
               .ToArray()
               .Where(c => c.Boardgames.Count > 0)
               .Select(c => new ExportXmlDto()
               {
                   CreatorName = c.FirstName + " " + c.LastName,
                   Count = c.Boardgames.Count,
                   Boardgames = c.Boardgames
                   .Select(s => new ExportBoardgamesDto()
                   {
                       Name = s.Name,
                       YearPublished = s.YearPublished,
                   })
                   .OrderBy(x => x.Name)
                   .ToArray()
               })
               .OrderByDescending(b => b.Boardgames.Count())
               .ThenBy(c => c.CreatorName).ToArray();

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                NewLineChars = "\r\n",
                NewLineHandling = NewLineHandling.Replace
            };
            using XmlWriter writer = XmlWriter.Create(sb, settings);
            xmlSerializer.Serialize(writer, creators, namespaces);
            return sb.ToString().TrimEnd();

        }

        public static string ExportSellersWithMostBoardgames(BoardgamesContext context, int year, double rating)
        {
            var SellersWithBoardgames = context.Sellers
                .Include(c=>c.BoardgamesSellers)
                .ThenInclude(c=>c.Boardgame)
                .AsNoTracking()
                .ToArray()
                .Where(s => s.BoardgamesSellers.Count > 0 &&
                s.BoardgamesSellers.Any(bs => bs.Boardgame.YearPublished >= year &&
                bs.Boardgame.Rating <= rating))
                .Select(s => new
                {
                    Name = s.Name,
                    Website = s.Website,
                    Boardgames = s.BoardgamesSellers
                    .Where(bs => bs.Boardgame.YearPublished >= year &&
                    bs.Boardgame.Rating <= rating)
                    .Select(bs => new 
                    {
                        Name = bs.Boardgame.Name,
                        Rating = bs.Boardgame.Rating,
                        Mechanics = bs.Boardgame.Mechanics,
                        Category = bs.Boardgame.CategoryType.ToString(),
                    })
                    .OrderByDescending(b=>b.Rating)
                    .ThenBy(bs => bs.Name)
                })
                .ToArray()
                .OrderByDescending(c => c.Boardgames.Count())
                .ThenBy(c => c.Name)
                .Take(5);
            return JsonConvert.SerializeObject(SellersWithBoardgames, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
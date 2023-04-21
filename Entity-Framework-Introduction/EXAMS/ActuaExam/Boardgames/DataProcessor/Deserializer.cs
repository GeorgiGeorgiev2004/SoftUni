namespace Boardgames.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics;
    using System.Text;
    using Boardgames.Data;
    using Boardgames.Data.Models;
    using Boardgames.Data.Models.Enums;
    using Boardgames.DataProcessor.ImportDto;
    using Boardgames.Utilities;
    using Microsoft.IdentityModel.Tokens;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedCreator
            = "Successfully imported creator – {0} {1} with {2} boardgames.";

        private const string SuccessfullyImportedSeller
            = "Successfully imported seller - {0} with {1} boardgames.";

        public static string ImportCreators(BoardgamesContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();
            XmlHelper helper = new XmlHelper();
            ImportDtoXml[] Dtos = helper.Deserialize<ImportDtoXml[]>(xmlString, "Creators");
            ICollection<Creator> validDtos = new HashSet<Creator>();
            foreach (var dto in Dtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Creator creator = new Creator() 
                {
                    FirstName= dto.FirstName,
                    LastName= dto.LastName
                };
                foreach (var boardgame in dto.Boardgames)
                {
                    if (!IsValid(boardgame))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    Boardgame bg = new Boardgame() 
                    {
                        Name= boardgame.Name,
                        Rating= boardgame.Rating,
                        YearPublished= boardgame.YearPublished,
                        CategoryType = (CategoryType) boardgame.CategoryType,
                        Mechanics= boardgame.Mechanics,
                    };
                    creator.Boardgames.Add(bg);
                }
                validDtos.Add(creator);
                sb.AppendLine(string.Format(SuccessfullyImportedCreator, creator.FirstName,creator.LastName,creator.Boardgames.Count));
            }
            context.Creators.AddRange(validDtos);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportSellers(BoardgamesContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            ImportJsonSeller[] Dtos = JsonConvert.DeserializeObject<ImportJsonSeller[]>(jsonString);
            ICollection<Seller> ValidSellers = new HashSet<Seller>();
            ICollection<int> Ids = context.Boardgames
                .Select(x => x.Id)
                .ToArray();
            foreach (var dto in Dtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                Seller seller = new Seller()
                {
                    Name = dto.Name,
                    Address = dto.Address,
                    Country = dto.Country,
                    Website = dto.Website,
                };

                foreach (var item in dto.Boardgames.Distinct())
                {
                    if (!Ids.Contains(item))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    BoardgameSeller bs = new BoardgameSeller()
                    {
                        Seller = seller,
                        BoardgameId = item
                    };

                    seller.BoardgamesSellers.Add(bs);
                }

                ValidSellers.Add(seller);
                sb.AppendLine(string.Format(SuccessfullyImportedSeller, seller.Name, seller.BoardgamesSellers.Count));

            }

            context.Sellers.AddRange(ValidSellers);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }
        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}

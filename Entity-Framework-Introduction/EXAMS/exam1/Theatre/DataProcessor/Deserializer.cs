namespace Theatre.DataProcessor
{
    using AutoMapper;
    using Castle.Core.Internal;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Numerics;
    using System.Text;
    using Theatre.Data;
    using Theatre.Data.Models;
    using Theatre.Data.Models.Enums;
    using Theatre.DataProcessor.ImportDto;
    using Theatre.Utilities;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfulImportPlay
            = "Successfully imported {0} with genre {1} and a rating of {2}!";

        private const string SuccessfulImportActor
            = "Successfully imported actor {0} as a {1} character!";

        private const string SuccessfulImportTheatre
            = "Successfully imported theatre {0} with #{1} tickets!";



        public static string ImportPlays(TheatreContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();
            IMapper map = InitializeAutoMapper();
            List<string> list = new List<string> { "Comedy", "Drama", "Romance", "Musical" };
        XmlHelper helper = new XmlHelper();
            ImportPlaysDto[] PlaysDto = helper
                .Deserialize<ImportPlaysDto[]>(xmlString, "Plays"); 
            ICollection<Play> ValidPlays = new HashSet<Play>();
            foreach (var pplay in PlaysDto)
            {
                var currentTime = TimeSpan.ParseExact(pplay.Duration, "c", CultureInfo.InvariantCulture);
                var mintime = new TimeSpan(1,0,0);
                if (!IsValid(pplay) ||
                    (currentTime < mintime) ||
                    (!list.Contains(pplay.Genre.ToString())))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Play play = new Play() 
                {
                    Title = pplay.Title,
                    Duration = TimeSpan.Parse(pplay.Duration),
                    Rating = float.Parse(pplay.Rating.ToString()),
                    Genre = pplay.Genre,
                    Description= pplay.Description,
                    Screenwriter= pplay.Screenwriter,
                };
                ValidPlays.Add(play);
                sb.AppendLine(string.Format(SuccessfulImportPlay, play.Title, play.Genre, play.Rating));
            }
            context.AddRange(ValidPlays);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportCasts(TheatreContext context, string xmlString)
        {
            throw new NotImplementedException();
        }

        public static string ImportTtheatersTickets(TheatreContext context, string jsonString)
        {
            throw new NotImplementedException();
        }


        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
        private static IMapper InitializeAutoMapper()
           => new Mapper(new MapperConfiguration(cfg =>
           {
               cfg.AddProfile<TheatreProfile>();
           }));
    }
}

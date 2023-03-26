namespace Trucks.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using Data;
    using Newtonsoft.Json;
    using Trucks.Data.Models;
    using Trucks.Data.Models.Enums;
    using Trucks.DataProcessor.ImportDto;
    using Trucks.Utilities;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedDespatcher
            = "Successfully imported despatcher - {0} with {1} trucks.";

        private const string SuccessfullyImportedClient
            = "Successfully imported client - {0} with {1} trucks.";

        public static string ImportDespatcher(TrucksContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();
            XmlHelper helper = new XmlHelper();
            ImportDespatcherDto[] Dtos= helper.Deserialize<ImportDespatcherDto[]>(xmlString, "Despatchers");
            ICollection<Despatcher> validDtos = new HashSet<Despatcher>();
            foreach (var dto in Dtos)
            {
                if (!IsValid(dto)||string.IsNullOrEmpty(dto.Position))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                Despatcher dsp = new Despatcher()
                {
                    Name= dto.Name,
                    Position= dto.Position
                };
                foreach (var truck in dto.Trucks)
                {
                    if (!IsValid(truck))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    Truck t = new Truck()
                    {
                        RegistrationNumber= truck.RegistrationNumber,
                        VinNumber = truck.VinNumber,
                        TankCapacity = truck.TankCapacity,
                        CargoCapacity = truck.CargoCapacity,
                        CategoryType = (CategoryType)truck.CategoryType,
                        MakeType= (MakeType)truck.MakeType,
                    };
                    dsp.Trucks.Add(t);
                }
                validDtos.Add(dsp);
                sb.AppendLine(string.Format(SuccessfullyImportedDespatcher, dsp.Name, dsp.Trucks.Count()));
            }
            context.AddRange(validDtos);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }
        public static string ImportClient(TrucksContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            ImportClientDto[] Dtos = JsonConvert.DeserializeObject<ImportClientDto[]>(jsonString);
            List<Client> ValidClients = new List<Client>();
            foreach (var dto in Dtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                 continue;
                }
                Client client = new Client() 
                {
                    Name= dto.Name,
                    Nationality= dto.Nationality,
                    Type= dto.Type,
                };
                if (client.Type == "usual")
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
               
                foreach (var truck in dto.Trucks.Distinct())
                {
                    Truck t = context.Trucks.Find(truck);
                    if (t == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    client.ClientsTrucks.Add(new ClientTruck()
                    {
                        Truck = t
                    });
                }
                ValidClients.Add(client);
                sb.AppendLine(String.Format(SuccessfullyImportedClient, client.Name, client.ClientsTrucks.Count));
            }
            context.Clients.AddRange(ValidClients);
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
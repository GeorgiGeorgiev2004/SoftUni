using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProductShop.DTOs.Export;

public class ExportUserStuff
{
    public class ProductsDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("price")]
        public decimal Price { get; set; }
    }

    public class UserDto
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("age")]
        public int? Age { get; set; }
        [JsonProperty("soldProducts")]
        public SoldProducts SoldProducts { get; set; }
    }

    public class SoldProducts
    {
        public SoldProducts()
        {
            this.Products = new List<ProductsDto>();
        }
        [JsonProperty("count")]
        public int Count { get => this.Products.Count; }
        [JsonProperty("products")]
        public List<ProductsDto> Products { get; set; }
    }

    public class UsersAndProductsDto
    {
        public UsersAndProductsDto()
        {
            this.Users = new List<UserDto>();
        }
        [JsonProperty("usersCount")]
        public int UsersCount { get => this.Users.Count; }
        [JsonProperty("users")]
        public List<UserDto> Users { get; set; }
    }
}

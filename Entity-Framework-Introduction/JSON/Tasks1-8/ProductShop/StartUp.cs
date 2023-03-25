

namespace ProductShop;

using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProductShop.Data;
using ProductShop.DTOs.Export;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using System.Linq.Expressions;
using static ProductShop.DTOs.Export.ExportUserStuff;

public class StartUp
{
    public static void Main()
    {
        ProductShopContext context = new ProductShopContext();
        string result = GetUsersWithProducts(context);
        Console.WriteLine(result);
    }
    public static string ImportUsers(ProductShopContext context, string inputJson)
    {
        IMapper map = CreateMapper();
        ImportUserDto[] userDtos = JsonConvert.DeserializeObject<ImportUserDto[]>(inputJson);
        ICollection<User> validUsers = new HashSet<User>();
        foreach (var userdto in userDtos)
        {
            User user = map.Map<User>(userdto);
            validUsers.Add(user);
        }
        context.AddRange(validUsers);
        context.SaveChanges();
        return $"Successfully imported {validUsers.Count}";
    }
    public static string ImportProducts(ProductShopContext context, string inputJson) 
    {
        IMapper map = CreateMapper();
        ImportProductDto[] productDtos 
            = JsonConvert.DeserializeObject<ImportProductDto[]>(inputJson);
        ICollection<Product> validproducts = new HashSet<Product>();
        foreach (var productDto in productDtos)
        {
            Product product = map.Map<Product>(productDto);
            validproducts.Add(product);
        }
        context.AddRange(validproducts);
        context.SaveChanges();
        return $"Successfully imported {validproducts.Count}";
    }

    public static string ImportCategories(ProductShopContext context, string inputJson) 
    {
        IMapper map = CreateMapper();
        ImportCategoryDto[] categoryDtos = JsonConvert.DeserializeObject<ImportCategoryDto[]>(inputJson);
        ICollection<Category> ValidCategories = new HashSet<Category>();
        foreach (var category in categoryDtos)
        {
            Category ctg = map.Map<Category>(category);
            if (ctg.Name!=null)
            {
                ValidCategories.Add(ctg);
            }
        }
        context.AddRange(ValidCategories);
        context.SaveChanges();
        return $"Successfully imported {ValidCategories.Count}";

    }

    public static string ImportCategoryProducts(ProductShopContext context, string inputJson) 
    {
        IMapper map = CreateMapper();
        ImportCategoryProductDto[] CategoryProductDtos = JsonConvert.DeserializeObject<ImportCategoryProductDto[]>(inputJson);
        ICollection<CategoryProduct> ValidCategoriProoducts = new HashSet<CategoryProduct>();
        foreach (var CategoryProductDto in CategoryProductDtos)
        {
            if (!context.Categories.Any(c => c.Id == CategoryProductDto.CategoryId) ||
                    !context.Products.Any(p => p.Id == CategoryProductDto.ProductId))
            {
                continue;
            }
            CategoryProduct ctp = map.Map<CategoryProduct>(CategoryProductDto);
            ValidCategoriProoducts.Add(ctp);
        }
        context.AddRange(ValidCategoriProoducts);
        context.SaveChanges();
        return $"Successfully imported {ValidCategoriProoducts.Count}";
    }

    public static string GetProductsInRange(ProductShopContext context) 
    {
        IMapper map = CreateMapper();
        var productsInfo= context.Products
            .Where(p=>p.Price>=500 &&p.Price<=1000)
            .OrderBy(p=>p.Price)
            .AsNoTracking()
            .ProjectTo<ExportProductByPriceDto>(map.ConfigurationProvider)
            .ToList();
        return JsonConvert.SerializeObject(productsInfo, Formatting.Indented);
    }

    public static string GetSoldProducts(ProductShopContext context)
    {
        IMapper map = CreateMapper();
        var userInfo = context.Users
            .Include(x => x.ProductsSold)
            .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
            .OrderBy(u => u.LastName)
            .ThenBy(u => u.FirstName)
            .ProjectTo<ExportSoldProducts>(map.ConfigurationProvider)
            .ToList();
        return JsonConvert.SerializeObject(userInfo, Formatting.Indented);
    }

    public static string GetCategoriesByProductsCount(ProductShopContext context)
    {
        IMapper map = CreateMapper();
        var categories = context.Categories
            .OrderByDescending(c => c.CategoriesProducts.Count)
            .ProjectTo<ExportCategoriesByCount>(map.ConfigurationProvider)
            .ToList();

        return JsonConvert.SerializeObject(categories, Formatting.Indented);

    }

    public static string GetUsersWithProducts(ProductShopContext context) 
    {
        IMapper map = CreateMapper();
        var users = context.Users
            .Include(u=>u.ProductsSold)
            .Where(u => u.ProductsSold.Count > 0 && u.ProductsSold.Any(p => p.BuyerId != null))
            .OrderByDescending(u => u.ProductsSold.Count(p => p.Buyer != null))
            .ProjectTo<UserDto>(map.ConfigurationProvider)
            .ToList();

        var objectToSerialize = map.Map<UsersAndProductsDto>(users);

        return JsonConvert.SerializeObject(objectToSerialize, new JsonSerializerSettings()
        {
            NullValueHandling = NullValueHandling.Ignore,
            Formatting = Formatting.Indented
        });

    }
    private static IMapper CreateMapper()
    {
        return new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<ProductShopProfile>();
        }));
    } 
}
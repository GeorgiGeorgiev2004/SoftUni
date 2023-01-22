using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Repositories
{
    public class CocktailRepository : IRepository<ICocktail>
    {
        List<ICocktail> models = new List<ICocktail>();
        public IReadOnlyCollection<ICocktail> Models => models;

        public void AddModel(ICocktail model)
        {
            models.Add(model);
        }
    }
}

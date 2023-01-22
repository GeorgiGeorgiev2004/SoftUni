using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Repositories
{
    public class BoothRepository : IRepository<IBooth>
    {
        List<IBooth> models = new List<IBooth>();
        public IReadOnlyCollection<IBooth> Models => models;

        public void AddModel(IBooth model)
        {
            models.Add(model);
        }
    }
}

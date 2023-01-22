﻿using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Repositories
{
    public class DelicacyRepository : IRepository<IDelicacy>
    {
        List<IDelicacy> models = new List<IDelicacy>();
        public IReadOnlyCollection<IDelicacy> Models => models;

        public void AddModel(IDelicacy model)
        {
            models.Add(model);
        }
    }
}

using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ChristmasPastryShop.Models
{
    public class Booth : IBooth
    {
        private int boothID;
        private int capacity;
        private double bill = 0;
        private double turnover = 0;
        private bool reserved = false;
        DelicacyRepository delicacyRepository;
        CocktailRepository cocktailRepository;
        public Booth(int boothId, int capacity)
        {
            BoothId = boothId;
            Capacity = capacity;
            cocktailRepository = new CocktailRepository();
            delicacyRepository = new DelicacyRepository();
        }
        public int BoothId
        {
            get { return boothID; }
            private set { boothID = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            private set 
            {
                if (value<=0)
                {
                    throw new ArgumentException(Utilities.Messages.ExceptionMessages.CapacityLessThanOne);
                }
                capacity = value;
            }
        }
        public IRepository<IDelicacy> DelicacyMenu => delicacyRepository;

        public IRepository<ICocktail> CocktailMenu => cocktailRepository;

        public double CurrentBill => bill;

        public double Turnover => turnover;

        public bool IsReserved => reserved;

        public void ChangeStatus()
        {
            if (IsReserved)
            {
                reserved = false;
            }
            else reserved = true;
        }

        public void Charge()
        {
            turnover += bill;
            bill = 0;
        }

        public void UpdateCurrentBill(double amount)
        {
            bill += amount;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Booth: {boothID}");
            sb.AppendLine($"Turnover: {turnover:F2} lv");
            sb.AppendLine($"-Cocktail menu:");
            foreach (var item in CocktailMenu.Models)
            {
                sb.AppendLine($"--{item.ToString()}");
            }
            sb.AppendLine($"-Delicacy menu:");
            foreach (var item in DelicacyMenu.Models)
            {
                sb.AppendLine($"--{item.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}

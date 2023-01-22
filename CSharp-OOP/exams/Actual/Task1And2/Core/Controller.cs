using ChristmasPastryShop.Core.Contracts;
using ChristmasPastryShop.Models;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ChristmasPastryShop.Core
{
    public class Controller : IController
    {
        private BoothRepository booths;
        public Controller()
        {
            booths = new BoothRepository();
        }
        public string AddBooth(int capacity)
        {
            Booth booth = new Booth(booths.Models.Count + 1, capacity);
            booths.AddModel(booth);
            return $"Added booth number {booth.BoothId} with capacity {capacity} in the pastry shop!";
        }

        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {
            if (cocktailTypeName != "MulledWine" && cocktailTypeName != "Hibernation")
            {
                return $"Cocktail type {cocktailTypeName} is not supported in our application!";
            }
            if (size!="Large"&& size != "Small" && size != "Middle")
            {
                return $"{size} is not recognized as valid cocktail size!";
            }
            ICocktail delicacy;
            if (cocktailTypeName == "MulledWine")
            {
                delicacy = new MulledWine(cocktailName,size);
            }
            else
            {
                delicacy = new Hibernation(cocktailName,size);
            }
            if (booths.Models.First(b => b.BoothId == boothId).CocktailMenu.Models.Any(n => n.Name == cocktailName && n.Size == size))
            {
                return $"{cocktailName} is already added in the pastry shop!";
            }
            booths.Models.First(b => b.BoothId == boothId).CocktailMenu.AddModel(delicacy);
            return $"{size} {cocktailName} {cocktailTypeName} added to the pastry shop!";
        }

        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {
            if (delicacyTypeName != "Gingerbread" && delicacyTypeName != "Stolen")
            {
                return $"Delicacy type {delicacyTypeName} is not supported in our application!";
            }
            IDelicacy delicacy;
            if (delicacyTypeName == "Gingerbread")
            {
                delicacy = new Gingerbread(delicacyName);

            }
            else
            {
                delicacy = new Stolen(delicacyName);
            }
            if (booths.Models.First(b => b.BoothId == boothId).DelicacyMenu.Models.Any(n => n.Name == delicacyName))
            {
                return $"{delicacyName} is already added in the pastry shop!";
            }
            booths.Models.First(b => b.BoothId == boothId).DelicacyMenu.AddModel(delicacy);
            return $"{delicacyTypeName} {delicacyName} added to the pastry shop!";
        }

        public string BoothReport(int boothId)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in booths.Models)
            {
                if (item.BoothId == boothId)
                {
                    sb.AppendLine($"Booth: {boothId}");
                    sb.AppendLine($"Capacity: {item.Capacity}");
                    sb.AppendLine($"Turnover: {item.Turnover:f2} lv");
                    sb.AppendLine($"-Cocktail menu:");
                    foreach (var cocktail in item.CocktailMenu.Models)
                    {
                        sb.AppendLine($"--{cocktail.ToString()}");
                    }
                    sb.AppendLine($"-Delicacy menu:");
                    foreach (var delicacy in item.DelicacyMenu.Models)
                    {
                        sb.AppendLine($"--{delicacy.ToString()}");
                    }
                }
            }
            return sb.ToString();
        }

        public string LeaveBooth(int boothId)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in booths.Models)
            {
                if (item.BoothId == boothId)
                {
                    item.Charge();
                    item.ChangeStatus();
                    sb.AppendLine($"Bill {item.CurrentBill:f2} lv");
                    sb.AppendLine($"Booth {boothId} is now available!");
                }
            }
            return sb.ToString().TrimEnd();
        }

        public string ReserveBooth(int countOfPeople)
        {
            BoothRepository availiable = new BoothRepository();
            foreach (var item in booths.Models)
            {
                if (!item.IsReserved && countOfPeople <= item.Capacity)
                {
                    availiable.AddModel(item);
                }
            }
            if (availiable.Models.Count == 0)
            {
                return $"No available booth for {countOfPeople} people!";
            }
            else availiable.Models.OrderBy(x => x.Capacity).ThenByDescending(x => x.BoothId);
            availiable.Models.First().ChangeStatus();
            return $"Booth {availiable.Models.First().BoothId} has been reserved for {countOfPeople} people!";
        }
        public string TryOrder(int boothId, string order)
        {
            string itemTypeName = order.Split("/", StringSplitOptions.RemoveEmptyEntries)[0];
            string itemName = order.Split("/", StringSplitOptions.RemoveEmptyEntries)[1];
            int countOfOrderedItems = int.Parse(order.Split("/", StringSplitOptions.RemoveEmptyEntries)[2]);
            string size = "";
            bool isdrink = false;
            if (order.Split("/", StringSplitOptions.RemoveEmptyEntries).Count() == 4)
            {
                size = order.Split("/", StringSplitOptions.RemoveEmptyEntries)[3];
                isdrink = true;
            }


            if (!booths.Models.First(x => x.BoothId == boothId).DelicacyMenu.Models.Any(x => x.GetType().Name == itemTypeName && x.Name != itemName) &&
                 !booths.Models.First(x => x.BoothId == boothId).CocktailMenu.Models.Any(x => x.GetType().Name == itemTypeName && x.Name != itemName))

            {
                return $"{itemTypeName} is not recognized type!";
            }

             if (!booths.Models.First(x => x.BoothId == boothId).DelicacyMenu.Models.Any(x => x.Name == itemName) &&
                !booths.Models.First(x => x.BoothId == boothId).CocktailMenu.Models.Any(x => x.Name == itemName))
            {
                return $"There is no {itemTypeName} {itemName} available!";
            }

            if (!booths.Models.First(x => x.BoothId == boothId).CocktailMenu.Models.Any(x => x.GetType().Name == itemTypeName && x.Name == itemName && x.Size == size)&&isdrink)
            {
                return $"There is no {size} {itemName} available!";
            }
            else if(isdrink)
            {

                booths.Models.First(x => x.BoothId == boothId).UpdateCurrentBill(booths.Models.First(x => x.BoothId == boothId).CocktailMenu.Models.First(x => x.GetType().Name == itemTypeName && x.Name == itemName && x.Size == size).Price * countOfOrderedItems);
                return $"Booth {boothId} ordered {countOfOrderedItems} {itemName}!";
            }

            if (!booths.Models.First(x => x.BoothId == boothId).DelicacyMenu.Models.Any(x => x.GetType().Name == itemTypeName && x.Name == itemName))
            {
                return $"There is no {itemTypeName} {itemName} available!";
            }
            else
            {
                booths.Models.First(x => x.BoothId == boothId).UpdateCurrentBill(booths.Models.First(x => x.BoothId == boothId).DelicacyMenu.Models.First(x => x.GetType().Name == itemTypeName && x.Name == itemName).Price * countOfOrderedItems);
                return $"Booth {boothId} ordered {countOfOrderedItems} {itemName}!";
            }
        }
    }
}

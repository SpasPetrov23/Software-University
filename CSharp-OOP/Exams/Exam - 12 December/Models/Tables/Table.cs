using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Tables
{
    public abstract class Table : ITable
    {
        private List<IBakedFood> foodOrders;
        private List<IDrink> drinkOrders;

        private int capacity;
        private int numberOfPeople;
        private bool isReserved = false;

        public Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            foodOrders = new List<IBakedFood>();
            drinkOrders = new List<IDrink>();

            this.TableNumber = tableNumber;
            this.Capacity = capacity;
            this.PricePerPerson = pricePerPerson;
        }

        public int TableNumber { get; }

        public int Capacity 
        {
            get { return this.capacity; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity has to be greater than 0");
                }
                else
                {
                    this.capacity = value;
                }
            }
        }

        public int NumberOfPeople 
        {
            get { return this.numberOfPeople; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot place zero or less people!");
                }
                else
                {
                    this.numberOfPeople = value;
                }
            }
        }

        public decimal PricePerPerson { get; }

        public bool IsReserved
        { 
            get { return this.isReserved; }
            set
            {
                this.isReserved = value;
            }
        }

        public decimal Price { get; protected set; }

        public void Clear()
        {
            this.foodOrders.Clear();
            this.drinkOrders.Clear();
            this.NumberOfPeople = 0;
            this.IsReserved = false;
        }

        public decimal GetBill()
        {
            decimal bill = 0;
            foreach (var food in foodOrders)
            {
                bill += food.Price;
            }
            foreach (var drink in drinkOrders)
            {
                bill += drink.Price;
            }
            bill += PricePerPerson * NumberOfPeople;
            return bill;
        }

        public string GetFreeTableInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Table: {this.TableNumber}");
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Capacity: {this.Capacity}");
            sb.AppendLine($"Price per Person: {this.PricePerPerson}");
            return sb.ToString().TrimEnd();
        }

        public void OrderDrink(IDrink drink)
        {
            drinkOrders.Add(drink);
        }

        public void OrderFood(IBakedFood food)
        {
            foodOrders.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            this.NumberOfPeople = numberOfPeople;
            this.IsReserved = true;
        }
    }
}

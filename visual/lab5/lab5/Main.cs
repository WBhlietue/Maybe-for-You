using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class FoodRegister
    {
        public List<Food> foodList = new List<Food>();
        public List<Order> ordered = new List<Order>();
        public int total
        {
            get
            {
                int a = 0;
                foreach (var item in ordered)
                {
                    a += item.price;
                }
                return a;
            }
        }
        public FoodRegister()
        {
            foodList.Add(new Food(FoodType.Hool, "Хоол 1", 10000, 8000, 9000));
            foodList.Add(new Food(FoodType.Hool, "Хоол 2", 9500, 8000, 9000));
            foodList.Add(new Food(FoodType.Hool, "Хоол 3", 6000, 4000, 5000));
            foodList.Add(new Food(FoodType.Hool, "Хоол 4", 7500, 5000, 6000));
            foodList.Add(new Food(FoodType.Salat, "Салат 1", 3000, 2000, 2500));
            foodList.Add(new Food(FoodType.Salat, "Салат 2", 2000, 1500, 1750));
            foodList.Add(new Food(FoodType.Salat, "Салат 3", 1000, 800, 900));
        }
        
        public void AddOrder(int foodNum, FoodSize size, int num)
        {
            foreach(var item in ordered)
            {
                if (item.IsSame(foodList[foodNum], size))
                {
                    item.num += num;
                    return;
                }
            }
            Food f = foodList[foodNum].GetFood(size);
            Order or = new Order(f, num);
            ordered.Add(or);
        }

        public int GetFoodNum(Food food)
        {
            for(int i = 0; i < foodList.Count; i++)
            {
               if(food.name == foodList[i].name)
                {
                    return i;
                }
            }
            return -1;
        }

        public void ChangeOrderNum(int foodNum, FoodSize size, int num)
        {
            foreach (var item in ordered)
            {
                if (item.IsSame(foodList[foodNum], size))
                {
                    item.num = num;
                    return;
                }
            }
        }
        public void RemoveOrder(int foodNum, FoodSize size)
        {
            foreach (var item in ordered)
            {
                if (item.IsSame(foodList[foodNum], size))
                {
                    ordered.Remove(item);
                    return;
                }
            }
        }
        public static FoodSize ConvertSize(string size)
        {
            if(size == FoodSize.None.ToString())
            {
                return FoodSize.None;
            }else if(size == "Жижиг")
            {
                return FoodSize.Half;
            }else if(size == "Дунд")
            {
                return FoodSize.Medium;
            }else if(size == "Том")
            {
                return FoodSize.Full;
            }
            return FoodSize.None;
        }
    }
    public class Order
    {
        public Food food;
        public int num;
        public int price
        {
            get
            {
                return food.price * num;
            }
        }
        public bool IsSame(Food f, FoodSize size)
        {
            return food.name == f.name && food.fSize == size;
        }

        public Order(Food food, int num)
        {
            this.food = food;
            this.num = num;
        }
        public override string ToString()
        {
            return "food type: " + food.fType + " name: " + food.name + " food size: " + food.fSize + " num: " + num;
        }
    }
    public class Food
    {
        public FoodType fType;
        public FoodSize fSize;
        public string name;
        public int fullPrice;
        public int halfPrice;
        public int mediumPrice;
        public int price
        {
            get
            {
                switch (fSize)
                {
                    case FoodSize.Half:
                        return halfPrice;
                    case FoodSize.Full:
                        return fullPrice;
                    case FoodSize.Medium:
                        return mediumPrice;
                    default:
                        return -1;
                }
            }
        }
        public Food(FoodType ft, string n, int fp, int hp, int mp)
        {
            fSize = FoodSize.None;
            fType = ft;
            name = n;
            fullPrice = fp;
            halfPrice = hp;
            mediumPrice = mp;
        }
        public Food GetFood(FoodSize size)
        {
            Food f = new Food(fType, name, fullPrice, halfPrice, mediumPrice);
            f.fSize = size;
            return f;
        }
        public override string ToString()
        {
            return "name: " + name + " food type: " + fType + " food size: " + fSize + " price: " + price;
        }
    }
    public enum FoodType
    {
        Hool, Salat
    }
    public enum FoodSize
    {
        Medium, Half, Full, None
    }

}

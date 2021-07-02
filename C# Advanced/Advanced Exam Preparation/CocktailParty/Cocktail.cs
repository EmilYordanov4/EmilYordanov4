using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private string name;
        private int capacity;
        private int maxAlcoholLevel;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            this.Ingredients = new List<Ingredient>();
            this.Name = name;
            this.Capacity = capacity;
            this.MaxAlcoholLevel = maxAlcoholLevel;
        }


        public void Add(Ingredient ingredient)
        {
            int sum = 0;
            for (int i = 0; i < Ingredients.Count; i++)
            {
                sum += Ingredients[i].Alcohol;
            }

            if (Ingredients.Count >= this.Capacity || sum + ingredient.Alcohol >= maxAlcoholLevel)
            {

            }
            else
            {
                Ingredients.Add(ingredient);
            }
        }

        public bool Remove(string name) 
        {
            bool isDeleted = false;
            for (int i = 0; i < Ingredients.Count; i++)
            {
                if (Ingredients[i].Name == name)
                {
                    Ingredients.RemoveAt(i);
                    isDeleted = true;
                }
            }
            return isDeleted;
        }

        public Ingredient FindIngredient(string name) 
        {
            
            for (int i = 0; i < Ingredients.Count; i++)
            {
                if (Ingredients[i].Name == name)
                {
                    return Ingredients[i];
                }
            }
            return null;
        }

        public Ingredient GetMostAlcoholicIngredient() 
        {
            int maxAlcohol = int.MinValue;
            int index = -1;
            for (int i = 0; i < Ingredients.Count; i++)
            {
                if (Ingredients[i].Alcohol > maxAlcohol)
                {
                    maxAlcohol = Ingredients[i].Alcohol;
                    index = i;
                }
            }

            return Ingredients[index];

        }

        public string Report() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cocktail: {this.Name} - Current Alcohol Level: {this.CurrentAlcoholLevel}");
            foreach (var item in Ingredients)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().Trim();
        }

        public int CurrentAlcoholLevel => Ingredients.Sum(x => x.Alcohol);
        public List<Ingredient> Ingredients { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int MaxAlcoholLevel
        {
            get { return maxAlcoholLevel; }
            set { maxAlcoholLevel = value; }
        }

    }
}

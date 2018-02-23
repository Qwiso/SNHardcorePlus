using System;
using System.Collections.Generic;
using System.Reflection;

namespace SNHardcorePlus
{
    class HCPIngredients : List<HCPIngredient>
    {
        public static readonly Type IngredientsType = typeof(CraftData).GetNestedType("Ingredients", BindingFlags.NonPublic);


        public HCPIngredients() : base()
        {
        }


        public void Add(TechType techType, int amount = 1)
        {
            this.Add(new HCPIngredient(techType, amount));
        }


        public static HCPIngredients GetFromIngredients(object obj)
        {
            if (obj == null)
            {
                return null;
            }
            var count = (int)IngredientsType.GetProperty("Count").GetValue(obj, null);
            var indexprop = IngredientsType.GetProperty("Item");

            var newobj = (new HCPIngredients());
            for (int i = 0; i < count; i++)
            {
                var cur = HCPIngredient.GetFromIngredient(indexprop.GetValue(obj, new object[] { i }));
                newobj.Add(cur);
            }
            return newobj;
        }


        public object ConvertToIngredients()
        {
            var newobj = Activator.CreateInstance(IngredientsType);
            var add = IngredientsType.GetMethod("Add", new Type[] { HCPIngredient.IngredientType });
            foreach (var i in this)
            {
                add.Invoke(newobj, new object[] { i.ConvertToIngredient() });
            }
            return newobj;
        }
    }
}

using System;
using System.Reflection;

namespace SNHardcorePlus
{
    class HCPIngredient : IIngredient
    {
        private TechType _techType;
        private int _amount;
        public TechType techType => _techType;
        public static readonly Type IngredientType = typeof(CraftData).GetNestedType("Ingredient", BindingFlags.NonPublic);
        public int amount => _amount;


        public HCPIngredient(TechType techType, int amount = 1)
        {
            _techType = techType;
            _amount = amount;
        }


        public object ConvertToIngredient()
        {
            return Activator.CreateInstance(IngredientType, _techType, _amount);
        }


        public static HCPIngredient GetFromIngredient(object obj)
        {
            if (obj == null)
            {
                return null;
            }
            if (!obj.GetType().Equals(IngredientType))
            {
                throw new Exception();
            }

            return new HCPIngredient((TechType)IngredientType.GetField("_techType", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(obj), (int)IngredientType.GetField("_amount", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(obj));
        }
    }
}

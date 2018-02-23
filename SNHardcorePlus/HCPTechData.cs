using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SNHardcorePlus
{
    class HCPTechData : ITechData
    {
        public int _craftAmount;

        public HCPIngredients _ingredients;
        public List<TechType> _linkedItems;
        public TechType _techType;
        public static readonly Type TechDataType = typeof(CraftData).GetNestedType("TechData", BindingFlags.NonPublic);
        public int craftAmount => _craftAmount;
        private static readonly IIngredient nullIngredient = (IIngredient)new HCPIngredient(TechType.None, 0);


        public int ingredientCount
        {
            get
            {
                if (_ingredients != null)
                {
                    return this._ingredients.Count;

                }
                return 0;
            }
        }


        public HCPTechData()
        {
            _craftAmount = 1;
        }


        public static HCPTechData GetFromTechData(object techdata)
        {
            var newobject = new HCPTechData();
            if (techdata == null)
            {
                return newobject;
            }

            newobject._ingredients = HCPIngredients.GetFromIngredients(TechDataType.GetField("_ingredients").GetValue(techdata));
            newobject._craftAmount = (int)(TechDataType.GetField("_craftAmount").GetValue(techdata));
            newobject._techType = (TechType)(TechDataType.GetField("_techType").GetValue(techdata));
            newobject._linkedItems = (List<TechType>)(TechDataType.GetField("_linkedItems").GetValue(techdata));
            return newobject;
        }


        public object ConvertToTechData()
        {
            var newobject = Activator.CreateInstance(TechDataType);
            (TechDataType.GetField("_craftAmount")).SetValue(newobject, _craftAmount);
            (TechDataType.GetField("_ingredients")).SetValue(newobject, _ingredients.ConvertToIngredients());
            (TechDataType.GetField("_techType")).SetValue(newobject, _techType);
            (TechDataType.GetField("_linkedItems")).SetValue(newobject, _linkedItems);
            return newobject;
        }


        public int linkedItemCount
        {
            get
            {
                if (this._linkedItems != null)
                    return this._linkedItems.Count;
                return 0;
            }
        }


        public IIngredient GetIngredient(int index)
        {
            if (this._ingredients == null || index >= this._ingredients.Count || index < 0)
                return nullIngredient;
            return (IIngredient)this._ingredients[index];
        }


        public TechType GetLinkedItem(int index)
        {
            if (this._linkedItems == null || index >= this._linkedItems.Count || index < 0)
                return TechType.None;
            return this._linkedItems[index];
        }
    }
}

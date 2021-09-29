using PulsarModLoader.Content.Items;
using UnityEngine;

namespace CustomContentTests.Items
{
    class PizzaPawnItemMod : ItemMod
    {
        public override string Name => "Pizza";

        public override PLPawnItem PLPawnItem => new PizzaPawnItem();
    }
    class PizzaPawnItem : PLPawnItem_Food
    {
        public PizzaPawnItem() : base(EFoodType.MAX)
        {
            HealAmt = 50f;
            m_Desc = "Bobs your uncle and I'm a pizza.";
        }
        public override string GetItemName(bool skipLocalization = false)
        {
            base.GetItemName(skipLocalization);
            return "Pizza";
        }
        public override GameObject GetVisualPrefab()
        {
            return Global.PizzaAsset;
        }
    }
}

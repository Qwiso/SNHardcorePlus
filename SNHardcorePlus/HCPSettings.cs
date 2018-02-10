namespace SNHardcorePlus
{
    public class HCPSettings
    {
        public static float DayNightCycleMultiplier = 1f;               // note that all methods using Time.deltaTime are affected by this
        public static int CraftingCostMultiplier = 2;                   // straight up multiplier for crafting costs
        public static int PowerUsedPerCraft = 25;                       // BUGGED will change the amount of power used for each item crafted

        public static float HealthRegenerationThreshold = 0.75f;        // if current food + water is greater than X percent of foodmax + watermax
        public static float HealthRegenerationAmount = 5f;              // flat amount of health returned per tick of regeneration
        public static float HealthKitRestoreAmount = 5f;                // flat amount of health restored by a med kit (TODO: fix tooltip)

        public static float RawDamageMultiplier = 1f;                   // multiplies the damage you take by X

        public static float HealthMax = 200f;                           // maximum health ...
        public static float FoodMax = 200f;
        public static float WaterMax = 200f;

        public static float HealthRespawnRatio = 0.5f;                  // percent of maximum health after first spawn or respawn
        public static float FoodStart = 100f;                           // respawn food
        public static float WaterStart = 100f;                          // respawn water

        public static float FoodDrainMultiplier = 1f;                   // multiplier for food drain with 1f being 100%...
        public static float WaterDrainMultipliser = 1f;
        public static float EnergyDrainMultiplier = 1f;
        public static float OxygenDrainMultiplier = 1f;

        public static float StarvationDamageMultiplier = 25f;           // 25f is the value used by default in the game. scale up or down as you choose
        public static float DehydrationDamageMultiplier = 25f;          // a value of 50f would kill you twice as quickly when starved or dehydrated
    }
}

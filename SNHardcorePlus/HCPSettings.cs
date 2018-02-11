using Oculus.Newtonsoft.Json;

namespace SNHardcorePlus
{
    [JsonObject(MemberSerialization.OptOut)]
    public class HCPSettings
    {
        public float DayNightCycleMultiplier = 1f;               // note that all methods using Time.deltaTime are affected by this
        public int CraftingCostMultiplier = 2;                   // straight up multiplier for crafting costs
        public int PowerUsedPerCraft = 25;                       // BUGGED will change the amount of power used for each item crafted

        public float HealthRegenerationThreshold = 0.75f;        // if current food + water is greater than X percent of foodmax + watermax
        public float HealthRegenerationAmount = 5f;              // flat amount of health returned per tick of regeneration
        public float HealthKitRestoreAmount = 5f;                // flat amount of health restored by a med kit (TODO: fix tooltip)

        public float RawDamageMultiplier = 1f;                   // multiplies the damage you take by X

        public float HealthMax = 200f;                           // maximum health ...
        public float FoodMax = 200f;
        public float WaterMax = 200f;

        public float HealthRespawnRatio = 0.5f;                  // percent of maximum health after first spawn or respawn
        public float FoodStart = 100f;                           // respawn food
        public float WaterStart = 100f;                          // respawn water

        public float FoodDrainMultiplier = 1f;                   // multiplier for food drain with 1f being 100%...
        public float WaterDrainMultiplier = 1f;
        public float EnergyDrainMultiplier = 1f;
        public float OxygenDrainMultiplier = 1f;

        public float StarvationDamageMultiplier = 25f;           // 25f is the value used by default in the game. scale up or down as you choose
        public float DehydrationDamageMultiplier = 25f;          // a value of 50f would kill you twice as quickly when starved or dehydrated


        private static readonly HCPSettings instance = new HCPSettings();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static HCPSettings()
        {
        }

        private HCPSettings()
        {
        }

        public static HCPSettings Instance
        {
            get
            {
                return instance;
            }
        }
    }
}

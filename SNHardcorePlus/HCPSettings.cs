using Oculus.Newtonsoft.Json;

namespace SNHardcorePlus
{
    [JsonObject(MemberSerialization.OptOut)]
    public class HCPSettings
    {
        public float DayNightCycleMultiplier = 1f;
        public int CraftingCostMultiplier = 1;
        public float PowerUsedPerCraft = 5f;

        public float CyclopsMotorDrainMultiplier = 1f;
        public float CyclopsShieldPowerCost = 50f;
        public float CyclopsSonarPowerCost = 10f;
        public float CyclopsSilentPowerCost = 5f;

        public float PlantGrowRateMultiplier = 1f;
        public float MaproomPowerDrainMultiplier = 0.5f;

        public float HealthRegenerationThreshold = 0.75f;
        public float HealthRegenerationAmount = 0.5f;

        public float HealthKitRestoreAmount = 50f;
        public float BladderFishOxygenValue = 15f;

        public float RawDamageMultiplier = 1f;

        public float HealthMax = 100f;
        public float FoodMax = 100f;
        public float WaterMax = 100f;
        public float FoodOverchargeMax = 150f;

        public float HealthRespawnRatio = 0.6f;
        public float FoodStart = 60f;
        public float WaterStart = 40f;

        public float FoodDrainMultiplier = 1f;
        public float WaterDrainMultiplier = 1f;
        public float OxygenDrainMultiplier = 1f;

        public float PrawnSeamothPowerDrainMultiplier = 1f;
        public float HandToolsPowerDrainMultiplier = 1f;

        public float StarvationDamageMultiplier = 25f;
        public float DehydrationDamageMultiplier = 25f;


        private static readonly HCPSettings instance = new HCPSettings();

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

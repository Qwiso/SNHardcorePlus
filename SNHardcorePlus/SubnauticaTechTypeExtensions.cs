namespace SNHardcorePlus
{
    public static class SubnauticaTechTypeExtensions
    {
        public static TechType ToTechType(this string techTypeAsString)
        {
            if (!string.IsNullOrEmpty(techTypeAsString))
            {
                switch (techTypeAsString.ToLower())
                {
                    case "seamoth": return TechType.SeamothFragment;
                    case "seaglide": return TechType.SeaglideFragment;
                    case "statisrefile": return TechType.StasisRifleFragment;
                    case "prawn": return TechType.ExosuitFragment;
                    case "workbench": return TechType.WorkbenchFragment;
                    case "propulsioncannon": return TechType.PropulsionCannonFragment;
                    case "bioreactor": return TechType.BioreactorFragment;
                    case "thermalplant": return TechType.ThermalPlantFragment;
                    case "nuclearreactor": return TechType.NuclearReactorFragment;
                    case "moonpool": return TechType.MoonpoolFragment;
                    case "waterfiltration": return TechType.BaseFiltrationMachineFragment;
                    case "cyclopshull": return TechType.CyclopsHullFragment;
                    case "cyclopsbridge": return TechType.CyclopsBridgeFragment;
                    case "cyclopsengine": return TechType.CyclopsEngineFragment;
                    case "powertransmitter": return TechType.PowerTransmitterFragment;
                    case "modificationbay": return TechType.BaseUpgradeConsoleFragment;
                    case "observatory": return TechType.BaseObservatoryFragment;
                    case "batterycharger": return TechType.BatteryChargerFragment;
                    case "powercellcharger": return TechType.PowerCellChargerFragment;
                    case "scannerroom": return TechType.ScannerRoomFragment;
                    case "specimenanalyzer": return TechType.SpecimenAnalyzerFragment;
                    case "growbed": return TechType.FarmingTrayFragment;
                    case "sign": return TechType.SignFragment;
                    case "pictureframe": return TechType.PictureFrameFragment;
                    case "bench": return TechType.BenchFragment;
                    case "planterpot": return TechType.PlanterPotFragment;
                    case "planterbox": return TechType.PlanterBoxFragment;
                    case "plantershelf": return TechType.PlanterShelfFragment;
                    case "aquarium": return TechType.AquariumFragment;
                    case "reinforceddivesuit": return TechType.ReinforcedDiveSuitFragment;
                    case "stillsuit": return TechType.StillsuitFragment;
                    case "ledlight": return TechType.LEDLightFragment;
                    case "techlight": return TechType.TechlightFragment;
                    case "spotlight": return TechType.SpotlightFragment;
                    case "lasercutter": return TechType.LaserCutterFragment;
                    case "beacon": return TechType.BeaconFragment;
                    case "gravsphere": return TechType.GravSphereFragment;
                    case "drillarm": return TechType.ExosuitDrillArmFragment;
                    case "propulsionarm": return TechType.ExosuitPropulsionArmFragment;
                    case "grapplingarm": return TechType.ExosuitGrapplingArmFragment;
                    case "torpedoarm": return TechType.ExosuitTorpedoArmFragment;
                }
            }

            return TechType.Unobtanium;
        }
    }
}

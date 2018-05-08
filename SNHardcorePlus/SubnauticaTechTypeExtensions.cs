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
                    case "batterycharger": return TechType.BatteryChargerFragment;
                    case "beacon": return TechType.BeaconFragment;
                    case "bioreactor": return TechType.BioreactorFragment;
                    case "cyclopsbridge": return TechType.CyclopsBridgeFragment;
                    case "cyclopsengine": return TechType.CyclopsEngineFragment;
                    case "cyclopshull": return TechType.CyclopsHullFragment;
                    case "floodlight": return TechType.TechlightFragment;
                    case "gravsphere": return TechType.GravSphereFragment;
                    case "gravtrap": return TechType.GravSphereFragment;
                    case "lasercutter": return TechType.LaserCutterFragment;
                    case "modificationbay": return TechType.BaseUpgradeConsoleFragment;
                    case "moonpool": return TechType.MoonpoolFragment;
                    case "nuclearreactor": return TechType.NuclearReactorFragment;
                    case "powercellcharger": return TechType.PowerCellChargerFragment;
                    case "powertransmitter": return TechType.PowerTransmitterFragment;
                    case "prawn": return TechType.ExosuitFragment;
                    case "prawndrillarm": return TechType.ExosuitDrillArmFragment;
                    case "prawngrapplingarm": return TechType.ExosuitGrapplingArmFragment;
                    case "prawnpropulsionarm": return TechType.ExosuitPropulsionArmFragment;
                    case "prawnpropulsioncannon": return TechType.ExosuitPropulsionArmFragment;
                    case "prawntorpoedoarm": return TechType.ExosuitTorpedoArmFragment;
                    case "propulsioncannon": return TechType.PropulsionCannonFragment;
                    case "reinforceddivesuit": return TechType.ReinforcedDiveSuitFragment;
                    case "scannerroom": return TechType.ScannerRoomFragment;
                    case "seaglide": return TechType.SeaglideFragment;
                    case "seamoth": return TechType.SeamothFragment;
                    case "statisrefile": return TechType.StasisRifleFragment;
                    case "stillsuit": return TechType.StillsuitFragment;
                    case "techlight": return TechType.TechlightFragment;
                    case "thermalplant": return TechType.ThermalPlantFragment;
                    case "torpedoarm": return TechType.ExosuitTorpedoArmFragment;
                    case "waterfiltration": return TechType.BaseFiltrationMachineFragment;
                }
            }

            return TechType.Unobtanium;
        }
    }
}

using System.Collections.Generic;

namespace SNHardcorePlus
{
    public class HCPScannerSettings
    {
        public Dictionary<TechType, int> Required = new Dictionary<TechType, int>();

        public HCPScannerSettings(Dictionary<string, int> config)
        {
            foreach(var kvp in config)
            {
                var techType = kvp.Key.ToTechType();
                Required[techType] = kvp.Value;
            }
        }
    }
}

using Harmony;
using Oculus.Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

namespace SNHardcorePlus
{
    public class QPatch
    {
        public static void Patch()
        {
            manageSettingsFile();
            
            HarmonyInstance harmony = HarmonyInstance.Create("qwiso.snhardcoreplus.mod");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }


        private static void manageSettingsFile()
        {
            string modDirectory = Environment.CurrentDirectory + @"\QMods";
            string settingsPath = modDirectory + @"\snhcp.txt";

            if (!File.Exists(settingsPath))
            {
                writeDefaultSettingsFile(settingsPath);
                return;
            }

            var userSettings = JsonConvert.DeserializeObject<HCPSettings>(File.ReadAllText(settingsPath));
            applyUserSettings(userSettings, modDirectory);
        }


        private static void applyUserSettings(HCPSettings userSettings, string dir)
        {
            var fields = typeof(HCPSettings).GetFields();

            foreach (var field in fields)
            {
                var userValue = field.GetValue(userSettings);
                field.SetValue(HCPSettings.Instance, userValue);
            }
        }

        private static void writeDefaultSettingsFile(string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(HCPSettings.Instance));
        }
    }
}

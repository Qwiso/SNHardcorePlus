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
            string settingsPath = modDirectory + @"\SNHardcorePlus\config.json";

            if (!File.Exists(settingsPath))
            {
                writeDefaultSettingsFile(settingsPath);
                return;
            }

            var userSettings = JsonConvert.DeserializeObject<HCPSettings>(File.ReadAllText(settingsPath));
            applyUserSettings(userSettings);
        }


        private static void applyUserSettings(HCPSettings userSettings)
        {
            var fields = typeof(HCPSettings).GetFields();

            foreach (var field in fields)
            {
                var userValue = field.GetValue(userSettings);
                field.SetValue(HCPSettings.Instance, userValue);
            }

            HCPSettings.Instance.Initialize();
        }

        private static void writeDefaultSettingsFile(string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(HCPSettings.Instance));
        }
    }
}

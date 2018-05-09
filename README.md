## Requires the use of [QModManager](https://www.nexusmods.com/subnautica/mods/16/) found on Nexus Mods

### Installation
https://www.nexusmods.com/subnautica/mods/17

### config.json
Should be located in `QMods\SNHardcorePlus` folder. This is where you customize your experience by editing the values of each key

##### Be aware that DayNightCycle affects many parts of the game: plant growth, crafting time, and other unforseen things

Name | Value | Description
:--- | :-----: | :---
DayNightCycleMultiplier | 1.0 | the rate of time passing
CraftingCostMultiplier | 1 | a value of 5 would make every blueprint require 5 times more of each ingredient
PowerUsedPerCraft | 5.0 | how much power does each item use when crafting
CyclopsShieldPowerCost | 50.0 | the default consumption of shields. needs more testing
CyclopsSonarPowerCost | 10.0 | power cost of the cyclops sonar
CyclopsSilentPowerCost | 5.0 | power cost of the cyclops silent mode
PlantGrowRateMultiplier | 1.0 | adjust the rate which plants mature
MaproomPowerDrainMultiplier | 0.5 | *should be called MaproomPowerCost* 
HealthRegenerationThreshold | 0.75 | the percentage of FoodMax+WaterMax you must be above before you regen
HealthRegenerationAmount | 0.5 | how much hp you regen every 10 seconds while above the regen threshold
HealtKitRestoreAmount | 50.0 | 50hp returned per medical kit
RawDamageMultiplier | 1.0 | 2.0 would cause all damage to double when applied to the player
HealthMax | 100.0 | maximum health available to player
WaterMax | 100.0 | maximum water value available to the player
FoodMax | 100.0 | maximum food value available to player
FoodOverchargeMax | 150.0 | maximum value to which food can be overcharged
HealthRespawnRatio | 0.6 | sets health at 60% of HealthMax when you respawn
FoodStart | 60.0 | the value of food you respawn with
WaterStart | 40.0 | the value of water you respawn with
FoodDrainMultiplier | 1.0 | the rate of drain on the player's food supply
WaterDrainMultiplier | 1.0 | the rate of drain on the player's water supply
OxygenDrainMultiplier | 1.0 | the rate of oxygen consumption of the player
PrawnSeamothPowerDrainMultiplier | 1.0 | power usage for prawn and seamoth
HandToolsPowerDrainMultiplier | 1.0 | power usage for handheld tools
StarvationDamageMultiplier | 25.0 | 25 is the default value in the game's code. adjust accordingly
DehydrationDamageMultiplier | 25.0 | 25 is the default value in the game's code. adjust accordingly


```
{
	"DayNightCycleMultiplier": 1.0,
	"CraftingCostMultiplier": 1,
	"PowerUsedPerCraft": 5.0,
	"CyclopsShieldPowerCost": 50.0,
	"CyclopsSonarPowerCost": 10.0,
	"CyclopsSilentPowerCost": 5.0,
	"PlantGrowRateMultiplier": 1.0,
	"MaproomPowerDrainMultiplier": 0.5,
	"HealthRegenerationThreshold": 0.75,
	"HealthRegenerationAmount": 0.5,
	"HealthKitRestoreAmount": 50.0,
	"BladderFishOxygenValue": 15.0,
	"RawDamageMultiplier": 1.0,
	"HealthMax": 100.0,
	"FoodMax": 100.0,
	"WaterMax": 100.0,
	"FoodOverchargeMax": 150.0,
	"HealthRespawnRatio": 0.6,
	"FoodStart": 60.0,
	"WaterStart": 40.0,
	"FoodDrainMultiplier": 1.0,
	"WaterDrainMultiplier": 1.0,
	"OxygenDrainMultiplier": 1.0,
	"PrawnSeamothPowerDrainMultiplier": 1.0,
	"HandToolsPowerDrainMultiplier": 1.0,
	"StarvationDamageMultiplier": 25.0,
	"DehydrationDamageMultiplier": 25.0,
	"Blueprints": {
		"BatteryCharger": 2,
		"Beacon": 2,
		"Bioreactor": 2,
		"CyclopsBridge": 3,
		"CyclopsEngine": 3,
		"CyclopsHull": 3,
		"Floodlight": 1,
		"GravTrap": 2,
		"LaserCutter": 3,
		"ModificationBay": 3,
		"Moonpool": 2,
		"NuclearReactor": 3,
		"PowerCellCharger": 2,
		"PowerTransmitter": 1,
		"Prawn": 4,
		"PrawnDrillArm": 2,
		"PrawnGrapplingArm": 2,
		"PrawnPropulsionCannon": 2,
		"PrawnTorpedoArm": 2,
		"PropulsionCannon": 2,
		"ReinforcedDiveSuit": 2,
		"ScannerRoom": 3,
		"Seamoth": 3,
		"Seaglide": 2,
		"StatisRifle": 2,
		"Stillsuit": 2,
		"ThermalPlant": 2,
		"WaterFiltration": 2
	}
}
```

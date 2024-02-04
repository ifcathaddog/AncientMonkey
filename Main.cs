using MelonLoader;
using BTD_Mod_Helper;
using AncientMonkey;
using Il2CppAssets.Scripts.Simulation.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using static Il2CppSystem.Globalization.TimeSpanParse;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models;
using BTD_Mod_Helper.Api.Components;
using BTD_Mod_Helper.Api.Enums;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using MelonLoader;
using BTD_Mod_Helper;
using System;
using Il2CppAssets.Scripts.Simulation.Towers.Weapons;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using UnityEngine;
using BTD_Mod_Helper.Api.Components;
using BTD_Mod_Helper.Api.Enums;
using Il2CppAssets.Scripts.Simulation.Towers;
using UnityEngine;
using Il2CppAssets.Scripts.Data.Gameplay.Mods;
using Il2CppSystem;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;
using System.Linq;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2Cpp;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Unity;

using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Simulation.Bloons;
using Il2CppAssets.Scripts.Models.Towers.Weapons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using Il2CppSystem.IO;
using Il2CppAssets.Scripts.Simulation.Objects;
using UnityEngine.InputSystem.Utilities;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;

[assembly: MelonInfo(typeof(AncientMonkey.AncientMonkey), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace AncientMonkey;

public class AncientMonkey : BloonsTD6Mod
{
    public static AncientMonkey mod;
    public float newWeaponCost = 250;
    public float baseNewWeaponCost = 250;
    public float rareChance = 85;
    public float epicChance = 100;
    public float legendaryChance = 100;
    public float exoticChance = 100;
    public float rareStrongChance = 85;
    public float epicStrongChance = 100;
    public float legendaryStrongChance = 100;
    public float exoticStrongChance = 100;
    public float strongerWeaponCost = 1100;
    public float baseStrongerWeaponCost = 1100;
    public float newAbilityCost = 750;
    public float baseNewAbilityCost = 750;
    public bool upgradeOpen = false;
    public bool selectingWeaponOpen = false;
    public bool mib = false;
    public override void OnApplicationStart()
    {
        ModHelper.Msg<AncientMonkey>("AncientMonkey loaded!");
        mod = this;

    }
    public override void OnGameModelLoaded(GameModel model)
    {
        
        newWeaponCost = 250;
        rareChance = 90;
        epicChance = 100;
        legendaryChance = 100;
        exoticChance = 100;
        rareStrongChance = 90;
        epicStrongChance = 100;
        legendaryStrongChance = 100;
        exoticStrongChance = 100;
        baseNewWeaponCost = 250;
        strongerWeaponCost = 500;
        baseStrongerWeaponCost = 500;
        newAbilityCost = 2000;
        baseNewAbilityCost = 2000;
        upgradeOpen = false;
        selectingWeaponOpen = false;
        mib = false;
    }
    public override void OnTowerSold(Tower tower, float amount)
    {
        if (tower.towerModel.name.Contains("AncientMonkey"))
        {
            newWeaponCost = 250;
            baseNewWeaponCost = 250;
            rareChance = 90;
            epicChance = 100;
            legendaryChance = 100;
            exoticChance = 100;
            strongerWeaponCost = 500;
            baseStrongerWeaponCost = 500;
            rareStrongChance = 90;
            epicStrongChance = 100;
            legendaryStrongChance = 100;
            exoticStrongChance = 100;
            newAbilityCost = 2000;
            baseNewAbilityCost = 2000;
            upgradeOpen = false;
            selectingWeaponOpen = false;
            mib = false;
        }
    }
    public override void OnTowerCreated(Tower tower, Entity target, Model modelToUse)
    {
        if (tower.towerModel.name.Contains("AncientMonkey"))
        {
            newWeaponCost = 250;
            baseNewWeaponCost = 250;
            rareChance = 90;
            epicChance = 100;
            legendaryChance = 100;
            exoticChance = 100;
            rareStrongChance = 90;
            epicStrongChance = 100;
            legendaryStrongChance = 100;
            exoticStrongChance = 100;
            strongerWeaponCost = 500;
            baseStrongerWeaponCost = 500;
            newAbilityCost = 2000;
            baseNewAbilityCost = 2000;
            upgradeOpen = false;
            selectingWeaponOpen = false;
            mib = false;
        }
    }
    public override void OnNewGameModel(GameModel result)
    {
        foreach (var tower in result.towerSet.ToList())
        {
            if (tower.name.Contains("AncientMonkey"))
            {
                tower.GetShopTowerDetails().towerCount = 1;
            }
            
        }
    }
    public override void OnTowerSelected(Tower tower)
    {
        if (tower.towerModel.name.Contains("AncientMonkey"))
        {
            InGame game = InGame.instance;
            RectTransform rect = game.uiRect;
            MenuUi.CreateUpgradeMenu(rect, tower);
            upgradeOpen = true;
        }
    }
    public override void OnTowerDeselected(Tower tower)
    {
        if (tower.towerModel.name.Contains("AncientMonkey"))
        {
            InGame game = InGame.instance;
            RectTransform rect = game.uiRect;
            upgradeOpen = false;
            MenuUi.instance.CloseMenu();
        }
        ModHelper.Msg<AncientMonkey>("Deselected");
      
    }
    public string[] CommonWpn = {
        "Dart",
        "Tack",
        "Nail",
        "Boomerang",
        "Glue", 
        "Bomb",
        "Magic",
    };
    public string[] RareWpn = {
        "Laser Blasts",
        "Hot Rang",
        "Crossbow",
        "Cluster",
        "White Hot Spikes",
        "Greater Production",
        "Heart Of Thunder",
        "Double Shot",
        "Wall Of Fire",
        "Airburst Darts",
        "Hot Shot",
        "Large Calibre",
    };
    public string[] EpicWpn = {
        "Plasma Blasts",
        "Dragon's Breath",
        "Bouncing Bullet",
        "Recursive Cluster",
        "Sticky Bomb",
        "Spiked Balls",
        "Banana Plantation",
        "Bloon Trap",
        "Hydra Rocket Pods",
        "Destroyer",
        "Moab Glue",
        "Icicles",
        "Overdrive",
    };
    public string[] LegendaryWpn = {
        "Ultra Juggernaut",
        "Bloon Solver",
        "Super Brittle",
        "Tack Zone",
        "Bomb Blitz",
        "Perma Charge",
        "Elite Defender",
        "Sub Commander",
        "Plasma Accelerator",
        "Arcane Spike",
        "Sun Avatar",
        "Spiked Mines",
        "Banana Research Facility",
        "Sentry Champion",
    };
    public string[] ExoticWpn = {
        "Legend Of The Night",
        "Super Mines",
        "Banana Central",
        "XXXL Trap",
        "Archmage",
        "M.A.D",
        "Ray Of Doom",
        "Avatar Of Wrath",
        "Inferno Ring",
        "Bloon Crush",
        "Moab Domination",
        "Perma Brew",
        "Super Storm",
    };
    public string[] Ability = {
        "MIB",
        "Summoning Phoenix",
        "Teleportation",
        "Blade Maelstrom",
        "Tech Terror",
        "Spike Storm",
        "Overclock",
        "First Strike Capability",
        "Elite Sniper",
        "Snow Storm",
    };
    public string[] AbilityImg = {
        VanillaSprites.MonkeyIntelligenceBureauUpgradeIcon,
        VanillaSprites.SummonPhoenixUpgradeIcon,
        VanillaSprites.DarkKnightUpgradeIcon,
        VanillaSprites.BladeMaelstromUpgradeIcon,
        VanillaSprites.TechTerrorUpgradeIcon,
        VanillaSprites.SpikeStormUpgradeIcon,
        VanillaSprites.OverclockUpgradeIcon,
        VanillaSprites.FirstStrikeCapabilityUpgradeIcon,
        VanillaSprites.EliteSniperUpgradeIcon,
        VanillaSprites.SnowstormUpgradeIcon,
    };
    public string[] ExoticImg = {
        VanillaSprites.LegendOfTheNightUpgradeIcon,
        VanillaSprites.SuperMinesUpgradeIcon,
        VanillaSprites.BananaCentralUpgradeIcon,
        VanillaSprites.XXXLUpgradeIcon,
        VanillaSprites.ArchmageUpgradeIcon,
        VanillaSprites.MadUpgradeIcon,
        VanillaSprites.RayOfDoomUpgradeIcon,
        VanillaSprites.AvatarofWrathUpgradeIcon,
        VanillaSprites.InfernoRingUpgradeIcon,
        VanillaSprites.BloonCrushUpgradeIcon,
        VanillaSprites.MoabDominationUpgradeIcon,
        VanillaSprites.PermanentBrewUpgradeIcon,
        VanillaSprites.SuperStormUpgradeIcon,
    };
    public string[] LegendaryImg = {
        VanillaSprites.UltraJuggernautUpgradeIcon,
        VanillaSprites.TheBloonSolverUpgradeIcon,
        VanillaSprites.SuperBrittleUpgradeIcon,
        VanillaSprites.TheTackZoneUpgradeIcon,
        VanillaSprites.BombBlitzUpgradeIcon,
        VanillaSprites.PermaChargeUpgradeIcon,
        VanillaSprites.EliteDefenderUpgradeIcon,
        VanillaSprites.SubCommanderUpgradeIcon,
        VanillaSprites.PlasmaAcceleratorUpgradeIcon,
        VanillaSprites.ArcaneSpikeUpgradeIcon,
        VanillaSprites.SunAvatarUpgradeIcon,
        VanillaSprites.SpikedMinesUpgradeIcon,
        VanillaSprites.BananaResearchFacilityUpgradeIcon,
        VanillaSprites.SentryParagonUpgradeIcon,
    };
    public string[] EpicImg = {
        VanillaSprites.PlasmaBlastUpgradeIcon,
        VanillaSprites.DragonsBreathUpgradeIcon,
        VanillaSprites.BouncingBulletUpgradeIcon,
        VanillaSprites.RecursiveClusterUpgradeIcon,
        VanillaSprites.StickyBombUpgradeIcon,
        VanillaSprites.SpikedBallsUpgradeIcon,
        VanillaSprites.BananaPlantationUpgradeIcon,
        VanillaSprites.BloonTrapUpgradeIcon,
        VanillaSprites.HydraRocketsUpgradeIcon,
        VanillaSprites.DestroyerUpgradeIcon,
        VanillaSprites.MoabGlueUpgradeIcon,
        VanillaSprites.IciclesUpgradeIcon,
        VanillaSprites.OverdriveUpgradeIcon,
    };
    public string[] CommonImg = {
        VanillaSprites.SharpShotsUpgradeIcon,
        VanillaSprites.FasterShootingUpgradeIcon,
        VanillaSprites.LargerServiceAreaUpgradeIcon,
        VanillaSprites.ImprovedRangsUpgradeIcon,
        VanillaSprites.GlueSoakUpgradeIcon,
        VanillaSprites.BiggerBombsUpgradeIcon,
        VanillaSprites.IntenseMagicUpgradeIcon,
    };
    public string[] RareImg = {
        VanillaSprites.LaserBlastUpgradeIcon,
        VanillaSprites.RedHotRangsUpgradeIcon,
        VanillaSprites.CrossBowUpgradeIcon,
        VanillaSprites.ClusterBombsUpgradeIcon,
        VanillaSprites.WhiteHotSpikesUpgradeIcon,
        VanillaSprites.GreaterProductionUpgradeIcon,
        VanillaSprites.HeartofThunderUpgradeIcon,
        VanillaSprites.DoubleShotUpgradeIcon2,
        VanillaSprites.WallOfFireUpgradeIcon,
        VanillaSprites.AirburstDartsUpgradeIcon,
        VanillaSprites.HotShotUpgradeIcon,
        VanillaSprites.LongCalibreUpgradeIcon,
    };
    [RegisterTypeInIl2Cpp(false)]
    public class MenuUi : MonoBehaviour
    {
        public static MenuUi instance;

        public ModHelperInputField input;
        public void CloseMenu()
        {
            Destroy(gameObject);
        }
        public void NewWeapon(Tower tower)
        {
            InGame game = InGame.instance;
            if (game.GetCash() >= mod.newWeaponCost)
            {
                game.AddCash(-mod.newWeaponCost);
                RectTransform rect = game.uiRect;
                mod.newWeaponCost += mod.baseNewWeaponCost;
                tower.worth += mod.newWeaponCost - mod.baseNewWeaponCost;
                mod.baseNewWeaponCost *= 1.06f;
                MenuUi.NewWeaponPanel(rect, tower);
                MenuUi.instance.CloseMenu();
            }
        }
        public void WeaponSelected(string Weapon, Tower tower)
        {
            InGame game = InGame.instance;
            RectTransform rect = game.uiRect;
            Destroy(gameObject);
            ModHelper.Msg<AncientMonkey>(Weapon);
            if (Weapon == "Dart")
            {
                var wpn = Game.instance.model.GetTowerFromId("DartMonkey").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Tack")
            {
                var wpn = Game.instance.model.GetTowerFromId("TackShooter").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Nail")
            {
                var wpn = Game.instance.model.GetTowerFromId("EngineerMonkey").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Boomerang")
            {
                var wpn = Game.instance.model.GetTowerFromId("BoomerangMonkey").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Glue")
            {
                var wpn = Game.instance.model.GetTowerFromId("GlueGunner").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Bomb")
            {
                var wpn = Game.instance.model.GetTowerFromId("BombShooter").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Magic")
            {
                var wpn = Game.instance.model.GetTowerFromId("WizardMonkey").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Laser Blasts")
            {
                var wpn = Game.instance.model.GetTowerFromId("SuperMonkey-100").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Hot Rang")
            {
                var wpn = Game.instance.model.GetTowerFromId("BoomerangMonkey-002").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Crossbow")
            {
                var wpn = Game.instance.model.GetTowerFromId("DartMonkey-003").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Cluster")
            {
                var wpn = Game.instance.model.GetTowerFromId("BombShooter-003").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "White Hot Spikes")
            {
                var wpn = Game.instance.model.GetTowerFromId("SpikeFactory-220").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Greater Production")
            {
                var wpn = Game.instance.model.GetTowerFromId("BananaFarm-200").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Heart Of Thunder")
            {
                var wpn = Game.instance.model.GetTowerFromId("Druid-200").GetAttackModel().weapons.First(w => w.name == "WeaponModel_Lightning").Duplicate(); 
              
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.GetAttackModel().AddWeapon(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Double Shot")
            {
                var wpn = Game.instance.model.GetTowerFromId("NinjaMonkey-300").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Wall Of Fire")
            {
                var wpn = Game.instance.model.GetTowerFromId("WizardMonkey-020").GetAttackModel(2).Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Airburst Darts")
            {
                var wpn = Game.instance.model.GetTowerFromId("MonkeySub-003").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Hot Shot")
            {
                var wpn = Game.instance.model.GetTowerFromId("MonkeyBuccaneer-020").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                wpn.GetBehavior<RotateToTargetModel>().additionalRotation = 0;
                wpn.weapons[0].emission.RemoveBehavior<EmissionRotationOffTowerDirectionModel>();
                wpn.weapons[0].ejectX = 0;
                wpn.weapons[0].ejectY = 0;
                wpn.weapons[0].ejectX = 0;
                wpn.weapons[1].ejectX = 0;
                wpn.weapons[1].ejectY = 0;
                wpn.weapons[1].ejectX = 0;
                wpn.weapons[2].ejectX = 0;
                wpn.weapons[2].ejectY = 0;
                wpn.weapons[2].ejectX = 0;
                wpn.weapons[2].emission.RemoveBehavior<EmissionArcRotationOffTowerDirectionModel>();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Large Calibre")
            {
                var wpn = Game.instance.model.GetTowerFromId("SniperMonkey-202").GetAttackModel().Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Plasma Blasts")
            {
                var wpn = Game.instance.model.GetTowerFromId("SuperMonkey-200").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Dragon's Breath")
            {
                var wpn = Game.instance.model.GetTowerFromId("WizardMonkey-030").GetAttackModel(3).Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Bouncing Bullet")
            {
                var wpn = Game.instance.model.GetTowerFromId("SniperMonkey-230").GetAttackModel().Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Recursive Cluster")
            {
                var wpn = Game.instance.model.GetTowerFromId("BombShooter-024").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Sticky Bomb")
            {
                var wpn = Game.instance.model.GetTowerFromId("NinjaMonkey-004").GetAttackModel(2).Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Spiked Balls")
            {
                var wpn = Game.instance.model.GetTowerFromId("SpikeFactory-320").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Banana Plantation")
            {
                var wpn = Game.instance.model.GetTowerFromId("BananaFarm-320").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Bloon Trap")
            {
                var wpn = Game.instance.model.GetTowerFromId("EngineerMonkey-004").GetAttackModel(1).Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Hydra Rocket Pods")
            {
                var wpn = Game.instance.model.GetTowerFromId("DartlingGunner-030").GetAttackModel().Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Destroyer")
            {
                var wpn = Game.instance.model.GetTowerFromId("MonkeyBuccaneer-320").GetAttackModel().Duplicate();
                wpn.GetBehavior<RotateToTargetModel>().additionalRotation = 0;
                wpn.weapons[0].emission.RemoveBehavior<EmissionRotationOffTowerDirectionModel>();
                wpn.weapons[0].ejectX = 0;
                wpn.weapons[0].ejectY = 0;
                wpn.weapons[0].ejectX = 0;
                wpn.weapons[1].ejectX = 0;
                wpn.weapons[1].ejectY = 0;
                wpn.weapons[1].ejectX = 0;
                wpn.weapons[2].ejectX = 0;
                wpn.weapons[2].ejectY = 0;
                wpn.weapons[2].ejectX = 0;
                wpn.weapons[2].emission.RemoveBehavior<EmissionArcRotationOffTowerDirectionModel>();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Moab Glue")
            {
                var wpn = Game.instance.model.GetTowerFromId("GlueGunner-023").GetAttackModel().Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Icicles")
            {
                var wpn = Game.instance.model.GetTowerFromId("IceMonkey-204").GetAttackModel().Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Overdrive")
            {
                var wpn = Game.instance.model.GetTowerFromId("TackShooter-204").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Ultra Juggernaut")
            {
                var wpn = Game.instance.model.GetTowerFromId("DartMonkey-520").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Ultra Juggernaut")
            {
                var wpn = Game.instance.model.GetTowerFromId("DartMonkey-520").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Bloon Solver")
            {
                var wpn = Game.instance.model.GetTowerFromId("GlueGunner-520").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Super Brittle")
            {
                var wpn = Game.instance.model.GetTowerFromId("IceMonkey-520").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Tack Zone")
            {
                var wpn = Game.instance.model.GetTowerFromId("TackShooter-025").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Bomb Blitz")
            {
                var wpn = Game.instance.model.GetTowerFromId("BombShooter-025").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Perma Charge")
            {
                var wpn = Game.instance.model.GetTowerFromId("BoomerangMonkey-052").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Elite Defender")
            {
                var wpn = Game.instance.model.GetTowerFromId("SniperMonkey-025").GetAttackModel().Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Sub Commander")
            {
                var wpn = Game.instance.model.GetTowerFromId("MonkeySub-025").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Plasma Accelerator")
            {
                var wpn = Game.instance.model.GetTowerFromId("DartlingGunner-402").GetAttackModel().Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Arcane Spike")
            {
                var wpn = Game.instance.model.GetTowerFromId("WizardMonkey-402").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Spiked Mines")
            {
                var wpn = Game.instance.model.GetTowerFromId("SpikeFactory-420").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Sun Avatar")
            {
                var wpn = Game.instance.model.GetTowerFromId("SuperMonkey-320").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Banana Research Facility")
            {
                var wpn = Game.instance.model.GetTowerFromId("BananaFarm-420").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Sentry Champion")
            {
                var wpn = Game.instance.model.GetTowerFromId("EngineerMonkey-520").GetAttackModel(1).Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Legend Of The Night")
            {
                var wpn = Game.instance.model.GetTowerFromId("SuperMonkey-205").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Super Mines")
            {
                var wpn = Game.instance.model.GetTowerFromId("SpikeFactory-520").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Banana Central")
            {
                var wpn = Game.instance.model.GetTowerFromId("BananaFarm-520").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "XXXL Trap")
            {
                var wpn = Game.instance.model.GetTowerFromId("EngineerMonkey-015").GetAttackModel(1).Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Archmage")
            {
                var wpn = Game.instance.model.GetTowerFromId("WizardMonkey-500").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var wpn2 = Game.instance.model.GetTowerFromId("WizardMonkey-500").GetAttackModel(1).Duplicate();
                wpn2.range = tower.towerModel.range;
                var wpn3 = Game.instance.model.GetTowerFromId("WizardMonkey-500").GetAttackModel(2).Duplicate();
                wpn3.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                towerModel.AddBehavior(wpn2);
                towerModel.AddBehavior(wpn3);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "M.A.D")
            {
                var wpn = Game.instance.model.GetTowerFromId("DartlingGunner-250").GetAttackModel().Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Ray Of Doom")
            {
                var wpn = Game.instance.model.GetTowerFromId("DartlingGunner-520").GetAttackModel().Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Avatar Of Wrath")
            {
                var wpn = Game.instance.model.GetTowerFromId("Druid-025").GetAttackModel().Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Inferno Ring")
            {
                var wpn = Game.instance.model.GetTowerFromId("TackShooter-520").GetAttackModel().Duplicate();
                var wpn2 = Game.instance.model.GetTowerFromId("TackShooter-520").GetAttackModel(1).Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                towerModel.AddBehavior(wpn2);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Bloon Crush")
            {
                var wpn = Game.instance.model.GetTowerFromId("BombShooter-520").GetAttackModel().Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Moab Domination")
            {
                var wpn = Game.instance.model.GetTowerFromId("BoomerangMonkey-025").GetAttackModel(1).Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Perma Brew")
            {
                var wpn = Game.instance.model.GetTowerFromId("Alchemist-520").GetAttackModel(2).Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
            if (Weapon == "Super Storm")
            {
                var tornado = Game.instance.model.GetTowerFromId("Druid-520").GetAttackModel().weapons.First(w => w.name.Contains("Superstorm")).Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.GetAttackModel().AddWeapon(tornado);
                tower.UpdateRootModel(towerModel);
            }
            mod.rareChance -= 5f;
            mod.epicChance -= 1.45f;
            if (mod.epicChance <= 88)
            {
                mod.legendaryChance -= 0.85f;
            }
            if (mod.legendaryChance <= 91)
            {
                mod.exoticChance -= 0.50f;
            }
            
            mod.selectingWeaponOpen = false;
          
            if (mod.upgradeOpen == true)
            {
                CreateUpgradeMenu(rect, tower);
            }

            if (mod.mib == true)
            {
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
                foreach (var weaponModel in towerModel.GetDescendants<WeaponModel>().ToArray())
                {
                    if (weaponModel.projectile.HasBehavior<DamageModel>())
                    {
                        weaponModel.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
                    }
                }
                tower.UpdateRootModel(towerModel);
            }

        }
        public static void NewWeaponPanel(RectTransform rect, Tower tower)
        {
            ModHelperPanel panel = rect.gameObject.AddModHelperPanel(new Info("Panel_", 2200, 1500, 2500, 1850, new UnityEngine.Vector2()), VanillaSprites.BrownInsertPanel);
            MenuUi upgradeUi = panel.AddComponent<MenuUi>();
            ModHelperText selectWpn = panel.AddText(new Info("selectWpn", 0, 800, 2500, 180), "Select New Weapon", 100);
            Il2CppSystem.Random rnd = new Il2CppSystem.Random();
            var num1 = rnd.Next(0, 7);
            var wpnSelected = mod.CommonWpn[num1];
            var imgSelected = mod.CommonImg[num1];

            ModHelperPanel wpn1Panel = panel.AddPanel(new Info("wpn1Panel", 375, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.GreyInsertPanel);
            ModHelperText rarityText1 = panel.AddText(new Info("rarityText1", -875, 600, 800, 180), "Common", 100);
            ModHelperText weaponText1 = panel.AddText(new Info("weaponText1", -875, 500, 800, 180), wpnSelected, 75);
            ModHelperImage image1 = panel.AddImage(new Info("image1", -875, 0, 400, 400), imgSelected);
            ModHelperButton selectWpnBtn1 = panel.AddButton(new Info("selectWpnBtn1", -875, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.WeaponSelected(wpnSelected,tower)));
            ModHelperText selectWpn1 = selectWpnBtn1.AddText(new Info("selectWpn1", 0, 0, 700, 160), "Select", 70);
            var rarityNum = rnd.Next(1, 100);
            var rarity = "Common";
            if (rarityNum >= mod.rareChance)
            {
                rarity = "Rare";
            }
            if (rarityNum >= mod.epicChance)
            {
                rarity = "Epic";
            }
          
            if (rarity == "Common")
            {
                var num2 = rnd.Next(1, 7);
                var wpnSelected2 = mod.CommonWpn[num2];
                var imgSelected2 = mod.CommonImg[num2];
                ModHelperPanel wpncm2Panel = panel.AddPanel(new Info("wpn2Pane2", 1250, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.GreyInsertPanel);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 0, 600, 800, 180), "Common", 100);
                ModHelperText weaponText2 = panel.AddText(new Info("weaponText2", 0, 500, 800, 180), wpnSelected2, 75);
                ModHelperImage image2 = panel.AddImage(new Info("image2", 0, 0, 400, 400), imgSelected2);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 0, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.WeaponSelected(wpnSelected2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }
            if (rarity == "Rare")
            {
                var num2 = rnd.Next(0, 12);
                var wpnSelected2 = mod.RareWpn[num2];
                var imgSelected2 = mod.RareImg[num2];
                ModHelperPanel wpnra2Panel = panel.AddPanel(new Info("wpn2Panel", 1250, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.BlueInsertPanel);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 0, 600, 800, 180), "Rare", 100);
                ModHelperText weaponText2 = panel.AddText(new Info("weaponText2", 0, 500, 800, 180), wpnSelected2, 75);
                ModHelperImage image2 = panel.AddImage(new Info("image2", 0, 0, 400, 400), imgSelected2);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 0, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.WeaponSelected(wpnSelected2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }
            if (rarity == "Epic")
            {
              
                var num2 = rnd.Next(0, 13);
                var wpnSelected2 = mod.EpicWpn[num2];
                var imgSelected2 = mod.EpicImg[num2];
                ModHelperPanel wpnEp2Panel = panel.AddPanel(new Info("wpn2Panel", 1250, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.MainBgPanelParagon);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 0, 600, 800, 180), "Epic", 100);
                ModHelperText weaponText2 = panel.AddText(new Info("weaponText2", 0, 500, 800, 180), wpnSelected2, 75);
                ModHelperImage image2 = panel.AddImage(new Info("image2", 0, 0, 400, 400), imgSelected2);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 0, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.WeaponSelected(wpnSelected2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }
            var rarityNum2 = rnd.Next(1, 100);
            var rarity2 = "Common";
            if (rarityNum2 >= mod.rareChance)
            {
                rarity2 = "Rare";
            }
            if (rarityNum2 >= mod.epicChance)
            {
                rarity2 = "Epic";
            }
            if (rarityNum2 >= mod.legendaryChance)
            {
                rarity2 = "Legendary";
            }
            if (rarityNum2 >= mod.exoticChance)
            {
                rarity2 = "Exotic";
            }
            if (rarity2 == "Common")
            {
                var num2 = rnd.Next(1, 7);
                var wpnSelected2 = mod.CommonWpn[num2];
                var imgSelected2 = mod.CommonImg[num2];
                ModHelperPanel wpncm2Panel = panel.AddPanel(new Info("wpn2Pane2", 2125, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.GreyInsertPanel);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 875, 600, 800, 180), "Common", 100);
                ModHelperText weaponText2 = panel.AddText(new Info("weaponText2", 875, 500, 800, 180), wpnSelected2, 75);
                ModHelperImage image2 = panel.AddImage(new Info("image2", 875, 0, 400, 400), imgSelected2);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 875, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.WeaponSelected(wpnSelected2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }
            if (rarity2 == "Rare")
            {
                var num2 = rnd.Next(0, 12);
                var wpnSelected2 = mod.RareWpn[num2];
                var imgSelected2 = mod.RareImg[num2];
                ModHelperPanel wpnra2Panel = panel.AddPanel(new Info("wpn2Panel", 2125, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.BlueInsertPanel);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 875, 600, 800, 180), "Rare", 100);
                ModHelperText weaponText2 = panel.AddText(new Info("weaponText2", 875, 500, 800, 180), wpnSelected2, 75);
                ModHelperImage image2 = panel.AddImage(new Info("image2", 875, 0, 400, 400), imgSelected2);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 875, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.WeaponSelected(wpnSelected2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }
            if (rarity2 == "Epic")
            {

                var num2 = rnd.Next(0, 13);
                var wpnSelected2 = mod.EpicWpn[num2];
                var imgSelected2 = mod.EpicImg[num2];
                ModHelperPanel wpnEp2Panel = panel.AddPanel(new Info("wpn2Panel", 2125, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.MainBgPanelParagon);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 875, 600, 800, 180), "Epic", 100);
                ModHelperText weaponText2 = panel.AddText(new Info("weaponText2", 875, 500, 800, 180), wpnSelected2, 75);
                ModHelperImage image2 = panel.AddImage(new Info("image2", 875, 0, 400, 400), imgSelected2);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 875, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.WeaponSelected(wpnSelected2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }
            if (rarity2 == "Legendary")
            {

                var num2 = rnd.Next(0, 14);
                var wpnSelected2 = mod.LegendaryWpn[num2];
                var imgSelected2 = mod.LegendaryImg[num2];
                ModHelperPanel wpnEp2Panel = panel.AddPanel(new Info("wpn2Panel", 2125, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.MainBGPanelYellow);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 875, 600, 800, 180), "Legendary", 100);
                ModHelperText weaponText2 = panel.AddText(new Info("weaponText2", 875, 500, 800, 180), wpnSelected2, 75);
                ModHelperImage image2 = panel.AddImage(new Info("image2", 875, 0, 400, 400), imgSelected2);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 875, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.WeaponSelected(wpnSelected2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }
            if (rarity2 == "Exotic")
            {

                var num2 = rnd.Next(0, 13);
                var wpnSelected2 = mod.ExoticWpn[num2];
                var imgSelected2 = mod.ExoticImg[num2];
                ModHelperPanel wpnEp2Panel = panel.AddPanel(new Info("wpn2Panel", 2125, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.MainBgPanelWhiteSmall);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 875, 600, 800, 180), "Exotic", 100);
                ModHelperText weaponText2 = panel.AddText(new Info("weaponText2", 875, 500, 800, 180), wpnSelected2, 75);
                ModHelperImage image2 = panel.AddImage(new Info("image2", 875, 0, 400, 400), imgSelected2);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 875, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.WeaponSelected(wpnSelected2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }

        }
        public static void StrongWeaponPanel(RectTransform rect, Tower tower)
        {
            ModHelperPanel panel = rect.gameObject.AddModHelperPanel(new Info("Panel_", 2200, 1500, 2500, 1850, new UnityEngine.Vector2()), VanillaSprites.BrownInsertPanel);
            MenuUi upgradeUi = panel.AddComponent<MenuUi>();
            ModHelperText selectWpn = panel.AddText(new Info("selectWpn", 0, 800, 2500, 180), "Select New Weapon", 100);
            Il2CppSystem.Random rnd = new Il2CppSystem.Random();
            var num1 = rnd.Next(0, 8);
            int DmgBoost = 0;
            int PierceBoost = 0;
            float RangeBoost = 1f;
            float AttackSpeedBoost = 1f;
            float MoneyBoost = 1f;
            if (num1 == 0)
            {
                PierceBoost = 1;
                RangeBoost = 1.1f;
                AttackSpeedBoost = 0.96f;
            }
            if (num1 == 1)
            {
                DmgBoost = 2;
                RangeBoost = 1.2f;
            }
            if (num1 == 2)
            {
                DmgBoost = 1;
                PierceBoost = 1;
            }
            if (num1 == 3)
            {
                PierceBoost = 3;
            }
            if (num1 == 4)
            {
                AttackSpeedBoost = 0.9f;
                RangeBoost = 1.05f;
            }
            if (num1 == 5)
            {
                PierceBoost = 1;
                RangeBoost = 1.35f;
            }
            if (num1 == 6)
            {
                MoneyBoost = 1.25f;
                DmgBoost = 1;
                PierceBoost = 1;
            }
            if (num1 == 7)
            {
                MoneyBoost = 1.4f;
            }
            ModHelperPanel wpn1Panel = panel.AddPanel(new Info("wpn1Panel", 375, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.GreyInsertPanel);
            ModHelperText rarityText1 = panel.AddText(new Info("rarityText1", -875, 600, 800, 180), "Common", 100);
            ModHelperText cardText1 = panel.AddText(new Info("cardText1", -875, 500, 800, 180), "Stronger Weapon Card", 50);
            ModHelperText dmgBoostText1 = panel.AddText(new Info("dmgBoostText1", -875, 200, 800, 180), "Damage Boost :" + DmgBoost, 50);
            ModHelperText prcBoostText1 = panel.AddText(new Info("prcBoostText1", -875, 100, 800, 180), "Pierce Boost :" + PierceBoost, 50);
            ModHelperText rngBoostText1 = panel.AddText(new Info("rngBoostText1", -875, 0, 800, 180), "Range Boost : X" + RangeBoost, 50);
            ModHelperText atkspdBoostText1 = panel.AddText(new Info("atkspdBoostText1", -875, -100, 800, 180), "Attack Speed Boost : X" + AttackSpeedBoost, 50);
            ModHelperText mnyBoostText1 = panel.AddText(new Info("mnyBoostText1", -875, -200, 800, 180), "Money Boost : X" + MoneyBoost, 50);
            ModHelperButton selectWpnBtn1 = panel.AddButton(new Info("selectWpnBtn1", -875, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.StrongWpnSelected(DmgBoost, PierceBoost, AttackSpeedBoost,RangeBoost,MoneyBoost, tower)));
            ModHelperText selectWpn1 = selectWpnBtn1.AddText(new Info("selectWpn1", 0, 0, 700, 160), "Select", 70);
            var rarityNum = rnd.Next(1, 100);
            var rarity = "Common";
            if (rarityNum >= mod.rareStrongChance)
            {
                rarity = "Rare";
            }
            if (rarityNum >= mod.epicStrongChance)
            {
                rarity = "Epic";
            }

            if (rarity == "Common")
            {
                var num2 = rnd.Next(0, 8);
                int DmgBoost2 = 0;
                int PierceBoost2 = 0;
                float RangeBoost2 = 1f;
                float AttackSpeedBoost2 = 1f;
                float MoneyBoost2 = 1f;
                if (num2 == 0)
                {
                    PierceBoost2 = 1;
                    RangeBoost2 = 1.1f;
                    AttackSpeedBoost2 = 0.96f;
                }
                if (num2 == 1)
                {
                    DmgBoost2 = 2;
                    RangeBoost2 = 1.2f;
                }
                if (num2 == 2)
                {
                    DmgBoost2 = 1;
                    PierceBoost2 = 1;
                }
                if (num2 == 3)
                {
                    PierceBoost2 = 3;
                }
                if (num2 == 4)
                {
                    AttackSpeedBoost2 = 0.9f;
                    RangeBoost2 = 1.05f;
                }
                if (num2 == 5)
                {
                    PierceBoost2 = 1;
                    RangeBoost2 = 1.35f;
                }
                if (num2 == 6)
                {
                    MoneyBoost2 = 1.25f;
                    DmgBoost2 = 1;
                    PierceBoost2 = 1;
                }
                if (num2 == 7)
                {
                    MoneyBoost2 = 1.4f;
                }
                ModHelperPanel wpn2Panel = panel.AddPanel(new Info("wpn2Panel", 1250, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.GreyInsertPanel);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 0, 600, 800, 180), "Common", 100);
                ModHelperText cardText2 = panel.AddText(new Info("cardText2", 0, 500, 800, 180), "Stronger Weapon Card", 50);
                ModHelperText dmgBoostText2 = panel.AddText(new Info("dmgBoostText2", 0, 200, 800, 180), "Damage Boost :" + DmgBoost2, 50);
                ModHelperText prcBoostText2 = panel.AddText(new Info("prcBoostText2", 0, 100, 800, 180), "Pierce Boost :" + PierceBoost2, 50);
                ModHelperText rngBoostText2 = panel.AddText(new Info("rngBoostText2", 05, 0, 800, 180), "Range Boost : X" + RangeBoost2, 50);
                ModHelperText atkspdBoostText2 = panel.AddText(new Info("atkspdBoostText2", 0, -100, 800, 180), "Attack Speed Boost : X" + AttackSpeedBoost2, 50);
                ModHelperText mnyBoostText2 = panel.AddText(new Info("mnyBoostText2", 0, -200, 800, 180), "Money Boost : X" + MoneyBoost2, 50);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 0, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.StrongWpnSelected(DmgBoost2, PierceBoost2, AttackSpeedBoost2, RangeBoost2, MoneyBoost2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }
            if (rarity == "Rare")
            {
                var num2 = rnd.Next(0, 10);
                int DmgBoost2 = 0;
                int PierceBoost2 = 0;
                float RangeBoost2 = 1f;
                float AttackSpeedBoost2 = 1f;
                float MoneyBoost2 = 1f;
                if (num2 == 0)
                {
                    PierceBoost2 = 2;
                    RangeBoost2 = 1.2f;
                    AttackSpeedBoost2 = 0.94f;
                }
                if (num2 == 1)
                {
                    DmgBoost2 = 4;
                    RangeBoost2 = 1.3f;
                }
                if (num2 == 2)
                {
                    DmgBoost2 = 3;
                    PierceBoost2 = 2;
                }
                if (num2 == 3)
                {
                    PierceBoost2 = 5;
                }
                if (num2 == 4)
                {
                    AttackSpeedBoost2 = 0.85f;
                    RangeBoost2 = 1.12f;
                }
                if (num2 == 5)
                {
                    PierceBoost2 = 3;
                    RangeBoost2 = 1.4f;
                }
                if (num2 == 6)
                {
                    MoneyBoost2 = 1.35f;
                    DmgBoost2 = 2;
                    PierceBoost2 = 3;
                }
                if (num2 == 7)
                {
                    MoneyBoost2 = 1.6f;
                }
                if (num2 == 8)
                {
                    MoneyBoost2 = 1.2f;
                    DmgBoost2 = 2;
                    PierceBoost2 = 2;
                    AttackSpeedBoost2 = 0.95f;
                    RangeBoost2 = 1.1f;
                }
                if (num2 == 9)
                {
                    DmgBoost2 = 4;
                    PierceBoost2 = 1;
                }
                ModHelperPanel wpn2Panel = panel.AddPanel(new Info("wpn2Panel", 1250, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.BlueInsertPanel);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 0, 600, 800, 180), "Rare", 100);
                ModHelperText cardText2 = panel.AddText(new Info("cardText2", 0, 500, 800, 180), "Stronger Weapon Card", 50);
                ModHelperText dmgBoostText2 = panel.AddText(new Info("dmgBoostText2", 0, 200, 800, 180), "Damage Boost :" + DmgBoost2, 50);
                ModHelperText prcBoostText2 = panel.AddText(new Info("prcBoostText2", 0, 100, 800, 180), "Pierce Boost :" + PierceBoost2, 50);
                ModHelperText rngBoostText2 = panel.AddText(new Info("rngBoostText2", 05, 0, 800, 180), "Range Boost : X" + RangeBoost2, 50);
                ModHelperText atkspdBoostText2 = panel.AddText(new Info("atkspdBoostText2", 0, -100, 800, 180), "Attack Speed Boost : X" + AttackSpeedBoost2, 50);
                ModHelperText mnyBoostText2 = panel.AddText(new Info("mnyBoostText2", 0, -200, 800, 180), "Money Boost : X" + MoneyBoost2, 50);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 0, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.StrongWpnSelected(DmgBoost2, PierceBoost2, AttackSpeedBoost2, RangeBoost2, MoneyBoost2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }
            if (rarity == "Epic")
            {
                var num2 = rnd.Next(0, 11);
                int DmgBoost2 = 0;
                int PierceBoost2 = 0;
                float RangeBoost2 = 1f;
                float AttackSpeedBoost2 = 1f;
                float MoneyBoost2 = 1f;
                if (num2 == 0)
                {
                    PierceBoost2 = 4;
                    RangeBoost2 = 1.3f;
                    AttackSpeedBoost2 = 0.90f;
                }
                if (num2 == 1)
                {
                    DmgBoost2 = 7;
                    RangeBoost2 = 1.45f;
                }
                if (num2 == 2)
                {
                    DmgBoost2 = 5;
                    PierceBoost2 = 3;
                }
                if (num2 == 3)
                {
                    PierceBoost2 = 8;
                }
                if (num2 == 4)
                {
                    AttackSpeedBoost2 = 0.82f;
                    RangeBoost2 = 1.18f;
                }
                if (num2 == 5)
                {
                    PierceBoost2 = 5;
                    RangeBoost2 = 1.52f;
                }
                if (num2 == 6)
                {
                    MoneyBoost2 = 1.45f;
                    DmgBoost2 = 4;
                    PierceBoost2 = 5;
                }
                if (num2 == 7)
                {
                    MoneyBoost2 = 1.8f;
                }
                if (num2 == 8)
                {
                    MoneyBoost2 = 1.35f;
                    DmgBoost2 = 3;
                    PierceBoost2 = 4;
                    AttackSpeedBoost2 = 0.91f;
                    RangeBoost2 = 1.25f;
                }
                if (num2 == 9)
                {
                    DmgBoost2 = 7;
                    PierceBoost2 = 3;
                }
                if (num2 == 10)
                {
                    MoneyBoost2 = 1.45f;
                    DmgBoost2 = 5;
                    PierceBoost2 = 4;
                }
                ModHelperPanel wpn2Panel = panel.AddPanel(new Info("wpn2Panel", 1250, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.MainBgPanelParagon);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 0, 600, 800, 180), "Epic", 100);
                ModHelperText cardText2 = panel.AddText(new Info("cardText2", 0, 500, 800, 180), "Stronger Weapon Card", 50);
                ModHelperText dmgBoostText2 = panel.AddText(new Info("dmgBoostText2", 0, 200, 800, 180), "Damage Boost :" + DmgBoost2, 50);
                ModHelperText prcBoostText2 = panel.AddText(new Info("prcBoostText2", 0, 100, 800, 180), "Pierce Boost :" + PierceBoost2, 50);
                ModHelperText rngBoostText2 = panel.AddText(new Info("rngBoostText2", 05, 0, 800, 180), "Range Boost : X" + RangeBoost2, 50);
                ModHelperText atkspdBoostText2 = panel.AddText(new Info("atkspdBoostText2", 0, -100, 800, 180), "Attack Speed Boost : X" + AttackSpeedBoost2, 50);
                ModHelperText mnyBoostText2 = panel.AddText(new Info("mnyBoostText2", 0, -200, 800, 180), "Money Boost : X" + MoneyBoost2, 50);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 0, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.StrongWpnSelected(DmgBoost2, PierceBoost2, AttackSpeedBoost2, RangeBoost2, MoneyBoost2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }
            var rarityNum2 = rnd.Next(1, 100);
            var rarity2 = "Common";
            if (rarityNum2 >= mod.rareStrongChance)
            {
                rarity2 = "Rare";
            }
            if (rarityNum2 >= mod.epicStrongChance)
            {
                rarity2 = "Epic";
            }
            if (rarityNum2 >= mod.legendaryStrongChance)
            {
                rarity2 = "Legendary";
            }
            if (rarityNum2 >= mod.exoticStrongChance)
            {
                rarity2 = "Exotic";
            }
            if (rarity2 == "Common")
            {
                var num2 = rnd.Next(0, 8);
                int DmgBoost2 = 0;
                int PierceBoost2 = 0;
                float RangeBoost2 = 1f;
                float AttackSpeedBoost2 = 1f;
                float MoneyBoost2 = 1f;
                if (num2 == 0)
                {
                    PierceBoost2 = 1;
                    RangeBoost2 = 1.1f;
                    AttackSpeedBoost2 = 0.96f;
                }
                if (num2 == 1)
                {
                    DmgBoost2 = 2;
                    RangeBoost2 = 1.2f;
                }
                if (num2 == 2)
                {
                    DmgBoost2 = 1;
                    PierceBoost2 = 1;
                }
                if (num2 == 3)
                {
                    PierceBoost2 = 3;
                }
                if (num2 == 4)
                {
                    AttackSpeedBoost2 = 0.9f;
                    RangeBoost2 = 1.05f;
                }
                if (num2 == 5)
                {
                    PierceBoost2 = 1;
                    RangeBoost2 = 1.35f;
                }
                if (num2 == 6)
                {
                    MoneyBoost2 = 1.25f;
                    DmgBoost2 = 1;
                    PierceBoost2 = 1;
                }
                if (num2 == 7)
                {
                    MoneyBoost2 = 1.4f;
                }
                ModHelperPanel wpn2Panel = panel.AddPanel(new Info("wpn2Panel", 2125, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.GreyInsertPanel);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 875, 600, 800, 180), "Common", 100);
                ModHelperText cardText2 = panel.AddText(new Info("cardText2", 875, 500, 800, 180), "Stronger Weapon Card", 50);
                ModHelperText dmgBoostText2 = panel.AddText(new Info("dmgBoostText2", 875, 200, 800, 180), "Damage Boost :" + DmgBoost2, 50);
                ModHelperText prcBoostText2 = panel.AddText(new Info("prcBoostText2", 875, 100, 800, 180), "Pierce Boost :" + PierceBoost2, 50);
                ModHelperText rngBoostText2 = panel.AddText(new Info("rngBoostText2", 875, 0, 800, 180), "Range Boost : X" + RangeBoost2, 50);
                ModHelperText atkspdBoostText2 = panel.AddText(new Info("atkspdBoostText2", 875, -100, 800, 180), "Attack Speed Boost : X" + AttackSpeedBoost2, 50);
                ModHelperText mnyBoostText2 = panel.AddText(new Info("mnyBoostText2", 875, -200, 800, 180), "Money Boost : X" + MoneyBoost2, 50);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 875, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.StrongWpnSelected(DmgBoost2, PierceBoost2, AttackSpeedBoost2, RangeBoost2, MoneyBoost2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }
            if (rarity2 == "Rare")
            {
                var num2 = rnd.Next(0, 10);
                int DmgBoost2 = 0;
                int PierceBoost2 = 0;
                float RangeBoost2 = 1f;
                float AttackSpeedBoost2 = 1f;
                float MoneyBoost2 = 1f;
                if (num2 == 0)
                {
                    PierceBoost2 = 2;
                    RangeBoost2 = 1.2f;
                    AttackSpeedBoost2 = 0.94f;
                }
                if (num2 == 1)
                {
                    DmgBoost2 = 4;
                    RangeBoost2 = 1.3f;
                }
                if (num2 == 2)
                {
                    DmgBoost2 = 3;
                    PierceBoost2 = 2;
                }
                if (num2 == 3)
                {
                    PierceBoost2 = 5;
                }
                if (num2 == 4)
                {
                    AttackSpeedBoost2 = 0.85f;
                    RangeBoost2 = 1.12f;
                }
                if (num2 == 5)
                {
                    PierceBoost2 = 3;
                    RangeBoost2 = 1.4f;
                }
                if (num2 == 6)
                {
                    MoneyBoost2 = 1.35f;
                    DmgBoost2 = 2;
                    PierceBoost2 = 3;
                }
                if (num2 == 7)
                {
                    MoneyBoost2 = 1.6f;
                }
                if (num2 == 8)
                {
                    MoneyBoost2 = 1.2f;
                    DmgBoost2 = 2;
                    PierceBoost2 = 2;
                    AttackSpeedBoost2 = 0.95f;
                    RangeBoost2 = 1.1f;
                }
                if (num2 == 9)
                {
                    DmgBoost2 = 4;
                    PierceBoost2 = 1;
                }
                ModHelperPanel wpn2Panel = panel.AddPanel(new Info("wpn2Panel", 2125, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.BlueInsertPanel);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 875, 600, 800, 180), "Rare", 100);
                ModHelperText cardText2 = panel.AddText(new Info("cardText2", 875, 500, 800, 180), "Stronger Weapon Card", 50);
                ModHelperText dmgBoostText2 = panel.AddText(new Info("dmgBoostText2", 875, 200, 800, 180), "Damage Boost :" + DmgBoost2, 50);
                ModHelperText prcBoostText2 = panel.AddText(new Info("prcBoostText2", 875, 100, 800, 180), "Pierce Boost :" + PierceBoost2, 50);
                ModHelperText rngBoostText2 = panel.AddText(new Info("rngBoostText2", 875, 0, 800, 180), "Range Boost : X" + RangeBoost2, 50);
                ModHelperText atkspdBoostText2 = panel.AddText(new Info("atkspdBoostText2", 875, -100, 800, 180), "Attack Speed Boost : X" + AttackSpeedBoost2, 50);
                ModHelperText mnyBoostText2 = panel.AddText(new Info("mnyBoostText2", 875, -200, 800, 180), "Money Boost : X" + MoneyBoost2, 50);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 875, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.StrongWpnSelected(DmgBoost2, PierceBoost2, AttackSpeedBoost2, RangeBoost2, MoneyBoost2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }
            if (rarity2 == "Epic")
            {
                var num2 = rnd.Next(0, 11);
                int DmgBoost2 = 0;
                int PierceBoost2 = 0;
                float RangeBoost2 = 1f;
                float AttackSpeedBoost2 = 1f;
                float MoneyBoost2 = 1f;
                if (num2 == 0)
                {
                    PierceBoost2 = 4;
                    RangeBoost2 = 1.3f;
                    AttackSpeedBoost2 = 0.90f;
                }
                if (num2 == 1)
                {
                    DmgBoost2 = 7;
                    RangeBoost2 = 1.45f;
                }
                if (num2 == 2)
                {
                    DmgBoost2 = 5;
                    PierceBoost2 = 3;
                }
                if (num2 == 3)
                {
                    PierceBoost2 = 8;
                }
                if (num2 == 4)
                {
                    AttackSpeedBoost2 = 0.82f;
                    RangeBoost2 = 1.18f;
                }
                if (num2 == 5)
                {
                    PierceBoost2 = 5;
                    RangeBoost2 = 1.52f;
                }
                if (num2 == 6)
                {
                    MoneyBoost2 = 1.45f;
                    DmgBoost2 = 4;
                    PierceBoost2 = 5;
                }
                if (num2 == 7)
                {
                    MoneyBoost2 = 1.8f;
                }
                if (num2 == 8)
                {
                    MoneyBoost2 = 1.35f;
                    DmgBoost2 = 3;
                    PierceBoost2 = 4;
                    AttackSpeedBoost2 = 0.91f;
                    RangeBoost2 = 1.25f;
                }
                if (num2 == 9)
                {
                    DmgBoost2 = 7;
                    PierceBoost2 = 3;
                }
                if (num2 == 10)
                {
                    MoneyBoost2 = 1.45f;
                    DmgBoost2 = 5;
                    PierceBoost2 = 4;
                }
                ModHelperPanel wpn2Panel = panel.AddPanel(new Info("wpn2Panel", 2125, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.MainBgPanelParagon);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 875, 600, 800, 180), "Epic", 100);
                ModHelperText cardText2 = panel.AddText(new Info("cardText2", 875, 500, 800, 180), "Stronger Weapon Card", 50);
                ModHelperText dmgBoostText2 = panel.AddText(new Info("dmgBoostText2", 875, 200, 800, 180), "Damage Boost :" + DmgBoost2, 50);
                ModHelperText prcBoostText2 = panel.AddText(new Info("prcBoostText2", 875, 100, 800, 180), "Pierce Boost :" + PierceBoost2, 50);
                ModHelperText rngBoostText2 = panel.AddText(new Info("rngBoostText2", 875, 0, 800, 180), "Range Boost : X" + RangeBoost2, 50);
                ModHelperText atkspdBoostText2 = panel.AddText(new Info("atkspdBoostText2", 875, -100, 800, 180), "Attack Speed Boost : X" + AttackSpeedBoost2, 50);
                ModHelperText mnyBoostText2 = panel.AddText(new Info("mnyBoostText2", 875, -200, 800, 180), "Money Boost : X" + MoneyBoost2, 50);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 875, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.StrongWpnSelected(DmgBoost2, PierceBoost2, AttackSpeedBoost2, RangeBoost2, MoneyBoost2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }
            if (rarity2 == "Legendary")
            {
                var num2 = rnd.Next(0, 12);
                int DmgBoost2 = 0;
                int PierceBoost2 = 0;
                float RangeBoost2 = 1f;
                float AttackSpeedBoost2 = 1f;
                float MoneyBoost2 = 1f;
                if (num2 == 0)
                {
                    PierceBoost2 = 7;
                    RangeBoost2 = 1.45f;
                    AttackSpeedBoost2 = 0.85f;
                }
                if (num2 == 1)
                {
                    DmgBoost2 = 12;
                    RangeBoost2 = 1.55f;
                }
                if (num2 == 2)
                {
                    DmgBoost2 = 8;
                    PierceBoost2 = 7;
                }
                if (num2 == 3)
                {
                    PierceBoost2 = 12;
                }
                if (num2 == 4)
                {
                    AttackSpeedBoost2 = 0.77f;
                    RangeBoost2 = 1.25f;
                }
                if (num2 == 5)
                {
                    PierceBoost2 = 9;
                    RangeBoost2 = 1.60f;
                }
                if (num2 == 6)
                {
                    MoneyBoost2 = 1.55f;
                    DmgBoost2 = 7;
                    PierceBoost2 = 8;
                }
                if (num2 == 7)
                {
                    MoneyBoost2 = 2f;
                }
                if (num2 == 8)
                {
                    MoneyBoost2 = 1.45f;
                    DmgBoost2 = 5;
                    PierceBoost2 = 7;
                    AttackSpeedBoost2 = 0.85f;
                    RangeBoost2 = 1.35f;
                }
                if (num2 == 9)
                {
                    DmgBoost2 = 11;
                    PierceBoost2 = 6;
                }
                if (num2 == 10)
                {
                    MoneyBoost2 = 1.55f;
                    DmgBoost2 = 8;
                    PierceBoost2 = 6;
                }
                if (num2 == 11)
                {
                    AttackSpeedBoost2 = 0.7f;
                }
                ModHelperPanel wpn2Panel = panel.AddPanel(new Info("wpn2Panel", 2125, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.MainBGPanelYellow);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 875, 600, 800, 180), "Legendary", 100);
                ModHelperText cardText2 = panel.AddText(new Info("cardText2", 875, 500, 800, 180), "Stronger Weapon Card", 50);
                ModHelperText dmgBoostText2 = panel.AddText(new Info("dmgBoostText2", 875, 200, 800, 180), "Damage Boost :" + DmgBoost2, 50);
                ModHelperText prcBoostText2 = panel.AddText(new Info("prcBoostText2", 875, 100, 800, 180), "Pierce Boost :" + PierceBoost2, 50);
                ModHelperText rngBoostText2 = panel.AddText(new Info("rngBoostText2", 875, 0, 800, 180), "Range Boost : X" + RangeBoost2, 50);
                ModHelperText atkspdBoostText2 = panel.AddText(new Info("atkspdBoostText2", 875, -100, 800, 180), "Attack Speed Boost : X" + AttackSpeedBoost2, 50);
                ModHelperText mnyBoostText2 = panel.AddText(new Info("mnyBoostText2", 875, -200, 800, 180), "Money Boost : X" + MoneyBoost2, 50);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 875, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.StrongWpnSelected(DmgBoost2, PierceBoost2, AttackSpeedBoost2, RangeBoost2, MoneyBoost2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }
            if (rarity2 == "Exotic")
            {
                var num2 = rnd.Next(0, 12);
                int DmgBoost2 = 0;
                int PierceBoost2 = 0;
                float RangeBoost2 = 1f;
                float AttackSpeedBoost2 = 1f;
                float MoneyBoost2 = 1f;
                if (num2 == 0)
                {
                    PierceBoost2 = 11;
                    RangeBoost2 = 1.6f;
                    AttackSpeedBoost2 = 0.79f;
                }
                if (num2 == 1)
                {
                    DmgBoost2 = 17;
                    RangeBoost2 = 1.7f;
                }
                if (num2 == 2)
                {
                    DmgBoost2 = 13;
                    PierceBoost2 = 12;
                }
                if (num2 == 3)
                {
                    PierceBoost2 = 20;
                }
                if (num2 == 4)
                {
                    AttackSpeedBoost2 = 0.7f;
                    RangeBoost2 = 1.35f;
                }
                if (num2 == 5)
                {
                    PierceBoost2 = 14;
                    RangeBoost2 = 1.75f;
                }
                if (num2 == 6)
                {
                    MoneyBoost2 = 1.70f;
                    DmgBoost2 = 12;
                    PierceBoost2 = 14;
                }
                if (num2 == 7)
                {
                    MoneyBoost2 = 2.5f;
                }
                if (num2 == 8)
                {
                    MoneyBoost2 = 1.62f;
                    DmgBoost2 = 9;
                    PierceBoost2 = 11;
                    AttackSpeedBoost2 = 0.78f;
                    RangeBoost2 = 1.48f;
                }
                if (num2 == 9)
                {
                    DmgBoost2 = 16;
                    PierceBoost2 = 10;
                }
                if (num2 == 10)
                {
                    MoneyBoost2 = 1.75f;
                    DmgBoost2 = 13;
                    PierceBoost2 = 11;
                }
                if (num2 == 11)
                {
                    AttackSpeedBoost2 = 0.6f;
                    PierceBoost2 = 5;
                }
                ModHelperPanel wpn2Panel = panel.AddPanel(new Info("wpn2Panel", 2125, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.MainBgPanelWhiteSmall);
                ModHelperText rarityText2 = panel.AddText(new Info("rarityText2", 875, 600, 800, 180), "Exotic", 100);
                ModHelperText cardText2 = panel.AddText(new Info("cardText2", 875, 500, 800, 180), "Stronger Weapon Card", 50);
                ModHelperText dmgBoostText2 = panel.AddText(new Info("dmgBoostText2", 875, 200, 800, 180), "Damage Boost :" + DmgBoost2, 50);
                ModHelperText prcBoostText2 = panel.AddText(new Info("prcBoostText2", 875, 100, 800, 180), "Pierce Boost :" + PierceBoost2, 50);
                ModHelperText rngBoostText2 = panel.AddText(new Info("rngBoostText2", 875, 0, 800, 180), "Range Boost : X" + RangeBoost2, 50);
                ModHelperText atkspdBoostText2 = panel.AddText(new Info("atkspdBoostText2", 875, -100, 800, 180), "Attack Speed Boost : X" + AttackSpeedBoost2, 50);
                ModHelperText mnyBoostText2 = panel.AddText(new Info("mnyBoostText2", 875, -200, 800, 180), "Money Boost : X" + MoneyBoost2, 50);
                ModHelperButton selectWpnBtn2 = panel.AddButton(new Info("selectWpnBtn2", 875, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.StrongWpnSelected(DmgBoost2, PierceBoost2, AttackSpeedBoost2, RangeBoost2, MoneyBoost2, tower)));
                ModHelperText selectWpn2 = selectWpnBtn2.AddText(new Info("selectWpn2", 0, 0, 700, 160), "Select", 70);
            }
        }
        public void StrongWeapon(Tower tower)
        {
            InGame game = InGame.instance;
            if (game.GetCash() >= mod.strongerWeaponCost)
            {
                game.AddCash(-mod.strongerWeaponCost);
                RectTransform rect = game.uiRect;
                MenuUi.StrongWeaponPanel(rect, tower);
                mod.strongerWeaponCost += mod.baseStrongerWeaponCost;
                tower.worth += mod.strongerWeaponCost - mod.baseStrongerWeaponCost;
                mod.baseStrongerWeaponCost *= 1.06f;
                
         
                MenuUi.instance.CloseMenu();

            }
        }
        public void StrongWpnSelected(int Dmg, int Pierce, float AtkSpd, float Range, float Money, Tower tower)
        {

            InGame game = InGame.instance;
            Destroy(gameObject);
            RectTransform rect = game.uiRect;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();

            towerModel.range *= Range;
            foreach (var weaponModel in towerModel.GetDescendants<WeaponModel>().ToArray())
            {
                if (weaponModel.projectile.HasBehavior<DamageModel>())
                {
                    weaponModel.rate *= AtkSpd;
                    weaponModel.projectile.pierce += Pierce;
                    weaponModel.projectile.GetDamageModel().damage += Dmg;
                }
                if (weaponModel.projectile.HasBehavior<TravelStraitModel>())
                {
                    weaponModel.projectile.GetBehavior<TravelStraitModel>().lifespan += Range / 90;
                }
                if (weaponModel.projectile.HasBehavior<CashModel>())
                {
                    weaponModel.projectile.GetBehavior<CashModel>().minimum *= Money;
                    weaponModel.projectile.GetBehavior<CashModel>().maximum *= Money;
                }
            }
            foreach (var attackModel in towerModel.GetDescendants<AttackModel>().ToArray())
            {
                attackModel.range *= Range;
            }
            mod.rareStrongChance -= 7f;
            mod.epicStrongChance -= 2.10f;
            if (mod.epicStrongChance <= 88)
            {
                mod.legendaryStrongChance -= 1.25f;
            }
            if (mod.legendaryStrongChance <= 91)
            {
                mod.exoticStrongChance -= 0.8f;
            }
         
            tower.UpdateRootModel(towerModel);
            if (mod.upgradeOpen == true)
            {
                CreateUpgradeMenu(rect, tower);
            }

        }
        public void NewAbility(Tower tower)
        {
            InGame game = InGame.instance;
            if (game.GetCash() >= mod.newAbilityCost)
            {
                game.AddCash(-mod.newAbilityCost);
                RectTransform rect = game.uiRect;
                mod.newAbilityCost += mod.baseNewAbilityCost;
                tower.worth += mod.newAbilityCost - mod.baseNewAbilityCost;
                MenuUi.NewAbilityPanel(rect, tower);
                MenuUi.instance.CloseMenu();
            }
        }
    
        public static void NewAbilityPanel(RectTransform rect, Tower tower)
        {
            ModHelperPanel panel = rect.gameObject.AddModHelperPanel(new Info("Panel_", 2000, 1500, 1000, 1850, new UnityEngine.Vector2()), VanillaSprites.BrownInsertPanel);
            MenuUi upgradeUi = panel.AddComponent<MenuUi>();
            ModHelperText selectAbility = panel.AddText(new Info("selectAbility", 0, 800, 2500, 180), "Select New Ability", 100);
            Il2CppSystem.Random rnd = new Il2CppSystem.Random();
            var num1 = rnd.Next(0, 10);
            var abSelected = mod.Ability[num1];
            var imgSelected = mod.AbilityImg[num1];

            ModHelperPanel abilityPanel = panel.AddPanel(new Info("abilityPanel", 500, 900, 650, 1450, new UnityEngine.Vector2()), VanillaSprites.GreyInsertPanel);
            ModHelperText abilityText = panel.AddText(new Info("abilityText", 0, 600, 800, 180), "Ability", 100);
            ModHelperText abilityText2 = panel.AddText(new Info("abilityText2", 0, 500, 800, 180), abSelected, 75);
            ModHelperImage image2 = panel.AddImage(new Info("image2", 0, 0, 400, 400), imgSelected);
            ModHelperButton selectAbilityBtn2 = panel.AddButton(new Info("selectAbilityBtn2", 0, -600, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.AbilitySelected(abSelected, tower, "Common")));
            ModHelperText selectAbility2 = selectAbilityBtn2.AddText(new Info("selectAbility2", 0, 0, 700, 160), "Select", 70);
        }
        public void AbilitySelected(string Ability, Tower tower, string rarity)
        {

            InGame game = InGame.instance;
            Destroy(gameObject);
            RectTransform rect = game.uiRect;
            if (Ability == "MIB")
            {
                mod.mib = true;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
                foreach (var weaponModel in towerModel.GetDescendants<WeaponModel>().ToArray())
                {
                    if (weaponModel.projectile.HasBehavior<DamageModel>())
                    {
                        weaponModel.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
                    }
                }
                tower.UpdateRootModel(towerModel);
            }
            if (Ability == "Summoning Phoenix")
            {
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                var ab = Game.instance.model.GetTowerFromId("WizardMonkey-042").GetAbility().Duplicate();
                towerModel.AddBehavior(ab);
                tower.UpdateRootModel(towerModel);
            }
            if (Ability == "Teleportation")
            {
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                var ab = Game.instance.model.GetTowerFromId("SuperMonkey-004").GetAbility().Duplicate();
                towerModel.AddBehavior(ab);
                tower.UpdateRootModel(towerModel);
            }
            if (Ability == "Blade Maelstrom")
            {
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                var ab = Game.instance.model.GetTowerFromId("TackShooter-040").GetAbility().Duplicate();
                towerModel.AddBehavior(ab);
                tower.UpdateRootModel(towerModel);
            }
            if (Ability == "Tech Terror")
            {
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                var ab = Game.instance.model.GetTowerFromId("SuperMonkey-040").GetAbility().Duplicate();
                towerModel.AddBehavior(ab);
                tower.UpdateRootModel(towerModel);
            }
            if (Ability == "Spike Storm")
            {
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                var ab = Game.instance.model.GetTowerFromId("SpikeFactory-040").GetAbility().Duplicate();
                towerModel.AddBehavior(ab);
                tower.UpdateRootModel(towerModel);
            }
            if (Ability == "Overclock")
            {
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                var ab = Game.instance.model.GetTowerFromId("EngineerMonkey-040").GetAbility().Duplicate();
                towerModel.AddBehavior(ab);
                tower.UpdateRootModel(towerModel);
            }
            if (Ability == "First Strike Capability")
            {
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                var ab = Game.instance.model.GetTowerFromId("MonkeySub-040").GetAbility().Duplicate();
                towerModel.AddBehavior(ab);
                tower.UpdateRootModel(towerModel);
            }
            if (Ability == "Elite Sniper")
            {
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                var ab = Game.instance.model.GetTowerFromId("SniperMonkey-050").GetAbility().Duplicate();
                towerModel.AddBehavior(ab);
                tower.UpdateRootModel(towerModel);
            }
            if (Ability == "Elite Sniper")
            {
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                var ab = Game.instance.model.GetTowerFromId("SniperMonkey-050").GetAbility().Duplicate();
                towerModel.AddBehavior(ab);
                tower.UpdateRootModel(towerModel);
            }
            if (Ability == "Snow Storm")
            {
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                var ab = Game.instance.model.GetTowerFromId("IceMonkey-040").GetAbility().Duplicate();
                towerModel.AddBehavior(ab);
                tower.UpdateRootModel(towerModel);
            }
            if (mod.upgradeOpen == true)
            {
                CreateUpgradeMenu(rect, tower);
            }
        }

        public static void CreateUpgradeMenu(RectTransform rect, Tower tower)
        {
            ModHelperPanel panel = rect.gameObject.AddModHelperPanel(new Info("Panel_", 2200, 200, 2500, 450, new UnityEngine.Vector2()), VanillaSprites.BrownInsertPanel);
            MenuUi upgradeUi = panel.AddComponent<MenuUi>();
            instance = upgradeUi;
            ModHelperText newWpnCost = panel.AddText(new Info("newWpnCost", 0, 140, 1000, 180), "New Weapon: $" + Mathf.Round(mod.newWeaponCost), 70);
            if (mod.selectingWeaponOpen == false)
            {
                ModHelperButton newWpnBtn = panel.AddButton(new Info("newWpnBtn", 0, 20, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.NewWeapon(tower)));
                ModHelperText newWpnBuy = newWpnBtn.AddText(new Info("newWpnBuy", 0, 0, 700, 160), "Buy", 70);
            }
            ModHelperText newWpnDesc = panel.AddText(new Info("newWpnDesc", 0, -100, 860, 180), "Give an extra weapon", 42);

            ModHelperText strongWpnCost = panel.AddText(new Info("strongWpnCost", -800, 140, 1000, 180), "Stronger Weapon: $" + Mathf.Round(mod.strongerWeaponCost), 70);
            if (mod.selectingWeaponOpen == false)
            {
                ModHelperButton strongWpnBtn = panel.AddButton(new Info("strongWpnBtn", -800, 20, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.StrongWeapon(tower)));
                ModHelperText strongWpnBuy = strongWpnBtn.AddText(new Info("strongWpnBuy", 0, 0, 700, 160), "Buy", 70);
            }
            ModHelperText strongWpnDesc = panel.AddText(new Info("strongWpnDesc", -800, -100, 860, 180), "Make your current weapon stronger", 42);

            ModHelperText abilityCost = panel.AddText(new Info("abilityCost", 800, 140, 1000, 180), "New Ability: $" + Mathf.Round(mod.newAbilityCost), 70);
            if (mod.selectingWeaponOpen == false)
            {
                ModHelperButton abilityBtn = panel.AddButton(new Info("abilityBtn", 800, 20, 500, 160), VanillaSprites.GreenBtnLong, new System.Action(() => upgradeUi.NewAbility(tower)));
                ModHelperText abilityBuy = abilityBtn.AddText(new Info("abilityBuy", 0, 0, 700, 160), "Buy", 70);
            }
            ModHelperText abilityDesc = panel.AddText(new Info("abilityDesc", 800, -100, 860, 180), "Give an ability", 42);


        }

    }
}
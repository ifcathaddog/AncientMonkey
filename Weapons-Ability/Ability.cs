using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Enums;
using Il2CppAssets.Scripts.Data.Gameplay.Mods;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Data.Gameplay.Mods;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Simulation.Towers;
using Il2CppAssets.Scripts.Unity;
using UnityEngine;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppSystem;

namespace AncientMonkey.Weapons
{
    public class MIB : AbilityTemplate
    {
        public override string AbilityName => "MIB";
        public override string Icon => VanillaSprites.MonkeyIntelligenceBureauUpgradeIcon;
        public override void EditTower(Tower tower)
        {
        }
    }
    public class SummoningPhoenix : AbilityTemplate
    {
        public override string AbilityName => "Summoning Phoenix";
        public override string Icon => VanillaSprites.SummonPhoenixUpgradeIcon;
        public override void EditTower(Tower tower)
        {
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            var ab = Game.instance.model.GetTowerFromId("WizardMonkey-042").GetAbility().Duplicate();
            towerModel.AddBehavior(ab);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Teleportation : AbilityTemplate
    {
        public override string AbilityName => "Teleportation";
        public override string Icon => VanillaSprites.DarkKnightUpgradeIconAA;
        public override void EditTower(Tower tower)
        {
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            var ab = Game.instance.model.GetTowerFromId("SuperMonkey-004").GetAbility().Duplicate();
            towerModel.AddBehavior(ab);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class BladeMaelstrom : AbilityTemplate
    {
        public override string AbilityName => "Blade Maelstrom";
        public override string Icon => VanillaSprites.BladeMaelstromUpgradeIconAA;
        public override void EditTower(Tower tower)
        {
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            var ab = Game.instance.model.GetTowerFromId("TackShooter-040").GetAbility().Duplicate();
            towerModel.AddBehavior(ab);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class TechTerror : AbilityTemplate
    {
        public override string AbilityName => "Tech Terror";
        public override string Icon => VanillaSprites.TechTerrorUpgradeIconAA;
        public override void EditTower(Tower tower)
        {
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            var ab = Game.instance.model.GetTowerFromId("SuperMonkey-040").GetAbility().Duplicate();
            towerModel.AddBehavior(ab);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class SpikeStorm : AbilityTemplate
    {
        public override string AbilityName => "Spike Storm";
        public override string Icon => VanillaSprites.SpikeStormUpgradeIcon;
        public override void EditTower(Tower tower)
        {
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            var ab = Game.instance.model.GetTowerFromId("SpikeFactory-040").GetAbility().Duplicate();
            towerModel.AddBehavior(ab);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Overclock : AbilityTemplate
    {
        public override string AbilityName => "Overclock";
        public override string Icon => VanillaSprites.OverclockUpgradeIcon;
        public override void EditTower(Tower tower)
        {
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            var ab = Game.instance.model.GetTowerFromId("EngineerMonkey-040").GetAbility().Duplicate();
            towerModel.AddBehavior(ab);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class FirstStrikeCapability : AbilityTemplate
    {
        public override string AbilityName => "First Strike Capability";
        public override string Icon => VanillaSprites.FirstStrikeCapabilityUpgradeIconAA;
        public override void EditTower(Tower tower)
        {
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            var ab = Game.instance.model.GetTowerFromId("MonkeySub-040").GetAbility().Duplicate();
            towerModel.AddBehavior(ab);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class EliteSniper : AbilityTemplate
    {
        public override string AbilityName => "Elite Sniper";
        public override string Icon => VanillaSprites.EliteSniperUpgradeIcon;
        public override void EditTower(Tower tower)
        {
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            var ab = Game.instance.model.GetTowerFromId("SniperMonkey-050").GetAbility().Duplicate();
            towerModel.AddBehavior(ab);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class SnowStorm : AbilityTemplate
    {
        public override string AbilityName => "Snow Storm";
        public override string Icon => VanillaSprites.SnowstormUpgradeIcon;
        public override void EditTower(Tower tower)
        {
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            var ab = Game.instance.model.GetTowerFromId("IceMonkey-040").GetAbility().Duplicate();
            towerModel.AddBehavior(ab);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class CarpetOfSpike : AbilityTemplate
    {
        public override string AbilityName => "Carpet Of Spike";
        public override string Icon => VanillaSprites.CarpetOfSpikesUpgradeIcon;
        public override void EditTower(Tower tower)
        {
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            var ab = Game.instance.model.GetTowerFromId("SpikeFactory-250").GetAbility().Duplicate();
            towerModel.AddBehavior(ab);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class MoabEliminator : AbilityTemplate
    {
        public override string AbilityName => "Moab Eliminator";
        public override string Icon => VanillaSprites.MoabEliminatorUpgradeIcon;
        public override void EditTower(Tower tower)
        {
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            var ab = Game.instance.model.GetTowerFromId("BombShooter-050").GetAbility().Duplicate();
            towerModel.AddBehavior(ab);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class MonkeyNomics : AbilityTemplate
    {
        public override string AbilityName => "Monkey Nomics";
        public override string Icon => VanillaSprites.MonkeyNomicsUpgradeIcon;
        public override void EditTower(Tower tower)
        {
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            var ab = Game.instance.model.GetTowerFromId("BananaFarm-050").GetAbility().Duplicate();
            towerModel.AddBehavior(ab);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class AbilityClass
    {
        public static List<string> AbilityName = new List<string>();
        public static List<string> AbilityImg = new List<string>();
    }
}

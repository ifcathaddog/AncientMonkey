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

namespace AncientMonkey.Weapons
{
    public class Dart : WeaponTemplate
    {
        public override int SandboxIndex => 1;
        public override Rarity WeaponRarity => Rarity.Common;
        public override string WeaponName => "Dart";
        public override string Icon => VanillaSprites.SharpShotsUpgradeIcon;
        public override void EditTower(Tower tower)
        {
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            var wpn = Game.instance.model.GetTowerFromId("DartMonkey").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Boomerang : WeaponTemplate
    {
        public override int SandboxIndex => 1;
        public override Rarity WeaponRarity => Rarity.Common;
        public override string WeaponName => "Boomerang";
        public override string Icon => VanillaSprites.ImprovedRangsUpgradeIcon;
        public override void EditTower(Tower tower)
        {
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            var wpn = Game.instance.model.GetTowerFromId("BoomerangMonkey").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Tack : WeaponTemplate
    {
        public override int SandboxIndex => 1;
        public override Rarity WeaponRarity => Rarity.Common;
        public override string Icon => VanillaSprites.FasterShootingUpgradeIcon;
        public override string WeaponName => "Tack";
        public override void EditTower(Tower tower)
        {
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            var wpn = Game.instance.model.GetTowerFromId("TackShooter").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Nail : WeaponTemplate
    {
        public override int SandboxIndex => 1;
        public override Rarity WeaponRarity => Rarity.Common;
        public override string Icon => VanillaSprites.LargerServiceAreaUpgradeIcon;
        public override string WeaponName => "Nail";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("EngineerMonkey").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Glue : WeaponTemplate
    {
        public override int SandboxIndex => 1;
        public override Rarity WeaponRarity => Rarity.Common;
        public override string Icon => VanillaSprites.GlueSoakUpgradeIcon;
        public override string WeaponName => "Glue";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("GlueGunner").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Bomb : WeaponTemplate
    {
        public override int SandboxIndex => 1;
        public override Rarity WeaponRarity => Rarity.Common;
        public override string Icon => VanillaSprites.BiggerBombsUpgradeIcon;
        public override string WeaponName => "Bomb";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("BombShooter").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Magic : WeaponTemplate
    {
        public override int SandboxIndex => 1;
        public override Rarity WeaponRarity => Rarity.Common;
        public override string Icon => VanillaSprites.IntenseMagicUpgradeIcon;
        public override string WeaponName => "Magic";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("WizardMonkey").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Quincy : WeaponTemplate
    {
        public override int SandboxIndex => 1;
        public override Rarity WeaponRarity => Rarity.Common;
        public override string Icon => VanillaSprites.QuincyIcon;
        public override string WeaponName => "Quincy";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("Quincy").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Shuriken : WeaponTemplate
    {
        public override int SandboxIndex => 1;
        public override Rarity WeaponRarity => Rarity.Common;
        public override string Icon => VanillaSprites.SharpShurikensUpgradeIcon;
        public override string WeaponName => "Shuriken";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("NinjaMonkey").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Obyn : WeaponTemplate
    {
        public override int SandboxIndex => 1;
        public override Rarity WeaponRarity => Rarity.Common;
        public override string Icon => VanillaSprites.ObynGreenFootIcon;
        public override string WeaponName => "Obyn";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("ObynGreenfoot").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Sauda : WeaponTemplate
    {
        public override int SandboxIndex => 1;
        public override Rarity WeaponRarity => Rarity.Common;
        public override string Icon => VanillaSprites.SaudaIcon;
        public override string WeaponName => "Sauda";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("Sauda").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Gwendolin : WeaponTemplate
    {
        public override int SandboxIndex => 1;
        public override Rarity WeaponRarity => Rarity.Common;
        public override string Icon => VanillaSprites.GwendolinIcon;
        public override string WeaponName => "Gwendolin";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("Gwendolin").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Ezili : WeaponTemplate
    {
        public override int SandboxIndex => 1;
        public override Rarity WeaponRarity => Rarity.Common;
        public override string Icon => VanillaSprites.EziliIcon;
        public override string WeaponName => "Ezili";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("Ezili").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Sniper : WeaponTemplate
    {
        public override int SandboxIndex => 1;
        public override Rarity WeaponRarity => Rarity.Common;
        public override string Icon => VanillaSprites.EvenFasterFiringUpgradeIcon;
        public override string WeaponName => "Sniper";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("SniperMonkey").GetAttackModel().Duplicate();
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Thorn : WeaponTemplate
    {
        public override int SandboxIndex => 1;
        public override Rarity WeaponRarity => Rarity.Common;
        public override string Icon => VanillaSprites.ThornSwarmUpgradeIcon;
        public override string WeaponName => "Thorn";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("Druid").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Common
    {
        public static List<string> CommonWpn = new List<string>();
        public static List<string> CommonImg = new List<string>();
    }
}

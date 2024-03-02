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

namespace AncientMonkey.Weapons
{
    public class LaserBlasts : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.LaserBlastUpgradeIcon;
        public override string WeaponName => "Laser Blasts";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("SuperMonkey-100").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class HotRang : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.RedHotRangsUpgradeIcon;
        public override string WeaponName => "Hot Rang";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("BoomerangMonkey-002").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Crossbow : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.CrossBowUpgradeIcon;
        public override string WeaponName => "Crossbow";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("DartMonkey-003").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Cluster : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.ClusterBombsUpgradeIcon;
        public override string WeaponName => "Cluster";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("BombShooter-003").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class WhiteHotSpikes : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.WhiteHotSpikesUpgradeIcon;
        public override string WeaponName => "White Hot Spikes";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("BananaFarm-200").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class GreaterProduction : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.GreaterProductionUpgradeIcon;
        public override string WeaponName => "Greater Production";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("BombShooter-003").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class HeartOfThunder : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.HeartofThunderUpgradeIcon;
        public override string WeaponName => "Heart Of Thunder";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("Druid-200").GetAttackModel().weapons.First(w => w.name == "WeaponModel_Lightning").Duplicate();
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.GetAttackModel().AddWeapon(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class DoubleShot : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.DoubleShotUpgradeIcon2;
        public override string WeaponName => "Double Shot";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("NinjaMonkey-300").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class WallOfFire : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.WallOfFireUpgradeIcon;
        public override string WeaponName => "Wall Of Fire";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("WizardMonkey-020").GetAttackModel(2).Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class AirburstDarts : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.AirburstDartsUpgradeIcon;
        public override string WeaponName => "Airburst Darts";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("MonkeySub-003").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class HotShot : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.HotShotUpgradeIcon;
        public override string WeaponName => "Hot Shot";
        public override void EditTower(Tower tower)
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
    }
    public class LargeCalibre : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.LongCalibreUpgradeIcon;
        public override string WeaponName => "Large Calibre";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("SniperMonkey-202").GetAttackModel().Duplicate();
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Churchill : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.CaptainChurchillIcon;
        public override string WeaponName => "Churchill";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("CaptainChurchill").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Adora : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.AdoraIcon;
        public override string WeaponName => "Adora";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("Adora").GetAttackModel().Duplicate();
            wpn.range = tower.towerModel.range;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Etienne : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.EtienneIcon;
        public override string WeaponName => "Etienne";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("Etienne").GetBehavior<DroneSupportModel>().Duplicate();
            wpn.count = 2;
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Psi : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.PsiIcon;
        public override string WeaponName => "Psi";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("Psi").GetAttackModel().Duplicate();
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class TripleShot : WeaponTemplate
    {
        public override int SandboxIndex => 2;
        public override Rarity WeaponRarity => Rarity.Rare;
        public override string Icon => VanillaSprites.TripleShotUpgradeIcon;
        public override string WeaponName => "Triple Shot";
        public override void EditTower(Tower tower)
        {
            var wpn = Game.instance.model.GetTowerFromId("DartMonkey-032").GetAttackModel().Duplicate();
            var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
            towerModel.AddBehavior(wpn);
            tower.UpdateRootModel(towerModel);
        }
    }
    public class Rare
    {
        public static List<string> RareWpn = new List<string>();
        public static List<string> RareImg = new List<string>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Enums;
using Il2CppAssets.Scripts.Data.Gameplay.Mods;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using UnityEngine;
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
using System.Threading;

namespace AncientMonkey.Weapons
{
    public class Exotic
    {
        public class LegendOfTheNight : WeaponTemplate
        {
            public override int SandboxIndex => 5;
            public override Rarity WeaponRarity => Rarity.Exotic;
            public override string Icon => VanillaSprites.LegendOfTheNightUpgradeIcon;
            public override string WeaponName => "Legend Of The Night";
            public override void EditTower(Tower tower)
            {
                var wpn = Game.instance.model.GetTowerFromId("SuperMonkey-205").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
        }
        public class SuperMines : WeaponTemplate
        {
            public override int SandboxIndex => 5;
            public override Rarity WeaponRarity => Rarity.Exotic;
            public override string Icon => VanillaSprites.SuperMinesUpgradeIcon;
            public override string WeaponName => "Super Mines";
            public override void EditTower(Tower tower)
            {
                var wpn = Game.instance.model.GetTowerFromId("SpikeFactory-520").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
        }
        public class BananaCentral : WeaponTemplate
        {
            public override int SandboxIndex => 5;
            public override Rarity WeaponRarity => Rarity.Exotic;
            public override string Icon => VanillaSprites.BananaCentralUpgradeIcon;
            public override string WeaponName => "Banana Central";
            public override void EditTower(Tower tower)
            {
                var wpn = Game.instance.model.GetTowerFromId("BananaFarm-520").GetAttackModel().Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
        }
        public class XXXLTrap : WeaponTemplate
        {
            public override int SandboxIndex => 5;
            public override Rarity WeaponRarity => Rarity.Exotic;
            public override string Icon => VanillaSprites.XXXLUpgradeIcon;
            public override string WeaponName => "XXXL Trap";
            public override void EditTower(Tower tower)
            {
                var wpn = Game.instance.model.GetTowerFromId("EngineerMonkey-015").GetAttackModel(1).Duplicate();
                wpn.range = tower.towerModel.range;
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
        }
        public class Archmage : WeaponTemplate
        {
            public override int SandboxIndex => 5;
            public override Rarity WeaponRarity => Rarity.Exotic;
            public override string Icon => VanillaSprites.ArchmageUpgradeIcon;
            public override string WeaponName => "Archmage";
            public override void EditTower(Tower tower)
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
        }
        public class MAD : WeaponTemplate
        {
            public override int SandboxIndex => 5;
            public override Rarity WeaponRarity => Rarity.Exotic;
            public override string Icon => VanillaSprites.MadUpgradeIcon;
            public override string WeaponName => "M.A.D";
            public override void EditTower(Tower tower)
            {
                var wpn = Game.instance.model.GetTowerFromId("DartlingGunner-250").GetAttackModel().Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
        }
        public class RayOfDoom : WeaponTemplate
        {
            public override int SandboxIndex => 5;
            public override Rarity WeaponRarity => Rarity.Exotic;
            public override string Icon => VanillaSprites.RayOfDoomUpgradeIcon;
            public override string WeaponName => "Ray Of Doom";
            public override void EditTower(Tower tower)
            {
                var wpn = Game.instance.model.GetTowerFromId("DartlingGunner-520").GetAttackModel().Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
        }
        public class AvatarOfWrath : WeaponTemplate
        {
            public override int SandboxIndex => 5;
            public override Rarity WeaponRarity => Rarity.Exotic;
            public override string Icon => VanillaSprites.AvatarofWrathUpgradeIcon;
            public override string WeaponName => "Avatar Of Wrath";
            public override void EditTower(Tower tower)
            {
                var wpn = Game.instance.model.GetTowerFromId("Druid-025").GetAttackModel().Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
        }
        public class InfernoRing : WeaponTemplate
        {
            public override int SandboxIndex => 5;
            public override Rarity WeaponRarity => Rarity.Exotic;
            public override string Icon => VanillaSprites.InfernoRingUpgradeIcon;
            public override string WeaponName => "Inferno Ring";
            public override void EditTower(Tower tower)
            {
                var wpn = Game.instance.model.GetTowerFromId("TackShooter-520").GetAttackModel().Duplicate();
                var wpn2 = Game.instance.model.GetTowerFromId("TackShooter-520").GetAttackModel(1).Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                towerModel.AddBehavior(wpn2);
                tower.UpdateRootModel(towerModel);
            }
        }
        public class BloonCrush : WeaponTemplate
        {
            public override int SandboxIndex => 5;
            public override Rarity WeaponRarity => Rarity.Exotic;
            public override string Icon => VanillaSprites.BloonCrushUpgradeIcon;
            public override string WeaponName => "Bloon Crush";
            public override void EditTower(Tower tower)
            {
                var wpn = Game.instance.model.GetTowerFromId("BombShooter-520").GetAttackModel().Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
        }
        public class MoabDomination : WeaponTemplate
        {
            public override int SandboxIndex => 5;
            public override Rarity WeaponRarity => Rarity.Exotic;
            public override string Icon => VanillaSprites.MoabDominationUpgradeIcon;
            public override string WeaponName => "Moab Domination";
            public override void EditTower(Tower tower)
            {
                var wpn = Game.instance.model.GetTowerFromId("BoomerangMonkey-025").GetAttackModel(1).Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
        }
        public class PermaBrew : WeaponTemplate
        {
            public override int SandboxIndex => 5;
            public override Rarity WeaponRarity => Rarity.Exotic;
            public override string Icon => VanillaSprites.PermanentBrewUpgradeIcon;
            public override string WeaponName => "Perma Brew";
            public override void EditTower(Tower tower)
            {
                var wpn = Game.instance.model.GetTowerFromId("Alchemist-520").GetAttackModel(2).Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.AddBehavior(wpn);
                tower.UpdateRootModel(towerModel);
            }
        }
        public class SuperStorm : WeaponTemplate
        {
            public override int SandboxIndex => 5;
            public override Rarity WeaponRarity => Rarity.Exotic;
            public override string Icon => VanillaSprites.SuperStormUpgradeIcon;
            public override string WeaponName => "Super Storm";
            public override void EditTower(Tower tower)
            {
                var tornado = Game.instance.model.GetTowerFromId("Druid-520").GetAttackModel().weapons.First(w => w.name.Contains("Superstorm")).Duplicate();
                var towerModel = tower.rootModel.Duplicate().Cast<TowerModel>();
                towerModel.GetAttackModel().AddWeapon(tornado);
                tower.UpdateRootModel(towerModel);
            }
        }
        public static List<string> ExoticWpn = new List<string>();
        public static List<string> ExoticImg = new List<string>();
    }
}

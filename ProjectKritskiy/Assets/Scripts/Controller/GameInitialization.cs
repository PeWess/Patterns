using UnityEngine;

namespace ProjectKritskiy
{
    internal sealed class GameInitialization
    {
        public GameInitialization(Controllers controllers, Data data)
        {
            Camera camera = Camera.main;
            
            data.Weapon.WeaponType = new StartWeapon(); //Временное решение
            
            var inputInitialization = new InputInitialization();
            var playerFactory = new PlayerFactory(data.Player);
            var weaponFactory = new WeaponFactory(data.Weapon);
            var pickUpFactory = new PickUpFactory(data.MedKit, data.PowerUp);
            var playerInitialization = new PlayerInitialization(playerFactory, data.Player.Position);
            var weaponInitialization = new WeaponInitialization(weaponFactory, data.Player.Position);
            var pickUpInitialization = new PickUpInitialization(pickUpFactory, data.MedKit.Position, data.PowerUp.Position);

            controllers.Add(inputInitialization);
            controllers.Add(playerInitialization);
            controllers.Add(weaponInitialization);
            controllers.Add(pickUpInitialization);

            controllers.Add(new InputController(inputInitialization.GetInput()));
            controllers.Add(new MouseController(inputInitialization.GetMouseInput()));
            
            controllers.Add(new MoveController(inputInitialization.GetInput(), playerInitialization.GetPlayer(), data.Player, data.Player.Rigidbody));
            controllers.Add(new WeaponController(data.Weapon.WeaponType, data.Weapon.Magazine, data.Weapon.MaxMagazine, data.Player.Ammo,
                data.Weapon.BulletPrefab, data.Player.Rigidbody));
            controllers.Add(new CameraController(inputInitialization.GetMouseInput(), camera.transform, data.Player.Rigidbody));
        }
    }
}
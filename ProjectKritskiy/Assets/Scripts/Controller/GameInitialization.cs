using UnityEngine;

namespace ProjectKritskiy
{
    internal sealed class GameInitialization
    {
        public GameInitialization(Controllers controllers, Data data)
        {
            Camera camera = Camera.main;
            var inputInitialization = new InputInitialization();
            var playerFactory = new PlayerFactory(data.Player);
            var weaponFactory = new WeaponFactory(data.Weapon);
            var medKitFactory = new MedKitFactory(data.MedKit);
            var playerInitialization = new PlayerInitialization(playerFactory, data.Player.Position);
            var weaponInitialization = new WeaponInitialization(weaponFactory, data.Player.Position);
            var medKitInitialization = new MedKitInitialization(medKitFactory, data.MedKit.Position);

            controllers.Add(inputInitialization);
            controllers.Add(playerInitialization);
            controllers.Add(weaponInitialization);
            controllers.Add(medKitInitialization);

            controllers.Add(new InputController(inputInitialization.GetInput()));
            controllers.Add(new MouseController(inputInitialization.GetMouseInput()));
            
            controllers.Add(new MoveController(inputInitialization.GetInput(), playerInitialization.GetPlayer(), data.Player, data.Player.Rigidbody));
            controllers.Add(new WeaponController(data.Weapon.Magazine, data.Weapon.MaxMagazine, data.Player.Ammo,
                data.Weapon.BulletPrefab, data.Player.Rigidbody));
            controllers.Add(new CameraController(inputInitialization.GetMouseInput(), camera.transform, data.Player.Rigidbody));
        }
    }
}
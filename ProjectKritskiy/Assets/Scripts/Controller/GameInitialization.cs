using UnityEngine;

namespace ProjectKritskiy
{
    internal sealed class GameInitialization
    {
        public GameInitialization(Controllers controllers, Data data)
        {
            Camera camera = Camera.main;
            var inputInitialization = new InputInitialization();
            var mouseInitialization = new MouseInitialization();
            var playerFactory = new PlayerFactory(data.Player);
            var weaponFactory = new WeaponFactory(data.Weapon);
            var playerInitialization = new PlayerInitialization(playerFactory, data.Player.Position);
            var weaponInitialization = new WeaponInitialization(weaponFactory, data.Player.Position);

            controllers.Add(inputInitialization);
            controllers.Add(mouseInitialization);
            controllers.Add(playerInitialization);
            controllers.Add(weaponInitialization);

            controllers.Add(new InputController(inputInitialization.GetInput()));
            controllers.Add(new MouseController(mouseInitialization.GetInput()));
            
            controllers.Add(new MoveController(inputInitialization.GetInput(), playerInitialization.GetPlayer(), data.Player));
            controllers.Add(new WeaponController(data.Weapon.Magazine, data.Weapon.MaxMagazine, data.Player.Ammo,
                data.Weapon.BulletPrefab));
            controllers.Add(new CameraController(mouseInitialization.GetInput(), camera.transform));
        }
    }
}
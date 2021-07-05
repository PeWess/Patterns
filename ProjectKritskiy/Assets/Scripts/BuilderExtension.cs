using Unity.VisualScripting;
using UnityEditor.SceneTemplate;
using UnityEngine;

namespace ProjectKritskiy
{
   public static partial class BuilderExtension
   {
      public static GameObject SetName(this GameObject gameObject, string name)
      {
         gameObject.name = name;
         return gameObject;
      }
      
      public static GameObject AddRigidBody(this GameObject gameObject, float mass)
      {
         var component = gameObject.AddComponent<Rigidbody>();
         component.mass = mass;
         return gameObject;
      }

      public static GameObject AddCapsuleCollider(this GameObject gameObject)
      {
         gameObject.GetOrAddComponent<CapsuleCollider>();
         return gameObject;
      }
      
      public static GameObject AddBoxTrigger(this GameObject gameObject)
      {
         gameObject.GetOrAddComponent<BoxCollider>().isTrigger = true;
         return gameObject;
      }

      private static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
      {
         var result = gameObject.GetComponent<T>();
         if (!result) result = gameObject.AddComponent<T>();

         return result;
      }
   }
}
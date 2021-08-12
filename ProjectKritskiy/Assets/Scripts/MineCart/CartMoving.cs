using UnityEngine;

namespace ProjectKritskiy
{
    public class CartMoving : State
    {
        private AudioClip _cartMoving;
        private AudioSource _audio;
        
        public override void Handle(Context context)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                _audio.PlayOneShot(_cartMoving);
            }

            context.State = new CartStanding();
        }
    }
}
namespace ProjectKritskiy
{
    public class CartStanding : State
    {
        public override void Handle(Context context)
        {
            context.State = new CartMoving();
        }
    }
}
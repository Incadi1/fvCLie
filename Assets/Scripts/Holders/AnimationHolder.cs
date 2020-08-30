
public class AnimationHolder
{
    public readonly float velocityX;
    public readonly float velocityZ;
    public readonly bool isGrounded;

    public AnimationHolder(float velocityX, float velocityZ,   bool isGrounded)
    {
        this.velocityX = velocityX;
        this.velocityZ = velocityZ;
        this.isGrounded = isGrounded;
    }
}

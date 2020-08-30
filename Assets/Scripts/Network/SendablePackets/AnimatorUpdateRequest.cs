
public class AnimatorUpdateRequest : SendablePacket
{
    public AnimatorUpdateRequest(float velocityX, float velocityZ, bool isGrounded)
    {
        WriteShort(10); // Packet id.
        WriteFloat(velocityX);
        WriteFloat(velocityZ);
        WriteByte(isGrounded ? 1 : 0);
    }
}

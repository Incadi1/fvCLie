
public class LocationUpdateRequest : SendablePacket
{
    public LocationUpdateRequest(float posX, float posY, float posZ, float heading)
    {
        WriteShort(9); // Packet id.
        WriteFloat(posX);
        WriteFloat(posY);
        WriteFloat(posZ);
        WriteFloat(heading);
    }
}

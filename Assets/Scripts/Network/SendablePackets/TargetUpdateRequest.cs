
public class TargetUpdateRequest : SendablePacket
{
    public TargetUpdateRequest(long objectId)
    {
        WriteShort(14); // Packet id.
        WriteLong(objectId);
    }
}

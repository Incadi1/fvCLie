
public class ObjectInfoRequest : SendablePacket
{
    public ObjectInfoRequest(long objectId)
    {
        WriteShort(11); // Packet id.
        WriteLong(objectId);
    }
}

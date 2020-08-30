
public class DeleteObject
{
    public static void Notify(ReceivablePacket packet)
    {
        long objectId = packet.ReadLong();
        WorldManager.Instance.DeleteObject(objectId);
    }
}

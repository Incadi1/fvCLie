
public class ExitWorldRequest : SendablePacket
{
    public ExitWorldRequest()
    {
        WriteShort(8); // Packet id.
    }
}

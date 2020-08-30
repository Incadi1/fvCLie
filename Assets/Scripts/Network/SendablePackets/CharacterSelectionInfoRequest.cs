
public class CharacterSelectionInfoRequest : SendablePacket
{
    public CharacterSelectionInfoRequest()
    {
        WriteShort(2); // Packet id.
        WriteString(MainManager.Instance.accountName);
    }
}

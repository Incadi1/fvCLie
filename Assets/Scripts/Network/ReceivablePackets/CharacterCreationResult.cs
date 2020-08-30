
public class CharacterCreationResult
{
    public static void Notify(ReceivablePacket packet)
    {
        CharacterCreationManager.Instance.creationResult = packet.ReadByte();
    }
}

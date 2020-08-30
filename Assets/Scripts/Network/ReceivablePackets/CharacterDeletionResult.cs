
public class CharacterDeletionResult
{
    public static void Notify(ReceivablePacket packet)
    {
        CharacterSelectionManager.Instance.waitingServer = false;
    }
}

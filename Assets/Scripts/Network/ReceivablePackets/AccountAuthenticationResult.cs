
public class AccountAuthenticationResult
{
    public static void Notify(ReceivablePacket packet)
    {
        LoginManager.Instance.status = packet.ReadByte();
    }
}

﻿
public class Logout
{
    public static void Notify(ReceivablePacket packet)
    {
        // Used for kicked message.
        NetworkManager.forcedDisconnection = true;
        NetworkManager.DisconnectFromServer();
        // Force exiting to login screen.
        WorldManager.Instance.kickFromWorld = true;
    }
}

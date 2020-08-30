﻿using System.Collections.Generic;


public class LocationUpdate
{
    public static void Notify(ReceivablePacket packet)
    {
        long objectId = packet.ReadLong();
        float posX = packet.ReadFloat();
        float posY = packet.ReadFloat();
        float posZ = packet.ReadFloat();
        float heading = packet.ReadFloat();

        ((IDictionary<long, MovementHolder>)WorldManager.Instance.moveQueue).Remove(objectId);
        WorldManager.Instance.moveQueue.TryAdd(objectId, new MovementHolder(posX, posY, posZ, heading));
    }
}

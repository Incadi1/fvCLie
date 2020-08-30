using System.Collections.Generic;


public class AnimatorUpdate
{
    public static void Notify(ReceivablePacket packet)
    {
        // Read data.
        long objectId = packet.ReadLong();
        float velocityX = packet.ReadFloat();
        float velocityZ = packet.ReadFloat();
        bool isGrounded = packet.ReadByte() == 1;

        ((IDictionary<long, AnimationHolder>)WorldManager.Instance.animationQueue).Remove(objectId);
        WorldManager.Instance.animationQueue.TryAdd(objectId, new AnimationHolder(velocityX, velocityZ, isGrounded));
    }
}

using System.Collections.Generic;

public class CharacterSelectionInfoResult
{
    public static void Notify(ReceivablePacket packet)
    {
        // Get player list size.
        int listSize = packet.ReadByte();
        // Read the data.
        List<CharacterDataHolder> characterList = new List<CharacterDataHolder>(listSize);
        for (int i = 0; i < listSize; i++)
        {
            CharacterDataHolder characterData = new CharacterDataHolder();
            characterData.SetName(packet.ReadString());
            characterData.SetSlot((byte)packet.ReadByte());
            characterData.SetSelected(packet.ReadByte() == 1 ? true : false);
            characterData.SetRace((byte)packet.ReadByte());
            characterData.SetHairType(packet.ReadByte());
            characterData.SetHairColor(packet.ReadInt());
            characterData.SetSkinColor(packet.ReadInt());
            characterData.SetEyeColor(packet.ReadInt());
            characterData.SetHeadItem(packet.ReadInt());
            characterData.SetChestItem(packet.ReadInt());
            characterData.SetLegsItem(packet.ReadInt());
            characterData.SetHandsItem(packet.ReadInt());
            characterData.SetFeetItem(packet.ReadInt());
            characterData.SetLeftHandItem(packet.ReadInt());
            characterData.SetRightHandItem(packet.ReadInt());
            characterData.SetX(packet.ReadFloat());
            characterData.SetY(packet.ReadFloat());
            characterData.SetZ(packet.ReadFloat());
            characterData.SetHeading(packet.ReadFloat());
            characterList.Add(characterData);
        }

        // Send the data.
        MainManager.Instance.characterList = characterList;

        // Enable player selection.
        CharacterSelectionManager.Instance.waitingServer = false;
    }
}

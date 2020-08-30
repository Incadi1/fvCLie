
public class CharacterCreationRequest : SendablePacket
{
    public CharacterCreationRequest(CharacterDataHolder dataHolder)
    {
        WriteShort(3); // Packet id.
        WriteString(dataHolder.GetName());
        WriteByte(dataHolder.GetRace());
        WriteByte(dataHolder.GetHairType());
        WriteInt(dataHolder.GetHairColor());
        WriteInt(dataHolder.GetSkinColor());
        WriteInt(dataHolder.GetEyeColor());
    }
}

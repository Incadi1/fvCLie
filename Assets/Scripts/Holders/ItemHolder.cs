
public class ItemHolder
{
    private readonly ItemTemplateHolder itemTemplate;
    private int slot = 0;
    private int quantity = 1;

    public ItemHolder(ItemTemplateHolder itemTemplate)
    {
        this.itemTemplate = itemTemplate;
    }

    public ItemTemplateHolder GetTemplate()
    {
        return itemTemplate;
    }

    public void SetSlot(int slot)
    {
        this.slot = slot;
    }

    public int GetSlot()
    {
        return slot;
    }

    public void SetQuantity(int quantity)
    {
        this.quantity = quantity;
    }

    public int GetQuantity()
    {
        return quantity;
    }

}

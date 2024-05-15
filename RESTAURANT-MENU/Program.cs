
using System.Runtime.CompilerServices;

public class MenuItem
{
    private string name;
    private float price;
    private string description;
    private string category;
    private bool isNew;

    public string Name
    {
        get { return name; }
        set { name = value;}
    }

    public float Price
    {
        get { return price; }
        set { price = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string Category
    {
        get { return category; }
        set { description = value; }
    }

    public bool IsNew
    {
        get { return isNew; }
        set { isNew = value; }
    }


    public MenuItem(string name, float price, string description, string category, bool isNew)
    {
        this.name = name;
        this.price = price;
        this.description = description;
        this.category = category;
        this.isNew = isNew;
    }


}

public class Menu
{

    private List<MenuItem> items;
    
    
    private static void AddItem(MenuItem)
    {
        Menu.item.Add(MenuItem);
    }
    
    // create properties for date/time when items are added.

}
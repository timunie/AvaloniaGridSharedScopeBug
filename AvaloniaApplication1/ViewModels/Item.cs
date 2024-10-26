namespace AvaloniaApplication1.ViewModels;

public class Item
{
	public Item()
	{

	}

	public Item(string name,int count)
	{
		Name = name;
		Count = count;
	}

	public string Name { get; set; }
	public int Count { get; set; }
}

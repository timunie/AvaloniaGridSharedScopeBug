using System.Collections.Generic;
using System.Text;

namespace AvaloniaApplication1.ViewModels;

public class MainViewModel
    : ViewModelBase
{
    public MainViewModel()
    {
        Items = new();
        StringBuilder a = new();
        for (int i = 0; i < 20; i++)
        {
            a.Append(i);
            Items.Add(new("Item " + a.ToString(), i));
        }
       
        Items.Add(new("Item qwertyqwertyqwert", 1));
	}

    public List<Item> Items { get; set; }
}

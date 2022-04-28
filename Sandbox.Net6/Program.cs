Repository repo = new();
repo.Add(new Item { Id = 1, Name = "Item 1" });
repo.Add(new Item { Id = 2, Name = "Item 2" });
repo.Add(new Item { Id = 3, Name = "Item 3" });

var items = repo.GetAll(x => x.Id >= 2);
items.ForEach(x => Console.WriteLine(x.Name));

public class Item
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class Repository
{
    private List<Item> _items = new();

    public void Add(Item item)
    {
        _items.Add(item);
    }

    public List<Item> GetAll(Func<Item, bool> filter)
    {
        return _items.Where(filter).ToList();
    }
}

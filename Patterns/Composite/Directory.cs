namespace Composite;

// 3. Композит (Папка)
public class Directory : FileSystemComponent
{
    private List<FileSystemComponent> _components = new();

    public Directory(string name) : base(name) { }

    public void Add(FileSystemComponent component)
    {
        _components.Add(component);
    }

    public override int GetSize()
    {
        // TODO: Пройтись по _components і підсумувати їх розмір
        int size = 0;

        foreach (var c in _components)
            size += c.GetSize();

        return size;
    }
}

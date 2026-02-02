namespace Composite;

public abstract class FileSystemComponent
{
    public string Name { get; protected set; }
    public FileSystemComponent(string name) => Name = name;

    public abstract int GetSize(); // Розмір у МБ
}

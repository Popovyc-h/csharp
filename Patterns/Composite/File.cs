namespace Composite;

// 2. Листок (Файл)
public class File : FileSystemComponent
{
    private int _size;

    public File(string name, int size) : base(name)
    {
        _size = size;
    }

    public override int GetSize()
    {
        return _size;
    }
}

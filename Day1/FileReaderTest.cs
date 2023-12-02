using DisposableFileSystem;

namespace Day1;

public class FileReaderTest : IDisposable
{
    private DisposableDirectory _dir;
    public FileReaderTest()
    {
        _dir = DisposableFileSystem.DisposableDirectory.Create();
    }

    [Fact]
    public void reads_file()
    {
        var path = Path.Combine(_dir.Path, "test.json");
        var content = "hello";
        File.WriteAllText(path, content);

        Assert.Equal(content, File.ReadAllText(path));
    }
    public void Dispose()
    {
        _dir.Dispose();
    }
}
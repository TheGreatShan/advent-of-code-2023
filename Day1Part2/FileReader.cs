namespace Day1;

public static class FileReader
{
    public static string[] ReadFiles(string path) =>
        File.ReadAllLines(path);
}

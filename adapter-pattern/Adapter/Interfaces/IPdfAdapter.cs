namespace adapter_pattern.Adapter.Interfaces
{
    public interface IPdfAdapter
    {
        void Generate(string path, string content);
    }
}

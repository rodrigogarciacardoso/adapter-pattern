using adapter_pattern.Adapter.Interfaces;

namespace adapter_pattern.Service
{
    public class SalesReportGenerator(IPdfAdapter pdfAdapter)
    {
        private readonly IPdfAdapter _pdfAdapter = pdfAdapter;

        public void Generate()
        {
            var filename = $"{DateTime.Now.Ticks}.pdf";
            var content = "content of report";

            string pathExecution = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(pathExecution, filename);

            _pdfAdapter.Generate(path, content);
        }
    }
}

using adapter_pattern.Adapter.Interfaces;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace adapter_pattern.Adapter
{
    public class ITextAdapter : IPdfAdapter
    {
        public void Generate(string path, string content)
        {
            var pdfDocument = new PdfDocument(new PdfWriter(new FileStream(path, FileMode.Create, FileAccess.Write)));
            var document = new Document(pdfDocument);

            document.Add(new Paragraph(content));
            document.Close();
        }
    }
}

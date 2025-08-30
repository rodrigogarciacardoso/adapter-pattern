using adapter_pattern.Adapter;
using adapter_pattern.Service;

var pdfAdapter = new ITextAdapter();
var salesReportGenerator = new SalesReportGenerator(pdfAdapter);
salesReportGenerator.Generate();

Console.WriteLine("Awesome PDF just got created.");


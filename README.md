# Adapter Pattern

This project is a demonstration of the *Adapter Design Pattern*.  
The goal is to show how we can integrate classes with incompatible interfaces by introducing an adapter that "translates" one interface into another expected by the client.

To exemplify this, a small console application was developed that generates a sales report in PDF format. The system depends on a generic interface (`IPdfAdapter`), while the concrete PDF library is integrated through an adapter.

---

## What is the Adapter Pattern?

The Adapter is one of the original 23 "Gang of Four" (GoF) design patterns, classified as a **structural pattern**.  

It allows two incompatible interfaces to work together by creating a middle layer (the adapter).  
Instead of modifying the legacy or third-party class, the adapter implements the expected interface and delegates the calls to the adaptee.

### Key Advantages

* **Decoupling:** The client depends only on an interface, not on a specific third-party library.  
* **Reusability:** Existing or legacy code can be reused without modification.  
* **Flexibility:** It is easy to swap one library for another by writing a new adapter.  

---

## Practical Example: PDF Report Generator

In this project, the **SalesReportGenerator** service needs to generate reports as PDFs.  
However, the PDF library being used exposes a different method signature than what the system expects.

To solve this, we define an interface (`IPdfAdapter`) and create an adapter (`ITextAdapter`) that implements this interface. The adapter internally calls the external PDF library, making it compatible with our system.

---

## Project Structure

* **Service:**  
  * `SalesReportGenerator` – Client code that depends on `IPdfAdapter` to generate PDF reports.  

* **Adapter:**  
  * `IPdfAdapter` (Interface) – Defines the contract that all PDF adapters must follow.  
  * `ITextAdapter` (Concrete Adapter) – Implements `IPdfAdapter` and delegates calls to the third-party PDF library.  

* **Program (Client):**  
  Entry point that wires everything together and generates the report.  

---

## How It Works

```csharp
// Program.cs
var pdfAdapter = new ITextAdapter();
var salesReportGenerator = new SalesReportGenerator(pdfAdapter);
salesReportGenerator.Generate();

Console.WriteLine("Awesome PDF just got created.");

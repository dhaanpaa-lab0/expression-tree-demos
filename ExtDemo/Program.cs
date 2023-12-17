// See https://aka.ms/new-console-template for more information

using ExtDemo;

Console.WriteLine("Hello, World!");

var model = new ExampleModel()
{
    Field1 = "1",
    Field2 = "12345",
    Field3 = "MEOA"
};

var t= new SearchService().Search(
    model,  
    exampleModel => exampleModel.Field1, 
    exampleModel => exampleModel.Field4, 
    exampleModel => exampleModel.Field7  );
Console.WriteLine(t);
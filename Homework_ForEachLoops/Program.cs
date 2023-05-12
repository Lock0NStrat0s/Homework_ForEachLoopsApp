
// Ask user for their first name.
// Continue asking for first names until exit
// Loop through each name using foreach saying hello

//ask user for first name
string? response;
List<string> names = new();
do
{
    Console.Write("What is your first name (e to exit): ");
    response = Console.ReadLine();
    if (response != "e")
    {
        names.Add(response);
    }
} while (response != "e");

//loop through each name in list
foreach (string name in names)
{
    Console.WriteLine($"Hello {name}.");
}
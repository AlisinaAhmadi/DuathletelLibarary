namespace restDuathlon.Mangers
{
    public class DuathlonsManager
    {
        private static int _nextId = 1;
        private static readonly List<Duathletel> Data = new List<Duathletel>
        {
            new Duathletel {Id = _nextId++,  = "C# is nice", Price = 12.34},
            new Book {Id=_nextId++, Title = "Python is even nicer", Price = 22.33}
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        };

    }
}

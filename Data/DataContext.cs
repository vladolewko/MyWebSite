using System.Data.Entity;


namespace Data;

public class DataContext:DbContext
{
    public DataContext() : base("MyAppDb")
    {
        
    }
}
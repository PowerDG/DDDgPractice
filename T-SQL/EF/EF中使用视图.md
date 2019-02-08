





```csharp

0
down vote
I'm actually working with Entity Framework "Code First" and views, the way I do it is like this:

1) Create a class

[Table("view_name_on_database")]
public class ViewClassName {
    // View columns mapping
    public int Id {get; set;}
    public string Name {get; set;}
    // And a few more...
}
---
2) Add the class to the context

public class ContextName : DbContext {
    // Tables
    public DbSet<SomeTableClassHere> ATable { get; set; }
    // And other tables...

    // Views
    public DbSet<ViewClassName> ViewContextName { get; set; }

    // This lines help me during "update-database" command
    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        // Remove comments before "update-database" command and 
        // comment this line again after "update-database", otherwise 
        // you will not be able to query the view from the context.
        // Ignore the creation of a table named "view_name_on_database"
        
        //modelBuilder.Ignore<ViewClassName>();
        //不要加  modelBuilder.Ignore<ViewClassName>(); 这句。 
    }
}

```


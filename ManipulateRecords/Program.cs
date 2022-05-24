using ManipulateRecords.Db;
using System.Linq;

// See https://aka.ms/new-console-template for more information

using (var context = new ContactsContext())
{

    var ct = new Contact()
    {
        ContactName = "Sean",
        ContactEmail = "you@me.com",
        ContactPhoneType = "Mobile",
        ContactPhoneNumber = "123-456-7890",
        ContactAge = 32,
        ContactNotes = "Learning C#"
    };

    Console.WriteLine("New contact will be added. Press enter to continue...");
    Console.ReadLine();
    context.Contacts.Add(ct);
    context.SaveChanges();

    Console.WriteLine("New contact will be listed. Press enter to continue...");
    Console.ReadLine();
    foreach (var v in context.Contacts)
    {
        Console.WriteLine(v.ContactName);
        Console.WriteLine(v.ContactEmail);
        Console.WriteLine(v.ContactPhoneType);
        Console.WriteLine(v.ContactPhoneNumber);
        Console.WriteLine(v.ContactAge);
        Console.WriteLine(v.ContactNotes);
    }
    
    Console.WriteLine("Contact will be removed. Press enter to continue...");
    Console.ReadLine();
    var con = context.Contacts.Where(c => c.ContactName == "Sean");
    context.Contacts.RemoveRange();
    context.SaveChanges();
}


using ManipulateRecords.Db;

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

    context.Contacts.Add(ct);
    context.SaveChanges();
}


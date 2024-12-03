using MyContacts.Model;

namespace MyContacts.Views;



[QueryProperty(nameof(id), "id")]
public partial class EditContactPage : ContentPage
{
    ContactsRepository repository = new ContactsRepository();

    public string id { get; set; }
	public EditContactPage()
	{
        
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        
        var contact = repository.GetContact(Int32.Parse(id));
        selectedContact.Text = id + " " + contact.NameSurname;
    }
}
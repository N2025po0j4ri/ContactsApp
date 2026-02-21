namespace ContactsApp;

public partial class ContactDetailPage : ContentPage
{
	public ContactDetailPage(Contact item)
	{
		InitializeComponent();
        ContactImage.Source = item.ImageName;
        LblContactName.Text = item.Name;
        LblContactEmail.Text = item.Email;
        LblContactPhoneNumber.Text = item.PhoneNumber;
        LblContactDesc.Text = item.Description;
    }
}
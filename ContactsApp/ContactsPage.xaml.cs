namespace ContactsApp;

public partial class ContactsPage : ContentPage
{
    public List<ContactGroup> Contacts = new List<ContactGroup>();
   // {
       // new Contact(){ Name="Alisa More",Email="alice@uc.org",ImageName="pic2.png",PhoneNumber="513-807-1234",Description="Tennis Player"},
       // new Contact(){ Name="Adi Vu",Email="vu@uc.org",ImageName="pic1.png",PhoneNumber="513-807-1235",Description="Hocky Player"}
   // };

    public ContactsPage()
	{
		InitializeComponent();
        Contacts.Add(new ContactGroup("Group A", new List<Contact>
        {
            new Contact(){ Name="Adi Vu",Email="vu@uc.org",ImageName="pic1.png",PhoneNumber="513-807-2235",Description="Hocky Player"},
            new Contact(){ Name="Aaron Blake",Email="blake@uc.org",ImageName="pic1.png",PhoneNumber="513-807-2235",Description="Football Player"},
            new Contact(){ Name="Alisa More",Email="alice@uc.org",ImageName="pic2.png",PhoneNumber="513-807-1234",Description="Tennis Player"},
            new Contact(){ Name="Andrew Patel",Email="patel@uc.org",ImageName="pic3.png",PhoneNumber="513-807-2235",Description="Baseball Player"},
            new Contact(){ Name="Ava Thompson",Email="thompson@uc.org",ImageName="pic4.png",PhoneNumber="513-807-2235",Description="Cricket Player"}         
        }));
        Contacts.Add(new ContactGroup("Group B", new List<Contact>
        {
            new Contact(){ Name="Barbie Mattel",Email="barb@uc.org",ImageName="pic2.png",PhoneNumber="555‑310‑8822",Description="Wrestler"},
            new Contact(){ Name="Brandon Hughes",Email="hughes@uc.org",ImageName="pic1.png",PhoneNumber="513-807-4235",Description="Boxer"},
            new Contact(){ Name="Bella Singh",Email="singh@uc.org",ImageName="pic4.png",PhoneNumber="513-807-4235",Description="Hockey Player"},
            new Contact(){ Name="Brooke Carter",Email="carter@uc.org",ImageName="pic3.png",PhoneNumber="513-807-4235",Description="Tennis Player"},
            new Contact(){ Name="Benjamin Ortiz",Email="ortiz@uc.org",ImageName="pic1.png",PhoneNumber="513-807-4235",Description="Basketball Player"}
        }));
        Contacts.Add(new ContactGroup("Group C", new List<Contact>
        {
            new Contact(){ Name="Caleb Foster",Email="foster@uc.org",ImageName="pic1.png",PhoneNumber="513-807-3234",Description="Baseball Player"},
            new Contact(){ Name="Chloe Ramirez",Email="ramirez@uc.org",ImageName="pic2.png",PhoneNumber="513-807-4235",Description="Soccer Player"},
            new Contact(){ Name="Clara Nguyen",Email="nguyen@uc.org",ImageName="pic4.png",PhoneNumber="513-807-4235",Description="Pickelball Player"},
            new Contact(){ Name="Cameron Wells",Email="wells@uc.org",ImageName="pic1.png",PhoneNumber="513-807-4235",Description="Table Tennis Player"},
            new Contact(){ Name="Cynthia Harper",Email="harper@uc.org",ImageName="pic4.png",PhoneNumber="513-807-4235",Description="Softball Player"}
        }));
        Contacts.Add(new ContactGroup("Group D", new List<Contact>
        {
            new Contact(){ Name="Daniel Brooks",Email="brooks@uc.org",ImageName="pic1.png",PhoneNumber="213-307-7421",Description="Picklebball Player"},
            new Contact(){ Name="Diana Keller",Email="keller@uc.org",ImageName="pic2.png",PhoneNumber="513-807-4235",Description="Golf Player"},
            new Contact(){ Name=" Dylan Price",Email="price@uc.org",ImageName="pic3.png",PhoneNumber="513-807-4235",Description="Tennis Player"},
            new Contact(){ Name="Dominic Shaw",Email="shaw@uc.org",ImageName="pic3.png",PhoneNumber="513-807-4235",Description="Baseball Player"},
            new Contact(){ Name="Daisy Turner",Email="turner@uc.org",ImageName="pic1.png",PhoneNumber="513-807-4235",Description="Basketball Player"}
        }));
        Contacts.Add(new ContactGroup("Group E", new List<Contact>
        {
            new Contact(){ Name="Ethan Wallace",Email="wallace@uc.org",ImageName="pic1.png",PhoneNumber="513-807-3234",Description="Baseball Player"},
            new Contact(){ Name="Emma Rodriguez",Email="rodriguez@uc.org",ImageName="pic2.png",PhoneNumber="513-807-4235",Description="Soccer Player"},
            new Contact(){ Name="Elena Scott",Email="scott@uc.org",ImageName="pic4.png",PhoneNumber="513-807-4235",Description="Cricket Player"},
            new Contact(){ Name="Eric Lawson",Email="lawson@uc.org",ImageName="pic3.png",PhoneNumber="513-807-4235",Description="Wrestler"},
            new Contact(){ Name="Eva Mitchel",Email="mitchel@uc.org",ImageName="pic4.png",PhoneNumber="513-807-4235",Description="Volleyball Player"}
        }));
        LvContacts.ItemsSource = Contacts;
    }
    private void LvContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Contact;
        if (selectedItem == null) return;
        Navigation.PushAsync(new ContactDetailPage(selectedItem));
        ((CollectionView)sender).SelectedItem = null;
    }

    /*  private void LvContactsItemSelecteded(object sender, SelectedItemChangedEventArgs e)
      {
          var selectedItem = e.SelectedItem as Contact;
         if (selectedItem == null) return;
         Navigation.PushAsync(new ContactDetailPage(selectedItem));
          ((ListView)sender).SelectedItem = null; 
      } */
}
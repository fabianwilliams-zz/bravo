using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
using System.Threading.Tasks;

namespace bravosoc
{
	partial class AddSocialContact : UIViewController
	{
		private QSTodoService todoService;

		public AddSocialContact (IntPtr handle) : base (handle)
		{
		}

		public override async void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			todoService = QSTodoService.DefaultService;
			await todoService.InitializeStoreAsync ();

			await RefreshAsync ();

		}

		private async Task RefreshAsync ()
		{
			await todoService.RefreshDataAsync ();
		}

		async partial void Clicked (UIButton sender)
		{
			if (string.IsNullOrWhiteSpace (txtName.Text))
				return;
			if (string.IsNullOrWhiteSpace (txtEmail.Text))
				return;
			if (string.IsNullOrWhiteSpace (txtMobile.Text))
				return;

			var newItem = new ToDoItem {
				Text = txtName.Text, 
				FaceBookName = txtFB.Text, //this and all the below dummydata will be replaced
				TwitterHandle = txtTwitter.Text,//with legitmate controls later on
				InstagramName = txtInstagram.Text,
				MobilePhone = txtMobile.Text,
				EmailAddress = txtEmail.Text,
				Remove = false,
				Complete = false
			};

			await todoService.InsertTodoItemAsync (newItem);

			var index = todoService.Items.FindIndex (item => item.Id == newItem.Id);

			//update Message Label of Success
			lblMessgeAdd.Text = "Contact: " + txtName + " added!";

			txtName.Text = "";
			txtFB.Text = "";
			txtTwitter.Text = "";
			txtInstagram.Text = "";
			txtMobile.Text = "";
			txtEmail.Text = "";
			//will need to add more controls here and set them to no text when done -- fabian williams


		}

	}
}


// This file has been generated by the GUI designer. Do not modify.
namespace MultiMC
{
	public partial class EditNotesDialog
	{
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView notesTextView;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MultiMC.EditNotesDialog
			this.WidthRequest = 500;
			this.HeightRequest = 300;
			this.Name = "MultiMC.EditNotesDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Notes");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Gravity = ((global::Gdk.Gravity)(5));
			// Internal child MultiMC.EditNotesDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "notes_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child notes_VBox.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.notesTextView = new global::Gtk.TextView ();
			this.notesTextView.CanFocus = true;
			this.notesTextView.Name = "notesTextView";
			this.notesTextView.WrapMode = ((global::Gtk.WrapMode)(3));
			this.GtkScrolledWindow.Add (this.notesTextView);
			w1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(w1 [this.GtkScrolledWindow]));
			w3.Position = 0;
			// Internal child MultiMC.EditNotesDialog.ActionArea
			global::Gtk.HButtonBox w4 = this.ActionArea;
			w4.Name = "dialog1_ActionArea";
			w4.Spacing = 10;
			w4.BorderWidth = ((uint)(5));
			w4.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w5 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w4 [this.buttonCancel]));
			w5.Expand = false;
			w5.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w6 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w4 [this.buttonOk]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 500;
			this.DefaultHeight = 300;
			this.Show ();
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelActivated);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkActivated);
		}
	}
}

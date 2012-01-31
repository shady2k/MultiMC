
// This file has been generated by the GUI designer. Do not modify.
namespace MultiMC
{
	public partial class SettingsDialog
	{
		private global::Gtk.Notebook notebook;
		private global::Gtk.VBox vboxGeneral;
		private global::Gtk.Frame frameLauncherSettings;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.VBox vboxLauncher;
		private global::Gtk.HBox hboxLauncherDL;
		private global::Gtk.Button buttonLauncherDL;
		private global::Gtk.ProgressBar dlProgressbar;
		private global::Gtk.HBox hboxLauncherFile;
		private global::Gtk.Label labelLauncherFilename;
		private global::Gtk.Entry entryLauncherFilename;
		private global::Gtk.Label labelLauncherSettings;
		private global::Gtk.Frame frameConsoleSettings;
		private global::Gtk.Alignment GtkAlignment3;
		private global::Gtk.VBox vboxConsole;
		private global::Gtk.CheckButton checkbuttonShowConsole;
		private global::Gtk.CheckButton checkbuttonAutoCloseConsole;
		private global::Gtk.Label labelConsoleSettings;
		private global::Gtk.Frame frameUpdateSettings;
		private global::Gtk.Alignment GtkAlignment4;
		private global::Gtk.VBox vboxUpdates;
		private global::Gtk.CheckButton checkbuttonAutoUpdate;
		private global::Gtk.Label GtkLabel4;
		private global::Gtk.Label labelGeneral;
		private global::Gtk.VBox vboxAdvanced;
		private global::Gtk.Frame frameMemory;
		private global::Gtk.Alignment GtkAlignment5;
		private global::Gtk.Table tableMemory;
		private global::Gtk.Label labelInitialMemory;
		private global::Gtk.Label labelMaxMemory;
		private global::Gtk.SpinButton spinbuttonInitialMemory;
		private global::Gtk.SpinButton spinbuttonMaxMemory;
		private global::Gtk.Label labelMemorySettings;
		private global::Gtk.Frame frameJava;
		private global::Gtk.Alignment GtkAlignment6;
		private global::Gtk.VBox vboxJava;
		private global::Gtk.HBox hboxJavaPath;
		private global::Gtk.Label labelJavaPath;
		private global::Gtk.Entry entryJavaPath;
		private global::Gtk.Label labelJava;
		private global::Gtk.Label labelAdvanced;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MultiMC.SettingsDialog
			this.Name = "MultiMC.SettingsDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Settings");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-preferences", global::Gtk.IconSize.Menu);
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.AllowShrink = true;
			this.DefaultWidth = 450;
			this.DefaultHeight = 500;
			// Internal child MultiMC.SettingsDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialogVBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialogVBox.Gtk.Box+BoxChild
			this.notebook = new global::Gtk.Notebook ();
			this.notebook.CanFocus = true;
			this.notebook.Name = "notebook";
			this.notebook.CurrentPage = 0;
			this.notebook.TabPos = ((global::Gtk.PositionType)(0));
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.vboxGeneral = new global::Gtk.VBox ();
			this.vboxGeneral.Name = "vboxGeneral";
			this.vboxGeneral.Spacing = 6;
			// Container child vboxGeneral.Gtk.Box+BoxChild
			this.frameLauncherSettings = new global::Gtk.Frame ();
			this.frameLauncherSettings.Name = "frameLauncherSettings";
			this.frameLauncherSettings.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frameLauncherSettings.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			this.GtkAlignment2.RightPadding = ((uint)(6));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.vboxLauncher = new global::Gtk.VBox ();
			this.vboxLauncher.Name = "vboxLauncher";
			this.vboxLauncher.Spacing = 6;
			// Container child vboxLauncher.Gtk.Box+BoxChild
			this.hboxLauncherDL = new global::Gtk.HBox ();
			this.hboxLauncherDL.Name = "hboxLauncherDL";
			this.hboxLauncherDL.Spacing = 6;
			// Container child hboxLauncherDL.Gtk.Box+BoxChild
			this.buttonLauncherDL = new global::Gtk.Button ();
			this.buttonLauncherDL.CanFocus = true;
			this.buttonLauncherDL.Name = "buttonLauncherDL";
			this.buttonLauncherDL.UseUnderline = true;
			this.buttonLauncherDL.Label = global::Mono.Unix.Catalog.GetString ("Download Launcher");
			this.hboxLauncherDL.Add (this.buttonLauncherDL);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hboxLauncherDL [this.buttonLauncherDL]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hboxLauncherDL.Gtk.Box+BoxChild
			this.dlProgressbar = new global::Gtk.ProgressBar ();
			this.dlProgressbar.Name = "dlProgressbar";
			this.hboxLauncherDL.Add (this.dlProgressbar);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hboxLauncherDL [this.dlProgressbar]));
			w3.Position = 1;
			this.vboxLauncher.Add (this.hboxLauncherDL);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vboxLauncher [this.hboxLauncherDL]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vboxLauncher.Gtk.Box+BoxChild
			this.hboxLauncherFile = new global::Gtk.HBox ();
			this.hboxLauncherFile.Name = "hboxLauncherFile";
			this.hboxLauncherFile.Spacing = 6;
			// Container child hboxLauncherFile.Gtk.Box+BoxChild
			this.labelLauncherFilename = new global::Gtk.Label ();
			this.labelLauncherFilename.Name = "labelLauncherFilename";
			this.labelLauncherFilename.LabelProp = global::Mono.Unix.Catalog.GetString ("Launcher Filename");
			this.hboxLauncherFile.Add (this.labelLauncherFilename);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hboxLauncherFile [this.labelLauncherFilename]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hboxLauncherFile.Gtk.Box+BoxChild
			this.entryLauncherFilename = new global::Gtk.Entry ();
			this.entryLauncherFilename.CanFocus = true;
			this.entryLauncherFilename.Name = "entryLauncherFilename";
			this.entryLauncherFilename.IsEditable = true;
			this.entryLauncherFilename.InvisibleChar = '●';
			this.hboxLauncherFile.Add (this.entryLauncherFilename);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hboxLauncherFile [this.entryLauncherFilename]));
			w6.Position = 1;
			this.vboxLauncher.Add (this.hboxLauncherFile);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vboxLauncher [this.hboxLauncherFile]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.GtkAlignment2.Add (this.vboxLauncher);
			this.frameLauncherSettings.Add (this.GtkAlignment2);
			this.labelLauncherSettings = new global::Gtk.Label ();
			this.labelLauncherSettings.Name = "labelLauncherSettings";
			this.labelLauncherSettings.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Launcher</b>");
			this.labelLauncherSettings.UseMarkup = true;
			this.frameLauncherSettings.LabelWidget = this.labelLauncherSettings;
			this.vboxGeneral.Add (this.frameLauncherSettings);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vboxGeneral [this.frameLauncherSettings]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vboxGeneral.Gtk.Box+BoxChild
			this.frameConsoleSettings = new global::Gtk.Frame ();
			this.frameConsoleSettings.Name = "frameConsoleSettings";
			this.frameConsoleSettings.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frameConsoleSettings.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.vboxConsole = new global::Gtk.VBox ();
			this.vboxConsole.Name = "vboxConsole";
			this.vboxConsole.Spacing = 6;
			// Container child vboxConsole.Gtk.Box+BoxChild
			this.checkbuttonShowConsole = new global::Gtk.CheckButton ();
			this.checkbuttonShowConsole.CanFocus = true;
			this.checkbuttonShowConsole.Name = "checkbuttonShowConsole";
			this.checkbuttonShowConsole.Label = global::Mono.Unix.Catalog.GetString ("Show console while game is running");
			this.checkbuttonShowConsole.DrawIndicator = true;
			this.checkbuttonShowConsole.UseUnderline = true;
			this.vboxConsole.Add (this.checkbuttonShowConsole);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vboxConsole [this.checkbuttonShowConsole]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vboxConsole.Gtk.Box+BoxChild
			this.checkbuttonAutoCloseConsole = new global::Gtk.CheckButton ();
			this.checkbuttonAutoCloseConsole.CanFocus = true;
			this.checkbuttonAutoCloseConsole.Name = "checkbuttonAutoCloseConsole";
			this.checkbuttonAutoCloseConsole.Label = global::Mono.Unix.Catalog.GetString ("Automatically close console when the game quits");
			this.checkbuttonAutoCloseConsole.DrawIndicator = true;
			this.checkbuttonAutoCloseConsole.UseUnderline = true;
			this.vboxConsole.Add (this.checkbuttonAutoCloseConsole);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vboxConsole [this.checkbuttonAutoCloseConsole]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.GtkAlignment3.Add (this.vboxConsole);
			this.frameConsoleSettings.Add (this.GtkAlignment3);
			this.labelConsoleSettings = new global::Gtk.Label ();
			this.labelConsoleSettings.Name = "labelConsoleSettings";
			this.labelConsoleSettings.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Console</b>");
			this.labelConsoleSettings.UseMarkup = true;
			this.frameConsoleSettings.LabelWidget = this.labelConsoleSettings;
			this.vboxGeneral.Add (this.frameConsoleSettings);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vboxGeneral [this.frameConsoleSettings]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vboxGeneral.Gtk.Box+BoxChild
			this.frameUpdateSettings = new global::Gtk.Frame ();
			this.frameUpdateSettings.Name = "frameUpdateSettings";
			this.frameUpdateSettings.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frameUpdateSettings.Gtk.Container+ContainerChild
			this.GtkAlignment4 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment4.Name = "GtkAlignment4";
			this.GtkAlignment4.LeftPadding = ((uint)(12));
			// Container child GtkAlignment4.Gtk.Container+ContainerChild
			this.vboxUpdates = new global::Gtk.VBox ();
			this.vboxUpdates.Name = "vboxUpdates";
			this.vboxUpdates.Spacing = 6;
			// Container child vboxUpdates.Gtk.Box+BoxChild
			this.checkbuttonAutoUpdate = new global::Gtk.CheckButton ();
			this.checkbuttonAutoUpdate.CanFocus = true;
			this.checkbuttonAutoUpdate.Name = "checkbuttonAutoUpdate";
			this.checkbuttonAutoUpdate.Label = global::Mono.Unix.Catalog.GetString ("Check for updates when the program starts");
			this.checkbuttonAutoUpdate.DrawIndicator = true;
			this.checkbuttonAutoUpdate.UseUnderline = true;
			this.vboxUpdates.Add (this.checkbuttonAutoUpdate);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vboxUpdates [this.checkbuttonAutoUpdate]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			this.GtkAlignment4.Add (this.vboxUpdates);
			this.frameUpdateSettings.Add (this.GtkAlignment4);
			this.GtkLabel4 = new global::Gtk.Label ();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Updates</b>");
			this.GtkLabel4.UseMarkup = true;
			this.frameUpdateSettings.LabelWidget = this.GtkLabel4;
			this.vboxGeneral.Add (this.frameUpdateSettings);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vboxGeneral [this.frameUpdateSettings]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			this.notebook.Add (this.vboxGeneral);
			// Notebook tab
			this.labelGeneral = new global::Gtk.Label ();
			this.labelGeneral.Name = "labelGeneral";
			this.labelGeneral.LabelProp = global::Mono.Unix.Catalog.GetString ("_General");
			this.labelGeneral.UseUnderline = true;
			this.notebook.SetTabLabel (this.vboxGeneral, this.labelGeneral);
			this.labelGeneral.ShowAll ();
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.vboxAdvanced = new global::Gtk.VBox ();
			this.vboxAdvanced.Name = "vboxAdvanced";
			this.vboxAdvanced.Spacing = 6;
			// Container child vboxAdvanced.Gtk.Box+BoxChild
			this.frameMemory = new global::Gtk.Frame ();
			this.frameMemory.Name = "frameMemory";
			this.frameMemory.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frameMemory.Gtk.Container+ContainerChild
			this.GtkAlignment5 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment5.Name = "GtkAlignment5";
			this.GtkAlignment5.LeftPadding = ((uint)(12));
			// Container child GtkAlignment5.Gtk.Container+ContainerChild
			this.tableMemory = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.tableMemory.Name = "tableMemory";
			this.tableMemory.RowSpacing = ((uint)(6));
			this.tableMemory.ColumnSpacing = ((uint)(6));
			// Container child tableMemory.Gtk.Table+TableChild
			this.labelInitialMemory = new global::Gtk.Label ();
			this.labelInitialMemory.Name = "labelInitialMemory";
			this.labelInitialMemory.LabelProp = global::Mono.Unix.Catalog.GetString ("Initial Memory Allocation");
			this.tableMemory.Add (this.labelInitialMemory);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.tableMemory [this.labelInitialMemory]));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableMemory.Gtk.Table+TableChild
			this.labelMaxMemory = new global::Gtk.Label ();
			this.labelMaxMemory.Name = "labelMaxMemory";
			this.labelMaxMemory.LabelProp = global::Mono.Unix.Catalog.GetString ("Mamimum Memory Allocation");
			this.tableMemory.Add (this.labelMaxMemory);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.tableMemory [this.labelMaxMemory]));
			w22.TopAttach = ((uint)(1));
			w22.BottomAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableMemory.Gtk.Table+TableChild
			this.spinbuttonInitialMemory = new global::Gtk.SpinButton (512D, 65536D, 512D);
			this.spinbuttonInitialMemory.CanFocus = true;
			this.spinbuttonInitialMemory.Name = "spinbuttonInitialMemory";
			this.spinbuttonInitialMemory.Adjustment.PageIncrement = 1024D;
			this.spinbuttonInitialMemory.ClimbRate = 1D;
			this.spinbuttonInitialMemory.Numeric = true;
			this.spinbuttonInitialMemory.Value = 512D;
			this.tableMemory.Add (this.spinbuttonInitialMemory);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.tableMemory [this.spinbuttonInitialMemory]));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableMemory.Gtk.Table+TableChild
			this.spinbuttonMaxMemory = new global::Gtk.SpinButton (1024D, 65536D, 512D);
			this.spinbuttonMaxMemory.CanFocus = true;
			this.spinbuttonMaxMemory.Name = "spinbuttonMaxMemory";
			this.spinbuttonMaxMemory.Adjustment.PageIncrement = 1024D;
			this.spinbuttonMaxMemory.ClimbRate = 1D;
			this.spinbuttonMaxMemory.Numeric = true;
			this.spinbuttonMaxMemory.Value = 1024D;
			this.tableMemory.Add (this.spinbuttonMaxMemory);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.tableMemory [this.spinbuttonMaxMemory]));
			w24.TopAttach = ((uint)(1));
			w24.BottomAttach = ((uint)(2));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment5.Add (this.tableMemory);
			this.frameMemory.Add (this.GtkAlignment5);
			this.labelMemorySettings = new global::Gtk.Label ();
			this.labelMemorySettings.Name = "labelMemorySettings";
			this.labelMemorySettings.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Memory</b>");
			this.labelMemorySettings.UseMarkup = true;
			this.frameMemory.LabelWidget = this.labelMemorySettings;
			this.vboxAdvanced.Add (this.frameMemory);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vboxAdvanced [this.frameMemory]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vboxAdvanced.Gtk.Box+BoxChild
			this.frameJava = new global::Gtk.Frame ();
			this.frameJava.Name = "frameJava";
			this.frameJava.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frameJava.Gtk.Container+ContainerChild
			this.GtkAlignment6 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment6.Name = "GtkAlignment6";
			this.GtkAlignment6.LeftPadding = ((uint)(12));
			this.GtkAlignment6.RightPadding = ((uint)(6));
			// Container child GtkAlignment6.Gtk.Container+ContainerChild
			this.vboxJava = new global::Gtk.VBox ();
			this.vboxJava.Name = "vboxJava";
			this.vboxJava.Spacing = 6;
			// Container child vboxJava.Gtk.Box+BoxChild
			this.hboxJavaPath = new global::Gtk.HBox ();
			this.hboxJavaPath.Name = "hboxJavaPath";
			this.hboxJavaPath.Spacing = 6;
			// Container child hboxJavaPath.Gtk.Box+BoxChild
			this.labelJavaPath = new global::Gtk.Label ();
			this.labelJavaPath.Name = "labelJavaPath";
			this.labelJavaPath.LabelProp = global::Mono.Unix.Catalog.GetString ("Java Path");
			this.hboxJavaPath.Add (this.labelJavaPath);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hboxJavaPath [this.labelJavaPath]));
			w28.Position = 0;
			w28.Expand = false;
			w28.Fill = false;
			// Container child hboxJavaPath.Gtk.Box+BoxChild
			this.entryJavaPath = new global::Gtk.Entry ();
			this.entryJavaPath.CanFocus = true;
			this.entryJavaPath.Name = "entryJavaPath";
			this.entryJavaPath.IsEditable = true;
			this.entryJavaPath.InvisibleChar = '●';
			this.hboxJavaPath.Add (this.entryJavaPath);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hboxJavaPath [this.entryJavaPath]));
			w29.Position = 1;
			this.vboxJava.Add (this.hboxJavaPath);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vboxJava [this.hboxJavaPath]));
			w30.Position = 0;
			w30.Expand = false;
			w30.Fill = false;
			this.GtkAlignment6.Add (this.vboxJava);
			this.frameJava.Add (this.GtkAlignment6);
			this.labelJava = new global::Gtk.Label ();
			this.labelJava.Name = "labelJava";
			this.labelJava.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Java</b>");
			this.labelJava.UseMarkup = true;
			this.frameJava.LabelWidget = this.labelJava;
			this.vboxAdvanced.Add (this.frameJava);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vboxAdvanced [this.frameJava]));
			w33.Position = 1;
			w33.Expand = false;
			w33.Fill = false;
			this.notebook.Add (this.vboxAdvanced);
			global::Gtk.Notebook.NotebookChild w34 = ((global::Gtk.Notebook.NotebookChild)(this.notebook [this.vboxAdvanced]));
			w34.Position = 1;
			// Notebook tab
			this.labelAdvanced = new global::Gtk.Label ();
			this.labelAdvanced.Name = "labelAdvanced";
			this.labelAdvanced.LabelProp = global::Mono.Unix.Catalog.GetString ("_Advanced");
			this.labelAdvanced.UseUnderline = true;
			this.notebook.SetTabLabel (this.vboxAdvanced, this.labelAdvanced);
			this.labelAdvanced.ShowAll ();
			w1.Add (this.notebook);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(w1 [this.notebook]));
			w35.Position = 0;
			// Internal child MultiMC.SettingsDialog.ActionArea
			global::Gtk.HButtonBox w36 = this.ActionArea;
			w36.Name = "dialog1_ActionArea";
			w36.Spacing = 10;
			w36.BorderWidth = ((uint)(5));
			w36.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w37 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w36 [this.buttonCancel]));
			w37.Expand = false;
			w37.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w38 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w36 [this.buttonOk]));
			w38.Position = 1;
			w38.Expand = false;
			w38.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.labelGeneral.MnemonicWidget = this.notebook;
			this.labelAdvanced.MnemonicWidget = this.notebook;
			this.Show ();
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnCancel);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnOK);
		}
	}
}

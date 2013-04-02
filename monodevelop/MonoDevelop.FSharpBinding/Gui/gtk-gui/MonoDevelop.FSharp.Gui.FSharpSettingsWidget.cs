
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.FSharp.Gui
{
	public partial class FSharpSettingsWidget
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label4;
		private global::Gtk.CheckButton checkInteractiveUseDefault;
		private global::Gtk.Table table1;
		private global::Gtk.Button buttonBrowse;
		private global::Gtk.Entry entryArguments;
		private global::Gtk.Entry entryPath;
		private global::Gtk.Label GtkLabel1;
		private global::Gtk.Label GtkLabel6;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label2;
		private global::Gtk.CheckButton checkCompilerUseDefault;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.Table table2;
		private global::Gtk.Button buttonCompilerBrowse;
		private global::Gtk.Entry entryCompilerPath;
		private global::Gtk.Label label3;
		private global::Gtk.Label GtkLabel5;
		private global::Gtk.Frame frame4;
		private global::Gtk.Alignment GtkAlignment1;
		private global::Gtk.FontButton fontbutton1;
		private global::Gtk.Label GtkLabel13;
		private global::Gtk.Label label1;
		private global::Gtk.CheckButton matchThemeCheckbox;
		private global::Gtk.HBox colorsHBox;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Label label5;
		private global::Gtk.ColorButton baseColorButton;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Label label6;
		private global::Gtk.ColorButton textColorButton;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.FSharp.Gui.FSharpSettingsWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.FSharp.Gui.FSharpSettingsWidget";
			// Container child MonoDevelop.FSharp.Gui.FSharpSettingsWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>F# Interactive</b>");
			this.label4.UseMarkup = true;
			this.hbox2.Add (this.label4);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label4]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.checkInteractiveUseDefault = new global::Gtk.CheckButton ();
			this.checkInteractiveUseDefault.CanFocus = true;
			this.checkInteractiveUseDefault.Name = "checkInteractiveUseDefault";
			this.checkInteractiveUseDefault.Label = global::Mono.Unix.Catalog.GetString ("Use Default");
			this.checkInteractiveUseDefault.Active = true;
			this.checkInteractiveUseDefault.DrawIndicator = true;
			this.checkInteractiveUseDefault.UseUnderline = true;
			this.hbox2.Add (this.checkInteractiveUseDefault);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.checkInteractiveUseDefault]));
			w2.Position = 1;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.buttonBrowse = new global::Gtk.Button ();
			this.buttonBrowse.CanFocus = true;
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.UseUnderline = true;
			this.buttonBrowse.Label = global::Mono.Unix.Catalog.GetString ("_Browse...");
			this.table1.Add (this.buttonBrowse);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.buttonBrowse]));
			w4.LeftAttach = ((uint)(2));
			w4.RightAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryArguments = new global::Gtk.Entry ();
			this.entryArguments.CanFocus = true;
			this.entryArguments.Name = "entryArguments";
			this.entryArguments.IsEditable = true;
			this.entryArguments.InvisibleChar = '●';
			this.table1.Add (this.entryArguments);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryArguments]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(3));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryPath = new global::Gtk.Entry ();
			this.entryPath.CanFocus = true;
			this.entryPath.Name = "entryPath";
			this.entryPath.IsEditable = true;
			this.entryPath.InvisibleChar = '●';
			this.table1.Add (this.entryPath);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryPath]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkLabel1 = new global::Gtk.Label ();
			this.GtkLabel1.Name = "GtkLabel1";
			this.GtkLabel1.Xalign = 0F;
			this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("Path");
			this.GtkLabel1.UseMarkup = true;
			this.table1.Add (this.GtkLabel1);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.GtkLabel1]));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkLabel6 = new global::Gtk.Label ();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.Xalign = 0F;
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("Options");
			this.GtkLabel6.UseMarkup = true;
			this.table1.Add (this.GtkLabel6);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.GtkLabel6]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.table1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>F# Default Compiler</b>");
			this.label2.UseMarkup = true;
			this.hbox1.Add (this.label2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label2]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.checkCompilerUseDefault = new global::Gtk.CheckButton ();
			this.checkCompilerUseDefault.CanFocus = true;
			this.checkCompilerUseDefault.Name = "checkCompilerUseDefault";
			this.checkCompilerUseDefault.Label = global::Mono.Unix.Catalog.GetString ("Use Default");
			this.checkCompilerUseDefault.Active = true;
			this.checkCompilerUseDefault.DrawIndicator = true;
			this.checkCompilerUseDefault.UseUnderline = true;
			this.hbox1.Add (this.checkCompilerUseDefault);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.checkCompilerUseDefault]));
			w11.Position = 1;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.table2 = new global::Gtk.Table (((uint)(1)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.buttonCompilerBrowse = new global::Gtk.Button ();
			this.buttonCompilerBrowse.CanFocus = true;
			this.buttonCompilerBrowse.Name = "buttonCompilerBrowse";
			this.buttonCompilerBrowse.UseUnderline = true;
			this.buttonCompilerBrowse.Label = global::Mono.Unix.Catalog.GetString ("_Browse...");
			this.table2.Add (this.buttonCompilerBrowse);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2 [this.buttonCompilerBrowse]));
			w13.LeftAttach = ((uint)(2));
			w13.RightAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryCompilerPath = new global::Gtk.Entry ();
			this.entryCompilerPath.CanFocus = true;
			this.entryCompilerPath.Name = "entryCompilerPath";
			this.entryCompilerPath.IsEditable = true;
			this.entryCompilerPath.InvisibleChar = '●';
			this.table2.Add (this.entryCompilerPath);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryCompilerPath]));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Path");
			this.table2.Add (this.label3);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table2 [this.label3]));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment2.Add (this.table2);
			this.frame1.Add (this.GtkAlignment2);
			this.GtkLabel5 = new global::Gtk.Label ();
			this.GtkLabel5.Name = "GtkLabel5";
			this.GtkLabel5.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel5;
			this.vbox1.Add (this.frame1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame1]));
			w18.Position = 3;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frame4 = new global::Gtk.Frame ();
			this.frame4.Name = "frame4";
			this.frame4.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame4.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			this.GtkAlignment1.TopPadding = ((uint)(6));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.fontbutton1 = new global::Gtk.FontButton ();
			this.fontbutton1.CanFocus = true;
			this.fontbutton1.Name = "fontbutton1";
			this.GtkAlignment1.Add (this.fontbutton1);
			this.frame4.Add (this.GtkAlignment1);
			this.GtkLabel13 = new global::Gtk.Label ();
			this.GtkLabel13.Name = "GtkLabel13";
			this.GtkLabel13.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Interactive Pad Font</b>");
			this.GtkLabel13.UseMarkup = true;
			this.frame4.LabelWidget = this.GtkLabel13;
			this.vbox1.Add (this.frame4);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame4]));
			w21.Position = 4;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>FSI Colors</b>");
			this.label1.UseMarkup = true;
			this.vbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label1]));
			w22.Position = 5;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.matchThemeCheckbox = new global::Gtk.CheckButton ();
			this.matchThemeCheckbox.CanFocus = true;
			this.matchThemeCheckbox.Name = "matchThemeCheckbox";
			this.matchThemeCheckbox.Label = global::Mono.Unix.Catalog.GetString ("Match with Theme");
			this.matchThemeCheckbox.DrawIndicator = true;
			this.matchThemeCheckbox.UseUnderline = true;
			this.vbox1.Add (this.matchThemeCheckbox);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.matchThemeCheckbox]));
			w23.Position = 6;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.colorsHBox = new global::Gtk.HBox ();
			this.colorsHBox.Name = "colorsHBox";
			this.colorsHBox.Spacing = 6;
			// Container child colorsHBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Base Color");
			this.vbox2.Add (this.label5);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label5]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.baseColorButton = new global::Gtk.ColorButton ();
			this.baseColorButton.CanFocus = true;
			this.baseColorButton.Events = ((global::Gdk.EventMask)(784));
			this.baseColorButton.Name = "baseColorButton";
			this.vbox2.Add (this.baseColorButton);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.baseColorButton]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			this.colorsHBox.Add (this.vbox2);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.colorsHBox [this.vbox2]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child colorsHBox.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Text Color");
			this.vbox3.Add (this.label6);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label6]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.textColorButton = new global::Gtk.ColorButton ();
			this.textColorButton.CanFocus = true;
			this.textColorButton.Events = ((global::Gdk.EventMask)(784));
			this.textColorButton.Name = "textColorButton";
			this.vbox3.Add (this.textColorButton);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.textColorButton]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			this.colorsHBox.Add (this.vbox3);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.colorsHBox [this.vbox3]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			this.vbox1.Add (this.colorsHBox);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.colorsHBox]));
			w30.PackType = ((global::Gtk.PackType)(1));
			w30.Position = 7;
			w30.Expand = false;
			w30.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}

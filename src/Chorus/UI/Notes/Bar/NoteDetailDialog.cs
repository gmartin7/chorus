﻿using System;
using System.Windows.Forms;
using Chorus.notes;

namespace Chorus.UI.Notes.Bar
{
	public partial class NoteDetailDialog : Form
	{
		public NoteDetailDialog(Annotation annotation, AnnotationEditorModel.Factory viewModelFactory)
		{
			InitializeComponent();
			var model = viewModelFactory(annotation, false);
			Text = model.GetLongLabel();
			var view = new AnnotationEditorView(model);
			view.ModalDialogMode = true;
			view.Dock = DockStyle.Fill;
			//view.Size  = new Size(Width, Height - 50);
			Controls.Add(view);
			AcceptButton = view.OKButton;
			view.OnClose += (CloseButton_Click);
		}

		void CloseButton_Click(object sender, EventArgs e)
		{
			DialogResult = (DialogResult) sender;
			//this relies on us being the second receiver of this message, after the view itself
			this.Close();
		}

		private void NoteDetailDialog_Load(object sender, EventArgs e)
		{

		}
	}
}
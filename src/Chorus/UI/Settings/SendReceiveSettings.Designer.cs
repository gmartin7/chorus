﻿using Palaso.UI.WindowsForms.SettingProtection;

namespace Chorus.UI.Settings
{
	partial class SendReceiveSettings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.nameLabel = new System.Windows.Forms.Label();
			this.userNameTextBox = new System.Windows.Forms.TextBox();
			this.settingsTabs = new System.Windows.Forms.TabControl();
			this.internetTab = new System.Windows.Forms.TabPage();
			this._internetSettingsFlow = new System.Windows.Forms.FlowLayoutPanel();
			this._internetButtonEnabledCheckBox = new System.Windows.Forms.CheckBox();
			this._serverSettingsControl = new Chorus.UI.Misc.ServerSettingsControl();
			this.networkFolderTab = new System.Windows.Forms.TabPage();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this._sharedFolderButtonEnabledCheckBox = new System.Windows.Forms.CheckBox();
			this._sharedFolderSettingsControl = new Chorus.UI.Misc.NetworkFolderSettingsControl();
			this._helpButton = new System.Windows.Forms.Button();
			this._cancelButton = new System.Windows.Forms.Button();
			this._okButton = new System.Windows.Forms.Button();
			this.settingsProtectionButton = new Palaso.UI.WindowsForms.SettingProtection.SettingsProtectionLauncherButton();
			this.settingsTabs.SuspendLayout();
			this.internetTab.SuspendLayout();
			this._internetSettingsFlow.SuspendLayout();
			this.networkFolderTab.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			//
			// nameLabel
			//
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(13, 13);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(161, 13);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Name to show in change history:";
			//
			// userNameTextBox
			//
			this.userNameTextBox.Location = new System.Drawing.Point(16, 30);
			this.userNameTextBox.Name = "userNameTextBox";
			this.userNameTextBox.Size = new System.Drawing.Size(158, 20);
			this.userNameTextBox.TabIndex = 1;
			this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
			//
			// settingsTabs
			//
			this.settingsTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.settingsTabs.Controls.Add(this.internetTab);
			this.settingsTabs.Controls.Add(this.networkFolderTab);
			this.settingsTabs.Location = new System.Drawing.Point(13, 77);
			this.settingsTabs.Name = "settingsTabs";
			this.settingsTabs.SelectedIndex = 0;
			this.settingsTabs.Size = new System.Drawing.Size(484, 294);
			this.settingsTabs.TabIndex = 2;
			//
			// internetTab
			//
			this.internetTab.Controls.Add(this._internetSettingsFlow);
			this.internetTab.Location = new System.Drawing.Point(4, 22);
			this.internetTab.Name = "internetTab";
			this.internetTab.Padding = new System.Windows.Forms.Padding(3);
			this.internetTab.Size = new System.Drawing.Size(476, 268);
			this.internetTab.TabIndex = 0;
			this.internetTab.Text = "Internet";
			this.internetTab.UseVisualStyleBackColor = true;
			//
			// _internetSettingsFlow
			//
			this._internetSettingsFlow.Controls.Add(this._internetButtonEnabledCheckBox);
			this._internetSettingsFlow.Controls.Add(this._serverSettingsControl);
			this._internetSettingsFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this._internetSettingsFlow.Location = new System.Drawing.Point(0, 11);
			this._internetSettingsFlow.Name = "_internetSettingsFlow";
			this._internetSettingsFlow.Size = new System.Drawing.Size(456, 238);
			this._internetSettingsFlow.TabIndex = 0;
			this._internetSettingsFlow.WrapContents = false;
			//
			// _internetButtonEnabledCheckBox
			//
			this._internetButtonEnabledCheckBox.AutoSize = true;
			this._internetButtonEnabledCheckBox.Location = new System.Drawing.Point(110, 3);
			this._internetButtonEnabledCheckBox.Margin = new System.Windows.Forms.Padding(110, 3, 3, 3);
			this._internetButtonEnabledCheckBox.Name = "_internetButtonEnabledCheckBox";
			this._internetButtonEnabledCheckBox.Size = new System.Drawing.Size(211, 17);
			this._internetButtonEnabledCheckBox.TabIndex = 0;
			this._internetButtonEnabledCheckBox.Text = "Show Internet as Send/Receive option";
			this._internetButtonEnabledCheckBox.UseVisualStyleBackColor = true;
			//
			// _serverSettingsControl
			//
			this._serverSettingsControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._serverSettingsControl.Location = new System.Drawing.Point(3, 26);
			this._serverSettingsControl.MinimumSize = new System.Drawing.Size(430, 200);
			this._serverSettingsControl.Name = "_serverSettingsControl";
			this._serverSettingsControl.Size = new System.Drawing.Size(430, 200);
			this._serverSettingsControl.TabIndex = 1;
			//
			// networkFolderTab
			//
			this.networkFolderTab.Controls.Add(this.flowLayoutPanel1);
			this.networkFolderTab.Location = new System.Drawing.Point(4, 22);
			this.networkFolderTab.Name = "networkFolderTab";
			this.networkFolderTab.Padding = new System.Windows.Forms.Padding(3);
			this.networkFolderTab.Size = new System.Drawing.Size(476, 268);
			this.networkFolderTab.TabIndex = 1;
			this.networkFolderTab.Text = "Network Folder";
			this.networkFolderTab.UseVisualStyleBackColor = true;
			//
			// flowLayoutPanel1
			//
			this.flowLayoutPanel1.Controls.Add(this._sharedFolderButtonEnabledCheckBox);
			this.flowLayoutPanel1.Controls.Add(this._sharedFolderSettingsControl);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 15);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(456, 238);
			this.flowLayoutPanel1.TabIndex = 1;
			this.flowLayoutPanel1.WrapContents = false;
			//
			// _sharedFolderButtonEnabledCheckBox
			//
			this._sharedFolderButtonEnabledCheckBox.AutoSize = true;
			this._sharedFolderButtonEnabledCheckBox.Location = new System.Drawing.Point(10, 3);
			this._sharedFolderButtonEnabledCheckBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this._sharedFolderButtonEnabledCheckBox.Name = "_sharedFolderButtonEnabledCheckBox";
			this._sharedFolderButtonEnabledCheckBox.Size = new System.Drawing.Size(247, 17);
			this._sharedFolderButtonEnabledCheckBox.TabIndex = 0;
			this._sharedFolderButtonEnabledCheckBox.Text = "Show Network Folder as Send/Receive option";
			this._sharedFolderButtonEnabledCheckBox.UseVisualStyleBackColor = true;
			//
			// _sharedFolderSettingsControl
			//
			this._sharedFolderSettingsControl.Location = new System.Drawing.Point(3, 26);
			this._sharedFolderSettingsControl.Name = "_sharedFolderSettingsControl";
			this._sharedFolderSettingsControl.Size = new System.Drawing.Size(326, 155);
			this._sharedFolderSettingsControl.TabIndex = 1;
			//
			// _helpButton
			//
			this._helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._helpButton.Location = new System.Drawing.Point(422, 399);
			this._helpButton.Name = "_helpButton";
			this._helpButton.Size = new System.Drawing.Size(75, 23);
			this._helpButton.TabIndex = 5;
			this._helpButton.Text = "Help";
			this._helpButton.UseVisualStyleBackColor = true;
			//
			// _cancelButton
			//
			this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._cancelButton.Location = new System.Drawing.Point(341, 399);
			this._cancelButton.Name = "_cancelButton";
			this._cancelButton.Size = new System.Drawing.Size(75, 23);
			this._cancelButton.TabIndex = 4;
			this._cancelButton.Text = "Cancel";
			this._cancelButton.UseVisualStyleBackColor = true;
			this._cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			//
			// _okButton
			//
			this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._okButton.Location = new System.Drawing.Point(260, 399);
			this._okButton.Name = "_okButton";
			this._okButton.Size = new System.Drawing.Size(75, 23);
			this._okButton.TabIndex = 3;
			this._okButton.Text = "OK";
			this._okButton.UseVisualStyleBackColor = true;
			this._okButton.Click += new System.EventHandler(this.okButton_Click);
			//
			// settingsProtectionButton
			//
			this.settingsProtectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.settingsProtectionButton.Location = new System.Drawing.Point(14, 388);
			this.settingsProtectionButton.Margin = new System.Windows.Forms.Padding(0);
			this.settingsProtectionButton.Name = "settingsProtectionButton";
			this.settingsProtectionButton.Size = new System.Drawing.Size(258, 37);
			this.settingsProtectionButton.TabIndex = 0;
			//
			// SendReceiveSettings
			//
			this.AcceptButton = this._okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._cancelButton;
			this.ClientSize = new System.Drawing.Size(508, 434);
			this.Controls.Add(this._okButton);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this._helpButton);
			this.Controls.Add(this.settingsTabs);
			this.Controls.Add(this.userNameTextBox);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.settingsProtectionButton);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SendReceiveSettings";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Send/Receive Settings";
			this.settingsTabs.ResumeLayout(false);
			this.internetTab.ResumeLayout(false);
			this._internetSettingsFlow.ResumeLayout(false);
			this._internetSettingsFlow.PerformLayout();
			this.networkFolderTab.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox userNameTextBox;
		private System.Windows.Forms.TabControl settingsTabs;
		private System.Windows.Forms.TabPage internetTab;
		private System.Windows.Forms.TabPage networkFolderTab;
		private System.Windows.Forms.Button _helpButton;
		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.Button _okButton;
		private Palaso.UI.WindowsForms.SettingProtection.SettingsProtectionLauncherButton settingsProtectionButton;
		private System.Windows.Forms.FlowLayoutPanel _internetSettingsFlow;
		private System.Windows.Forms.CheckBox _internetButtonEnabledCheckBox;
		private Misc.ServerSettingsControl _serverSettingsControl;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.CheckBox _sharedFolderButtonEnabledCheckBox;
		private Misc.NetworkFolderSettingsControl _sharedFolderSettingsControl;
	}
}
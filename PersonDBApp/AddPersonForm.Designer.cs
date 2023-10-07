using System.ComponentModel;

namespace PersonDBApp;

partial class AddPersonForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtSurname = new System.Windows.Forms.TextBox();
            this._btnAddPerson = new System.Windows.Forms.Button();
            this._cmbSex = new System.Windows.Forms.ComboBox();
            this._mcBirthday = new System.Windows.Forms.MonthCalendar();
            this._cmbAddress = new System.Windows.Forms.ComboBox();
            this._btnAddAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(103, 4);
            this._txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(218, 23);
            this._txtName.TabIndex = 5;
            // 
            // _txtSurname
            // 
            this._txtSurname.Location = new System.Drawing.Point(103, 40);
            this._txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtSurname.Name = "_txtSurname";
            this._txtSurname.Size = new System.Drawing.Size(218, 23);
            this._txtSurname.TabIndex = 6;
            // 
            // _btnAddPerson
            // 
            this._btnAddPerson.Location = new System.Drawing.Point(10, 291);
            this._btnAddPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnAddPerson.Name = "_btnAddPerson";
            this._btnAddPerson.Size = new System.Drawing.Size(310, 22);
            this._btnAddPerson.TabIndex = 10;
            this._btnAddPerson.Text = "Add";
            this._btnAddPerson.UseVisualStyleBackColor = true;
            this._btnAddPerson.Click += new System.EventHandler(this._btnAddPerson_Click);
            // 
            // _cmbSex
            // 
            this._cmbSex.FormattingEnabled = true;
            this._cmbSex.Location = new System.Drawing.Point(103, 72);
            this._cmbSex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmbSex.Name = "_cmbSex";
            this._cmbSex.Size = new System.Drawing.Size(218, 23);
            this._cmbSex.TabIndex = 11;
            // 
            // _mcBirthday
            // 
            this._mcBirthday.Location = new System.Drawing.Point(152, 98);
            this._mcBirthday.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this._mcBirthday.Name = "_mcBirthday";
            this._mcBirthday.TabIndex = 12;
            this._mcBirthday.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this._mcBirthday_DateSelected);
            // 
            // _cmbAddress
            // 
            this._cmbAddress.FormattingEnabled = true;
            this._cmbAddress.Location = new System.Drawing.Point(104, 262);
            this._cmbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmbAddress.Name = "_cmbAddress";
            this._cmbAddress.Size = new System.Drawing.Size(217, 23);
            this._cmbAddress.TabIndex = 13;
            // 
            // _btnAddAddress
            // 
            this._btnAddAddress.Location = new System.Drawing.Point(10, 317);
            this._btnAddAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnAddAddress.Name = "_btnAddAddress";
            this._btnAddAddress.Size = new System.Drawing.Size(310, 23);
            this._btnAddAddress.TabIndex = 14;
            this._btnAddAddress.Text = "Add address";
            this._btnAddAddress.UseVisualStyleBackColor = true;
            this._btnAddAddress.Click += new System.EventHandler(this._btnAddAddress_Click);
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 350);
            this.Controls.Add(this._btnAddAddress);
            this.Controls.Add(this._cmbAddress);
            this.Controls.Add(this._mcBirthday);
            this.Controls.Add(this._cmbSex);
            this.Controls.Add(this._btnAddPerson);
            this.Controls.Add(this._txtSurname);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddPersonForm";
            this.Text = "AddPersonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox _txtName;
    private TextBox _txtSurname;
    private Button _btnAddPerson;
    private ComboBox _cmbSex;
    private MonthCalendar _mcBirthday;
    private ComboBox _cmbAddress;
    private Button _btnAddAddress;
}
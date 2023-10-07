using System.ComponentModel;

namespace PersonDBApp;

partial class AddAddressForm
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
            this._txtStreet = new System.Windows.Forms.TextBox();
            this._txtCity = new System.Windows.Forms.TextBox();
            this._txtZip = new System.Windows.Forms.TextBox();
            this._txtCountry = new System.Windows.Forms.TextBox();
            this._btnAddAddress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _txtStreet
            // 
            this._txtStreet.Location = new System.Drawing.Point(88, 9);
            this._txtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtStreet.Name = "_txtStreet";
            this._txtStreet.Size = new System.Drawing.Size(110, 23);
            this._txtStreet.TabIndex = 0;
            // 
            // _txtCity
            // 
            this._txtCity.Location = new System.Drawing.Point(88, 47);
            this._txtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtCity.Name = "_txtCity";
            this._txtCity.Size = new System.Drawing.Size(110, 23);
            this._txtCity.TabIndex = 1;
            // 
            // _txtZip
            // 
            this._txtZip.Location = new System.Drawing.Point(88, 86);
            this._txtZip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtZip.Name = "_txtZip";
            this._txtZip.Size = new System.Drawing.Size(110, 23);
            this._txtZip.TabIndex = 2;
            // 
            // _txtCountry
            // 
            this._txtCountry.Location = new System.Drawing.Point(86, 120);
            this._txtCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtCountry.Name = "_txtCountry";
            this._txtCountry.Size = new System.Drawing.Size(110, 23);
            this._txtCountry.TabIndex = 3;
            // 
            // _btnAddAddress
            // 
            this._btnAddAddress.Location = new System.Drawing.Point(10, 150);
            this._btnAddAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnAddAddress.Name = "_btnAddAddress";
            this._btnAddAddress.Size = new System.Drawing.Size(186, 22);
            this._btnAddAddress.TabIndex = 5;
            this._btnAddAddress.Text = "Add";
            this._btnAddAddress.UseVisualStyleBackColor = true;
            this._btnAddAddress.Click += new System.EventHandler(this._btnAddAddress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "County";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Street";
            // 
            // AddAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 184);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnAddAddress);
            this.Controls.Add(this._txtCountry);
            this.Controls.Add(this._txtZip);
            this.Controls.Add(this._txtCity);
            this.Controls.Add(this._txtStreet);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddAddressForm";
            this.Text = "AddAddressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox _txtStreet;
    private TextBox _txtCity;
    private TextBox _txtZip;
    private TextBox _txtCountry;
    private Button _btnAddAddress;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
}
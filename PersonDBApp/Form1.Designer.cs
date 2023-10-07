namespace PersonDBApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this._lsbPersons = new System.Windows.Forms.ListBox();
            this._lblPerson = new System.Windows.Forms.Label();
            this._lblAddress = new System.Windows.Forms.Label();
            this._btnAddAddress = new System.Windows.Forms.Button();
            this._btnAddPerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lsbPersons
            // 
            this._lsbPersons.FormattingEnabled = true;
            this._lsbPersons.ItemHeight = 20;
            this._lsbPersons.Location = new System.Drawing.Point(12, 12);
            this._lsbPersons.Name = "_lsbPersons";
            this._lsbPersons.Size = new System.Drawing.Size(277, 424);
            this._lsbPersons.TabIndex = 0;
            this._lsbPersons.SelectedIndexChanged += new System.EventHandler(this._lsbPersons_SelectedIndexChanged);
            // 
            // _lblPerson
            // 
            this._lblPerson.AutoSize = true;
            this._lblPerson.Location = new System.Drawing.Point(295, 12);
            this._lblPerson.Name = "_lblPerson";
            this._lblPerson.Size = new System.Drawing.Size(15, 20);
            this._lblPerson.TabIndex = 2;
            this._lblPerson.Text = "-";
            // 
            // _lblAddress
            // 
            this._lblAddress.AutoSize = true;
            this._lblAddress.Location = new System.Drawing.Point(295, 48);
            this._lblAddress.Name = "_lblAddress";
            this._lblAddress.Size = new System.Drawing.Size(15, 20);
            this._lblAddress.TabIndex = 3;
            this._lblAddress.Text = "-";
            // 
            // _btnAddAddress
            // 
            this._btnAddAddress.Location = new System.Drawing.Point(295, 372);
            this._btnAddAddress.Name = "_btnAddAddress";
            this._btnAddAddress.Size = new System.Drawing.Size(325, 29);
            this._btnAddAddress.TabIndex = 4;
            this._btnAddAddress.Text = "Add Address";
            this._btnAddAddress.UseVisualStyleBackColor = true;
            this._btnAddAddress.Click += new System.EventHandler(this._btnAddAddress_Click);
            // 
            // _btnAddPerson
            // 
            this._btnAddPerson.Location = new System.Drawing.Point(295, 407);
            this._btnAddPerson.Name = "_btnAddPerson";
            this._btnAddPerson.Size = new System.Drawing.Size(325, 29);
            this._btnAddPerson.TabIndex = 5;
            this._btnAddPerson.Text = "Add Person";
            this._btnAddPerson.UseVisualStyleBackColor = true;
            this._btnAddPerson.Click += new System.EventHandler(this._btnAddPerson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this._btnAddPerson);
            this.Controls.Add(this._btnAddAddress);
            this.Controls.Add(this._lblAddress);
            this.Controls.Add(this._lblPerson);
            this.Controls.Add(this._lsbPersons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private ListBox _lsbPersons;
    private Label _lblPerson;
    private Label _lblAddress;
    private Button _btnAddAddress;
    private Button _btnAddPerson;
}
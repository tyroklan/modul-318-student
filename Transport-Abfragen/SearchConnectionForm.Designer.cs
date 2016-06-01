namespace Transport_Abfragen
{
    partial class SearchConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchConnectionForm));
            this.searchconnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departure = new System.Windows.Forms.ComboBox();
            this.destination = new System.Windows.Forms.ComboBox();
            this.connectionlist = new System.Windows.Forms.ListView();
            this.alldep = new System.Windows.Forms.Button();
            this.alldep2 = new System.Windows.Forms.Button();
            this.changedirection = new System.Windows.Forms.Button();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.timepicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchconnection
            // 
            this.searchconnection.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.searchconnection.Location = new System.Drawing.Point(504, 79);
            this.searchconnection.Name = "searchconnection";
            this.searchconnection.Size = new System.Drawing.Size(132, 43);
            this.searchconnection.TabIndex = 7;
            this.searchconnection.Text = "Verbindung Suchen";
            this.searchconnection.UseVisualStyleBackColor = true;
            this.searchconnection.Click += new System.EventHandler(this.searchconnection_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Abfahrtsort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zielort";
            // 
            // departure
            // 
            this.departure.FormattingEnabled = true;
            this.departure.Location = new System.Drawing.Point(171, 33);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(182, 21);
            this.departure.TabIndex = 1;
            this.departure.TextUpdate += new System.EventHandler(this.departure_TextUpdate);
            this.departure.MouseClick += new System.Windows.Forms.MouseEventHandler(this.departure_MouseClick);
            // 
            // destination
            // 
            this.destination.FormattingEnabled = true;
            this.destination.Location = new System.Drawing.Point(171, 79);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(182, 21);
            this.destination.TabIndex = 3;
            this.destination.TextUpdate += new System.EventHandler(this.destination_TextUpdate);
            this.destination.MouseClick += new System.Windows.Forms.MouseEventHandler(this.destination_MouseClick);
            // 
            // connectionlist
            // 
            this.connectionlist.Location = new System.Drawing.Point(0, 148);
            this.connectionlist.Name = "connectionlist";
            this.connectionlist.Size = new System.Drawing.Size(657, 274);
            this.connectionlist.TabIndex = 8;
            this.connectionlist.UseCompatibleStateImageBehavior = false;
            this.connectionlist.View = System.Windows.Forms.View.Details;
            // 
            // alldep
            // 
            this.alldep.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.alldep.Location = new System.Drawing.Point(359, 33);
            this.alldep.Name = "alldep";
            this.alldep.Size = new System.Drawing.Size(47, 21);
            this.alldep.TabIndex = 2;
            this.alldep.Text = "Details";
            this.alldep.UseVisualStyleBackColor = true;
            this.alldep.Click += new System.EventHandler(this.alldep_Click);
            // 
            // alldep2
            // 
            this.alldep2.Location = new System.Drawing.Point(359, 79);
            this.alldep2.Name = "alldep2";
            this.alldep2.Size = new System.Drawing.Size(47, 21);
            this.alldep2.TabIndex = 4;
            this.alldep2.Text = "Details";
            this.alldep2.UseVisualStyleBackColor = true;
            this.alldep2.Click += new System.EventHandler(this.alldep2_Click);
            // 
            // changedirection
            // 
            this.changedirection.Location = new System.Drawing.Point(7, 40);
            this.changedirection.Name = "changedirection";
            this.changedirection.Size = new System.Drawing.Size(63, 48);
            this.changedirection.TabIndex = 8;
            this.changedirection.Text = "Richtung ändern";
            this.changedirection.UseVisualStyleBackColor = true;
            this.changedirection.Click += new System.EventHandler(this.changedirection_Click);
            // 
            // datepicker
            // 
            this.datepicker.CustomFormat = "yyyy-MM-dd";
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker.Location = new System.Drawing.Point(555, 25);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(82, 20);
            this.datepicker.TabIndex = 5;
            // 
            // timepicker
            // 
            this.timepicker.CustomFormat = "HH:mm";
            this.timepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timepicker.Location = new System.Drawing.Point(580, 52);
            this.timepicker.Name = "timepicker";
            this.timepicker.ShowUpDown = true;
            this.timepicker.Size = new System.Drawing.Size(56, 20);
            this.timepicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Uhrzeit:";
            // 
            // SearchConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 427);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timepicker);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.changedirection);
            this.Controls.Add(this.alldep2);
            this.Controls.Add(this.alldep);
            this.Controls.Add(this.connectionlist);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchconnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchConnectionForm";
            this.Text = "ÖV Info Programm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchconnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox departure;
        private System.Windows.Forms.ComboBox destination;
        private System.Windows.Forms.ListView connectionlist;
        private System.Windows.Forms.Button alldep;
        private System.Windows.Forms.Button alldep2;
        private System.Windows.Forms.Button changedirection;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.DateTimePicker timepicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


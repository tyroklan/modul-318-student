namespace Transport_Abfragen
{
    partial class Form1
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
            this.searchconnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departure = new System.Windows.Forms.ComboBox();
            this.destination = new System.Windows.Forms.ComboBox();
            this.connectionlist = new System.Windows.Forms.ListView();
            this.dep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.des = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deptime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alldep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchconnection
            // 
            this.searchconnection.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.searchconnection.Location = new System.Drawing.Point(329, 51);
            this.searchconnection.Name = "searchconnection";
            this.searchconnection.Size = new System.Drawing.Size(114, 35);
            this.searchconnection.TabIndex = 0;
            this.searchconnection.Text = "Verbindung Suchen";
            this.searchconnection.UseVisualStyleBackColor = true;
            this.searchconnection.Click += new System.EventHandler(this.searchconnection_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Abfahrtsort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zielort";
            // 
            // departure
            // 
            this.departure.FormattingEnabled = true;
            this.departure.Location = new System.Drawing.Point(129, 33);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(182, 21);
            this.departure.TabIndex = 6;
            this.departure.TextUpdate += new System.EventHandler(this.departure_TextUpdate);
            this.departure.MouseClick += new System.Windows.Forms.MouseEventHandler(this.departure_MouseClick);
            // 
            // destination
            // 
            this.destination.FormattingEnabled = true;
            this.destination.Location = new System.Drawing.Point(129, 79);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(182, 21);
            this.destination.TabIndex = 7;
            this.destination.TextUpdate += new System.EventHandler(this.destination_TextUpdate);
            this.destination.MouseClick += new System.Windows.Forms.MouseEventHandler(this.destination_MouseClick);
            // 
            // connectionlist
            // 
            this.connectionlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dep,
            this.des,
            this.deptime,
            this.destime});
            this.connectionlist.Location = new System.Drawing.Point(46, 146);
            this.connectionlist.Name = "connectionlist";
            this.connectionlist.Size = new System.Drawing.Size(545, 223);
            this.connectionlist.TabIndex = 8;
            this.connectionlist.UseCompatibleStateImageBehavior = false;
            this.connectionlist.View = System.Windows.Forms.View.Details;
            // 
            // dep
            // 
            this.dep.Text = "Von";
            this.dep.Width = 100;
            // 
            // des
            // 
            this.des.Text = "Nach";
            this.des.Width = 100;
            // 
            // deptime
            // 
            this.deptime.Text = "Abfahrtszeit";
            this.deptime.Width = 170;
            // 
            // destime
            // 
            this.destime.Text = "Ankunftszeit";
            this.destime.Width = 170;
            // 
            // alldep
            // 
            this.alldep.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.alldep.Location = new System.Drawing.Point(477, 51);
            this.alldep.Name = "alldep";
            this.alldep.Size = new System.Drawing.Size(114, 35);
            this.alldep.TabIndex = 9;
            this.alldep.Text = "Alle Verbindungen suchen ab";
            this.alldep.UseVisualStyleBackColor = true;
            this.alldep.Click += new System.EventHandler(this.alldep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 411);
            this.Controls.Add(this.alldep);
            this.Controls.Add(this.connectionlist);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchconnection);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ColumnHeader dep;
        private System.Windows.Forms.ColumnHeader des;
        private System.Windows.Forms.ColumnHeader deptime;
        private System.Windows.Forms.ColumnHeader destime;
        private System.Windows.Forms.Button alldep;
    }
}


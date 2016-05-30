using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport_Abfragen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Verbindung zwischen den beiden Stationen suchen
        private void searchconnection_Click_1(object sender, EventArgs e)
        {
            connectionlist.Clear();

            connectionlist.Columns.Add("From", 100, HorizontalAlignment.Left);
            connectionlist.Columns.Add("To", 100, HorizontalAlignment.Left);
            connectionlist.Columns.Add("Plattform", 60, HorizontalAlignment.Left);
            connectionlist.Columns.Add("Departure", 140, HorizontalAlignment.Left);
            connectionlist.Columns.Add("Arrival", 140, HorizontalAlignment.Left);
            connectionlist.Columns.Add("Duration", 100, HorizontalAlignment.Left);

            Transport connection = new Transport();
            Connections connections = new Connections();
            
            //Verbindung holen
            connections = connection.GetConnections(departure.Text, destination.Text);



            foreach (var con in connections.ConnectionList)
            {
                //Zeitformat anpassen
                DateTime convertedDateDep = DateTime.Parse(con.From.Departure);
                DateTime convertedDateArr = DateTime.Parse(con.To.Arrival);

                //Liste mit Verbindungen erstellen und Verbindungen adden
                ListViewItem lvlist = new ListViewItem(con.From.Station.Name);
                lvlist.SubItems.Add(con.To.Station.Name);
                lvlist.SubItems.Add(con.From.Platform);
                lvlist.SubItems.Add(convertedDateDep.ToString());
                lvlist.SubItems.Add(convertedDateArr.ToString());
                lvlist.SubItems.Add(con.Duration);
                connectionlist.Items.Add(lvlist);
            }
            
        }

        //Stations vorschläge holen und in Dropdown adden
        private void departure_TextUpdate(object sender, EventArgs e)
        {
            departure.Items.Clear();

            departure.Select(departure.Text.Length, departure.Text.Length);

            Stations from = new Stations();
            Stations to = new Stations();
            Transport transport = new Transport();

            //Stationen suchen
            from = transport.GetStations(departure.Text);

            //Stationen in droppdown adden
            foreach (Station hold in from.StationList)
            {
                departure.Items.Add(hold.Name);
            }
        }

        //Stations vorschläge holen und in Dropdown adden
        private void destination_TextUpdate(object sender, EventArgs e)
        {
            destination.Items.Clear();

            destination.Select(destination.Text.Length, destination.Text.Length);

            Stations from = new Stations();
            Stations to = new Stations();
            Transport transport = new Transport();
            
            //Stationen suchen
            from = transport.GetStations(destination.Text);

            //Stationen in droppdown adden
            foreach (Station hold in from.StationList)
            {
                destination.Items.Add(hold.Name);
            }
        }

        //Dropdown auf dem Felder aktivieren beim Reinklicken
        private void destination_MouseClick(object sender, MouseEventArgs e)
        {
            destination.DroppedDown = true;
        }

        //Dropdown auf dem Felder aktivieren beim Reinklicken
        private void departure_MouseClick(object sender, MouseEventArgs e)
        {
            departure.DroppedDown = true;
        }

        //Station board laden und anzeigen für Abfahrtsort
        private void alldep_Click(object sender, EventArgs e)
        {
            connectionlist.Clear();

            //Spalten in der Liste erstellen
            connectionlist.Columns.Add("", 50, HorizontalAlignment.Left);
            connectionlist.Columns.Add("Name", 60, HorizontalAlignment.Left);
            connectionlist.Columns.Add("To", 130, HorizontalAlignment.Left);
            connectionlist.Columns.Add("Departure", 130, HorizontalAlignment.Left);

            Transport connection = new Transport();
            Connections connections = new Connections();

            //Auf leeres Feld prüfen
            if (departure.Text != "")
            {
                                string id = connection.GetStations(departure.Text).StationList.First().Id;
                // 1. Alle Stationen werden geladen, Parameter wird Text von Combobox mitgegeben.
                // 2. Von der Rückgabe Liste, wird das erste Element ausgewählt.
                // 3. Von diesem Element wird die ID ausgeleden.

                //Mithilfe vom Text in der Combobox und der ID werden alle Verbindungen geholt. 
                StationBoardRoot stationboard = connection.GetStationBoard(departure.Text, id);

                int temp = 1;

                foreach (var board in stationboard.Entries)
                {
                    //Jedes Item wird der Liste hinzugefügt. 
                    ListViewItem lvlist = new ListViewItem(temp.ToString());
                    lvlist.SubItems.Add(board.Name);
                    lvlist.SubItems.Add(board.To);
                    lvlist.SubItems.Add(board.Stop.Departure.ToString());
                    connectionlist.Items.Add(lvlist);

                    temp++;
                }
            }
            else
            {
                MessageBox.Show("Das Feld darf nicht leer sein!");
            }
            
        }

        //Station board laden und anzeigen für Ankunftsort
        private void alldep2_Click(object sender, EventArgs e)
        {
            connectionlist.Clear();

            //Spalten in der Liste erstellen
            connectionlist.Columns.Add("", 50, HorizontalAlignment.Left);
            connectionlist.Columns.Add("Name", 60, HorizontalAlignment.Left);
            connectionlist.Columns.Add("To", 130, HorizontalAlignment.Left);
            connectionlist.Columns.Add("Departure", 130, HorizontalAlignment.Left);

            Transport connection = new Transport();
            Connections connections = new Connections();

            //Auf leeres Feld prüfen
            if (destination.Text != "")
            {      
                string id = connection.GetStations(destination.Text).StationList.First().Id;
                // 1. Alle Stationen werden geladen, Parameter wird Text von Combobox mitgegeben.
                // 2. Von der Rückgabe Liste, wird das erste Element ausgewählt.
                // 3. Von diesem Element wird die ID ausgeleden.

                //Mithilfe vom Text in der Combobox und der ID werden alle Verbindungen geholt. 
                StationBoardRoot stationboard = connection.GetStationBoard(departure.Text, id);

                int temp = 1;

                foreach (var board in stationboard.Entries)
                {
                    //Jedes Item wird der Liste hinzugefügt.
                    ListViewItem lvlist = new ListViewItem(temp.ToString());
                    lvlist.SubItems.Add(board.Name);
                    lvlist.SubItems.Add(board.To);
                    lvlist.SubItems.Add(board.Stop.Departure.ToString());
                    connectionlist.Items.Add(lvlist);

                temp++;
                }
            }
            else
            {
                MessageBox.Show("Das Feld darf nicht leer sein!");
            }
        }

        //Abfahrts- und Ankunftsort vertauschen
        private void changedirection_Click(object sender, EventArgs e)
        {
            string temp = departure.Text;
            departure.Text = destination.Text;
            destination.Text = temp;

            destination.Items.Clear();
            departure.Items.Clear();
        }
    }
}

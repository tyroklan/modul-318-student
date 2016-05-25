﻿using SwissTransport;
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

        private void searchconnection_Click_1(object sender, EventArgs e)
        {
            Transport connection = new Transport();
            Connections connections = new Connections();
            

            connections = connection.GetConnections(departure.Text, destination.Text);



            foreach (var con in connections.ConnectionList)
            {
                DateTime convertedDateDep = DateTime.Parse(con.From.Departure);
                DateTime convertedDateArr = DateTime.Parse(con.To.Arrival);

                ListViewItem lvlist = new ListViewItem(con.From.Station.Name);
                lvlist.SubItems.Add(con.To.Station.Name);
                lvlist.SubItems.Add(convertedDateDep.ToString());
                lvlist.SubItems.Add(convertedDateArr.ToString());
                connectionlist.Items.Add(lvlist);
            }
            
        }

        private void departure_TextUpdate(object sender, EventArgs e)
        {
            departure.Items.Clear();

            departure.Select(departure.Text.Length, departure.Text.Length);

            Stations from = new Stations();
            Stations to = new Stations();
            Transport transport = new Transport();

            from = transport.GetStations(departure.Text);

            foreach (Station hold in from.StationList)
            {
                departure.Items.Add(hold.Name);
            }
        }

        private void destination_TextUpdate(object sender, EventArgs e)
        {
            destination.Items.Clear();

            destination.Select(destination.Text.Length, destination.Text.Length);

            Stations from = new Stations();
            Stations to = new Stations();
            Transport transport = new Transport();

            from = transport.GetStations(destination.Text);

            foreach (Station hold in from.StationList)
            {
                destination.Items.Add(hold.Name);
            }
        }

        private void destination_MouseClick(object sender, MouseEventArgs e)
        {
            destination.DroppedDown = true;
        }

        private void departure_MouseClick(object sender, MouseEventArgs e)
        {
            departure.DroppedDown = true;
        }

        private void alldep_Click(object sender, EventArgs e)
        {
            Transport connection = new Transport();
            Connections connections = new Connections();

            string id = connection.GetStations(departure.Text).StationList.First().Id;
            // 1. Alle Stationen werden geladen, Parameter wird Text von Combobox mitgegeben.
            // 2. Von der Rückgabe Liste, wird das erste Element ausgewählt.
            // 3. Von diesem Element wird die ID ausgeleden.

            StationBoardRoot stationboard = connection.GetStationBoard(departure.Text, id);

            foreach (var board in stationboard.ToString())
            {
                //Korriegieren
                ListViewItem lvlist = new ListViewItem(stationboard.ToString());
                connectionlist.Items.Add(lvlist);
            }
            
        }
    }
}

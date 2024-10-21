using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipal_Issue_Tracker
{
    public partial class LocalEventsAndAnnouncements : Form
    {
        private List<Event> events = new List<Event>();
        public LocalEventsAndAnnouncements()
        {
            InitializeComponent();
            InitializeEvents(); // Populate the events list
            DisplayEvents(events);
        }

        private void LocalEventsAndAnnouncements_Load(object sender, EventArgs e)
        {

        }
        private void InitializeEvents()
        {
            // Add sample events to the list (you can later fetch real events from a database)
            events.Add(new Event("Music Concert", "Music", DateTime.Now.AddDays(2)));
            events.Add(new Event("Art Exhibition", "Art", DateTime.Now.AddDays(5)));
            events.Add(new Event("Tech Conference", "Technology", DateTime.Now.AddDays(7)));
            events.Add(new Event("Food Festival", "Food", DateTime.Now.AddDays(3)));
            // Add more events as necessary...
        }
        private void DisplayEvents(List<Event> eventsToDisplay)
        {
            // Clear previous controls
            flowLayoutPanelEvents.Controls.Clear();

            // Dynamically create and add controls for each event
            foreach (var ev in eventsToDisplay)
            {
                Panel eventPanel = new Panel
                {
                    Width = 300,
                    Height = 150,
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label eventName = new Label
                {
                    Text = ev.Name,
                    Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold),
                    Dock = DockStyle.Top,
                    Height = 30
                };

                Label eventCategory = new Label
                {
                    Text = $"Category: {ev.Category}",
                    Dock = DockStyle.Top,
                    Height = 25
                };

                Label eventDate = new Label
                {
                    Text = $"Date: {ev.Date.ToShortDateString()}",
                    Dock = DockStyle.Top,
                    Height = 25
                };

                eventPanel.Controls.Add(eventDate);
                eventPanel.Controls.Add(eventCategory);
                eventPanel.Controls.Add(eventName);

                flowLayoutPanelEvents.Controls.Add(eventPanel);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {

            string category = comboBoxCategory.SelectedItem?.ToString() ?? string.Empty;
            DateTime selectedDate = dateTimePickerEventDate.Value.Date;

            // Search events based on category and date
            var filteredEvents = events.Where(ev =>
                (string.IsNullOrEmpty(category) || ev.Category == category) &&
                (ev.Date.Date == selectedDate || selectedDate == DateTime.MinValue)).ToList();

            DisplayEvents(filteredEvents);
        }
    }
}

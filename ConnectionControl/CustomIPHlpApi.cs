using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IpHlpApidotnet;

using ConnectionControl.CommonTypes;

namespace ConnectionControl
{
    class CustomIPHlpApi : TCPUDPConnections
    {
        public CustomIPHlpApi()
        {
            // Prevent auto refresh connections list
            this.StopAutoRefresh();
            // Refresh dead connections without delay
            this.DeadConnsMultiplier = 1;
        }

        public FullTableContent GetIPTableContent()
        {
            var table_content = new FullTableContent();

            // Variables for connection parameters
            var protocols = new List<string>();
            var states = new List<string>();
            var local_addresses = new List<string>();
            var local_ip_addresses = new List<string>();
            var remote_addresses = new List<string>();
            var remote_ip_addresses = new List<string>();
            var pids = new List<string>();
            var processes_names = new List<string>();
            var was_active_at = new List<string>();

            // Get connection parameters
            foreach (var connect in this)
            {
                protocols.Add(connect.Protocol.ToString());
                states.Add(connect.State);
                local_addresses.Add(connect.TryGetLocalAddress());
                local_ip_addresses.Add(connect.Local.ToString());
                remote_addresses.Add(connect.TryGetRemoteAddress());
                remote_ip_addresses.Add(connect.Remote.Address.ToString());
                pids.Add(connect.PID.ToString());
                processes_names.Add(connect.ProcessName);
                was_active_at.Add(connect.WasActiveAt.ToString());
            }
            // Create enumerate for records
            var record_numbers = Enumerable.Range(1, states.Count).Select(i => i.ToString()).ToArray();

            // Add column with numbers
            table_content.Add("№", record_numbers);

            // Pass all conection information into dictionary
            table_content.Add("Protocol", protocols.ToArray());
            table_content.Add("State", states.ToArray());
            table_content.Add("Local IP addresses", local_ip_addresses.ToArray());
            table_content.Add("Local addresses", local_addresses.ToArray());
            table_content.Add("Remote IP address", remote_ip_addresses.ToArray());
            table_content.Add("Remote addresses", remote_addresses.ToArray());
            table_content.Add("PID", pids.ToArray());
            table_content.Add("Process name", processes_names.ToArray());
            table_content.Add("Was active at", was_active_at.ToArray());

            return table_content;
        }
    }
}
// UpdateNetworkThrottleReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:23.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region UpdateNetworkThrottleReply
    public class UpdateNetworkThrottleReply: IFragment
    {
        #region members
        //      C# -> System.Int32? ArchivalThrottlePort
        // GraphQL -> archivalThrottlePort: Int (scalar)
        [JsonProperty("archivalThrottlePort")]
        public System.Int32? ArchivalThrottlePort { get; set; }

        //      C# -> System.Single? DefaultThrottleLimit
        // GraphQL -> defaultThrottleLimit: Float (scalar)
        [JsonProperty("defaultThrottleLimit")]
        public System.Single? DefaultThrottleLimit { get; set; }

        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> System.String? NetworkInterface
        // GraphQL -> networkInterface: String (scalar)
        [JsonProperty("networkInterface")]
        public System.String? NetworkInterface { get; set; }

        //      C# -> List<NetworkThrottleScheduleSummary>? ScheduledThrottles
        // GraphQL -> scheduledThrottles: [NetworkThrottleScheduleSummary!]! (type)
        [JsonProperty("scheduledThrottles")]
        public List<NetworkThrottleScheduleSummary>? ScheduledThrottles { get; set; }

        //      C# -> NetworkThrottleResourceId? ResourceId
        // GraphQL -> resourceId: NetworkThrottleResourceId! (enum)
        [JsonProperty("resourceId")]
        public NetworkThrottleResourceId? ResourceId { get; set; }

        #endregion

    #region methods

    public UpdateNetworkThrottleReply Set(
        System.Int32? ArchivalThrottlePort = null,
        System.Single? DefaultThrottleLimit = null,
        System.Boolean? IsEnabled = null,
        System.String? NetworkInterface = null,
        List<NetworkThrottleScheduleSummary>? ScheduledThrottles = null,
        NetworkThrottleResourceId? ResourceId = null
    ) 
    {
        if ( ArchivalThrottlePort != null ) {
            this.ArchivalThrottlePort = ArchivalThrottlePort;
        }
        if ( DefaultThrottleLimit != null ) {
            this.DefaultThrottleLimit = DefaultThrottleLimit;
        }
        if ( IsEnabled != null ) {
            this.IsEnabled = IsEnabled;
        }
        if ( NetworkInterface != null ) {
            this.NetworkInterface = NetworkInterface;
        }
        if ( ScheduledThrottles != null ) {
            this.ScheduledThrottles = ScheduledThrottles;
        }
        if ( ResourceId != null ) {
            this.ResourceId = ResourceId;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int32? ArchivalThrottlePort
            // GraphQL -> archivalThrottlePort: Int (scalar)
            if (this.ArchivalThrottlePort != null)
            {
                 s += ind + "archivalThrottlePort\n";

            }
            //      C# -> System.Single? DefaultThrottleLimit
            // GraphQL -> defaultThrottleLimit: Float (scalar)
            if (this.DefaultThrottleLimit != null)
            {
                 s += ind + "defaultThrottleLimit\n";

            }
            //      C# -> System.Boolean? IsEnabled
            // GraphQL -> isEnabled: Boolean! (scalar)
            if (this.IsEnabled != null)
            {
                 s += ind + "isEnabled\n";

            }
            //      C# -> System.String? NetworkInterface
            // GraphQL -> networkInterface: String (scalar)
            if (this.NetworkInterface != null)
            {
                 s += ind + "networkInterface\n";

            }
            //      C# -> List<NetworkThrottleScheduleSummary>? ScheduledThrottles
            // GraphQL -> scheduledThrottles: [NetworkThrottleScheduleSummary!]! (type)
            if (this.ScheduledThrottles != null)
            {
                 s += ind + "scheduledThrottles\n";

                 s += ind + "{\n" + 
                 this.ScheduledThrottles.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> NetworkThrottleResourceId? ResourceId
            // GraphQL -> resourceId: NetworkThrottleResourceId! (enum)
            if (this.ResourceId != null)
            {
                 s += ind + "resourceId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? ArchivalThrottlePort
            // GraphQL -> archivalThrottlePort: Int (scalar)
            if (this.ArchivalThrottlePort == null && Exploration.Includes(parent + ".archivalThrottlePort$"))
            {
                this.ArchivalThrottlePort = new System.Int32();
            }
            //      C# -> System.Single? DefaultThrottleLimit
            // GraphQL -> defaultThrottleLimit: Float (scalar)
            if (this.DefaultThrottleLimit == null && Exploration.Includes(parent + ".defaultThrottleLimit$"))
            {
                this.DefaultThrottleLimit = new System.Single();
            }
            //      C# -> System.Boolean? IsEnabled
            // GraphQL -> isEnabled: Boolean! (scalar)
            if (this.IsEnabled == null && Exploration.Includes(parent + ".isEnabled$"))
            {
                this.IsEnabled = new System.Boolean();
            }
            //      C# -> System.String? NetworkInterface
            // GraphQL -> networkInterface: String (scalar)
            if (this.NetworkInterface == null && Exploration.Includes(parent + ".networkInterface$"))
            {
                this.NetworkInterface = new System.String("FETCH");
            }
            //      C# -> List<NetworkThrottleScheduleSummary>? ScheduledThrottles
            // GraphQL -> scheduledThrottles: [NetworkThrottleScheduleSummary!]! (type)
            if (this.ScheduledThrottles == null && Exploration.Includes(parent + ".scheduledThrottles"))
            {
                this.ScheduledThrottles = new List<NetworkThrottleScheduleSummary>();
                this.ScheduledThrottles.ApplyExploratoryFragment(parent + ".scheduledThrottles");
            }
            //      C# -> NetworkThrottleResourceId? ResourceId
            // GraphQL -> resourceId: NetworkThrottleResourceId! (enum)
            if (this.ResourceId == null && Exploration.Includes(parent + ".resourceId$"))
            {
                this.ResourceId = new NetworkThrottleResourceId();
            }
        }


    #endregion

    } // class UpdateNetworkThrottleReply
    #endregion

    public static class ListUpdateNetworkThrottleReplyExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<UpdateNetworkThrottleReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpdateNetworkThrottleReply> list, 
            String parent = "")
        {
            var item = new UpdateNetworkThrottleReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
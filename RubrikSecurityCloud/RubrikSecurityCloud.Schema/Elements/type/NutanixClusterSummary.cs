// NutanixClusterSummary.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
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
    #region NutanixClusterSummary
    public class NutanixClusterSummary: IFragment
    {
        #region members
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        [JsonProperty("naturalId")]
        public System.String? NaturalId { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        [JsonProperty("connectionStatus")]
        public RefreshableObjectConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        [JsonProperty("pendingSlaDomain")]
        public ManagedObjectPendingSlaInfo? PendingSlaDomain { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }

        #endregion

    #region methods

    public NutanixClusterSummary Set(
        System.String? Hostname = null,
        System.String? NaturalId = null,
        System.String? Username = null,
        RefreshableObjectConnectionStatus? ConnectionStatus = null,
        ManagedObjectPendingSlaInfo? PendingSlaDomain = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( NaturalId != null ) {
            this.NaturalId = NaturalId;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( PendingSlaDomain != null ) {
            this.PendingSlaDomain = PendingSlaDomain;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
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
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String! (scalar)
            if (this.Hostname != null)
            {
                 s += ind + "hostname\n";

            }
            //      C# -> System.String? NaturalId
            // GraphQL -> naturalId: String! (scalar)
            if (this.NaturalId != null)
            {
                 s += ind + "naturalId\n";

            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username != null)
            {
                 s += ind + "username\n";

            }
            //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
            if (this.ConnectionStatus != null)
            {
                 s += ind + "connectionStatus\n";

                 s += ind + "{\n" + 
                 this.ConnectionStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
            // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
            if (this.PendingSlaDomain != null)
            {
                 s += ind + "pendingSlaDomain\n";

                 s += ind + "{\n" + 
                 this.PendingSlaDomain.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SlaAssignable? SlaAssignable
            // GraphQL -> slaAssignable: SlaAssignable (type)
            if (this.SlaAssignable != null)
            {
                 s += ind + "slaAssignable\n";

                 s += ind + "{\n" + 
                 this.SlaAssignable.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String! (scalar)
            if (this.Hostname == null && Exploration.Includes(parent + ".hostname$"))
            {
                this.Hostname = new System.String("FETCH");
            }
            //      C# -> System.String? NaturalId
            // GraphQL -> naturalId: String! (scalar)
            if (this.NaturalId == null && Exploration.Includes(parent + ".naturalId$"))
            {
                this.NaturalId = new System.String("FETCH");
            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username == null && Exploration.Includes(parent + ".username$"))
            {
                this.Username = new System.String("FETCH");
            }
            //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
            if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus"))
            {
                this.ConnectionStatus = new RefreshableObjectConnectionStatus();
                this.ConnectionStatus.ApplyExploratoryFragment(parent + ".connectionStatus");
            }
            //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
            // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
            if (this.PendingSlaDomain == null && Exploration.Includes(parent + ".pendingSlaDomain"))
            {
                this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
                this.PendingSlaDomain.ApplyExploratoryFragment(parent + ".pendingSlaDomain");
            }
            //      C# -> SlaAssignable? SlaAssignable
            // GraphQL -> slaAssignable: SlaAssignable (type)
            if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
            {
                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFragment(parent + ".slaAssignable");
            }
        }


    #endregion

    } // class NutanixClusterSummary
    #endregion

    public static class ListNutanixClusterSummaryExtensions
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
            this List<NutanixClusterSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NutanixClusterSummary> list, 
            String parent = "")
        {
            var item = new NutanixClusterSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
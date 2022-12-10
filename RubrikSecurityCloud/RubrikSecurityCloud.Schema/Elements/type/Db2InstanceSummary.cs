// Db2InstanceSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:24.
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
    #region Db2InstanceSummary
    public class Db2InstanceSummary: IFragment
    {
        #region members
        //      C# -> List<System.String>? DatabaseIds
        // GraphQL -> databaseIds: [String!]! (scalar)
        [JsonProperty("databaseIds")]
        public List<System.String>? DatabaseIds { get; set; }

        //      C# -> List<System.String>? HadrDatabaseIds
        // GraphQL -> hadrDatabaseIds: [String!]! (scalar)
        [JsonProperty("hadrDatabaseIds")]
        public List<System.String>? HadrDatabaseIds { get; set; }

        //      C# -> List<System.String>? HostIds
        // GraphQL -> hostIds: [String!]! (scalar)
        [JsonProperty("hostIds")]
        public List<System.String>? HostIds { get; set; }

        //      C# -> List<System.String>? HostNames
        // GraphQL -> hostNames: [String!]! (scalar)
        [JsonProperty("hostNames")]
        public List<System.String>? HostNames { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.String? LastRefreshTime
        // GraphQL -> lastRefreshTime: String! (scalar)
        [JsonProperty("lastRefreshTime")]
        public System.String? LastRefreshTime { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: String! (scalar)
        [JsonProperty("primaryClusterUuid")]
        public System.String? PrimaryClusterUuid { get; set; }

        //      C# -> System.String? ProtectionDate
        // GraphQL -> protectionDate: String! (scalar)
        [JsonProperty("protectionDate")]
        public System.String? ProtectionDate { get; set; }

        //      C# -> List<System.String>? RelicDatabaseIds
        // GraphQL -> relicDatabaseIds: [String!]! (scalar)
        [JsonProperty("relicDatabaseIds")]
        public List<System.String>? RelicDatabaseIds { get; set; }

        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        [JsonProperty("slaDomainId")]
        public System.String? SlaDomainId { get; set; }

        //      C# -> System.String? SlaType
        // GraphQL -> slaType: String! (scalar)
        [JsonProperty("slaType")]
        public System.String? SlaType { get; set; }

        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        [JsonProperty("statusMessage")]
        public System.String? StatusMessage { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> Db2InstanceSummaryStatus? Status
        // GraphQL -> status: Db2InstanceSummaryStatus! (enum)
        [JsonProperty("status")]
        public Db2InstanceSummaryStatus? Status { get; set; }

        #endregion

    #region methods

    public Db2InstanceSummary Set(
        List<System.String>? DatabaseIds = null,
        List<System.String>? HadrDatabaseIds = null,
        List<System.String>? HostIds = null,
        List<System.String>? HostNames = null,
        System.String? Id = null,
        System.Boolean? IsArchived = null,
        System.String? LastRefreshTime = null,
        System.String? Name = null,
        System.String? PrimaryClusterUuid = null,
        System.String? ProtectionDate = null,
        List<System.String>? RelicDatabaseIds = null,
        System.String? SlaDomainId = null,
        System.String? SlaType = null,
        System.String? StatusMessage = null,
        System.String? Username = null,
        Db2InstanceSummaryStatus? Status = null
    ) 
    {
        if ( DatabaseIds != null ) {
            this.DatabaseIds = DatabaseIds;
        }
        if ( HadrDatabaseIds != null ) {
            this.HadrDatabaseIds = HadrDatabaseIds;
        }
        if ( HostIds != null ) {
            this.HostIds = HostIds;
        }
        if ( HostNames != null ) {
            this.HostNames = HostNames;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( LastRefreshTime != null ) {
            this.LastRefreshTime = LastRefreshTime;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PrimaryClusterUuid != null ) {
            this.PrimaryClusterUuid = PrimaryClusterUuid;
        }
        if ( ProtectionDate != null ) {
            this.ProtectionDate = ProtectionDate;
        }
        if ( RelicDatabaseIds != null ) {
            this.RelicDatabaseIds = RelicDatabaseIds;
        }
        if ( SlaDomainId != null ) {
            this.SlaDomainId = SlaDomainId;
        }
        if ( SlaType != null ) {
            this.SlaType = SlaType;
        }
        if ( StatusMessage != null ) {
            this.StatusMessage = StatusMessage;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> List<System.String>? DatabaseIds
            // GraphQL -> databaseIds: [String!]! (scalar)
            if (this.DatabaseIds != null)
            {
                 s += ind + "databaseIds\n";

            }
            //      C# -> List<System.String>? HadrDatabaseIds
            // GraphQL -> hadrDatabaseIds: [String!]! (scalar)
            if (this.HadrDatabaseIds != null)
            {
                 s += ind + "hadrDatabaseIds\n";

            }
            //      C# -> List<System.String>? HostIds
            // GraphQL -> hostIds: [String!]! (scalar)
            if (this.HostIds != null)
            {
                 s += ind + "hostIds\n";

            }
            //      C# -> List<System.String>? HostNames
            // GraphQL -> hostNames: [String!]! (scalar)
            if (this.HostNames != null)
            {
                 s += ind + "hostNames\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean (scalar)
            if (this.IsArchived != null)
            {
                 s += ind + "isArchived\n";

            }
            //      C# -> System.String? LastRefreshTime
            // GraphQL -> lastRefreshTime: String! (scalar)
            if (this.LastRefreshTime != null)
            {
                 s += ind + "lastRefreshTime\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? PrimaryClusterUuid
            // GraphQL -> primaryClusterUuid: String! (scalar)
            if (this.PrimaryClusterUuid != null)
            {
                 s += ind + "primaryClusterUuid\n";

            }
            //      C# -> System.String? ProtectionDate
            // GraphQL -> protectionDate: String! (scalar)
            if (this.ProtectionDate != null)
            {
                 s += ind + "protectionDate\n";

            }
            //      C# -> List<System.String>? RelicDatabaseIds
            // GraphQL -> relicDatabaseIds: [String!]! (scalar)
            if (this.RelicDatabaseIds != null)
            {
                 s += ind + "relicDatabaseIds\n";

            }
            //      C# -> System.String? SlaDomainId
            // GraphQL -> slaDomainId: String! (scalar)
            if (this.SlaDomainId != null)
            {
                 s += ind + "slaDomainId\n";

            }
            //      C# -> System.String? SlaType
            // GraphQL -> slaType: String! (scalar)
            if (this.SlaType != null)
            {
                 s += ind + "slaType\n";

            }
            //      C# -> System.String? StatusMessage
            // GraphQL -> statusMessage: String! (scalar)
            if (this.StatusMessage != null)
            {
                 s += ind + "statusMessage\n";

            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username != null)
            {
                 s += ind + "username\n";

            }
            //      C# -> Db2InstanceSummaryStatus? Status
            // GraphQL -> status: Db2InstanceSummaryStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? DatabaseIds
            // GraphQL -> databaseIds: [String!]! (scalar)
            if (this.DatabaseIds == null && Exploration.Includes(parent + ".databaseIds$"))
            {
                this.DatabaseIds = new List<System.String>();
            }
            //      C# -> List<System.String>? HadrDatabaseIds
            // GraphQL -> hadrDatabaseIds: [String!]! (scalar)
            if (this.HadrDatabaseIds == null && Exploration.Includes(parent + ".hadrDatabaseIds$"))
            {
                this.HadrDatabaseIds = new List<System.String>();
            }
            //      C# -> List<System.String>? HostIds
            // GraphQL -> hostIds: [String!]! (scalar)
            if (this.HostIds == null && Exploration.Includes(parent + ".hostIds$"))
            {
                this.HostIds = new List<System.String>();
            }
            //      C# -> List<System.String>? HostNames
            // GraphQL -> hostNames: [String!]! (scalar)
            if (this.HostNames == null && Exploration.Includes(parent + ".hostNames$"))
            {
                this.HostNames = new List<System.String>();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean (scalar)
            if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived$"))
            {
                this.IsArchived = new System.Boolean();
            }
            //      C# -> System.String? LastRefreshTime
            // GraphQL -> lastRefreshTime: String! (scalar)
            if (this.LastRefreshTime == null && Exploration.Includes(parent + ".lastRefreshTime$"))
            {
                this.LastRefreshTime = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? PrimaryClusterUuid
            // GraphQL -> primaryClusterUuid: String! (scalar)
            if (this.PrimaryClusterUuid == null && Exploration.Includes(parent + ".primaryClusterUuid$"))
            {
                this.PrimaryClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.String? ProtectionDate
            // GraphQL -> protectionDate: String! (scalar)
            if (this.ProtectionDate == null && Exploration.Includes(parent + ".protectionDate$"))
            {
                this.ProtectionDate = new System.String("FETCH");
            }
            //      C# -> List<System.String>? RelicDatabaseIds
            // GraphQL -> relicDatabaseIds: [String!]! (scalar)
            if (this.RelicDatabaseIds == null && Exploration.Includes(parent + ".relicDatabaseIds$"))
            {
                this.RelicDatabaseIds = new List<System.String>();
            }
            //      C# -> System.String? SlaDomainId
            // GraphQL -> slaDomainId: String! (scalar)
            if (this.SlaDomainId == null && Exploration.Includes(parent + ".slaDomainId$"))
            {
                this.SlaDomainId = new System.String("FETCH");
            }
            //      C# -> System.String? SlaType
            // GraphQL -> slaType: String! (scalar)
            if (this.SlaType == null && Exploration.Includes(parent + ".slaType$"))
            {
                this.SlaType = new System.String("FETCH");
            }
            //      C# -> System.String? StatusMessage
            // GraphQL -> statusMessage: String! (scalar)
            if (this.StatusMessage == null && Exploration.Includes(parent + ".statusMessage$"))
            {
                this.StatusMessage = new System.String("FETCH");
            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username == null && Exploration.Includes(parent + ".username$"))
            {
                this.Username = new System.String("FETCH");
            }
            //      C# -> Db2InstanceSummaryStatus? Status
            // GraphQL -> status: Db2InstanceSummaryStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new Db2InstanceSummaryStatus();
            }
        }


    #endregion

    } // class Db2InstanceSummary
    #endregion

    public static class ListDb2InstanceSummaryExtensions
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
            this List<Db2InstanceSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Db2InstanceSummary> list, 
            String parent = "")
        {
            var item = new Db2InstanceSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
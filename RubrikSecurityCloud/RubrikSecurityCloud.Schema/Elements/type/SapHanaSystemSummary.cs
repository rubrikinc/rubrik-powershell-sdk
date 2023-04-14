// SapHanaSystemSummary.cs
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
    #region SapHanaSystemSummary
    public class SapHanaSystemSummary: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? InstanceNumber
        // GraphQL -> instanceNumber: String! (scalar)
        [JsonProperty("instanceNumber")]
        public System.String? InstanceNumber { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        [JsonProperty("lastRefreshTime")]
        public DateTime? LastRefreshTime { get; set; }

        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        [JsonProperty("numDbs")]
        public System.Int32? NumDbs { get; set; }

        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        [JsonProperty("sid")]
        public System.String? Sid { get; set; }

        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        [JsonProperty("statusMessage")]
        public System.String? StatusMessage { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> List<SapHanaHost>? Hosts
        // GraphQL -> hosts: [SapHanaHost!]! (type)
        [JsonProperty("hosts")]
        public List<SapHanaHost>? Hosts { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }

        //      C# -> SapHanaSslInfo? SslInfo
        // GraphQL -> sslInfo: SapHanaSslInfo (type)
        [JsonProperty("sslInfo")]
        public SapHanaSslInfo? SslInfo { get; set; }

        //      C# -> SapHanaSystemInfo? SystemInfo
        // GraphQL -> systemInfo: SapHanaSystemInfo (type)
        [JsonProperty("systemInfo")]
        public SapHanaSystemInfo? SystemInfo { get; set; }

        //      C# -> SapHanaSystemSummaryContainerType? ContainerType
        // GraphQL -> containerType: SapHanaSystemSummaryContainerType (enum)
        [JsonProperty("containerType")]
        public SapHanaSystemSummaryContainerType? ContainerType { get; set; }

        //      C# -> SapHanaSystemSummaryStatus? Status
        // GraphQL -> status: SapHanaSystemSummaryStatus! (enum)
        [JsonProperty("status")]
        public SapHanaSystemSummaryStatus? Status { get; set; }

        #endregion

    #region methods

    public SapHanaSystemSummary Set(
        System.String? Id = null,
        System.String? InstanceNumber = null,
        System.Boolean? IsArchived = null,
        DateTime? LastRefreshTime = null,
        System.Int32? NumDbs = null,
        System.String? Sid = null,
        System.String? StatusMessage = null,
        System.String? Username = null,
        List<SapHanaHost>? Hosts = null,
        SlaAssignable? SlaAssignable = null,
        SapHanaSslInfo? SslInfo = null,
        SapHanaSystemInfo? SystemInfo = null,
        SapHanaSystemSummaryContainerType? ContainerType = null,
        SapHanaSystemSummaryStatus? Status = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( InstanceNumber != null ) {
            this.InstanceNumber = InstanceNumber;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( LastRefreshTime != null ) {
            this.LastRefreshTime = LastRefreshTime;
        }
        if ( NumDbs != null ) {
            this.NumDbs = NumDbs;
        }
        if ( Sid != null ) {
            this.Sid = Sid;
        }
        if ( StatusMessage != null ) {
            this.StatusMessage = StatusMessage;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( Hosts != null ) {
            this.Hosts = Hosts;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
        }
        if ( SslInfo != null ) {
            this.SslInfo = SslInfo;
        }
        if ( SystemInfo != null ) {
            this.SystemInfo = SystemInfo;
        }
        if ( ContainerType != null ) {
            this.ContainerType = ContainerType;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? InstanceNumber
            // GraphQL -> instanceNumber: String! (scalar)
            if (this.InstanceNumber != null)
            {
                 s += ind + "instanceNumber\n";

            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean (scalar)
            if (this.IsArchived != null)
            {
                 s += ind + "isArchived\n";

            }
            //      C# -> DateTime? LastRefreshTime
            // GraphQL -> lastRefreshTime: DateTime (scalar)
            if (this.LastRefreshTime != null)
            {
                 s += ind + "lastRefreshTime\n";

            }
            //      C# -> System.Int32? NumDbs
            // GraphQL -> numDbs: Int! (scalar)
            if (this.NumDbs != null)
            {
                 s += ind + "numDbs\n";

            }
            //      C# -> System.String? Sid
            // GraphQL -> sid: String! (scalar)
            if (this.Sid != null)
            {
                 s += ind + "sid\n";

            }
            //      C# -> System.String? StatusMessage
            // GraphQL -> statusMessage: String (scalar)
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
            //      C# -> List<SapHanaHost>? Hosts
            // GraphQL -> hosts: [SapHanaHost!]! (type)
            if (this.Hosts != null)
            {
                 s += ind + "hosts\n";

                 s += ind + "{\n" + 
                 this.Hosts.AsFragment(indent+1) + 
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
            //      C# -> SapHanaSslInfo? SslInfo
            // GraphQL -> sslInfo: SapHanaSslInfo (type)
            if (this.SslInfo != null)
            {
                 s += ind + "sslInfo\n";

                 s += ind + "{\n" + 
                 this.SslInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SapHanaSystemInfo? SystemInfo
            // GraphQL -> systemInfo: SapHanaSystemInfo (type)
            if (this.SystemInfo != null)
            {
                 s += ind + "systemInfo\n";

                 s += ind + "{\n" + 
                 this.SystemInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SapHanaSystemSummaryContainerType? ContainerType
            // GraphQL -> containerType: SapHanaSystemSummaryContainerType (enum)
            if (this.ContainerType != null)
            {
                 s += ind + "containerType\n";

            }
            //      C# -> SapHanaSystemSummaryStatus? Status
            // GraphQL -> status: SapHanaSystemSummaryStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? InstanceNumber
            // GraphQL -> instanceNumber: String! (scalar)
            if (this.InstanceNumber == null && Exploration.Includes(parent + ".instanceNumber$"))
            {
                this.InstanceNumber = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean (scalar)
            if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived$"))
            {
                this.IsArchived = new System.Boolean();
            }
            //      C# -> DateTime? LastRefreshTime
            // GraphQL -> lastRefreshTime: DateTime (scalar)
            if (this.LastRefreshTime == null && Exploration.Includes(parent + ".lastRefreshTime$"))
            {
                this.LastRefreshTime = new DateTime();
            }
            //      C# -> System.Int32? NumDbs
            // GraphQL -> numDbs: Int! (scalar)
            if (this.NumDbs == null && Exploration.Includes(parent + ".numDbs$"))
            {
                this.NumDbs = new System.Int32();
            }
            //      C# -> System.String? Sid
            // GraphQL -> sid: String! (scalar)
            if (this.Sid == null && Exploration.Includes(parent + ".sid$"))
            {
                this.Sid = new System.String("FETCH");
            }
            //      C# -> System.String? StatusMessage
            // GraphQL -> statusMessage: String (scalar)
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
            //      C# -> List<SapHanaHost>? Hosts
            // GraphQL -> hosts: [SapHanaHost!]! (type)
            if (this.Hosts == null && Exploration.Includes(parent + ".hosts"))
            {
                this.Hosts = new List<SapHanaHost>();
                this.Hosts.ApplyExploratoryFragment(parent + ".hosts");
            }
            //      C# -> SlaAssignable? SlaAssignable
            // GraphQL -> slaAssignable: SlaAssignable (type)
            if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
            {
                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFragment(parent + ".slaAssignable");
            }
            //      C# -> SapHanaSslInfo? SslInfo
            // GraphQL -> sslInfo: SapHanaSslInfo (type)
            if (this.SslInfo == null && Exploration.Includes(parent + ".sslInfo"))
            {
                this.SslInfo = new SapHanaSslInfo();
                this.SslInfo.ApplyExploratoryFragment(parent + ".sslInfo");
            }
            //      C# -> SapHanaSystemInfo? SystemInfo
            // GraphQL -> systemInfo: SapHanaSystemInfo (type)
            if (this.SystemInfo == null && Exploration.Includes(parent + ".systemInfo"))
            {
                this.SystemInfo = new SapHanaSystemInfo();
                this.SystemInfo.ApplyExploratoryFragment(parent + ".systemInfo");
            }
            //      C# -> SapHanaSystemSummaryContainerType? ContainerType
            // GraphQL -> containerType: SapHanaSystemSummaryContainerType (enum)
            if (this.ContainerType == null && Exploration.Includes(parent + ".containerType$"))
            {
                this.ContainerType = new SapHanaSystemSummaryContainerType();
            }
            //      C# -> SapHanaSystemSummaryStatus? Status
            // GraphQL -> status: SapHanaSystemSummaryStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new SapHanaSystemSummaryStatus();
            }
        }


    #endregion

    } // class SapHanaSystemSummary
    #endregion

    public static class ListSapHanaSystemSummaryExtensions
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
            this List<SapHanaSystemSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SapHanaSystemSummary> list, 
            String parent = "")
        {
            var item = new SapHanaSystemSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
// UpdateNetworkThrottleReply.cs
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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region UpdateNetworkThrottleReply
    public class UpdateNetworkThrottleReply: BaseType
    {
        #region members

        //      C# -> NetworkThrottleResourceId? ResourceId
        // GraphQL -> resourceId: NetworkThrottleResourceId! (enum)
        [JsonProperty("resourceId")]
        public NetworkThrottleResourceId? ResourceId { get; set; }

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


        #endregion

    #region methods

    public UpdateNetworkThrottleReply Set(
        NetworkThrottleResourceId? ResourceId = null,
        System.Int32? ArchivalThrottlePort = null,
        System.Single? DefaultThrottleLimit = null,
        System.Boolean? IsEnabled = null,
        System.String? NetworkInterface = null,
        List<NetworkThrottleScheduleSummary>? ScheduledThrottles = null
    ) 
    {
        if ( ResourceId != null ) {
            this.ResourceId = ResourceId;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> NetworkThrottleResourceId? ResourceId
        // GraphQL -> resourceId: NetworkThrottleResourceId! (enum)
        if (this.ResourceId != null) {
            s += ind + "resourceId\n" ;
        }
        //      C# -> System.Int32? ArchivalThrottlePort
        // GraphQL -> archivalThrottlePort: Int (scalar)
        if (this.ArchivalThrottlePort != null) {
            s += ind + "archivalThrottlePort\n" ;
        }
        //      C# -> System.Single? DefaultThrottleLimit
        // GraphQL -> defaultThrottleLimit: Float (scalar)
        if (this.DefaultThrottleLimit != null) {
            s += ind + "defaultThrottleLimit\n" ;
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled != null) {
            s += ind + "isEnabled\n" ;
        }
        //      C# -> System.String? NetworkInterface
        // GraphQL -> networkInterface: String (scalar)
        if (this.NetworkInterface != null) {
            s += ind + "networkInterface\n" ;
        }
        //      C# -> List<NetworkThrottleScheduleSummary>? ScheduledThrottles
        // GraphQL -> scheduledThrottles: [NetworkThrottleScheduleSummary!]! (type)
        if (this.ScheduledThrottles != null) {
            var fspec = this.ScheduledThrottles.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "scheduledThrottles {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> NetworkThrottleResourceId? ResourceId
        // GraphQL -> resourceId: NetworkThrottleResourceId! (enum)
        if (this.ResourceId == null && Exploration.Includes(parent + ".resourceId", true))
        {
            this.ResourceId = new NetworkThrottleResourceId();
        }
        //      C# -> System.Int32? ArchivalThrottlePort
        // GraphQL -> archivalThrottlePort: Int (scalar)
        if (this.ArchivalThrottlePort == null && Exploration.Includes(parent + ".archivalThrottlePort", true))
        {
            this.ArchivalThrottlePort = Int32.MinValue;
        }
        //      C# -> System.Single? DefaultThrottleLimit
        // GraphQL -> defaultThrottleLimit: Float (scalar)
        if (this.DefaultThrottleLimit == null && Exploration.Includes(parent + ".defaultThrottleLimit", true))
        {
            this.DefaultThrottleLimit = new System.Single();
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled == null && Exploration.Includes(parent + ".isEnabled", true))
        {
            this.IsEnabled = true;
        }
        //      C# -> System.String? NetworkInterface
        // GraphQL -> networkInterface: String (scalar)
        if (this.NetworkInterface == null && Exploration.Includes(parent + ".networkInterface", true))
        {
            this.NetworkInterface = "FETCH";
        }
        //      C# -> List<NetworkThrottleScheduleSummary>? ScheduledThrottles
        // GraphQL -> scheduledThrottles: [NetworkThrottleScheduleSummary!]! (type)
        if (this.ScheduledThrottles == null && Exploration.Includes(parent + ".scheduledThrottles"))
        {
            this.ScheduledThrottles = new List<NetworkThrottleScheduleSummary>();
            this.ScheduledThrottles.ApplyExploratoryFieldSpec(parent + ".scheduledThrottles");
        }
    }


    #endregion

    } // class UpdateNetworkThrottleReply
    
    #endregion

    public static class ListUpdateNetworkThrottleReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<UpdateNetworkThrottleReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateNetworkThrottleReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateNetworkThrottleReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
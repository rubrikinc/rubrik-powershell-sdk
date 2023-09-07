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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region NutanixClusterSummary
    public class NutanixClusterSummary: BaseType
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

    public override string GetGqlTypeName() {
        return "NutanixClusterSummary";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (this.NaturalId != null) {
            s += ind + "naturalId\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            var fspec = this.ConnectionStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "connectionStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain != null) {
            var fspec = this.PendingSlaDomain.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pendingSlaDomain {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            var fspec = this.SlaAssignable.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "slaAssignable {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname == null && ec.Includes("hostname",true))
        {
            this.Hostname = "FETCH";
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (this.NaturalId == null && ec.Includes("naturalId",true))
        {
            this.NaturalId = "FETCH";
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && ec.Includes("username",true))
        {
            this.Username = "FETCH";
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (this.ConnectionStatus == null && ec.Includes("connectionStatus",false))
        {
            this.ConnectionStatus = new RefreshableObjectConnectionStatus();
            this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain == null && ec.Includes("pendingSlaDomain",false))
        {
            this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
            this.PendingSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("pendingSlaDomain"));
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable == null && ec.Includes("slaAssignable",false))
        {
            this.SlaAssignable = new SlaAssignable();
            this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));
        }
    }


    #endregion

    } // class NutanixClusterSummary
    
    #endregion

    public static class ListNutanixClusterSummaryExtensions
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
            this List<NutanixClusterSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NutanixClusterSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixClusterSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<NutanixClusterSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
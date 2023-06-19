// HypervScvmmSummary.cs
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
    #region HypervScvmmSummary
    public class HypervScvmmSummary: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> System.String? RunAsAccount
        // GraphQL -> runAsAccount: String! (scalar)
        [JsonProperty("runAsAccount")]
        public System.String? RunAsAccount { get; set; }

        //      C# -> System.String? ScvmmVersion
        // GraphQL -> scvmmVersion: String (scalar)
        [JsonProperty("scvmmVersion")]
        public System.String? ScvmmVersion { get; set; }

        //      C# -> System.Boolean? ShouldDeployAgent
        // GraphQL -> shouldDeployAgent: Boolean! (scalar)
        [JsonProperty("shouldDeployAgent")]
        public System.Boolean? ShouldDeployAgent { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }


        #endregion

    #region methods

    public HypervScvmmSummary Set(
        System.String? Id = null,
        System.String? PrimaryClusterId = null,
        System.String? RunAsAccount = null,
        System.String? ScvmmVersion = null,
        System.Boolean? ShouldDeployAgent = null,
        System.String? Status = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( RunAsAccount != null ) {
            this.RunAsAccount = RunAsAccount;
        }
        if ( ScvmmVersion != null ) {
            this.ScvmmVersion = ScvmmVersion;
        }
        if ( ShouldDeployAgent != null ) {
            this.ShouldDeployAgent = ShouldDeployAgent;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            s += ind + "primaryClusterId\n" ;
        }
        //      C# -> System.String? RunAsAccount
        // GraphQL -> runAsAccount: String! (scalar)
        if (this.RunAsAccount != null) {
            s += ind + "runAsAccount\n" ;
        }
        //      C# -> System.String? ScvmmVersion
        // GraphQL -> scvmmVersion: String (scalar)
        if (this.ScvmmVersion != null) {
            s += ind + "scvmmVersion\n" ;
        }
        //      C# -> System.Boolean? ShouldDeployAgent
        // GraphQL -> shouldDeployAgent: Boolean! (scalar)
        if (this.ShouldDeployAgent != null) {
            s += ind + "shouldDeployAgent\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId", true))
        {
            this.PrimaryClusterId = "FETCH";
        }
        //      C# -> System.String? RunAsAccount
        // GraphQL -> runAsAccount: String! (scalar)
        if (this.RunAsAccount == null && Exploration.Includes(parent + ".runAsAccount", true))
        {
            this.RunAsAccount = "FETCH";
        }
        //      C# -> System.String? ScvmmVersion
        // GraphQL -> scvmmVersion: String (scalar)
        if (this.ScvmmVersion == null && Exploration.Includes(parent + ".scvmmVersion", true))
        {
            this.ScvmmVersion = "FETCH";
        }
        //      C# -> System.Boolean? ShouldDeployAgent
        // GraphQL -> shouldDeployAgent: Boolean! (scalar)
        if (this.ShouldDeployAgent == null && Exploration.Includes(parent + ".shouldDeployAgent", true))
        {
            this.ShouldDeployAgent = true;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = "FETCH";
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
        {
            this.SlaAssignable = new SlaAssignable();
            this.SlaAssignable.ApplyExploratoryFieldSpec(parent + ".slaAssignable");
        }
    }


    #endregion

    } // class HypervScvmmSummary
    
    #endregion

    public static class ListHypervScvmmSummaryExtensions
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
            this List<HypervScvmmSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HypervScvmmSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervScvmmSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
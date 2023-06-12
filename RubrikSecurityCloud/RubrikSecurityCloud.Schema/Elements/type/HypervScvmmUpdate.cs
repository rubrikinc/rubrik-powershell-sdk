// HypervScvmmUpdate.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region HypervScvmmUpdate
    public class HypervScvmmUpdate: BaseType
    {
        #region members

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? RunAsAccount
        // GraphQL -> runAsAccount: String (scalar)
        [JsonProperty("runAsAccount")]
        public System.String? RunAsAccount { get; set; }

        //      C# -> System.Boolean? ShouldDeployAgent
        // GraphQL -> shouldDeployAgent: Boolean (scalar)
        [JsonProperty("shouldDeployAgent")]
        public System.Boolean? ShouldDeployAgent { get; set; }


        #endregion

    #region methods

    public HypervScvmmUpdate Set(
        System.String? ConfiguredSlaDomainId = null,
        System.String? Hostname = null,
        System.String? RunAsAccount = null,
        System.Boolean? ShouldDeployAgent = null
    ) 
    {
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( RunAsAccount != null ) {
            this.RunAsAccount = RunAsAccount;
        }
        if ( ShouldDeployAgent != null ) {
            this.ShouldDeployAgent = ShouldDeployAgent;
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
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            s += ind + "configuredSlaDomainId\n" ;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.String? RunAsAccount
        // GraphQL -> runAsAccount: String (scalar)
        if (this.RunAsAccount != null) {
            s += ind + "runAsAccount\n" ;
        }
        //      C# -> System.Boolean? ShouldDeployAgent
        // GraphQL -> shouldDeployAgent: Boolean (scalar)
        if (this.ShouldDeployAgent != null) {
            s += ind + "shouldDeployAgent\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (this.ConfiguredSlaDomainId == null && Exploration.Includes(parent + ".configuredSlaDomainId", true))
        {
            this.ConfiguredSlaDomainId = "FETCH";
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        if (this.Hostname == null && Exploration.Includes(parent + ".hostname", true))
        {
            this.Hostname = "FETCH";
        }
        //      C# -> System.String? RunAsAccount
        // GraphQL -> runAsAccount: String (scalar)
        if (this.RunAsAccount == null && Exploration.Includes(parent + ".runAsAccount", true))
        {
            this.RunAsAccount = "FETCH";
        }
        //      C# -> System.Boolean? ShouldDeployAgent
        // GraphQL -> shouldDeployAgent: Boolean (scalar)
        if (this.ShouldDeployAgent == null && Exploration.Includes(parent + ".shouldDeployAgent", true))
        {
            this.ShouldDeployAgent = true;
        }
    }


    #endregion

    } // class HypervScvmmUpdate
    
    #endregion

    public static class ListHypervScvmmUpdateExtensions
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
            this List<HypervScvmmUpdate> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HypervScvmmUpdate> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervScvmmUpdate());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
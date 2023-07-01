// VcdClusterSummary.cs
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
    #region VcdClusterSummary
    public class VcdClusterSummary: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> VcdConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: VcdConnectionStatus (type)
        [JsonProperty("connectionStatus")]
        public VcdConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }

        //      C# -> VcdClusterBaseConfig? VcdClusterBaseConfig
        // GraphQL -> vcdClusterBaseConfig: VcdClusterBaseConfig (type)
        [JsonProperty("vcdClusterBaseConfig")]
        public VcdClusterBaseConfig? VcdClusterBaseConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VcdClusterSummary";
    }

    public VcdClusterSummary Set(
        System.String? Id = null,
        VcdConnectionStatus? ConnectionStatus = null,
        SlaAssignable? SlaAssignable = null,
        VcdClusterBaseConfig? VcdClusterBaseConfig = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
        }
        if ( VcdClusterBaseConfig != null ) {
            this.VcdClusterBaseConfig = VcdClusterBaseConfig;
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
        //      C# -> VcdConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: VcdConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            var fspec = this.ConnectionStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "connectionStatus {\n" + fspec + ind + "}\n" ;
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
        //      C# -> VcdClusterBaseConfig? VcdClusterBaseConfig
        // GraphQL -> vcdClusterBaseConfig: VcdClusterBaseConfig (type)
        if (this.VcdClusterBaseConfig != null) {
            var fspec = this.VcdClusterBaseConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vcdClusterBaseConfig {\n" + fspec + ind + "}\n" ;
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
        //      C# -> VcdConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: VcdConnectionStatus (type)
        if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus"))
        {
            this.ConnectionStatus = new VcdConnectionStatus();
            this.ConnectionStatus.ApplyExploratoryFieldSpec(parent + ".connectionStatus");
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
        {
            this.SlaAssignable = new SlaAssignable();
            this.SlaAssignable.ApplyExploratoryFieldSpec(parent + ".slaAssignable");
        }
        //      C# -> VcdClusterBaseConfig? VcdClusterBaseConfig
        // GraphQL -> vcdClusterBaseConfig: VcdClusterBaseConfig (type)
        if (this.VcdClusterBaseConfig == null && Exploration.Includes(parent + ".vcdClusterBaseConfig"))
        {
            this.VcdClusterBaseConfig = new VcdClusterBaseConfig();
            this.VcdClusterBaseConfig.ApplyExploratoryFieldSpec(parent + ".vcdClusterBaseConfig");
        }
    }


    #endregion

    } // class VcdClusterSummary
    
    #endregion

    public static class ListVcdClusterSummaryExtensions
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
            this List<VcdClusterSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VcdClusterSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VcdClusterSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
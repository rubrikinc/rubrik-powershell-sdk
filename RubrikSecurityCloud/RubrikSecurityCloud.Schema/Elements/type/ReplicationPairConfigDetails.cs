// ReplicationPairConfigDetails.cs
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
    #region ReplicationPairConfigDetails
    public class ReplicationPairConfigDetails: BaseType
    {
        #region members

        //      C# -> System.String? SetupType
        // GraphQL -> setupType: String! (scalar)
        [JsonProperty("setupType")]
        public System.String? SetupType { get; set; }

        //      C# -> GatewayInfo? SourceGateway
        // GraphQL -> sourceGateway: GatewayInfo (type)
        [JsonProperty("sourceGateway")]
        public GatewayInfo? SourceGateway { get; set; }

        //      C# -> GatewayInfo? TargetGateway
        // GraphQL -> targetGateway: GatewayInfo (type)
        [JsonProperty("targetGateway")]
        public GatewayInfo? TargetGateway { get; set; }


        #endregion

    #region methods

    public ReplicationPairConfigDetails Set(
        System.String? SetupType = null,
        GatewayInfo? SourceGateway = null,
        GatewayInfo? TargetGateway = null
    ) 
    {
        if ( SetupType != null ) {
            this.SetupType = SetupType;
        }
        if ( SourceGateway != null ) {
            this.SourceGateway = SourceGateway;
        }
        if ( TargetGateway != null ) {
            this.TargetGateway = TargetGateway;
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
        //      C# -> System.String? SetupType
        // GraphQL -> setupType: String! (scalar)
        if (this.SetupType != null) {
            s += ind + "setupType\n" ;
        }
        //      C# -> GatewayInfo? SourceGateway
        // GraphQL -> sourceGateway: GatewayInfo (type)
        if (this.SourceGateway != null) {
            var fspec = this.SourceGateway.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sourceGateway {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> GatewayInfo? TargetGateway
        // GraphQL -> targetGateway: GatewayInfo (type)
        if (this.TargetGateway != null) {
            var fspec = this.TargetGateway.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetGateway {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? SetupType
        // GraphQL -> setupType: String! (scalar)
        if (this.SetupType == null && Exploration.Includes(parent + ".setupType", true))
        {
            this.SetupType = "FETCH";
        }
        //      C# -> GatewayInfo? SourceGateway
        // GraphQL -> sourceGateway: GatewayInfo (type)
        if (this.SourceGateway == null && Exploration.Includes(parent + ".sourceGateway"))
        {
            this.SourceGateway = new GatewayInfo();
            this.SourceGateway.ApplyExploratoryFieldSpec(parent + ".sourceGateway");
        }
        //      C# -> GatewayInfo? TargetGateway
        // GraphQL -> targetGateway: GatewayInfo (type)
        if (this.TargetGateway == null && Exploration.Includes(parent + ".targetGateway"))
        {
            this.TargetGateway = new GatewayInfo();
            this.TargetGateway.ApplyExploratoryFieldSpec(parent + ".targetGateway");
        }
    }


    #endregion

    } // class ReplicationPairConfigDetails
    
    #endregion

    public static class ListReplicationPairConfigDetailsExtensions
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
            this List<ReplicationPairConfigDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationPairConfigDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationPairConfigDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
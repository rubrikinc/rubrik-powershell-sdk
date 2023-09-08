// NodeKeyRotation.cs
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
    #region NodeKeyRotation
    public class NodeKeyRotation: BaseType
    {
        #region members

        //      C# -> ClusterKeyProtection? KeyType
        // GraphQL -> keyType: ClusterKeyProtection! (enum)
        [JsonProperty("keyType")]
        public ClusterKeyProtection? KeyType { get; set; }

        //      C# -> CdmKeyRotationState? State
        // GraphQL -> state: CdmKeyRotationState! (enum)
        [JsonProperty("state")]
        public CdmKeyRotationState? State { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NodeKeyRotation";
    }

    public NodeKeyRotation Set(
        ClusterKeyProtection? KeyType = null,
        CdmKeyRotationState? State = null,
        DateTime? EndTime = null,
        System.String? NodeId = null,
        DateTime? StartTime = null
    ) 
    {
        if ( KeyType != null ) {
            this.KeyType = KeyType;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
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
        //      C# -> ClusterKeyProtection? KeyType
        // GraphQL -> keyType: ClusterKeyProtection! (enum)
        if (this.KeyType != null) {
            s += ind + "keyType\n" ;
        }
        //      C# -> CdmKeyRotationState? State
        // GraphQL -> state: CdmKeyRotationState! (enum)
        if (this.State != null) {
            s += ind + "state\n" ;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId != null) {
            s += ind + "nodeId\n" ;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ClusterKeyProtection? KeyType
        // GraphQL -> keyType: ClusterKeyProtection! (enum)
        if (this.KeyType == null && ec.Includes("keyType",true))
        {
            this.KeyType = new ClusterKeyProtection();
        }
        //      C# -> CdmKeyRotationState? State
        // GraphQL -> state: CdmKeyRotationState! (enum)
        if (this.State == null && ec.Includes("state",true))
        {
            this.State = new CdmKeyRotationState();
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime == null && ec.Includes("endTime",true))
        {
            this.EndTime = new DateTime();
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId == null && ec.Includes("nodeId",true))
        {
            this.NodeId = "FETCH";
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime == null && ec.Includes("startTime",true))
        {
            this.StartTime = new DateTime();
        }
    }


    #endregion

    } // class NodeKeyRotation
    
    #endregion

    public static class ListNodeKeyRotationExtensions
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
            this List<NodeKeyRotation> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NodeKeyRotation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NodeKeyRotation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<NodeKeyRotation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// ClusterState.cs
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
    #region ClusterState
    public class ClusterState: BaseType
    {
        #region members

        //      C# -> ClusterRemovalState? ClusterRemovalState
        // GraphQL -> clusterRemovalState: ClusterRemovalState! (enum)
        [JsonProperty("clusterRemovalState")]
        public ClusterRemovalState? ClusterRemovalState { get; set; }

        //      C# -> ClusterStatus? ConnectedState
        // GraphQL -> connectedState: ClusterStatus! (enum)
        [JsonProperty("connectedState")]
        public ClusterStatus? ConnectedState { get; set; }

        //      C# -> DateTime? ClusterRemovalCreatedAt
        // GraphQL -> clusterRemovalCreatedAt: DateTime (scalar)
        [JsonProperty("clusterRemovalCreatedAt")]
        public DateTime? ClusterRemovalCreatedAt { get; set; }

        //      C# -> DateTime? ClusterRemovalUpdatedAt
        // GraphQL -> clusterRemovalUpdatedAt: DateTime (scalar)
        [JsonProperty("clusterRemovalUpdatedAt")]
        public DateTime? ClusterRemovalUpdatedAt { get; set; }


        #endregion

    #region methods

    public ClusterState Set(
        ClusterRemovalState? ClusterRemovalState = null,
        ClusterStatus? ConnectedState = null,
        DateTime? ClusterRemovalCreatedAt = null,
        DateTime? ClusterRemovalUpdatedAt = null
    ) 
    {
        if ( ClusterRemovalState != null ) {
            this.ClusterRemovalState = ClusterRemovalState;
        }
        if ( ConnectedState != null ) {
            this.ConnectedState = ConnectedState;
        }
        if ( ClusterRemovalCreatedAt != null ) {
            this.ClusterRemovalCreatedAt = ClusterRemovalCreatedAt;
        }
        if ( ClusterRemovalUpdatedAt != null ) {
            this.ClusterRemovalUpdatedAt = ClusterRemovalUpdatedAt;
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
        //      C# -> ClusterRemovalState? ClusterRemovalState
        // GraphQL -> clusterRemovalState: ClusterRemovalState! (enum)
        if (this.ClusterRemovalState != null) {
            s += ind + "clusterRemovalState\n" ;
        }
        //      C# -> ClusterStatus? ConnectedState
        // GraphQL -> connectedState: ClusterStatus! (enum)
        if (this.ConnectedState != null) {
            s += ind + "connectedState\n" ;
        }
        //      C# -> DateTime? ClusterRemovalCreatedAt
        // GraphQL -> clusterRemovalCreatedAt: DateTime (scalar)
        if (this.ClusterRemovalCreatedAt != null) {
            s += ind + "clusterRemovalCreatedAt\n" ;
        }
        //      C# -> DateTime? ClusterRemovalUpdatedAt
        // GraphQL -> clusterRemovalUpdatedAt: DateTime (scalar)
        if (this.ClusterRemovalUpdatedAt != null) {
            s += ind + "clusterRemovalUpdatedAt\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ClusterRemovalState? ClusterRemovalState
        // GraphQL -> clusterRemovalState: ClusterRemovalState! (enum)
        if (this.ClusterRemovalState == null && Exploration.Includes(parent + ".clusterRemovalState", true))
        {
            this.ClusterRemovalState = new ClusterRemovalState();
        }
        //      C# -> ClusterStatus? ConnectedState
        // GraphQL -> connectedState: ClusterStatus! (enum)
        if (this.ConnectedState == null && Exploration.Includes(parent + ".connectedState", true))
        {
            this.ConnectedState = new ClusterStatus();
        }
        //      C# -> DateTime? ClusterRemovalCreatedAt
        // GraphQL -> clusterRemovalCreatedAt: DateTime (scalar)
        if (this.ClusterRemovalCreatedAt == null && Exploration.Includes(parent + ".clusterRemovalCreatedAt", true))
        {
            this.ClusterRemovalCreatedAt = new DateTime();
        }
        //      C# -> DateTime? ClusterRemovalUpdatedAt
        // GraphQL -> clusterRemovalUpdatedAt: DateTime (scalar)
        if (this.ClusterRemovalUpdatedAt == null && Exploration.Includes(parent + ".clusterRemovalUpdatedAt", true))
        {
            this.ClusterRemovalUpdatedAt = new DateTime();
        }
    }


    #endregion

    } // class ClusterState
    
    #endregion

    public static class ListClusterStateExtensions
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
            this List<ClusterState> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterState> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterState());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
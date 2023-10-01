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

    public override string GetGqlTypeName() {
        return "clusterState";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ClusterRemovalState? ClusterRemovalState
        // GraphQL -> clusterRemovalState: ClusterRemovalState! (enum)
        if (this.ClusterRemovalState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterRemovalState\n" ;
            } else {
                s += ind + "clusterRemovalState\n" ;
            }
        }
        //      C# -> ClusterStatus? ConnectedState
        // GraphQL -> connectedState: ClusterStatus! (enum)
        if (this.ConnectedState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "connectedState\n" ;
            } else {
                s += ind + "connectedState\n" ;
            }
        }
        //      C# -> DateTime? ClusterRemovalCreatedAt
        // GraphQL -> clusterRemovalCreatedAt: DateTime (scalar)
        if (this.ClusterRemovalCreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterRemovalCreatedAt\n" ;
            } else {
                s += ind + "clusterRemovalCreatedAt\n" ;
            }
        }
        //      C# -> DateTime? ClusterRemovalUpdatedAt
        // GraphQL -> clusterRemovalUpdatedAt: DateTime (scalar)
        if (this.ClusterRemovalUpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterRemovalUpdatedAt\n" ;
            } else {
                s += ind + "clusterRemovalUpdatedAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ClusterRemovalState? ClusterRemovalState
        // GraphQL -> clusterRemovalState: ClusterRemovalState! (enum)
        if (ec.Includes("clusterRemovalState",true))
        {
            if(this.ClusterRemovalState == null) {

                this.ClusterRemovalState = new ClusterRemovalState();

            } else {


            }
        }
        else if (this.ClusterRemovalState != null && ec.Excludes("clusterRemovalState",true))
        {
            this.ClusterRemovalState = null;
        }
        //      C# -> ClusterStatus? ConnectedState
        // GraphQL -> connectedState: ClusterStatus! (enum)
        if (ec.Includes("connectedState",true))
        {
            if(this.ConnectedState == null) {

                this.ConnectedState = new ClusterStatus();

            } else {


            }
        }
        else if (this.ConnectedState != null && ec.Excludes("connectedState",true))
        {
            this.ConnectedState = null;
        }
        //      C# -> DateTime? ClusterRemovalCreatedAt
        // GraphQL -> clusterRemovalCreatedAt: DateTime (scalar)
        if (ec.Includes("clusterRemovalCreatedAt",true))
        {
            if(this.ClusterRemovalCreatedAt == null) {

                this.ClusterRemovalCreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.ClusterRemovalCreatedAt != null && ec.Excludes("clusterRemovalCreatedAt",true))
        {
            this.ClusterRemovalCreatedAt = null;
        }
        //      C# -> DateTime? ClusterRemovalUpdatedAt
        // GraphQL -> clusterRemovalUpdatedAt: DateTime (scalar)
        if (ec.Includes("clusterRemovalUpdatedAt",true))
        {
            if(this.ClusterRemovalUpdatedAt == null) {

                this.ClusterRemovalUpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.ClusterRemovalUpdatedAt != null && ec.Excludes("clusterRemovalUpdatedAt",true))
        {
            this.ClusterRemovalUpdatedAt = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ClusterState> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterState> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterState());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterState> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
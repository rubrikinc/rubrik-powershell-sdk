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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ClusterState> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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
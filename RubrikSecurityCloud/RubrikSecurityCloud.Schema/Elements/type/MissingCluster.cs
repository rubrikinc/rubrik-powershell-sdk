// MissingCluster.cs
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
    #region MissingCluster
    public class MissingCluster: BaseType
    {
        #region members

        //      C# -> MissingClusterConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: MissingClusterConnectionStatus! (enum)
        [JsonProperty("connectionStatus")]
        public MissingClusterConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> MissingClusterDisconnectedState? DisconnectedState
        // GraphQL -> disconnectedState: MissingClusterDisconnectedState! (enum)
        [JsonProperty("disconnectedState")]
        public MissingClusterDisconnectedState? DisconnectedState { get; set; }

        //      C# -> System.String? ClusterIp
        // GraphQL -> clusterIp: String! (scalar)
        [JsonProperty("clusterIp")]
        public System.String? ClusterIp { get; set; }

        //      C# -> System.String? ClusterType
        // GraphQL -> clusterType: String! (scalar)
        [JsonProperty("clusterType")]
        public System.String? ClusterType { get; set; }

        //      C# -> System.String? ExclusionReason
        // GraphQL -> exclusionReason: String! (scalar)
        [JsonProperty("exclusionReason")]
        public System.String? ExclusionReason { get; set; }

        //      C# -> System.Boolean? IsExcluded
        // GraphQL -> isExcluded: Boolean! (scalar)
        [JsonProperty("isExcluded")]
        public System.Boolean? IsExcluded { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? Nodes
        // GraphQL -> nodes: [String!]! (scalar)
        [JsonProperty("nodes")]
        public List<System.String>? Nodes { get; set; }

        //      C# -> System.Int32? NumOfNodes
        // GraphQL -> numOfNodes: Int! (scalar)
        [JsonProperty("numOfNodes")]
        public System.Int32? NumOfNodes { get; set; }

        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        [JsonProperty("uuid")]
        public System.String? Uuid { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MissingCluster";
    }

    public MissingCluster Set(
        MissingClusterConnectionStatus? ConnectionStatus = null,
        MissingClusterDisconnectedState? DisconnectedState = null,
        System.String? ClusterIp = null,
        System.String? ClusterType = null,
        System.String? ExclusionReason = null,
        System.Boolean? IsExcluded = null,
        System.String? Name = null,
        List<System.String>? Nodes = null,
        System.Int32? NumOfNodes = null,
        System.String? Uuid = null,
        System.String? Version = null
    ) 
    {
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( DisconnectedState != null ) {
            this.DisconnectedState = DisconnectedState;
        }
        if ( ClusterIp != null ) {
            this.ClusterIp = ClusterIp;
        }
        if ( ClusterType != null ) {
            this.ClusterType = ClusterType;
        }
        if ( ExclusionReason != null ) {
            this.ExclusionReason = ExclusionReason;
        }
        if ( IsExcluded != null ) {
            this.IsExcluded = IsExcluded;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Nodes != null ) {
            this.Nodes = Nodes;
        }
        if ( NumOfNodes != null ) {
            this.NumOfNodes = NumOfNodes;
        }
        if ( Uuid != null ) {
            this.Uuid = Uuid;
        }
        if ( Version != null ) {
            this.Version = Version;
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
        //      C# -> MissingClusterConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: MissingClusterConnectionStatus! (enum)
        if (this.ConnectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "connectionStatus\n" ;
            } else {
                s += ind + "connectionStatus\n" ;
            }
        }
        //      C# -> MissingClusterDisconnectedState? DisconnectedState
        // GraphQL -> disconnectedState: MissingClusterDisconnectedState! (enum)
        if (this.DisconnectedState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "disconnectedState\n" ;
            } else {
                s += ind + "disconnectedState\n" ;
            }
        }
        //      C# -> System.String? ClusterIp
        // GraphQL -> clusterIp: String! (scalar)
        if (this.ClusterIp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterIp\n" ;
            } else {
                s += ind + "clusterIp\n" ;
            }
        }
        //      C# -> System.String? ClusterType
        // GraphQL -> clusterType: String! (scalar)
        if (this.ClusterType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterType\n" ;
            } else {
                s += ind + "clusterType\n" ;
            }
        }
        //      C# -> System.String? ExclusionReason
        // GraphQL -> exclusionReason: String! (scalar)
        if (this.ExclusionReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exclusionReason\n" ;
            } else {
                s += ind + "exclusionReason\n" ;
            }
        }
        //      C# -> System.Boolean? IsExcluded
        // GraphQL -> isExcluded: Boolean! (scalar)
        if (this.IsExcluded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExcluded\n" ;
            } else {
                s += ind + "isExcluded\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> List<System.String>? Nodes
        // GraphQL -> nodes: [String!]! (scalar)
        if (this.Nodes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodes\n" ;
            } else {
                s += ind + "nodes\n" ;
            }
        }
        //      C# -> System.Int32? NumOfNodes
        // GraphQL -> numOfNodes: Int! (scalar)
        if (this.NumOfNodes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numOfNodes\n" ;
            } else {
                s += ind + "numOfNodes\n" ;
            }
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        if (this.Uuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uuid\n" ;
            } else {
                s += ind + "uuid\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MissingClusterConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: MissingClusterConnectionStatus! (enum)
        if (ec.Includes("connectionStatus",true))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new MissingClusterConnectionStatus();

            } else {


            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",true))
        {
            this.ConnectionStatus = null;
        }
        //      C# -> MissingClusterDisconnectedState? DisconnectedState
        // GraphQL -> disconnectedState: MissingClusterDisconnectedState! (enum)
        if (ec.Includes("disconnectedState",true))
        {
            if(this.DisconnectedState == null) {

                this.DisconnectedState = new MissingClusterDisconnectedState();

            } else {


            }
        }
        else if (this.DisconnectedState != null && ec.Excludes("disconnectedState",true))
        {
            this.DisconnectedState = null;
        }
        //      C# -> System.String? ClusterIp
        // GraphQL -> clusterIp: String! (scalar)
        if (ec.Includes("clusterIp",true))
        {
            if(this.ClusterIp == null) {

                this.ClusterIp = "FETCH";

            } else {


            }
        }
        else if (this.ClusterIp != null && ec.Excludes("clusterIp",true))
        {
            this.ClusterIp = null;
        }
        //      C# -> System.String? ClusterType
        // GraphQL -> clusterType: String! (scalar)
        if (ec.Includes("clusterType",true))
        {
            if(this.ClusterType == null) {

                this.ClusterType = "FETCH";

            } else {


            }
        }
        else if (this.ClusterType != null && ec.Excludes("clusterType",true))
        {
            this.ClusterType = null;
        }
        //      C# -> System.String? ExclusionReason
        // GraphQL -> exclusionReason: String! (scalar)
        if (ec.Includes("exclusionReason",true))
        {
            if(this.ExclusionReason == null) {

                this.ExclusionReason = "FETCH";

            } else {


            }
        }
        else if (this.ExclusionReason != null && ec.Excludes("exclusionReason",true))
        {
            this.ExclusionReason = null;
        }
        //      C# -> System.Boolean? IsExcluded
        // GraphQL -> isExcluded: Boolean! (scalar)
        if (ec.Includes("isExcluded",true))
        {
            if(this.IsExcluded == null) {

                this.IsExcluded = true;

            } else {


            }
        }
        else if (this.IsExcluded != null && ec.Excludes("isExcluded",true))
        {
            this.IsExcluded = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> List<System.String>? Nodes
        // GraphQL -> nodes: [String!]! (scalar)
        if (ec.Includes("nodes",true))
        {
            if(this.Nodes == null) {

                this.Nodes = new List<System.String>();

            } else {


            }
        }
        else if (this.Nodes != null && ec.Excludes("nodes",true))
        {
            this.Nodes = null;
        }
        //      C# -> System.Int32? NumOfNodes
        // GraphQL -> numOfNodes: Int! (scalar)
        if (ec.Includes("numOfNodes",true))
        {
            if(this.NumOfNodes == null) {

                this.NumOfNodes = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumOfNodes != null && ec.Excludes("numOfNodes",true))
        {
            this.NumOfNodes = null;
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        if (ec.Includes("uuid",true))
        {
            if(this.Uuid == null) {

                this.Uuid = "FETCH";

            } else {


            }
        }
        else if (this.Uuid != null && ec.Excludes("uuid",true))
        {
            this.Uuid = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
    }


    #endregion

    } // class MissingCluster
    
    #endregion

    public static class ListMissingClusterExtensions
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
            this List<MissingCluster> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MissingCluster> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MissingCluster> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MissingCluster());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MissingCluster> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
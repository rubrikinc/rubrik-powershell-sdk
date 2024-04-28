// ReplicationPair.cs
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
    #region ReplicationPair
    public class ReplicationPair: BaseType
    {
        #region members

        //      C# -> ReplicationPairConnectionStatus? Status
        // GraphQL -> status: ReplicationPairConnectionStatus! (enum)
        [JsonProperty("status")]
        public ReplicationPairConnectionStatus? Status { get; set; }

        //      C# -> System.Int64? FailedTasks
        // GraphQL -> failedTasks: Long (scalar)
        [JsonProperty("failedTasks")]
        public System.Int64? FailedTasks { get; set; }

        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean! (scalar)
        [JsonProperty("isPaused")]
        public System.Boolean? IsPaused { get; set; }

        //      C# -> System.Int64? RunningTasks
        // GraphQL -> runningTasks: Long (scalar)
        [JsonProperty("runningTasks")]
        public System.Int64? RunningTasks { get; set; }

        //      C# -> System.Int64? Storage
        // GraphQL -> storage: Long! (scalar)
        [JsonProperty("storage")]
        public System.Int64? Storage { get; set; }

        //      C# -> ReplicationPairConfigDetails? ConfigDetails
        // GraphQL -> configDetails: ReplicationPairConfigDetails (type)
        [JsonProperty("configDetails")]
        public ReplicationPairConfigDetails? ConfigDetails { get; set; }

        //      C# -> ConnectionStatusDetails? ConnectionDetails
        // GraphQL -> connectionDetails: ConnectionStatusDetails! (type)
        [JsonProperty("connectionDetails")]
        public ConnectionStatusDetails? ConnectionDetails { get; set; }

        //      C# -> NetworkThrottle? NetworkThrottle
        // GraphQL -> networkThrottle: NetworkThrottle (type)
        [JsonProperty("networkThrottle")]
        public NetworkThrottle? NetworkThrottle { get; set; }

        //      C# -> ReplicationCluster? SourceCluster
        // GraphQL -> sourceCluster: ReplicationCluster! (type)
        [JsonProperty("sourceCluster")]
        public ReplicationCluster? SourceCluster { get; set; }

        //      C# -> ReplicationCluster? TargetCluster
        // GraphQL -> targetCluster: ReplicationCluster! (type)
        [JsonProperty("targetCluster")]
        public ReplicationCluster? TargetCluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReplicationPair";
    }

    public ReplicationPair Set(
        ReplicationPairConnectionStatus? Status = null,
        System.Int64? FailedTasks = null,
        System.Boolean? IsPaused = null,
        System.Int64? RunningTasks = null,
        System.Int64? Storage = null,
        ReplicationPairConfigDetails? ConfigDetails = null,
        ConnectionStatusDetails? ConnectionDetails = null,
        NetworkThrottle? NetworkThrottle = null,
        ReplicationCluster? SourceCluster = null,
        ReplicationCluster? TargetCluster = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( FailedTasks != null ) {
            this.FailedTasks = FailedTasks;
        }
        if ( IsPaused != null ) {
            this.IsPaused = IsPaused;
        }
        if ( RunningTasks != null ) {
            this.RunningTasks = RunningTasks;
        }
        if ( Storage != null ) {
            this.Storage = Storage;
        }
        if ( ConfigDetails != null ) {
            this.ConfigDetails = ConfigDetails;
        }
        if ( ConnectionDetails != null ) {
            this.ConnectionDetails = ConnectionDetails;
        }
        if ( NetworkThrottle != null ) {
            this.NetworkThrottle = NetworkThrottle;
        }
        if ( SourceCluster != null ) {
            this.SourceCluster = SourceCluster;
        }
        if ( TargetCluster != null ) {
            this.TargetCluster = TargetCluster;
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
        //      C# -> ReplicationPairConnectionStatus? Status
        // GraphQL -> status: ReplicationPairConnectionStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.Int64? FailedTasks
        // GraphQL -> failedTasks: Long (scalar)
        if (this.FailedTasks != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failedTasks\n" ;
            } else {
                s += ind + "failedTasks\n" ;
            }
        }
        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean! (scalar)
        if (this.IsPaused != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPaused\n" ;
            } else {
                s += ind + "isPaused\n" ;
            }
        }
        //      C# -> System.Int64? RunningTasks
        // GraphQL -> runningTasks: Long (scalar)
        if (this.RunningTasks != null) {
            if (conf.Flat) {
                s += conf.Prefix + "runningTasks\n" ;
            } else {
                s += ind + "runningTasks\n" ;
            }
        }
        //      C# -> System.Int64? Storage
        // GraphQL -> storage: Long! (scalar)
        if (this.Storage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storage\n" ;
            } else {
                s += ind + "storage\n" ;
            }
        }
        //      C# -> ReplicationPairConfigDetails? ConfigDetails
        // GraphQL -> configDetails: ReplicationPairConfigDetails (type)
        if (this.ConfigDetails != null) {
            var fspec = this.ConfigDetails.AsFieldSpec(conf.Child("configDetails"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConnectionStatusDetails? ConnectionDetails
        // GraphQL -> connectionDetails: ConnectionStatusDetails! (type)
        if (this.ConnectionDetails != null) {
            var fspec = this.ConnectionDetails.AsFieldSpec(conf.Child("connectionDetails"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "connectionDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NetworkThrottle? NetworkThrottle
        // GraphQL -> networkThrottle: NetworkThrottle (type)
        if (this.NetworkThrottle != null) {
            var fspec = this.NetworkThrottle.AsFieldSpec(conf.Child("networkThrottle"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "networkThrottle" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ReplicationCluster? SourceCluster
        // GraphQL -> sourceCluster: ReplicationCluster! (type)
        if (this.SourceCluster != null) {
            var fspec = this.SourceCluster.AsFieldSpec(conf.Child("sourceCluster"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceCluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ReplicationCluster? TargetCluster
        // GraphQL -> targetCluster: ReplicationCluster! (type)
        if (this.TargetCluster != null) {
            var fspec = this.TargetCluster.AsFieldSpec(conf.Child("targetCluster"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetCluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ReplicationPairConnectionStatus? Status
        // GraphQL -> status: ReplicationPairConnectionStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ReplicationPairConnectionStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.Int64? FailedTasks
        // GraphQL -> failedTasks: Long (scalar)
        if (ec.Includes("failedTasks",true))
        {
            if(this.FailedTasks == null) {

                this.FailedTasks = new System.Int64();

            } else {


            }
        }
        else if (this.FailedTasks != null && ec.Excludes("failedTasks",true))
        {
            this.FailedTasks = null;
        }
        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean! (scalar)
        if (ec.Includes("isPaused",true))
        {
            if(this.IsPaused == null) {

                this.IsPaused = true;

            } else {


            }
        }
        else if (this.IsPaused != null && ec.Excludes("isPaused",true))
        {
            this.IsPaused = null;
        }
        //      C# -> System.Int64? RunningTasks
        // GraphQL -> runningTasks: Long (scalar)
        if (ec.Includes("runningTasks",true))
        {
            if(this.RunningTasks == null) {

                this.RunningTasks = new System.Int64();

            } else {


            }
        }
        else if (this.RunningTasks != null && ec.Excludes("runningTasks",true))
        {
            this.RunningTasks = null;
        }
        //      C# -> System.Int64? Storage
        // GraphQL -> storage: Long! (scalar)
        if (ec.Includes("storage",true))
        {
            if(this.Storage == null) {

                this.Storage = new System.Int64();

            } else {


            }
        }
        else if (this.Storage != null && ec.Excludes("storage",true))
        {
            this.Storage = null;
        }
        //      C# -> ReplicationPairConfigDetails? ConfigDetails
        // GraphQL -> configDetails: ReplicationPairConfigDetails (type)
        if (ec.Includes("configDetails",false))
        {
            if(this.ConfigDetails == null) {

                this.ConfigDetails = new ReplicationPairConfigDetails();
                this.ConfigDetails.ApplyExploratoryFieldSpec(ec.NewChild("configDetails"));

            } else {

                this.ConfigDetails.ApplyExploratoryFieldSpec(ec.NewChild("configDetails"));

            }
        }
        else if (this.ConfigDetails != null && ec.Excludes("configDetails",false))
        {
            this.ConfigDetails = null;
        }
        //      C# -> ConnectionStatusDetails? ConnectionDetails
        // GraphQL -> connectionDetails: ConnectionStatusDetails! (type)
        if (ec.Includes("connectionDetails",false))
        {
            if(this.ConnectionDetails == null) {

                this.ConnectionDetails = new ConnectionStatusDetails();
                this.ConnectionDetails.ApplyExploratoryFieldSpec(ec.NewChild("connectionDetails"));

            } else {

                this.ConnectionDetails.ApplyExploratoryFieldSpec(ec.NewChild("connectionDetails"));

            }
        }
        else if (this.ConnectionDetails != null && ec.Excludes("connectionDetails",false))
        {
            this.ConnectionDetails = null;
        }
        //      C# -> NetworkThrottle? NetworkThrottle
        // GraphQL -> networkThrottle: NetworkThrottle (type)
        if (ec.Includes("networkThrottle",false))
        {
            if(this.NetworkThrottle == null) {

                this.NetworkThrottle = new NetworkThrottle();
                this.NetworkThrottle.ApplyExploratoryFieldSpec(ec.NewChild("networkThrottle"));

            } else {

                this.NetworkThrottle.ApplyExploratoryFieldSpec(ec.NewChild("networkThrottle"));

            }
        }
        else if (this.NetworkThrottle != null && ec.Excludes("networkThrottle",false))
        {
            this.NetworkThrottle = null;
        }
        //      C# -> ReplicationCluster? SourceCluster
        // GraphQL -> sourceCluster: ReplicationCluster! (type)
        if (ec.Includes("sourceCluster",false))
        {
            if(this.SourceCluster == null) {

                this.SourceCluster = new ReplicationCluster();
                this.SourceCluster.ApplyExploratoryFieldSpec(ec.NewChild("sourceCluster"));

            } else {

                this.SourceCluster.ApplyExploratoryFieldSpec(ec.NewChild("sourceCluster"));

            }
        }
        else if (this.SourceCluster != null && ec.Excludes("sourceCluster",false))
        {
            this.SourceCluster = null;
        }
        //      C# -> ReplicationCluster? TargetCluster
        // GraphQL -> targetCluster: ReplicationCluster! (type)
        if (ec.Includes("targetCluster",false))
        {
            if(this.TargetCluster == null) {

                this.TargetCluster = new ReplicationCluster();
                this.TargetCluster.ApplyExploratoryFieldSpec(ec.NewChild("targetCluster"));

            } else {

                this.TargetCluster.ApplyExploratoryFieldSpec(ec.NewChild("targetCluster"));

            }
        }
        else if (this.TargetCluster != null && ec.Excludes("targetCluster",false))
        {
            this.TargetCluster = null;
        }
    }


    #endregion

    } // class ReplicationPair
    
    #endregion

    public static class ListReplicationPairExtensions
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
            this List<ReplicationPair> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReplicationPair> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationPair> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationPair());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReplicationPair> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
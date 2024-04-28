// VolumeGroupLiveMount.cs
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
    #region VolumeGroupLiveMount
    public class VolumeGroupLiveMount: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        [JsonProperty("isReady")]
        public System.Boolean? IsReady { get; set; }

        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String (scalar)
        [JsonProperty("mountPath")]
        public System.String? MountPath { get; set; }

        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        [JsonProperty("mountRequestId")]
        public System.String? MountRequestId { get; set; }

        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        [JsonProperty("mountTimestamp")]
        public DateTime? MountTimestamp { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NodeCompositeId
        // GraphQL -> nodeCompositeId: String (scalar)
        [JsonProperty("nodeCompositeId")]
        public System.String? NodeCompositeId { get; set; }

        //      C# -> System.String? NodeIp
        // GraphQL -> nodeIp: String (scalar)
        [JsonProperty("nodeIp")]
        public System.String? NodeIp { get; set; }

        //      C# -> System.String? RestoreScriptPath
        // GraphQL -> restoreScriptPath: String (scalar)
        [JsonProperty("restoreScriptPath")]
        public System.String? RestoreScriptPath { get; set; }

        //      C# -> System.String? SmbShareName
        // GraphQL -> smbShareName: String (scalar)
        [JsonProperty("smbShareName")]
        public System.String? SmbShareName { get; set; }

        //      C# -> System.String? SourceVolumeGroupId
        // GraphQL -> sourceVolumeGroupId: String! (scalar)
        [JsonProperty("sourceVolumeGroupId")]
        public System.String? SourceVolumeGroupId { get; set; }

        //      C# -> System.String? TargetHostId
        // GraphQL -> targetHostId: String (scalar)
        [JsonProperty("targetHostId")]
        public System.String? TargetHostId { get; set; }

        //      C# -> System.String? TargetHostName
        // GraphQL -> targetHostName: String (scalar)
        [JsonProperty("targetHostName")]
        public System.String? TargetHostName { get; set; }

        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        [JsonProperty("unmountRequestId")]
        public System.String? UnmountRequestId { get; set; }

        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        [JsonProperty("authorizedOperations")]
        public AuthorizedOperations? AuthorizedOperations { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> List<MountedVolume>? MountedVolumes
        // GraphQL -> mountedVolumes: [MountedVolume!]! (type)
        [JsonProperty("mountedVolumes")]
        public List<MountedVolume>? MountedVolumes { get; set; }

        //      C# -> PhysicalHost? SourceHost
        // GraphQL -> sourceHost: PhysicalHost! (type)
        [JsonProperty("sourceHost")]
        public PhysicalHost? SourceHost { get; set; }

        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        [JsonProperty("sourceSnapshot")]
        public CdmSnapshot? SourceSnapshot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VolumeGroupLiveMount";
    }

    public VolumeGroupLiveMount Set(
        System.String? Id = null,
        System.Boolean? IsReady = null,
        System.String? MountPath = null,
        System.String? MountRequestId = null,
        DateTime? MountTimestamp = null,
        System.String? Name = null,
        System.String? NodeCompositeId = null,
        System.String? NodeIp = null,
        System.String? RestoreScriptPath = null,
        System.String? SmbShareName = null,
        System.String? SourceVolumeGroupId = null,
        System.String? TargetHostId = null,
        System.String? TargetHostName = null,
        System.String? UnmountRequestId = null,
        AuthorizedOperations? AuthorizedOperations = null,
        Cluster? Cluster = null,
        List<MountedVolume>? MountedVolumes = null,
        PhysicalHost? SourceHost = null,
        CdmSnapshot? SourceSnapshot = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsReady != null ) {
            this.IsReady = IsReady;
        }
        if ( MountPath != null ) {
            this.MountPath = MountPath;
        }
        if ( MountRequestId != null ) {
            this.MountRequestId = MountRequestId;
        }
        if ( MountTimestamp != null ) {
            this.MountTimestamp = MountTimestamp;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NodeCompositeId != null ) {
            this.NodeCompositeId = NodeCompositeId;
        }
        if ( NodeIp != null ) {
            this.NodeIp = NodeIp;
        }
        if ( RestoreScriptPath != null ) {
            this.RestoreScriptPath = RestoreScriptPath;
        }
        if ( SmbShareName != null ) {
            this.SmbShareName = SmbShareName;
        }
        if ( SourceVolumeGroupId != null ) {
            this.SourceVolumeGroupId = SourceVolumeGroupId;
        }
        if ( TargetHostId != null ) {
            this.TargetHostId = TargetHostId;
        }
        if ( TargetHostName != null ) {
            this.TargetHostName = TargetHostName;
        }
        if ( UnmountRequestId != null ) {
            this.UnmountRequestId = UnmountRequestId;
        }
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( MountedVolumes != null ) {
            this.MountedVolumes = MountedVolumes;
        }
        if ( SourceHost != null ) {
            this.SourceHost = SourceHost;
        }
        if ( SourceSnapshot != null ) {
            this.SourceSnapshot = SourceSnapshot;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isReady\n" ;
            } else {
                s += ind + "isReady\n" ;
            }
        }
        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String (scalar)
        if (this.MountPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountPath\n" ;
            } else {
                s += ind + "mountPath\n" ;
            }
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        if (this.MountRequestId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountRequestId\n" ;
            } else {
                s += ind + "mountRequestId\n" ;
            }
        }
        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        if (this.MountTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountTimestamp\n" ;
            } else {
                s += ind + "mountTimestamp\n" ;
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
        //      C# -> System.String? NodeCompositeId
        // GraphQL -> nodeCompositeId: String (scalar)
        if (this.NodeCompositeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeCompositeId\n" ;
            } else {
                s += ind + "nodeCompositeId\n" ;
            }
        }
        //      C# -> System.String? NodeIp
        // GraphQL -> nodeIp: String (scalar)
        if (this.NodeIp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeIp\n" ;
            } else {
                s += ind + "nodeIp\n" ;
            }
        }
        //      C# -> System.String? RestoreScriptPath
        // GraphQL -> restoreScriptPath: String (scalar)
        if (this.RestoreScriptPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "restoreScriptPath\n" ;
            } else {
                s += ind + "restoreScriptPath\n" ;
            }
        }
        //      C# -> System.String? SmbShareName
        // GraphQL -> smbShareName: String (scalar)
        if (this.SmbShareName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "smbShareName\n" ;
            } else {
                s += ind + "smbShareName\n" ;
            }
        }
        //      C# -> System.String? SourceVolumeGroupId
        // GraphQL -> sourceVolumeGroupId: String! (scalar)
        if (this.SourceVolumeGroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceVolumeGroupId\n" ;
            } else {
                s += ind + "sourceVolumeGroupId\n" ;
            }
        }
        //      C# -> System.String? TargetHostId
        // GraphQL -> targetHostId: String (scalar)
        if (this.TargetHostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetHostId\n" ;
            } else {
                s += ind + "targetHostId\n" ;
            }
        }
        //      C# -> System.String? TargetHostName
        // GraphQL -> targetHostName: String (scalar)
        if (this.TargetHostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetHostName\n" ;
            } else {
                s += ind + "targetHostName\n" ;
            }
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        if (this.UnmountRequestId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unmountRequestId\n" ;
            } else {
                s += ind + "unmountRequestId\n" ;
            }
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations != null) {
            var fspec = this.AuthorizedOperations.AsFieldSpec(conf.Child("authorizedOperations"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "authorizedOperations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<MountedVolume>? MountedVolumes
        // GraphQL -> mountedVolumes: [MountedVolume!]! (type)
        if (this.MountedVolumes != null) {
            var fspec = this.MountedVolumes.AsFieldSpec(conf.Child("mountedVolumes"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mountedVolumes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PhysicalHost? SourceHost
        // GraphQL -> sourceHost: PhysicalHost! (type)
        if (this.SourceHost != null) {
            var fspec = this.SourceHost.AsFieldSpec(conf.Child("sourceHost"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceHost" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (this.SourceSnapshot != null) {
            var fspec = this.SourceSnapshot.AsFieldSpec(conf.Child("sourceSnapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (ec.Includes("isReady",true))
        {
            if(this.IsReady == null) {

                this.IsReady = true;

            } else {


            }
        }
        else if (this.IsReady != null && ec.Excludes("isReady",true))
        {
            this.IsReady = null;
        }
        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String (scalar)
        if (ec.Includes("mountPath",true))
        {
            if(this.MountPath == null) {

                this.MountPath = "FETCH";

            } else {


            }
        }
        else if (this.MountPath != null && ec.Excludes("mountPath",true))
        {
            this.MountPath = null;
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        if (ec.Includes("mountRequestId",true))
        {
            if(this.MountRequestId == null) {

                this.MountRequestId = "FETCH";

            } else {


            }
        }
        else if (this.MountRequestId != null && ec.Excludes("mountRequestId",true))
        {
            this.MountRequestId = null;
        }
        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        if (ec.Includes("mountTimestamp",true))
        {
            if(this.MountTimestamp == null) {

                this.MountTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.MountTimestamp != null && ec.Excludes("mountTimestamp",true))
        {
            this.MountTimestamp = null;
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
        //      C# -> System.String? NodeCompositeId
        // GraphQL -> nodeCompositeId: String (scalar)
        if (ec.Includes("nodeCompositeId",true))
        {
            if(this.NodeCompositeId == null) {

                this.NodeCompositeId = "FETCH";

            } else {


            }
        }
        else if (this.NodeCompositeId != null && ec.Excludes("nodeCompositeId",true))
        {
            this.NodeCompositeId = null;
        }
        //      C# -> System.String? NodeIp
        // GraphQL -> nodeIp: String (scalar)
        if (ec.Includes("nodeIp",true))
        {
            if(this.NodeIp == null) {

                this.NodeIp = "FETCH";

            } else {


            }
        }
        else if (this.NodeIp != null && ec.Excludes("nodeIp",true))
        {
            this.NodeIp = null;
        }
        //      C# -> System.String? RestoreScriptPath
        // GraphQL -> restoreScriptPath: String (scalar)
        if (ec.Includes("restoreScriptPath",true))
        {
            if(this.RestoreScriptPath == null) {

                this.RestoreScriptPath = "FETCH";

            } else {


            }
        }
        else if (this.RestoreScriptPath != null && ec.Excludes("restoreScriptPath",true))
        {
            this.RestoreScriptPath = null;
        }
        //      C# -> System.String? SmbShareName
        // GraphQL -> smbShareName: String (scalar)
        if (ec.Includes("smbShareName",true))
        {
            if(this.SmbShareName == null) {

                this.SmbShareName = "FETCH";

            } else {


            }
        }
        else if (this.SmbShareName != null && ec.Excludes("smbShareName",true))
        {
            this.SmbShareName = null;
        }
        //      C# -> System.String? SourceVolumeGroupId
        // GraphQL -> sourceVolumeGroupId: String! (scalar)
        if (ec.Includes("sourceVolumeGroupId",true))
        {
            if(this.SourceVolumeGroupId == null) {

                this.SourceVolumeGroupId = "FETCH";

            } else {


            }
        }
        else if (this.SourceVolumeGroupId != null && ec.Excludes("sourceVolumeGroupId",true))
        {
            this.SourceVolumeGroupId = null;
        }
        //      C# -> System.String? TargetHostId
        // GraphQL -> targetHostId: String (scalar)
        if (ec.Includes("targetHostId",true))
        {
            if(this.TargetHostId == null) {

                this.TargetHostId = "FETCH";

            } else {


            }
        }
        else if (this.TargetHostId != null && ec.Excludes("targetHostId",true))
        {
            this.TargetHostId = null;
        }
        //      C# -> System.String? TargetHostName
        // GraphQL -> targetHostName: String (scalar)
        if (ec.Includes("targetHostName",true))
        {
            if(this.TargetHostName == null) {

                this.TargetHostName = "FETCH";

            } else {


            }
        }
        else if (this.TargetHostName != null && ec.Excludes("targetHostName",true))
        {
            this.TargetHostName = null;
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        if (ec.Includes("unmountRequestId",true))
        {
            if(this.UnmountRequestId == null) {

                this.UnmountRequestId = "FETCH";

            } else {


            }
        }
        else if (this.UnmountRequestId != null && ec.Excludes("unmountRequestId",true))
        {
            this.UnmountRequestId = null;
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (ec.Includes("authorizedOperations",false))
        {
            if(this.AuthorizedOperations == null) {

                this.AuthorizedOperations = new AuthorizedOperations();
                this.AuthorizedOperations.ApplyExploratoryFieldSpec(ec.NewChild("authorizedOperations"));

            } else {

                this.AuthorizedOperations.ApplyExploratoryFieldSpec(ec.NewChild("authorizedOperations"));

            }
        }
        else if (this.AuthorizedOperations != null && ec.Excludes("authorizedOperations",false))
        {
            this.AuthorizedOperations = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> List<MountedVolume>? MountedVolumes
        // GraphQL -> mountedVolumes: [MountedVolume!]! (type)
        if (ec.Includes("mountedVolumes",false))
        {
            if(this.MountedVolumes == null) {

                this.MountedVolumes = new List<MountedVolume>();
                this.MountedVolumes.ApplyExploratoryFieldSpec(ec.NewChild("mountedVolumes"));

            } else {

                this.MountedVolumes.ApplyExploratoryFieldSpec(ec.NewChild("mountedVolumes"));

            }
        }
        else if (this.MountedVolumes != null && ec.Excludes("mountedVolumes",false))
        {
            this.MountedVolumes = null;
        }
        //      C# -> PhysicalHost? SourceHost
        // GraphQL -> sourceHost: PhysicalHost! (type)
        if (ec.Includes("sourceHost",false))
        {
            if(this.SourceHost == null) {

                this.SourceHost = new PhysicalHost();
                this.SourceHost.ApplyExploratoryFieldSpec(ec.NewChild("sourceHost"));

            } else {

                this.SourceHost.ApplyExploratoryFieldSpec(ec.NewChild("sourceHost"));

            }
        }
        else if (this.SourceHost != null && ec.Excludes("sourceHost",false))
        {
            this.SourceHost = null;
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (ec.Includes("sourceSnapshot",false))
        {
            if(this.SourceSnapshot == null) {

                this.SourceSnapshot = new CdmSnapshot();
                this.SourceSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("sourceSnapshot"));

            } else {

                this.SourceSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("sourceSnapshot"));

            }
        }
        else if (this.SourceSnapshot != null && ec.Excludes("sourceSnapshot",false))
        {
            this.SourceSnapshot = null;
        }
    }


    #endregion

    } // class VolumeGroupLiveMount
    
    #endregion

    public static class ListVolumeGroupLiveMountExtensions
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
            this List<VolumeGroupLiveMount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VolumeGroupLiveMount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VolumeGroupLiveMount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VolumeGroupLiveMount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VolumeGroupLiveMount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
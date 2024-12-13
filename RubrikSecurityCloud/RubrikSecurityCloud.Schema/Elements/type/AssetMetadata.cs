// AssetMetadata.cs
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
    #region AssetMetadata
    public class AssetMetadata: BaseType
    {
        #region members

        //      C# -> BackupStatus? BackupStatus
        // GraphQL -> backupStatus: BackupStatus! (enum)
        [JsonProperty("backupStatus")]
        public BackupStatus? BackupStatus { get; set; }

        //      C# -> Encryption? Encryption
        // GraphQL -> encryption: Encryption! (enum)
        [JsonProperty("encryption")]
        public Encryption? Encryption { get; set; }

        //      C# -> Logging? Logging
        // GraphQL -> logging: Logging! (enum)
        [JsonProperty("logging")]
        public Logging? Logging { get; set; }

        //      C# -> NetworkAccess? NetworkAccess
        // GraphQL -> networkAccess: NetworkAccess! (enum)
        [JsonProperty("networkAccess")]
        public NetworkAccess? NetworkAccess { get; set; }

        //      C# -> Platform? Platform
        // GraphQL -> platform: Platform! (enum)
        [JsonProperty("platform")]
        public Platform? Platform { get; set; }

        //      C# -> PlatformCategory? PlatformCategory
        // GraphQL -> platformCategory: PlatformCategory! (enum)
        [JsonProperty("platformCategory")]
        public PlatformCategory? PlatformCategory { get; set; }

        //      C# -> System.Int64? CreationTime
        // GraphQL -> creationTime: Long! (scalar)
        [JsonProperty("creationTime")]
        public System.Int64? CreationTime { get; set; }

        //      C# -> System.Int64? FirstSeenTime
        // GraphQL -> firstSeenTime: Long! (scalar)
        [JsonProperty("firstSeenTime")]
        public System.Int64? FirstSeenTime { get; set; }

        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        [JsonProperty("lastAccessTime")]
        public System.Int64? LastAccessTime { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PhysicalHost
        // GraphQL -> physicalHost: String! (scalar)
        [JsonProperty("physicalHost")]
        public System.String? PhysicalHost { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> AppMetadata? AppSpecificMetadata
        // GraphQL -> appSpecificMetadata: AppMetadata (type)
        [JsonProperty("appSpecificMetadata")]
        public AppMetadata? AppSpecificMetadata { get; set; }

        //      C# -> CloudAccountInfo? CloudAccountInfo
        // GraphQL -> cloudAccountInfo: CloudAccountInfo (type)
        [JsonProperty("cloudAccountInfo")]
        public CloudAccountInfo? CloudAccountInfo { get; set; }

        //      C# -> ClusterInfo? ClusterInfo
        // GraphQL -> clusterInfo: ClusterInfo (type)
        [JsonProperty("clusterInfo")]
        public ClusterInfo? ClusterInfo { get; set; }

        //      C# -> List<AssetTag>? ObjectTags
        // GraphQL -> objectTags: [AssetTag!]! (type)
        [JsonProperty("objectTags")]
        public List<AssetTag>? ObjectTags { get; set; }

        //      C# -> RubrikSlaInfo? RubrikSlaInfo
        // GraphQL -> rubrikSlaInfo: RubrikSlaInfo (type)
        [JsonProperty("rubrikSlaInfo")]
        public RubrikSlaInfo? RubrikSlaInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AssetMetadata";
    }

    public AssetMetadata Set(
        BackupStatus? BackupStatus = null,
        Encryption? Encryption = null,
        Logging? Logging = null,
        NetworkAccess? NetworkAccess = null,
        Platform? Platform = null,
        PlatformCategory? PlatformCategory = null,
        System.Int64? CreationTime = null,
        System.Int64? FirstSeenTime = null,
        System.Int64? LastAccessTime = null,
        System.String? Name = null,
        System.String? PhysicalHost = null,
        System.String? Region = null,
        System.Int64? Size = null,
        AppMetadata? AppSpecificMetadata = null,
        CloudAccountInfo? CloudAccountInfo = null,
        ClusterInfo? ClusterInfo = null,
        List<AssetTag>? ObjectTags = null,
        RubrikSlaInfo? RubrikSlaInfo = null
    ) 
    {
        if ( BackupStatus != null ) {
            this.BackupStatus = BackupStatus;
        }
        if ( Encryption != null ) {
            this.Encryption = Encryption;
        }
        if ( Logging != null ) {
            this.Logging = Logging;
        }
        if ( NetworkAccess != null ) {
            this.NetworkAccess = NetworkAccess;
        }
        if ( Platform != null ) {
            this.Platform = Platform;
        }
        if ( PlatformCategory != null ) {
            this.PlatformCategory = PlatformCategory;
        }
        if ( CreationTime != null ) {
            this.CreationTime = CreationTime;
        }
        if ( FirstSeenTime != null ) {
            this.FirstSeenTime = FirstSeenTime;
        }
        if ( LastAccessTime != null ) {
            this.LastAccessTime = LastAccessTime;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PhysicalHost != null ) {
            this.PhysicalHost = PhysicalHost;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( AppSpecificMetadata != null ) {
            this.AppSpecificMetadata = AppSpecificMetadata;
        }
        if ( CloudAccountInfo != null ) {
            this.CloudAccountInfo = CloudAccountInfo;
        }
        if ( ClusterInfo != null ) {
            this.ClusterInfo = ClusterInfo;
        }
        if ( ObjectTags != null ) {
            this.ObjectTags = ObjectTags;
        }
        if ( RubrikSlaInfo != null ) {
            this.RubrikSlaInfo = RubrikSlaInfo;
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
        //      C# -> BackupStatus? BackupStatus
        // GraphQL -> backupStatus: BackupStatus! (enum)
        if (this.BackupStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupStatus\n" ;
            } else {
                s += ind + "backupStatus\n" ;
            }
        }
        //      C# -> Encryption? Encryption
        // GraphQL -> encryption: Encryption! (enum)
        if (this.Encryption != null) {
            if (conf.Flat) {
                s += conf.Prefix + "encryption\n" ;
            } else {
                s += ind + "encryption\n" ;
            }
        }
        //      C# -> Logging? Logging
        // GraphQL -> logging: Logging! (enum)
        if (this.Logging != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logging\n" ;
            } else {
                s += ind + "logging\n" ;
            }
        }
        //      C# -> NetworkAccess? NetworkAccess
        // GraphQL -> networkAccess: NetworkAccess! (enum)
        if (this.NetworkAccess != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkAccess\n" ;
            } else {
                s += ind + "networkAccess\n" ;
            }
        }
        //      C# -> Platform? Platform
        // GraphQL -> platform: Platform! (enum)
        if (this.Platform != null) {
            if (conf.Flat) {
                s += conf.Prefix + "platform\n" ;
            } else {
                s += ind + "platform\n" ;
            }
        }
        //      C# -> PlatformCategory? PlatformCategory
        // GraphQL -> platformCategory: PlatformCategory! (enum)
        if (this.PlatformCategory != null) {
            if (conf.Flat) {
                s += conf.Prefix + "platformCategory\n" ;
            } else {
                s += ind + "platformCategory\n" ;
            }
        }
        //      C# -> System.Int64? CreationTime
        // GraphQL -> creationTime: Long! (scalar)
        if (this.CreationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "creationTime\n" ;
            } else {
                s += ind + "creationTime\n" ;
            }
        }
        //      C# -> System.Int64? FirstSeenTime
        // GraphQL -> firstSeenTime: Long! (scalar)
        if (this.FirstSeenTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "firstSeenTime\n" ;
            } else {
                s += ind + "firstSeenTime\n" ;
            }
        }
        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        if (this.LastAccessTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastAccessTime\n" ;
            } else {
                s += ind + "lastAccessTime\n" ;
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
        //      C# -> System.String? PhysicalHost
        // GraphQL -> physicalHost: String! (scalar)
        if (this.PhysicalHost != null) {
            if (conf.Flat) {
                s += conf.Prefix + "physicalHost\n" ;
            } else {
                s += ind + "physicalHost\n" ;
            }
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            if (conf.Flat) {
                s += conf.Prefix + "size\n" ;
            } else {
                s += ind + "size\n" ;
            }
        }
        //      C# -> AppMetadata? AppSpecificMetadata
        // GraphQL -> appSpecificMetadata: AppMetadata (type)
        if (this.AppSpecificMetadata != null) {
            var fspec = this.AppSpecificMetadata.AsFieldSpec(conf.Child("appSpecificMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "appSpecificMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudAccountInfo? CloudAccountInfo
        // GraphQL -> cloudAccountInfo: CloudAccountInfo (type)
        if (this.CloudAccountInfo != null) {
            var fspec = this.CloudAccountInfo.AsFieldSpec(conf.Child("cloudAccountInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudAccountInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ClusterInfo? ClusterInfo
        // GraphQL -> clusterInfo: ClusterInfo (type)
        if (this.ClusterInfo != null) {
            var fspec = this.ClusterInfo.AsFieldSpec(conf.Child("clusterInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AssetTag>? ObjectTags
        // GraphQL -> objectTags: [AssetTag!]! (type)
        if (this.ObjectTags != null) {
            var fspec = this.ObjectTags.AsFieldSpec(conf.Child("objectTags"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectTags" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RubrikSlaInfo? RubrikSlaInfo
        // GraphQL -> rubrikSlaInfo: RubrikSlaInfo (type)
        if (this.RubrikSlaInfo != null) {
            var fspec = this.RubrikSlaInfo.AsFieldSpec(conf.Child("rubrikSlaInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rubrikSlaInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> BackupStatus? BackupStatus
        // GraphQL -> backupStatus: BackupStatus! (enum)
        if (ec.Includes("backupStatus",true))
        {
            if(this.BackupStatus == null) {

                this.BackupStatus = new BackupStatus();

            } else {


            }
        }
        else if (this.BackupStatus != null && ec.Excludes("backupStatus",true))
        {
            this.BackupStatus = null;
        }
        //      C# -> Encryption? Encryption
        // GraphQL -> encryption: Encryption! (enum)
        if (ec.Includes("encryption",true))
        {
            if(this.Encryption == null) {

                this.Encryption = new Encryption();

            } else {


            }
        }
        else if (this.Encryption != null && ec.Excludes("encryption",true))
        {
            this.Encryption = null;
        }
        //      C# -> Logging? Logging
        // GraphQL -> logging: Logging! (enum)
        if (ec.Includes("logging",true))
        {
            if(this.Logging == null) {

                this.Logging = new Logging();

            } else {


            }
        }
        else if (this.Logging != null && ec.Excludes("logging",true))
        {
            this.Logging = null;
        }
        //      C# -> NetworkAccess? NetworkAccess
        // GraphQL -> networkAccess: NetworkAccess! (enum)
        if (ec.Includes("networkAccess",true))
        {
            if(this.NetworkAccess == null) {

                this.NetworkAccess = new NetworkAccess();

            } else {


            }
        }
        else if (this.NetworkAccess != null && ec.Excludes("networkAccess",true))
        {
            this.NetworkAccess = null;
        }
        //      C# -> Platform? Platform
        // GraphQL -> platform: Platform! (enum)
        if (ec.Includes("platform",true))
        {
            if(this.Platform == null) {

                this.Platform = new Platform();

            } else {


            }
        }
        else if (this.Platform != null && ec.Excludes("platform",true))
        {
            this.Platform = null;
        }
        //      C# -> PlatformCategory? PlatformCategory
        // GraphQL -> platformCategory: PlatformCategory! (enum)
        if (ec.Includes("platformCategory",true))
        {
            if(this.PlatformCategory == null) {

                this.PlatformCategory = new PlatformCategory();

            } else {


            }
        }
        else if (this.PlatformCategory != null && ec.Excludes("platformCategory",true))
        {
            this.PlatformCategory = null;
        }
        //      C# -> System.Int64? CreationTime
        // GraphQL -> creationTime: Long! (scalar)
        if (ec.Includes("creationTime",true))
        {
            if(this.CreationTime == null) {

                this.CreationTime = new System.Int64();

            } else {


            }
        }
        else if (this.CreationTime != null && ec.Excludes("creationTime",true))
        {
            this.CreationTime = null;
        }
        //      C# -> System.Int64? FirstSeenTime
        // GraphQL -> firstSeenTime: Long! (scalar)
        if (ec.Includes("firstSeenTime",true))
        {
            if(this.FirstSeenTime == null) {

                this.FirstSeenTime = new System.Int64();

            } else {


            }
        }
        else if (this.FirstSeenTime != null && ec.Excludes("firstSeenTime",true))
        {
            this.FirstSeenTime = null;
        }
        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        if (ec.Includes("lastAccessTime",true))
        {
            if(this.LastAccessTime == null) {

                this.LastAccessTime = new System.Int64();

            } else {


            }
        }
        else if (this.LastAccessTime != null && ec.Excludes("lastAccessTime",true))
        {
            this.LastAccessTime = null;
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
        //      C# -> System.String? PhysicalHost
        // GraphQL -> physicalHost: String! (scalar)
        if (ec.Includes("physicalHost",true))
        {
            if(this.PhysicalHost == null) {

                this.PhysicalHost = "FETCH";

            } else {


            }
        }
        else if (this.PhysicalHost != null && ec.Excludes("physicalHost",true))
        {
            this.PhysicalHost = null;
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = "FETCH";

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (ec.Includes("size",true))
        {
            if(this.Size == null) {

                this.Size = new System.Int64();

            } else {


            }
        }
        else if (this.Size != null && ec.Excludes("size",true))
        {
            this.Size = null;
        }
        //      C# -> AppMetadata? AppSpecificMetadata
        // GraphQL -> appSpecificMetadata: AppMetadata (type)
        if (ec.Includes("appSpecificMetadata",false))
        {
            if(this.AppSpecificMetadata == null) {

                this.AppSpecificMetadata = new AppMetadata();
                this.AppSpecificMetadata.ApplyExploratoryFieldSpec(ec.NewChild("appSpecificMetadata"));

            } else {

                this.AppSpecificMetadata.ApplyExploratoryFieldSpec(ec.NewChild("appSpecificMetadata"));

            }
        }
        else if (this.AppSpecificMetadata != null && ec.Excludes("appSpecificMetadata",false))
        {
            this.AppSpecificMetadata = null;
        }
        //      C# -> CloudAccountInfo? CloudAccountInfo
        // GraphQL -> cloudAccountInfo: CloudAccountInfo (type)
        if (ec.Includes("cloudAccountInfo",false))
        {
            if(this.CloudAccountInfo == null) {

                this.CloudAccountInfo = new CloudAccountInfo();
                this.CloudAccountInfo.ApplyExploratoryFieldSpec(ec.NewChild("cloudAccountInfo"));

            } else {

                this.CloudAccountInfo.ApplyExploratoryFieldSpec(ec.NewChild("cloudAccountInfo"));

            }
        }
        else if (this.CloudAccountInfo != null && ec.Excludes("cloudAccountInfo",false))
        {
            this.CloudAccountInfo = null;
        }
        //      C# -> ClusterInfo? ClusterInfo
        // GraphQL -> clusterInfo: ClusterInfo (type)
        if (ec.Includes("clusterInfo",false))
        {
            if(this.ClusterInfo == null) {

                this.ClusterInfo = new ClusterInfo();
                this.ClusterInfo.ApplyExploratoryFieldSpec(ec.NewChild("clusterInfo"));

            } else {

                this.ClusterInfo.ApplyExploratoryFieldSpec(ec.NewChild("clusterInfo"));

            }
        }
        else if (this.ClusterInfo != null && ec.Excludes("clusterInfo",false))
        {
            this.ClusterInfo = null;
        }
        //      C# -> List<AssetTag>? ObjectTags
        // GraphQL -> objectTags: [AssetTag!]! (type)
        if (ec.Includes("objectTags",false))
        {
            if(this.ObjectTags == null) {

                this.ObjectTags = new List<AssetTag>();
                this.ObjectTags.ApplyExploratoryFieldSpec(ec.NewChild("objectTags"));

            } else {

                this.ObjectTags.ApplyExploratoryFieldSpec(ec.NewChild("objectTags"));

            }
        }
        else if (this.ObjectTags != null && ec.Excludes("objectTags",false))
        {
            this.ObjectTags = null;
        }
        //      C# -> RubrikSlaInfo? RubrikSlaInfo
        // GraphQL -> rubrikSlaInfo: RubrikSlaInfo (type)
        if (ec.Includes("rubrikSlaInfo",false))
        {
            if(this.RubrikSlaInfo == null) {

                this.RubrikSlaInfo = new RubrikSlaInfo();
                this.RubrikSlaInfo.ApplyExploratoryFieldSpec(ec.NewChild("rubrikSlaInfo"));

            } else {

                this.RubrikSlaInfo.ApplyExploratoryFieldSpec(ec.NewChild("rubrikSlaInfo"));

            }
        }
        else if (this.RubrikSlaInfo != null && ec.Excludes("rubrikSlaInfo",false))
        {
            this.RubrikSlaInfo = null;
        }
    }


    #endregion

    } // class AssetMetadata
    
    #endregion

    public static class ListAssetMetadataExtensions
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
            this List<AssetMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AssetMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AssetMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AssetMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AssetMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
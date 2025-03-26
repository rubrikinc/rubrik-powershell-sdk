// CloudNativeSnapshotDetailsForRecovery.cs
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
    #region CloudNativeSnapshotDetailsForRecovery
    public class CloudNativeSnapshotDetailsForRecovery: BaseType
    {
        #region members

        //      C# -> CloudProviderType? CloudType
        // GraphQL -> cloudType: CloudProviderType! (enum)
        [JsonProperty("cloudType")]
        public CloudProviderType? CloudType { get; set; }

        //      C# -> FileRecoveryFeasibility? FileRecoveryFeasibility
        // GraphQL -> fileRecoveryFeasibility: FileRecoveryFeasibility! (enum)
        [JsonProperty("fileRecoveryFeasibility")]
        public FileRecoveryFeasibility? FileRecoveryFeasibility { get; set; }

        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        [JsonProperty("snapshotType")]
        public SnapshotType? SnapshotType { get; set; }

        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        [JsonProperty("locationName")]
        public System.String? LocationName { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> CloudNativeAccountIdWithName? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: CloudNativeAccountIdWithName (type)
        [JsonProperty("cloudNativeAccountId")]
        public CloudNativeAccountIdWithName? CloudNativeAccountId { get; set; }

        //      C# -> CloudNativeRegion? SnapshotRegion
        // GraphQL -> snapshotRegion: CloudNativeRegion! (type)
        [JsonProperty("snapshotRegion")]
        public CloudNativeRegion? SnapshotRegion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeSnapshotDetailsForRecovery";
    }

    public CloudNativeSnapshotDetailsForRecovery Set(
        CloudProviderType? CloudType = null,
        FileRecoveryFeasibility? FileRecoveryFeasibility = null,
        SnapshotType? SnapshotType = null,
        System.String? LocationName = null,
        System.String? SnapshotId = null,
        CloudNativeAccountIdWithName? CloudNativeAccountId = null,
        CloudNativeRegion? SnapshotRegion = null
    ) 
    {
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( FileRecoveryFeasibility != null ) {
            this.FileRecoveryFeasibility = FileRecoveryFeasibility;
        }
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
        }
        if ( LocationName != null ) {
            this.LocationName = LocationName;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( CloudNativeAccountId != null ) {
            this.CloudNativeAccountId = CloudNativeAccountId;
        }
        if ( SnapshotRegion != null ) {
            this.SnapshotRegion = SnapshotRegion;
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
        //      C# -> CloudProviderType? CloudType
        // GraphQL -> cloudType: CloudProviderType! (enum)
        if (this.CloudType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudType\n" ;
            } else {
                s += ind + "cloudType\n" ;
            }
        }
        //      C# -> FileRecoveryFeasibility? FileRecoveryFeasibility
        // GraphQL -> fileRecoveryFeasibility: FileRecoveryFeasibility! (enum)
        if (this.FileRecoveryFeasibility != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileRecoveryFeasibility\n" ;
            } else {
                s += ind + "fileRecoveryFeasibility\n" ;
            }
        }
        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        if (this.SnapshotType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotType\n" ;
            } else {
                s += ind + "snapshotType\n" ;
            }
        }
        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        if (this.LocationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationName\n" ;
            } else {
                s += ind + "locationName\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> CloudNativeAccountIdWithName? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: CloudNativeAccountIdWithName (type)
        if (this.CloudNativeAccountId != null) {
            var fspec = this.CloudNativeAccountId.AsFieldSpec(conf.Child("cloudNativeAccountId"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudNativeAccountId" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudNativeRegion? SnapshotRegion
        // GraphQL -> snapshotRegion: CloudNativeRegion! (type)
        if (this.SnapshotRegion != null) {
            var fspec = this.SnapshotRegion.AsFieldSpec(conf.Child("snapshotRegion"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotRegion" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudProviderType? CloudType
        // GraphQL -> cloudType: CloudProviderType! (enum)
        if (ec.Includes("cloudType",true))
        {
            if(this.CloudType == null) {

                this.CloudType = new CloudProviderType();

            } else {


            }
        }
        else if (this.CloudType != null && ec.Excludes("cloudType",true))
        {
            this.CloudType = null;
        }
        //      C# -> FileRecoveryFeasibility? FileRecoveryFeasibility
        // GraphQL -> fileRecoveryFeasibility: FileRecoveryFeasibility! (enum)
        if (ec.Includes("fileRecoveryFeasibility",true))
        {
            if(this.FileRecoveryFeasibility == null) {

                this.FileRecoveryFeasibility = new FileRecoveryFeasibility();

            } else {


            }
        }
        else if (this.FileRecoveryFeasibility != null && ec.Excludes("fileRecoveryFeasibility",true))
        {
            this.FileRecoveryFeasibility = null;
        }
        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        if (ec.Includes("snapshotType",true))
        {
            if(this.SnapshotType == null) {

                this.SnapshotType = new SnapshotType();

            } else {


            }
        }
        else if (this.SnapshotType != null && ec.Excludes("snapshotType",true))
        {
            this.SnapshotType = null;
        }
        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        if (ec.Includes("locationName",true))
        {
            if(this.LocationName == null) {

                this.LocationName = "FETCH";

            } else {


            }
        }
        else if (this.LocationName != null && ec.Excludes("locationName",true))
        {
            this.LocationName = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> CloudNativeAccountIdWithName? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: CloudNativeAccountIdWithName (type)
        if (ec.Includes("cloudNativeAccountId",false))
        {
            if(this.CloudNativeAccountId == null) {

                this.CloudNativeAccountId = new CloudNativeAccountIdWithName();
                this.CloudNativeAccountId.ApplyExploratoryFieldSpec(ec.NewChild("cloudNativeAccountId"));

            } else {

                this.CloudNativeAccountId.ApplyExploratoryFieldSpec(ec.NewChild("cloudNativeAccountId"));

            }
        }
        else if (this.CloudNativeAccountId != null && ec.Excludes("cloudNativeAccountId",false))
        {
            this.CloudNativeAccountId = null;
        }
        //      C# -> CloudNativeRegion? SnapshotRegion
        // GraphQL -> snapshotRegion: CloudNativeRegion! (type)
        if (ec.Includes("snapshotRegion",false))
        {
            if(this.SnapshotRegion == null) {

                this.SnapshotRegion = new CloudNativeRegion();
                this.SnapshotRegion.ApplyExploratoryFieldSpec(ec.NewChild("snapshotRegion"));

            } else {

                this.SnapshotRegion.ApplyExploratoryFieldSpec(ec.NewChild("snapshotRegion"));

            }
        }
        else if (this.SnapshotRegion != null && ec.Excludes("snapshotRegion",false))
        {
            this.SnapshotRegion = null;
        }
    }


    #endregion

    } // class CloudNativeSnapshotDetailsForRecovery
    
    #endregion

    public static class ListCloudNativeSnapshotDetailsForRecoveryExtensions
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
            this List<CloudNativeSnapshotDetailsForRecovery> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudNativeSnapshotDetailsForRecovery> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeSnapshotDetailsForRecovery> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeSnapshotDetailsForRecovery());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeSnapshotDetailsForRecovery> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
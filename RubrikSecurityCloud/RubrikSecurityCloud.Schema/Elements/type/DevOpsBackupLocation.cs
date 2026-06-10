// DevOpsBackupLocation.cs
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
    #region DevOpsBackupLocation
    public class DevOpsBackupLocation: BaseType
    {
        #region members

        //      C# -> CloudServiceProvider? CloudType
        // GraphQL -> cloudType: CloudServiceProvider! (enum)
        [JsonProperty("cloudType")]
        public CloudServiceProvider? CloudType { get; set; }

        //      C# -> DevOpsStorageType? StorageType
        // GraphQL -> storageType: DevOpsStorageType! (enum)
        [JsonProperty("storageType")]
        public DevOpsStorageType? StorageType { get; set; }

        //      C# -> System.String? ArchivalGroupId
        // GraphQL -> archivalGroupId: UUID! (scalar)
        [JsonProperty("archivalGroupId")]
        public System.String? ArchivalGroupId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> CloudSpecificRegionOneof? CloudSpecificRegion
        // GraphQL -> cloudSpecificRegion: CloudSpecificRegionOneof (type)
        [JsonProperty("cloudSpecificRegion")]
        public CloudSpecificRegionOneof? CloudSpecificRegion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DevOpsBackupLocation";
    }

    public DevOpsBackupLocation Set(
        CloudServiceProvider? CloudType = null,
        DevOpsStorageType? StorageType = null,
        System.String? ArchivalGroupId = null,
        System.String? Id = null,
        System.String? Name = null,
        CloudSpecificRegionOneof? CloudSpecificRegion = null
    ) 
    {
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( StorageType != null ) {
            this.StorageType = StorageType;
        }
        if ( ArchivalGroupId != null ) {
            this.ArchivalGroupId = ArchivalGroupId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( CloudSpecificRegion != null ) {
            this.CloudSpecificRegion = CloudSpecificRegion;
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
        //      C# -> CloudServiceProvider? CloudType
        // GraphQL -> cloudType: CloudServiceProvider! (enum)
        if (this.CloudType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudType\n" ;
            } else {
                s += ind + "cloudType\n" ;
            }
        }
        //      C# -> DevOpsStorageType? StorageType
        // GraphQL -> storageType: DevOpsStorageType! (enum)
        if (this.StorageType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageType\n" ;
            } else {
                s += ind + "storageType\n" ;
            }
        }
        //      C# -> System.String? ArchivalGroupId
        // GraphQL -> archivalGroupId: UUID! (scalar)
        if (this.ArchivalGroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalGroupId\n" ;
            } else {
                s += ind + "archivalGroupId\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
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
        //      C# -> CloudSpecificRegionOneof? CloudSpecificRegion
        // GraphQL -> cloudSpecificRegion: CloudSpecificRegionOneof (type)
        if (this.CloudSpecificRegion != null) {
            var fspec = this.CloudSpecificRegion.AsFieldSpec(conf.Child("cloudSpecificRegion"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudSpecificRegion" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudServiceProvider? CloudType
        // GraphQL -> cloudType: CloudServiceProvider! (enum)
        if (ec.Includes("cloudType",true))
        {
            if(this.CloudType == null) {

                this.CloudType = new CloudServiceProvider();

            } else {


            }
        }
        else if (this.CloudType != null && ec.Excludes("cloudType",true))
        {
            this.CloudType = null;
        }
        //      C# -> DevOpsStorageType? StorageType
        // GraphQL -> storageType: DevOpsStorageType! (enum)
        if (ec.Includes("storageType",true))
        {
            if(this.StorageType == null) {

                this.StorageType = new DevOpsStorageType();

            } else {


            }
        }
        else if (this.StorageType != null && ec.Excludes("storageType",true))
        {
            this.StorageType = null;
        }
        //      C# -> System.String? ArchivalGroupId
        // GraphQL -> archivalGroupId: UUID! (scalar)
        if (ec.Includes("archivalGroupId",true))
        {
            if(this.ArchivalGroupId == null) {

                this.ArchivalGroupId = "FETCH";

            } else {


            }
        }
        else if (this.ArchivalGroupId != null && ec.Excludes("archivalGroupId",true))
        {
            this.ArchivalGroupId = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
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
        //      C# -> CloudSpecificRegionOneof? CloudSpecificRegion
        // GraphQL -> cloudSpecificRegion: CloudSpecificRegionOneof (type)
        if (ec.Includes("cloudSpecificRegion",false))
        {
            if(this.CloudSpecificRegion == null) {

                this.CloudSpecificRegion = new CloudSpecificRegionOneof();
                this.CloudSpecificRegion.ApplyExploratoryFieldSpec(ec.NewChild("cloudSpecificRegion"));

            } else {

                this.CloudSpecificRegion.ApplyExploratoryFieldSpec(ec.NewChild("cloudSpecificRegion"));

            }
        }
        else if (this.CloudSpecificRegion != null && ec.Excludes("cloudSpecificRegion",false))
        {
            this.CloudSpecificRegion = null;
        }
    }


    #endregion

    } // class DevOpsBackupLocation
    
    #endregion

    public static class ListDevOpsBackupLocationExtensions
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
            this List<DevOpsBackupLocation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DevOpsBackupLocation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DevOpsBackupLocation> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DevOpsBackupLocation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DevOpsBackupLocation> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
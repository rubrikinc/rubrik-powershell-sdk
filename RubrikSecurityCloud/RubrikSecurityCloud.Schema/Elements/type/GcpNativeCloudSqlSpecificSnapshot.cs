// GcpNativeCloudSqlSpecificSnapshot.cs
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
    #region GcpNativeCloudSqlSpecificSnapshot
 
    public class GcpNativeCloudSqlSpecificSnapshot: BaseType, PolarisSpecificSnapshot
    {
        #region members

        //      C# -> GcpCloudSqlEdition? Edition
        // GraphQL -> edition: GcpCloudSqlEdition! (enum)
        [JsonProperty("edition")]
        public GcpCloudSqlEdition? Edition { get; set; }

        //      C# -> System.String? DatabaseVersion
        // GraphQL -> databaseVersion: String! (scalar)
        [JsonProperty("databaseVersion")]
        public System.String? DatabaseVersion { get; set; }

        //      C# -> System.String? InstanceTier
        // GraphQL -> instanceTier: String! (scalar)
        [JsonProperty("instanceTier")]
        public System.String? InstanceTier { get; set; }

        //      C# -> System.String? KmsKey
        // GraphQL -> kmsKey: String (scalar)
        [JsonProperty("kmsKey")]
        public System.String? KmsKey { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Int32? StorageSize
        // GraphQL -> storageSize: Int! (scalar)
        [JsonProperty("storageSize")]
        public System.Int32? StorageSize { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpNativeCloudSqlSpecificSnapshot";
    }

    public GcpNativeCloudSqlSpecificSnapshot Set(
        GcpCloudSqlEdition? Edition = null,
        System.String? DatabaseVersion = null,
        System.String? InstanceTier = null,
        System.String? KmsKey = null,
        System.String? SnapshotId = null,
        System.Int32? StorageSize = null
    ) 
    {
        if ( Edition != null ) {
            this.Edition = Edition;
        }
        if ( DatabaseVersion != null ) {
            this.DatabaseVersion = DatabaseVersion;
        }
        if ( InstanceTier != null ) {
            this.InstanceTier = InstanceTier;
        }
        if ( KmsKey != null ) {
            this.KmsKey = KmsKey;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( StorageSize != null ) {
            this.StorageSize = StorageSize;
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
        //      C# -> GcpCloudSqlEdition? Edition
        // GraphQL -> edition: GcpCloudSqlEdition! (enum)
        if (this.Edition != null) {
            if (conf.Flat) {
                s += conf.Prefix + "edition\n" ;
            } else {
                s += ind + "edition\n" ;
            }
        }
        //      C# -> System.String? DatabaseVersion
        // GraphQL -> databaseVersion: String! (scalar)
        if (this.DatabaseVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "databaseVersion\n" ;
            } else {
                s += ind + "databaseVersion\n" ;
            }
        }
        //      C# -> System.String? InstanceTier
        // GraphQL -> instanceTier: String! (scalar)
        if (this.InstanceTier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceTier\n" ;
            } else {
                s += ind + "instanceTier\n" ;
            }
        }
        //      C# -> System.String? KmsKey
        // GraphQL -> kmsKey: String (scalar)
        if (this.KmsKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kmsKey\n" ;
            } else {
                s += ind + "kmsKey\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.Int32? StorageSize
        // GraphQL -> storageSize: Int! (scalar)
        if (this.StorageSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageSize\n" ;
            } else {
                s += ind + "storageSize\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> GcpCloudSqlEdition? Edition
        // GraphQL -> edition: GcpCloudSqlEdition! (enum)
        if (ec.Includes("edition",true))
        {
            if(this.Edition == null) {

                this.Edition = new GcpCloudSqlEdition();

            } else {


            }
        }
        else if (this.Edition != null && ec.Excludes("edition",true))
        {
            this.Edition = null;
        }
        //      C# -> System.String? DatabaseVersion
        // GraphQL -> databaseVersion: String! (scalar)
        if (ec.Includes("databaseVersion",true))
        {
            if(this.DatabaseVersion == null) {

                this.DatabaseVersion = "FETCH";

            } else {


            }
        }
        else if (this.DatabaseVersion != null && ec.Excludes("databaseVersion",true))
        {
            this.DatabaseVersion = null;
        }
        //      C# -> System.String? InstanceTier
        // GraphQL -> instanceTier: String! (scalar)
        if (ec.Includes("instanceTier",true))
        {
            if(this.InstanceTier == null) {

                this.InstanceTier = "FETCH";

            } else {


            }
        }
        else if (this.InstanceTier != null && ec.Excludes("instanceTier",true))
        {
            this.InstanceTier = null;
        }
        //      C# -> System.String? KmsKey
        // GraphQL -> kmsKey: String (scalar)
        if (ec.Includes("kmsKey",true))
        {
            if(this.KmsKey == null) {

                this.KmsKey = "FETCH";

            } else {


            }
        }
        else if (this.KmsKey != null && ec.Excludes("kmsKey",true))
        {
            this.KmsKey = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
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
        //      C# -> System.Int32? StorageSize
        // GraphQL -> storageSize: Int! (scalar)
        if (ec.Includes("storageSize",true))
        {
            if(this.StorageSize == null) {

                this.StorageSize = Int32.MinValue;

            } else {


            }
        }
        else if (this.StorageSize != null && ec.Excludes("storageSize",true))
        {
            this.StorageSize = null;
        }
    }


    #endregion

    } // class GcpNativeCloudSqlSpecificSnapshot
    
    #endregion

    public static class ListGcpNativeCloudSqlSpecificSnapshotExtensions
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
            this List<GcpNativeCloudSqlSpecificSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpNativeCloudSqlSpecificSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpNativeCloudSqlSpecificSnapshot> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpNativeCloudSqlSpecificSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpNativeCloudSqlSpecificSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
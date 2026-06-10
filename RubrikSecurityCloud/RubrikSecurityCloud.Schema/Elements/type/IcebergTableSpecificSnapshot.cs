// IcebergTableSpecificSnapshot.cs
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
    #region IcebergTableSpecificSnapshot
 
    public class IcebergTableSpecificSnapshot: BaseType, PolarisSpecificSnapshot
    {
        #region members

        //      C# -> System.Int64? BytesCopied
        // GraphQL -> bytesCopied: Long! (scalar)
        [JsonProperty("bytesCopied")]
        public System.Int64? BytesCopied { get; set; }

        //      C# -> System.Int64? FileCount
        // GraphQL -> fileCount: Long! (scalar)
        [JsonProperty("fileCount")]
        public System.Int64? FileCount { get; set; }

        //      C# -> System.Int64? IcebergSnapshotFileCount
        // GraphQL -> icebergSnapshotFileCount: Long! (scalar)
        [JsonProperty("icebergSnapshotFileCount")]
        public System.Int64? IcebergSnapshotFileCount { get; set; }

        //      C# -> System.Int64? IcebergSnapshotId
        // GraphQL -> icebergSnapshotId: Long! (scalar)
        [JsonProperty("icebergSnapshotId")]
        public System.Int64? IcebergSnapshotId { get; set; }

        //      C# -> System.Int64? IcebergSnapshotSize
        // GraphQL -> icebergSnapshotSize: Long! (scalar)
        [JsonProperty("icebergSnapshotSize")]
        public System.Int64? IcebergSnapshotSize { get; set; }

        //      C# -> System.Boolean? IsSnapshotPartial
        // GraphQL -> isSnapshotPartial: Boolean! (scalar)
        [JsonProperty("isSnapshotPartial")]
        public System.Boolean? IsSnapshotPartial { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IcebergTableSpecificSnapshot";
    }

    public IcebergTableSpecificSnapshot Set(
        System.Int64? BytesCopied = null,
        System.Int64? FileCount = null,
        System.Int64? IcebergSnapshotFileCount = null,
        System.Int64? IcebergSnapshotId = null,
        System.Int64? IcebergSnapshotSize = null,
        System.Boolean? IsSnapshotPartial = null,
        System.String? SnapshotId = null
    ) 
    {
        if ( BytesCopied != null ) {
            this.BytesCopied = BytesCopied;
        }
        if ( FileCount != null ) {
            this.FileCount = FileCount;
        }
        if ( IcebergSnapshotFileCount != null ) {
            this.IcebergSnapshotFileCount = IcebergSnapshotFileCount;
        }
        if ( IcebergSnapshotId != null ) {
            this.IcebergSnapshotId = IcebergSnapshotId;
        }
        if ( IcebergSnapshotSize != null ) {
            this.IcebergSnapshotSize = IcebergSnapshotSize;
        }
        if ( IsSnapshotPartial != null ) {
            this.IsSnapshotPartial = IsSnapshotPartial;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
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
        //      C# -> System.Int64? BytesCopied
        // GraphQL -> bytesCopied: Long! (scalar)
        if (this.BytesCopied != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytesCopied\n" ;
            } else {
                s += ind + "bytesCopied\n" ;
            }
        }
        //      C# -> System.Int64? FileCount
        // GraphQL -> fileCount: Long! (scalar)
        if (this.FileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileCount\n" ;
            } else {
                s += ind + "fileCount\n" ;
            }
        }
        //      C# -> System.Int64? IcebergSnapshotFileCount
        // GraphQL -> icebergSnapshotFileCount: Long! (scalar)
        if (this.IcebergSnapshotFileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "icebergSnapshotFileCount\n" ;
            } else {
                s += ind + "icebergSnapshotFileCount\n" ;
            }
        }
        //      C# -> System.Int64? IcebergSnapshotId
        // GraphQL -> icebergSnapshotId: Long! (scalar)
        if (this.IcebergSnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "icebergSnapshotId\n" ;
            } else {
                s += ind + "icebergSnapshotId\n" ;
            }
        }
        //      C# -> System.Int64? IcebergSnapshotSize
        // GraphQL -> icebergSnapshotSize: Long! (scalar)
        if (this.IcebergSnapshotSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "icebergSnapshotSize\n" ;
            } else {
                s += ind + "icebergSnapshotSize\n" ;
            }
        }
        //      C# -> System.Boolean? IsSnapshotPartial
        // GraphQL -> isSnapshotPartial: Boolean! (scalar)
        if (this.IsSnapshotPartial != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSnapshotPartial\n" ;
            } else {
                s += ind + "isSnapshotPartial\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? BytesCopied
        // GraphQL -> bytesCopied: Long! (scalar)
        if (ec.Includes("bytesCopied",true))
        {
            if(this.BytesCopied == null) {

                this.BytesCopied = new System.Int64();

            } else {


            }
        }
        else if (this.BytesCopied != null && ec.Excludes("bytesCopied",true))
        {
            this.BytesCopied = null;
        }
        //      C# -> System.Int64? FileCount
        // GraphQL -> fileCount: Long! (scalar)
        if (ec.Includes("fileCount",true))
        {
            if(this.FileCount == null) {

                this.FileCount = new System.Int64();

            } else {


            }
        }
        else if (this.FileCount != null && ec.Excludes("fileCount",true))
        {
            this.FileCount = null;
        }
        //      C# -> System.Int64? IcebergSnapshotFileCount
        // GraphQL -> icebergSnapshotFileCount: Long! (scalar)
        if (ec.Includes("icebergSnapshotFileCount",true))
        {
            if(this.IcebergSnapshotFileCount == null) {

                this.IcebergSnapshotFileCount = new System.Int64();

            } else {


            }
        }
        else if (this.IcebergSnapshotFileCount != null && ec.Excludes("icebergSnapshotFileCount",true))
        {
            this.IcebergSnapshotFileCount = null;
        }
        //      C# -> System.Int64? IcebergSnapshotId
        // GraphQL -> icebergSnapshotId: Long! (scalar)
        if (ec.Includes("icebergSnapshotId",true))
        {
            if(this.IcebergSnapshotId == null) {

                this.IcebergSnapshotId = new System.Int64();

            } else {


            }
        }
        else if (this.IcebergSnapshotId != null && ec.Excludes("icebergSnapshotId",true))
        {
            this.IcebergSnapshotId = null;
        }
        //      C# -> System.Int64? IcebergSnapshotSize
        // GraphQL -> icebergSnapshotSize: Long! (scalar)
        if (ec.Includes("icebergSnapshotSize",true))
        {
            if(this.IcebergSnapshotSize == null) {

                this.IcebergSnapshotSize = new System.Int64();

            } else {


            }
        }
        else if (this.IcebergSnapshotSize != null && ec.Excludes("icebergSnapshotSize",true))
        {
            this.IcebergSnapshotSize = null;
        }
        //      C# -> System.Boolean? IsSnapshotPartial
        // GraphQL -> isSnapshotPartial: Boolean! (scalar)
        if (ec.Includes("isSnapshotPartial",true))
        {
            if(this.IsSnapshotPartial == null) {

                this.IsSnapshotPartial = true;

            } else {


            }
        }
        else if (this.IsSnapshotPartial != null && ec.Excludes("isSnapshotPartial",true))
        {
            this.IsSnapshotPartial = null;
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
    }


    #endregion

    } // class IcebergTableSpecificSnapshot
    
    #endregion

    public static class ListIcebergTableSpecificSnapshotExtensions
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
            this List<IcebergTableSpecificSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IcebergTableSpecificSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IcebergTableSpecificSnapshot> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IcebergTableSpecificSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IcebergTableSpecificSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
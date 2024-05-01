// AwsNativeS3SpecificSnapshot.cs
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
    #region AwsNativeS3SpecificSnapshot
 
    public class AwsNativeS3SpecificSnapshot: BaseType, PolarisSpecificSnapshot
    {
        #region members

        //      C# -> System.Int64? FailedObjectCount
        // GraphQL -> failedObjectCount: Long! (scalar)
        [JsonProperty("failedObjectCount")]
        public System.Int64? FailedObjectCount { get; set; }

        //      C# -> System.Boolean? IsSnapshotPartial
        // GraphQL -> isSnapshotPartial: Boolean! (scalar)
        [JsonProperty("isSnapshotPartial")]
        public System.Boolean? IsSnapshotPartial { get; set; }

        //      C# -> System.Int64? ProcessedObjectCount
        // GraphQL -> processedObjectCount: Long! (scalar)
        [JsonProperty("processedObjectCount")]
        public System.Int64? ProcessedObjectCount { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsNativeS3SpecificSnapshot";
    }

    public AwsNativeS3SpecificSnapshot Set(
        System.Int64? FailedObjectCount = null,
        System.Boolean? IsSnapshotPartial = null,
        System.Int64? ProcessedObjectCount = null,
        System.String? SnapshotId = null
    ) 
    {
        if ( FailedObjectCount != null ) {
            this.FailedObjectCount = FailedObjectCount;
        }
        if ( IsSnapshotPartial != null ) {
            this.IsSnapshotPartial = IsSnapshotPartial;
        }
        if ( ProcessedObjectCount != null ) {
            this.ProcessedObjectCount = ProcessedObjectCount;
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
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? FailedObjectCount
        // GraphQL -> failedObjectCount: Long! (scalar)
        if (this.FailedObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failedObjectCount\n" ;
            } else {
                s += ind + "failedObjectCount\n" ;
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
        //      C# -> System.Int64? ProcessedObjectCount
        // GraphQL -> processedObjectCount: Long! (scalar)
        if (this.ProcessedObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "processedObjectCount\n" ;
            } else {
                s += ind + "processedObjectCount\n" ;
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? FailedObjectCount
        // GraphQL -> failedObjectCount: Long! (scalar)
        if (ec.Includes("failedObjectCount",true))
        {
            if(this.FailedObjectCount == null) {

                this.FailedObjectCount = new System.Int64();

            } else {


            }
        }
        else if (this.FailedObjectCount != null && ec.Excludes("failedObjectCount",true))
        {
            this.FailedObjectCount = null;
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
        //      C# -> System.Int64? ProcessedObjectCount
        // GraphQL -> processedObjectCount: Long! (scalar)
        if (ec.Includes("processedObjectCount",true))
        {
            if(this.ProcessedObjectCount == null) {

                this.ProcessedObjectCount = new System.Int64();

            } else {


            }
        }
        else if (this.ProcessedObjectCount != null && ec.Excludes("processedObjectCount",true))
        {
            this.ProcessedObjectCount = null;
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

    } // class AwsNativeS3SpecificSnapshot
    
    #endregion

    public static class ListAwsNativeS3SpecificSnapshotExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AwsNativeS3SpecificSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsNativeS3SpecificSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsNativeS3SpecificSnapshot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsNativeS3SpecificSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsNativeS3SpecificSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
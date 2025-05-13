// SnapshotScanConfig.cs
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
    #region SnapshotScanConfig
    public class SnapshotScanConfig: BaseType
    {
        #region members

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.Int32? MaxSnapshotsPerObject
        // GraphQL -> maxSnapshotsPerObject: Int! (scalar)
        [JsonProperty("maxSnapshotsPerObject")]
        public System.Int32? MaxSnapshotsPerObject { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnapshotScanConfig";
    }

    public SnapshotScanConfig Set(
        DateTime? EndTime = null,
        System.Int32? MaxSnapshotsPerObject = null,
        DateTime? StartTime = null
    ) 
    {
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( MaxSnapshotsPerObject != null ) {
            this.MaxSnapshotsPerObject = MaxSnapshotsPerObject;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
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
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.Int32? MaxSnapshotsPerObject
        // GraphQL -> maxSnapshotsPerObject: Int! (scalar)
        if (this.MaxSnapshotsPerObject != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxSnapshotsPerObject\n" ;
            } else {
                s += ind + "maxSnapshotsPerObject\n" ;
            }
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new DateTime();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.Int32? MaxSnapshotsPerObject
        // GraphQL -> maxSnapshotsPerObject: Int! (scalar)
        if (ec.Includes("maxSnapshotsPerObject",true))
        {
            if(this.MaxSnapshotsPerObject == null) {

                this.MaxSnapshotsPerObject = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxSnapshotsPerObject != null && ec.Excludes("maxSnapshotsPerObject",true))
        {
            this.MaxSnapshotsPerObject = null;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new DateTime();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
    }


    #endregion

    } // class SnapshotScanConfig
    
    #endregion

    public static class ListSnapshotScanConfigExtensions
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
            this List<SnapshotScanConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SnapshotScanConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotScanConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotScanConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnapshotScanConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// HuntScanFileTimeLimits.cs
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
    #region HuntScanFileTimeLimits
    public class HuntScanFileTimeLimits: BaseType
    {
        #region members

        //      C# -> DateTime? EarliestCreationTime
        // GraphQL -> earliestCreationTime: DateTime (scalar)
        [JsonProperty("earliestCreationTime")]
        public DateTime? EarliestCreationTime { get; set; }

        //      C# -> DateTime? EarliestModificationTime
        // GraphQL -> earliestModificationTime: DateTime (scalar)
        [JsonProperty("earliestModificationTime")]
        public DateTime? EarliestModificationTime { get; set; }

        //      C# -> DateTime? LatestCreationTime
        // GraphQL -> latestCreationTime: DateTime (scalar)
        [JsonProperty("latestCreationTime")]
        public DateTime? LatestCreationTime { get; set; }

        //      C# -> DateTime? LatestModificationTime
        // GraphQL -> latestModificationTime: DateTime (scalar)
        [JsonProperty("latestModificationTime")]
        public DateTime? LatestModificationTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HuntScanFileTimeLimits";
    }

    public HuntScanFileTimeLimits Set(
        DateTime? EarliestCreationTime = null,
        DateTime? EarliestModificationTime = null,
        DateTime? LatestCreationTime = null,
        DateTime? LatestModificationTime = null
    ) 
    {
        if ( EarliestCreationTime != null ) {
            this.EarliestCreationTime = EarliestCreationTime;
        }
        if ( EarliestModificationTime != null ) {
            this.EarliestModificationTime = EarliestModificationTime;
        }
        if ( LatestCreationTime != null ) {
            this.LatestCreationTime = LatestCreationTime;
        }
        if ( LatestModificationTime != null ) {
            this.LatestModificationTime = LatestModificationTime;
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
        //      C# -> DateTime? EarliestCreationTime
        // GraphQL -> earliestCreationTime: DateTime (scalar)
        if (this.EarliestCreationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "earliestCreationTime\n" ;
            } else {
                s += ind + "earliestCreationTime\n" ;
            }
        }
        //      C# -> DateTime? EarliestModificationTime
        // GraphQL -> earliestModificationTime: DateTime (scalar)
        if (this.EarliestModificationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "earliestModificationTime\n" ;
            } else {
                s += ind + "earliestModificationTime\n" ;
            }
        }
        //      C# -> DateTime? LatestCreationTime
        // GraphQL -> latestCreationTime: DateTime (scalar)
        if (this.LatestCreationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestCreationTime\n" ;
            } else {
                s += ind + "latestCreationTime\n" ;
            }
        }
        //      C# -> DateTime? LatestModificationTime
        // GraphQL -> latestModificationTime: DateTime (scalar)
        if (this.LatestModificationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestModificationTime\n" ;
            } else {
                s += ind + "latestModificationTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? EarliestCreationTime
        // GraphQL -> earliestCreationTime: DateTime (scalar)
        if (ec.Includes("earliestCreationTime",true))
        {
            if(this.EarliestCreationTime == null) {

                this.EarliestCreationTime = new DateTime();

            } else {


            }
        }
        else if (this.EarliestCreationTime != null && ec.Excludes("earliestCreationTime",true))
        {
            this.EarliestCreationTime = null;
        }
        //      C# -> DateTime? EarliestModificationTime
        // GraphQL -> earliestModificationTime: DateTime (scalar)
        if (ec.Includes("earliestModificationTime",true))
        {
            if(this.EarliestModificationTime == null) {

                this.EarliestModificationTime = new DateTime();

            } else {


            }
        }
        else if (this.EarliestModificationTime != null && ec.Excludes("earliestModificationTime",true))
        {
            this.EarliestModificationTime = null;
        }
        //      C# -> DateTime? LatestCreationTime
        // GraphQL -> latestCreationTime: DateTime (scalar)
        if (ec.Includes("latestCreationTime",true))
        {
            if(this.LatestCreationTime == null) {

                this.LatestCreationTime = new DateTime();

            } else {


            }
        }
        else if (this.LatestCreationTime != null && ec.Excludes("latestCreationTime",true))
        {
            this.LatestCreationTime = null;
        }
        //      C# -> DateTime? LatestModificationTime
        // GraphQL -> latestModificationTime: DateTime (scalar)
        if (ec.Includes("latestModificationTime",true))
        {
            if(this.LatestModificationTime == null) {

                this.LatestModificationTime = new DateTime();

            } else {


            }
        }
        else if (this.LatestModificationTime != null && ec.Excludes("latestModificationTime",true))
        {
            this.LatestModificationTime = null;
        }
    }


    #endregion

    } // class HuntScanFileTimeLimits
    
    #endregion

    public static class ListHuntScanFileTimeLimitsExtensions
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
            this List<HuntScanFileTimeLimits> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HuntScanFileTimeLimits> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HuntScanFileTimeLimits> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HuntScanFileTimeLimits());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HuntScanFileTimeLimits> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// AwsNativeRdsPointInTimeRestoreWindow.cs
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
    #region AwsNativeRdsPointInTimeRestoreWindow
    public class AwsNativeRdsPointInTimeRestoreWindow: BaseType
    {
        #region members

        //      C# -> DateTime? EarliestTime
        // GraphQL -> earliestTime: DateTime (scalar)
        [JsonProperty("earliestTime")]
        public DateTime? EarliestTime { get; set; }

        //      C# -> DateTime? LatestTime
        // GraphQL -> latestTime: DateTime (scalar)
        [JsonProperty("latestTime")]
        public DateTime? LatestTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsNativeRdsPointInTimeRestoreWindow";
    }

    public AwsNativeRdsPointInTimeRestoreWindow Set(
        DateTime? EarliestTime = null,
        DateTime? LatestTime = null
    ) 
    {
        if ( EarliestTime != null ) {
            this.EarliestTime = EarliestTime;
        }
        if ( LatestTime != null ) {
            this.LatestTime = LatestTime;
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
        //      C# -> DateTime? EarliestTime
        // GraphQL -> earliestTime: DateTime (scalar)
        if (this.EarliestTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "earliestTime\n" ;
            } else {
                s += ind + "earliestTime\n" ;
            }
        }
        //      C# -> DateTime? LatestTime
        // GraphQL -> latestTime: DateTime (scalar)
        if (this.LatestTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestTime\n" ;
            } else {
                s += ind + "latestTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? EarliestTime
        // GraphQL -> earliestTime: DateTime (scalar)
        if (ec.Includes("earliestTime",true))
        {
            if(this.EarliestTime == null) {

                this.EarliestTime = new DateTime();

            } else {


            }
        }
        else if (this.EarliestTime != null && ec.Excludes("earliestTime",true))
        {
            this.EarliestTime = null;
        }
        //      C# -> DateTime? LatestTime
        // GraphQL -> latestTime: DateTime (scalar)
        if (ec.Includes("latestTime",true))
        {
            if(this.LatestTime == null) {

                this.LatestTime = new DateTime();

            } else {


            }
        }
        else if (this.LatestTime != null && ec.Excludes("latestTime",true))
        {
            this.LatestTime = null;
        }
    }


    #endregion

    } // class AwsNativeRdsPointInTimeRestoreWindow
    
    #endregion

    public static class ListAwsNativeRdsPointInTimeRestoreWindowExtensions
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
            this List<AwsNativeRdsPointInTimeRestoreWindow> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsNativeRdsPointInTimeRestoreWindow> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsNativeRdsPointInTimeRestoreWindow> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsNativeRdsPointInTimeRestoreWindow());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsNativeRdsPointInTimeRestoreWindow> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// RecoveryPlanFilterTimeRange.cs
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
    #region RecoveryPlanFilterTimeRange
    public class RecoveryPlanFilterTimeRange: BaseType
    {
        #region members

        //      C# -> DateTime? FromTime
        // GraphQL -> fromTime: DateTime (scalar)
        [JsonProperty("fromTime")]
        public DateTime? FromTime { get; set; }

        //      C# -> DateTime? UntilTime
        // GraphQL -> untilTime: DateTime (scalar)
        [JsonProperty("untilTime")]
        public DateTime? UntilTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryPlanFilterTimeRange";
    }

    public RecoveryPlanFilterTimeRange Set(
        DateTime? FromTime = null,
        DateTime? UntilTime = null
    ) 
    {
        if ( FromTime != null ) {
            this.FromTime = FromTime;
        }
        if ( UntilTime != null ) {
            this.UntilTime = UntilTime;
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
        //      C# -> DateTime? FromTime
        // GraphQL -> fromTime: DateTime (scalar)
        if (this.FromTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fromTime\n" ;
            } else {
                s += ind + "fromTime\n" ;
            }
        }
        //      C# -> DateTime? UntilTime
        // GraphQL -> untilTime: DateTime (scalar)
        if (this.UntilTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "untilTime\n" ;
            } else {
                s += ind + "untilTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? FromTime
        // GraphQL -> fromTime: DateTime (scalar)
        if (ec.Includes("fromTime",true))
        {
            if(this.FromTime == null) {

                this.FromTime = new DateTime();

            } else {


            }
        }
        else if (this.FromTime != null && ec.Excludes("fromTime",true))
        {
            this.FromTime = null;
        }
        //      C# -> DateTime? UntilTime
        // GraphQL -> untilTime: DateTime (scalar)
        if (ec.Includes("untilTime",true))
        {
            if(this.UntilTime == null) {

                this.UntilTime = new DateTime();

            } else {


            }
        }
        else if (this.UntilTime != null && ec.Excludes("untilTime",true))
        {
            this.UntilTime = null;
        }
    }


    #endregion

    } // class RecoveryPlanFilterTimeRange
    
    #endregion

    public static class ListRecoveryPlanFilterTimeRangeExtensions
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
            this List<RecoveryPlanFilterTimeRange> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryPlanFilterTimeRange> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryPlanFilterTimeRange> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryPlanFilterTimeRange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryPlanFilterTimeRange> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
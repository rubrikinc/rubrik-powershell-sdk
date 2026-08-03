// ViolationInfo.cs
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
    #region ViolationInfo
    public class ViolationInfo: BaseType
    {
        #region members

        //      C# -> ViolationSeverity? ViolationSeverity
        // GraphQL -> violationSeverity: ViolationSeverity! (enum)
        [JsonProperty("violationSeverity")]
        public ViolationSeverity? ViolationSeverity { get; set; }

        //      C# -> System.Int32? CriticalCount
        // GraphQL -> criticalCount: Int! (scalar)
        [JsonProperty("criticalCount")]
        public System.Int32? CriticalCount { get; set; }

        //      C# -> System.Int32? HighCount
        // GraphQL -> highCount: Int! (scalar)
        [JsonProperty("highCount")]
        public System.Int32? HighCount { get; set; }

        //      C# -> System.Int32? LowCount
        // GraphQL -> lowCount: Int! (scalar)
        [JsonProperty("lowCount")]
        public System.Int32? LowCount { get; set; }

        //      C# -> System.Int32? MediumCount
        // GraphQL -> mediumCount: Int! (scalar)
        [JsonProperty("mediumCount")]
        public System.Int32? MediumCount { get; set; }

        //      C# -> System.Int32? TotalCount
        // GraphQL -> totalCount: Int! (scalar)
        [JsonProperty("totalCount")]
        public System.Int32? TotalCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ViolationInfo";
    }

    public ViolationInfo Set(
        ViolationSeverity? ViolationSeverity = null,
        System.Int32? CriticalCount = null,
        System.Int32? HighCount = null,
        System.Int32? LowCount = null,
        System.Int32? MediumCount = null,
        System.Int32? TotalCount = null
    ) 
    {
        if ( ViolationSeverity != null ) {
            this.ViolationSeverity = ViolationSeverity;
        }
        if ( CriticalCount != null ) {
            this.CriticalCount = CriticalCount;
        }
        if ( HighCount != null ) {
            this.HighCount = HighCount;
        }
        if ( LowCount != null ) {
            this.LowCount = LowCount;
        }
        if ( MediumCount != null ) {
            this.MediumCount = MediumCount;
        }
        if ( TotalCount != null ) {
            this.TotalCount = TotalCount;
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
        //      C# -> ViolationSeverity? ViolationSeverity
        // GraphQL -> violationSeverity: ViolationSeverity! (enum)
        if (this.ViolationSeverity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violationSeverity\n" ;
            } else {
                s += ind + "violationSeverity\n" ;
            }
        }
        //      C# -> System.Int32? CriticalCount
        // GraphQL -> criticalCount: Int! (scalar)
        if (this.CriticalCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "criticalCount\n" ;
            } else {
                s += ind + "criticalCount\n" ;
            }
        }
        //      C# -> System.Int32? HighCount
        // GraphQL -> highCount: Int! (scalar)
        if (this.HighCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "highCount\n" ;
            } else {
                s += ind + "highCount\n" ;
            }
        }
        //      C# -> System.Int32? LowCount
        // GraphQL -> lowCount: Int! (scalar)
        if (this.LowCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lowCount\n" ;
            } else {
                s += ind + "lowCount\n" ;
            }
        }
        //      C# -> System.Int32? MediumCount
        // GraphQL -> mediumCount: Int! (scalar)
        if (this.MediumCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mediumCount\n" ;
            } else {
                s += ind + "mediumCount\n" ;
            }
        }
        //      C# -> System.Int32? TotalCount
        // GraphQL -> totalCount: Int! (scalar)
        if (this.TotalCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalCount\n" ;
            } else {
                s += ind + "totalCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ViolationSeverity? ViolationSeverity
        // GraphQL -> violationSeverity: ViolationSeverity! (enum)
        if (ec.Includes("violationSeverity",true))
        {
            if(this.ViolationSeverity == null) {

                this.ViolationSeverity = new ViolationSeverity();

            } else {


            }
        }
        else if (this.ViolationSeverity != null && ec.Excludes("violationSeverity",true))
        {
            this.ViolationSeverity = null;
        }
        //      C# -> System.Int32? CriticalCount
        // GraphQL -> criticalCount: Int! (scalar)
        if (ec.Includes("criticalCount",true))
        {
            if(this.CriticalCount == null) {

                this.CriticalCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.CriticalCount != null && ec.Excludes("criticalCount",true))
        {
            this.CriticalCount = null;
        }
        //      C# -> System.Int32? HighCount
        // GraphQL -> highCount: Int! (scalar)
        if (ec.Includes("highCount",true))
        {
            if(this.HighCount == null) {

                this.HighCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.HighCount != null && ec.Excludes("highCount",true))
        {
            this.HighCount = null;
        }
        //      C# -> System.Int32? LowCount
        // GraphQL -> lowCount: Int! (scalar)
        if (ec.Includes("lowCount",true))
        {
            if(this.LowCount == null) {

                this.LowCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.LowCount != null && ec.Excludes("lowCount",true))
        {
            this.LowCount = null;
        }
        //      C# -> System.Int32? MediumCount
        // GraphQL -> mediumCount: Int! (scalar)
        if (ec.Includes("mediumCount",true))
        {
            if(this.MediumCount == null) {

                this.MediumCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.MediumCount != null && ec.Excludes("mediumCount",true))
        {
            this.MediumCount = null;
        }
        //      C# -> System.Int32? TotalCount
        // GraphQL -> totalCount: Int! (scalar)
        if (ec.Includes("totalCount",true))
        {
            if(this.TotalCount == null) {

                this.TotalCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalCount != null && ec.Excludes("totalCount",true))
        {
            this.TotalCount = null;
        }
    }


    #endregion

    } // class ViolationInfo
    
    #endregion

    public static class ListViolationInfoExtensions
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
            this List<ViolationInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ViolationInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ViolationInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ViolationInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ViolationInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
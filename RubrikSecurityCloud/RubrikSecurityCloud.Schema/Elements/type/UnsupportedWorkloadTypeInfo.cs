// UnsupportedWorkloadTypeInfo.cs
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
    #region UnsupportedWorkloadTypeInfo
    public class UnsupportedWorkloadTypeInfo: BaseType
    {
        #region members

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.Int32? NonPausedCount
        // GraphQL -> nonPausedCount: Int! (scalar)
        [JsonProperty("nonPausedCount")]
        public System.Int32? NonPausedCount { get; set; }

        //      C# -> System.Int32? PausedCount
        // GraphQL -> pausedCount: Int! (scalar)
        [JsonProperty("pausedCount")]
        public System.Int32? PausedCount { get; set; }

        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        [JsonProperty("workloadType")]
        public System.String? WorkloadType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UnsupportedWorkloadTypeInfo";
    }

    public UnsupportedWorkloadTypeInfo Set(
        System.String? DisplayName = null,
        System.Int32? NonPausedCount = null,
        System.Int32? PausedCount = null,
        System.String? WorkloadType = null
    ) 
    {
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( NonPausedCount != null ) {
            this.NonPausedCount = NonPausedCount;
        }
        if ( PausedCount != null ) {
            this.PausedCount = PausedCount;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
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
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.Int32? NonPausedCount
        // GraphQL -> nonPausedCount: Int! (scalar)
        if (this.NonPausedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nonPausedCount\n" ;
            } else {
                s += ind + "nonPausedCount\n" ;
            }
        }
        //      C# -> System.Int32? PausedCount
        // GraphQL -> pausedCount: Int! (scalar)
        if (this.PausedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pausedCount\n" ;
            } else {
                s += ind + "pausedCount\n" ;
            }
        }
        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        if (this.WorkloadType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadType\n" ;
            } else {
                s += ind + "workloadType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> System.Int32? NonPausedCount
        // GraphQL -> nonPausedCount: Int! (scalar)
        if (ec.Includes("nonPausedCount",true))
        {
            if(this.NonPausedCount == null) {

                this.NonPausedCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.NonPausedCount != null && ec.Excludes("nonPausedCount",true))
        {
            this.NonPausedCount = null;
        }
        //      C# -> System.Int32? PausedCount
        // GraphQL -> pausedCount: Int! (scalar)
        if (ec.Includes("pausedCount",true))
        {
            if(this.PausedCount == null) {

                this.PausedCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.PausedCount != null && ec.Excludes("pausedCount",true))
        {
            this.PausedCount = null;
        }
        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        if (ec.Includes("workloadType",true))
        {
            if(this.WorkloadType == null) {

                this.WorkloadType = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadType != null && ec.Excludes("workloadType",true))
        {
            this.WorkloadType = null;
        }
    }


    #endregion

    } // class UnsupportedWorkloadTypeInfo
    
    #endregion

    public static class ListUnsupportedWorkloadTypeInfoExtensions
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
            this List<UnsupportedWorkloadTypeInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UnsupportedWorkloadTypeInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UnsupportedWorkloadTypeInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UnsupportedWorkloadTypeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UnsupportedWorkloadTypeInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// JobStateCounts.cs
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
    #region JobStateCounts
    public class JobStateCounts: BaseType
    {
        #region members

        //      C# -> SaasWorkloadType? SnappableType
        // GraphQL -> snappableType: SaasWorkloadType! (enum)
        [JsonProperty("snappableType")]
        public SaasWorkloadType? SnappableType { get; set; }

        //      C# -> System.Int32? Failed
        // GraphQL -> failed: Int! (scalar)
        [JsonProperty("failed")]
        public System.Int32? Failed { get; set; }

        //      C# -> System.Int32? Success
        // GraphQL -> success: Int! (scalar)
        [JsonProperty("success")]
        public System.Int32? Success { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "JobStateCounts";
    }

    public JobStateCounts Set(
        SaasWorkloadType? SnappableType = null,
        System.Int32? Failed = null,
        System.Int32? Success = null
    ) 
    {
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
        }
        if ( Failed != null ) {
            this.Failed = Failed;
        }
        if ( Success != null ) {
            this.Success = Success;
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
        //      C# -> SaasWorkloadType? SnappableType
        // GraphQL -> snappableType: SaasWorkloadType! (enum)
        if (this.SnappableType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableType\n" ;
            } else {
                s += ind + "snappableType\n" ;
            }
        }
        //      C# -> System.Int32? Failed
        // GraphQL -> failed: Int! (scalar)
        if (this.Failed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failed\n" ;
            } else {
                s += ind + "failed\n" ;
            }
        }
        //      C# -> System.Int32? Success
        // GraphQL -> success: Int! (scalar)
        if (this.Success != null) {
            if (conf.Flat) {
                s += conf.Prefix + "success\n" ;
            } else {
                s += ind + "success\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SaasWorkloadType? SnappableType
        // GraphQL -> snappableType: SaasWorkloadType! (enum)
        if (ec.Includes("snappableType",true))
        {
            if(this.SnappableType == null) {

                this.SnappableType = new SaasWorkloadType();

            } else {


            }
        }
        else if (this.SnappableType != null && ec.Excludes("snappableType",true))
        {
            this.SnappableType = null;
        }
        //      C# -> System.Int32? Failed
        // GraphQL -> failed: Int! (scalar)
        if (ec.Includes("failed",true))
        {
            if(this.Failed == null) {

                this.Failed = Int32.MinValue;

            } else {


            }
        }
        else if (this.Failed != null && ec.Excludes("failed",true))
        {
            this.Failed = null;
        }
        //      C# -> System.Int32? Success
        // GraphQL -> success: Int! (scalar)
        if (ec.Includes("success",true))
        {
            if(this.Success == null) {

                this.Success = Int32.MinValue;

            } else {


            }
        }
        else if (this.Success != null && ec.Excludes("success",true))
        {
            this.Success = null;
        }
    }


    #endregion

    } // class JobStateCounts
    
    #endregion

    public static class ListJobStateCountsExtensions
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
            this List<JobStateCounts> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<JobStateCounts> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<JobStateCounts> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new JobStateCounts());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<JobStateCounts> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
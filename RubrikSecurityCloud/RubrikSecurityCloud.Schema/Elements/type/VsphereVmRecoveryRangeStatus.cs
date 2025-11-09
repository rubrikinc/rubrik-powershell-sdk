// VsphereVmRecoveryRangeStatus.cs
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
    #region VsphereVmRecoveryRangeStatus
    public class VsphereVmRecoveryRangeStatus: BaseType
    {
        #region members

        //      C# -> RecoveryRangeStatus? Status
        // GraphQL -> status: RecoveryRangeStatus! (enum)
        [JsonProperty("status")]
        public RecoveryRangeStatus? Status { get; set; }

        //      C# -> System.String? BeginTime
        // GraphQL -> beginTime: String (scalar)
        [JsonProperty("beginTime")]
        public System.String? BeginTime { get; set; }

        //      C# -> System.String? EndTime
        // GraphQL -> endTime: String (scalar)
        [JsonProperty("endTime")]
        public System.String? EndTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VsphereVmRecoveryRangeStatus";
    }

    public VsphereVmRecoveryRangeStatus Set(
        RecoveryRangeStatus? Status = null,
        System.String? BeginTime = null,
        System.String? EndTime = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( BeginTime != null ) {
            this.BeginTime = BeginTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
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
        //      C# -> RecoveryRangeStatus? Status
        // GraphQL -> status: RecoveryRangeStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? BeginTime
        // GraphQL -> beginTime: String (scalar)
        if (this.BeginTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "beginTime\n" ;
            } else {
                s += ind + "beginTime\n" ;
            }
        }
        //      C# -> System.String? EndTime
        // GraphQL -> endTime: String (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RecoveryRangeStatus? Status
        // GraphQL -> status: RecoveryRangeStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new RecoveryRangeStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? BeginTime
        // GraphQL -> beginTime: String (scalar)
        if (ec.Includes("beginTime",true))
        {
            if(this.BeginTime == null) {

                this.BeginTime = "FETCH";

            } else {


            }
        }
        else if (this.BeginTime != null && ec.Excludes("beginTime",true))
        {
            this.BeginTime = null;
        }
        //      C# -> System.String? EndTime
        // GraphQL -> endTime: String (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = "FETCH";

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
    }


    #endregion

    } // class VsphereVmRecoveryRangeStatus
    
    #endregion

    public static class ListVsphereVmRecoveryRangeStatusExtensions
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
            this List<VsphereVmRecoveryRangeStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VsphereVmRecoveryRangeStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VsphereVmRecoveryRangeStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereVmRecoveryRangeStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VsphereVmRecoveryRangeStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
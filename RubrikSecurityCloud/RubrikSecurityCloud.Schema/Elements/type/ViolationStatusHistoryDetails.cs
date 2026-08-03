// ViolationStatusHistoryDetails.cs
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
    #region ViolationStatusHistoryDetails
 
    public class ViolationStatusHistoryDetails: BaseType, ViolationHistoryDetailsUnion
    {
        #region members

        //      C# -> PolicyViolationStatus? NewStatus
        // GraphQL -> newStatus: PolicyViolationStatus! (enum)
        [JsonProperty("newStatus")]
        public PolicyViolationStatus? NewStatus { get; set; }

        //      C# -> PolicyViolationStatus? PreviousStatus
        // GraphQL -> previousStatus: PolicyViolationStatus! (enum)
        [JsonProperty("previousStatus")]
        public PolicyViolationStatus? PreviousStatus { get; set; }

        //      C# -> PolicyViolationStatusReason? StatusChangeReason
        // GraphQL -> statusChangeReason: PolicyViolationStatusReason! (enum)
        [JsonProperty("statusChangeReason")]
        public PolicyViolationStatusReason? StatusChangeReason { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ViolationStatusHistoryDetails";
    }

    public ViolationStatusHistoryDetails Set(
        PolicyViolationStatus? NewStatus = null,
        PolicyViolationStatus? PreviousStatus = null,
        PolicyViolationStatusReason? StatusChangeReason = null
    ) 
    {
        if ( NewStatus != null ) {
            this.NewStatus = NewStatus;
        }
        if ( PreviousStatus != null ) {
            this.PreviousStatus = PreviousStatus;
        }
        if ( StatusChangeReason != null ) {
            this.StatusChangeReason = StatusChangeReason;
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
        //      C# -> PolicyViolationStatus? NewStatus
        // GraphQL -> newStatus: PolicyViolationStatus! (enum)
        if (this.NewStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newStatus\n" ;
            } else {
                s += ind + "newStatus\n" ;
            }
        }
        //      C# -> PolicyViolationStatus? PreviousStatus
        // GraphQL -> previousStatus: PolicyViolationStatus! (enum)
        if (this.PreviousStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "previousStatus\n" ;
            } else {
                s += ind + "previousStatus\n" ;
            }
        }
        //      C# -> PolicyViolationStatusReason? StatusChangeReason
        // GraphQL -> statusChangeReason: PolicyViolationStatusReason! (enum)
        if (this.StatusChangeReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusChangeReason\n" ;
            } else {
                s += ind + "statusChangeReason\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PolicyViolationStatus? NewStatus
        // GraphQL -> newStatus: PolicyViolationStatus! (enum)
        if (ec.Includes("newStatus",true))
        {
            if(this.NewStatus == null) {

                this.NewStatus = new PolicyViolationStatus();

            } else {


            }
        }
        else if (this.NewStatus != null && ec.Excludes("newStatus",true))
        {
            this.NewStatus = null;
        }
        //      C# -> PolicyViolationStatus? PreviousStatus
        // GraphQL -> previousStatus: PolicyViolationStatus! (enum)
        if (ec.Includes("previousStatus",true))
        {
            if(this.PreviousStatus == null) {

                this.PreviousStatus = new PolicyViolationStatus();

            } else {


            }
        }
        else if (this.PreviousStatus != null && ec.Excludes("previousStatus",true))
        {
            this.PreviousStatus = null;
        }
        //      C# -> PolicyViolationStatusReason? StatusChangeReason
        // GraphQL -> statusChangeReason: PolicyViolationStatusReason! (enum)
        if (ec.Includes("statusChangeReason",true))
        {
            if(this.StatusChangeReason == null) {

                this.StatusChangeReason = new PolicyViolationStatusReason();

            } else {


            }
        }
        else if (this.StatusChangeReason != null && ec.Excludes("statusChangeReason",true))
        {
            this.StatusChangeReason = null;
        }
    }


    #endregion

    } // class ViolationStatusHistoryDetails
    
    #endregion

    public static class ListViolationStatusHistoryDetailsExtensions
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
            this List<ViolationStatusHistoryDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ViolationStatusHistoryDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ViolationStatusHistoryDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ViolationStatusHistoryDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ViolationStatusHistoryDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
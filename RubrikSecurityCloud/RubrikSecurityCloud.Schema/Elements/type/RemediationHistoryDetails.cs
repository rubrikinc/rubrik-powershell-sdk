// RemediationHistoryDetails.cs
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
    #region RemediationHistoryDetails
 
    public class RemediationHistoryDetails: BaseType, ViolationHistoryDetailsUnion
    {
        #region members

        //      C# -> RemediationState? RemediationState
        // GraphQL -> remediationState: RemediationState! (enum)
        [JsonProperty("remediationState")]
        public RemediationState? RemediationState { get; set; }

        //      C# -> RemediationType? RemediationType
        // GraphQL -> remediationType: RemediationType! (enum)
        [JsonProperty("remediationType")]
        public RemediationType? RemediationType { get; set; }

        //      C# -> System.String? RemediationId
        // GraphQL -> remediationId: String! (scalar)
        [JsonProperty("remediationId")]
        public System.String? RemediationId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RemediationHistoryDetails";
    }

    public RemediationHistoryDetails Set(
        RemediationState? RemediationState = null,
        RemediationType? RemediationType = null,
        System.String? RemediationId = null
    ) 
    {
        if ( RemediationState != null ) {
            this.RemediationState = RemediationState;
        }
        if ( RemediationType != null ) {
            this.RemediationType = RemediationType;
        }
        if ( RemediationId != null ) {
            this.RemediationId = RemediationId;
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
        //      C# -> RemediationState? RemediationState
        // GraphQL -> remediationState: RemediationState! (enum)
        if (this.RemediationState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remediationState\n" ;
            } else {
                s += ind + "remediationState\n" ;
            }
        }
        //      C# -> RemediationType? RemediationType
        // GraphQL -> remediationType: RemediationType! (enum)
        if (this.RemediationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remediationType\n" ;
            } else {
                s += ind + "remediationType\n" ;
            }
        }
        //      C# -> System.String? RemediationId
        // GraphQL -> remediationId: String! (scalar)
        if (this.RemediationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remediationId\n" ;
            } else {
                s += ind + "remediationId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RemediationState? RemediationState
        // GraphQL -> remediationState: RemediationState! (enum)
        if (ec.Includes("remediationState",true))
        {
            if(this.RemediationState == null) {

                this.RemediationState = new RemediationState();

            } else {


            }
        }
        else if (this.RemediationState != null && ec.Excludes("remediationState",true))
        {
            this.RemediationState = null;
        }
        //      C# -> RemediationType? RemediationType
        // GraphQL -> remediationType: RemediationType! (enum)
        if (ec.Includes("remediationType",true))
        {
            if(this.RemediationType == null) {

                this.RemediationType = new RemediationType();

            } else {


            }
        }
        else if (this.RemediationType != null && ec.Excludes("remediationType",true))
        {
            this.RemediationType = null;
        }
        //      C# -> System.String? RemediationId
        // GraphQL -> remediationId: String! (scalar)
        if (ec.Includes("remediationId",true))
        {
            if(this.RemediationId == null) {

                this.RemediationId = "FETCH";

            } else {


            }
        }
        else if (this.RemediationId != null && ec.Excludes("remediationId",true))
        {
            this.RemediationId = null;
        }
    }


    #endregion

    } // class RemediationHistoryDetails
    
    #endregion

    public static class ListRemediationHistoryDetailsExtensions
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
            this List<RemediationHistoryDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RemediationHistoryDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RemediationHistoryDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RemediationHistoryDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RemediationHistoryDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
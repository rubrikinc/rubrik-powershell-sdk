// NutanixBatchAsyncApiResponse.cs
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
    #region NutanixBatchAsyncApiResponse
    public class NutanixBatchAsyncApiResponse: BaseType
    {
        #region members

        //      C# -> List<NutanixAsyncRequestFailureSummary>? FailedRequests
        // GraphQL -> failedRequests: [NutanixAsyncRequestFailureSummary!]! (type)
        [JsonProperty("failedRequests")]
        public List<NutanixAsyncRequestFailureSummary>? FailedRequests { get; set; }

        //      C# -> List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests
        // GraphQL -> successfulRequests: [NutanixAsyncRequestSuccessSummary!]! (type)
        [JsonProperty("successfulRequests")]
        public List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixBatchAsyncApiResponse";
    }

    public NutanixBatchAsyncApiResponse Set(
        List<NutanixAsyncRequestFailureSummary>? FailedRequests = null,
        List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests = null
    ) 
    {
        if ( FailedRequests != null ) {
            this.FailedRequests = FailedRequests;
        }
        if ( SuccessfulRequests != null ) {
            this.SuccessfulRequests = SuccessfulRequests;
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
        //      C# -> List<NutanixAsyncRequestFailureSummary>? FailedRequests
        // GraphQL -> failedRequests: [NutanixAsyncRequestFailureSummary!]! (type)
        if (this.FailedRequests != null) {
            var fspec = this.FailedRequests.AsFieldSpec(conf.Child("failedRequests"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "failedRequests" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests
        // GraphQL -> successfulRequests: [NutanixAsyncRequestSuccessSummary!]! (type)
        if (this.SuccessfulRequests != null) {
            var fspec = this.SuccessfulRequests.AsFieldSpec(conf.Child("successfulRequests"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "successfulRequests" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<NutanixAsyncRequestFailureSummary>? FailedRequests
        // GraphQL -> failedRequests: [NutanixAsyncRequestFailureSummary!]! (type)
        if (ec.Includes("failedRequests",false))
        {
            if(this.FailedRequests == null) {

                this.FailedRequests = new List<NutanixAsyncRequestFailureSummary>();
                this.FailedRequests.ApplyExploratoryFieldSpec(ec.NewChild("failedRequests"));

            } else {

                this.FailedRequests.ApplyExploratoryFieldSpec(ec.NewChild("failedRequests"));

            }
        }
        else if (this.FailedRequests != null && ec.Excludes("failedRequests",false))
        {
            this.FailedRequests = null;
        }
        //      C# -> List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests
        // GraphQL -> successfulRequests: [NutanixAsyncRequestSuccessSummary!]! (type)
        if (ec.Includes("successfulRequests",false))
        {
            if(this.SuccessfulRequests == null) {

                this.SuccessfulRequests = new List<NutanixAsyncRequestSuccessSummary>();
                this.SuccessfulRequests.ApplyExploratoryFieldSpec(ec.NewChild("successfulRequests"));

            } else {

                this.SuccessfulRequests.ApplyExploratoryFieldSpec(ec.NewChild("successfulRequests"));

            }
        }
        else if (this.SuccessfulRequests != null && ec.Excludes("successfulRequests",false))
        {
            this.SuccessfulRequests = null;
        }
    }


    #endregion

    } // class NutanixBatchAsyncApiResponse
    
    #endregion

    public static class ListNutanixBatchAsyncApiResponseExtensions
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
            this List<NutanixBatchAsyncApiResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixBatchAsyncApiResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixBatchAsyncApiResponse> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixBatchAsyncApiResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixBatchAsyncApiResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
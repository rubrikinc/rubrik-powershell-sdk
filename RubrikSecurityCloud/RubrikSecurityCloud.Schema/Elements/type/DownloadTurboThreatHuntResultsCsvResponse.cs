// DownloadTurboThreatHuntResultsCsvResponse.cs
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
    #region DownloadTurboThreatHuntResultsCsvResponse
    public class DownloadTurboThreatHuntResultsCsvResponse: BaseType
    {
        #region members

        //      C# -> ThreatHuntCsvGenerationStatus? Status
        // GraphQL -> status: ThreatHuntCsvGenerationStatus! (enum)
        [JsonProperty("status")]
        public ThreatHuntCsvGenerationStatus? Status { get; set; }

        //      C# -> System.String? SignedUrl
        // GraphQL -> signedUrl: String! (scalar)
        [JsonProperty("signedUrl")]
        public System.String? SignedUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DownloadTurboThreatHuntResultsCsvResponse";
    }

    public DownloadTurboThreatHuntResultsCsvResponse Set(
        ThreatHuntCsvGenerationStatus? Status = null,
        System.String? SignedUrl = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( SignedUrl != null ) {
            this.SignedUrl = SignedUrl;
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
        //      C# -> ThreatHuntCsvGenerationStatus? Status
        // GraphQL -> status: ThreatHuntCsvGenerationStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? SignedUrl
        // GraphQL -> signedUrl: String! (scalar)
        if (this.SignedUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "signedUrl\n" ;
            } else {
                s += ind + "signedUrl\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ThreatHuntCsvGenerationStatus? Status
        // GraphQL -> status: ThreatHuntCsvGenerationStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ThreatHuntCsvGenerationStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? SignedUrl
        // GraphQL -> signedUrl: String! (scalar)
        if (ec.Includes("signedUrl",true))
        {
            if(this.SignedUrl == null) {

                this.SignedUrl = "FETCH";

            } else {


            }
        }
        else if (this.SignedUrl != null && ec.Excludes("signedUrl",true))
        {
            this.SignedUrl = null;
        }
    }


    #endregion

    } // class DownloadTurboThreatHuntResultsCsvResponse
    
    #endregion

    public static class ListDownloadTurboThreatHuntResultsCsvResponseExtensions
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
            this List<DownloadTurboThreatHuntResultsCsvResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DownloadTurboThreatHuntResultsCsvResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DownloadTurboThreatHuntResultsCsvResponse> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DownloadTurboThreatHuntResultsCsvResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DownloadTurboThreatHuntResultsCsvResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
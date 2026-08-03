// GetPrivilegedPrincipalsSummaryResp.cs
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
    #region GetPrivilegedPrincipalsSummaryResp
    public class GetPrivilegedPrincipalsSummaryResp: BaseType
    {
        #region members

        //      C# -> List<PrivilegeSummaryByPrincipalType>? PrincipalTypeSummary
        // GraphQL -> principalTypeSummary: [PrivilegeSummaryByPrincipalType!]! (type)
        [JsonProperty("principalTypeSummary")]
        public List<PrivilegeSummaryByPrincipalType>? PrincipalTypeSummary { get; set; }

        //      C# -> Count? TotalSummary
        // GraphQL -> totalSummary: Count (type)
        [JsonProperty("totalSummary")]
        public Count? TotalSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetPrivilegedPrincipalsSummaryResp";
    }

    public GetPrivilegedPrincipalsSummaryResp Set(
        List<PrivilegeSummaryByPrincipalType>? PrincipalTypeSummary = null,
        Count? TotalSummary = null
    ) 
    {
        if ( PrincipalTypeSummary != null ) {
            this.PrincipalTypeSummary = PrincipalTypeSummary;
        }
        if ( TotalSummary != null ) {
            this.TotalSummary = TotalSummary;
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
        //      C# -> List<PrivilegeSummaryByPrincipalType>? PrincipalTypeSummary
        // GraphQL -> principalTypeSummary: [PrivilegeSummaryByPrincipalType!]! (type)
        if (this.PrincipalTypeSummary != null) {
            var fspec = this.PrincipalTypeSummary.AsFieldSpec(conf.Child("principalTypeSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "principalTypeSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Count? TotalSummary
        // GraphQL -> totalSummary: Count (type)
        if (this.TotalSummary != null) {
            var fspec = this.TotalSummary.AsFieldSpec(conf.Child("totalSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<PrivilegeSummaryByPrincipalType>? PrincipalTypeSummary
        // GraphQL -> principalTypeSummary: [PrivilegeSummaryByPrincipalType!]! (type)
        if (ec.Includes("principalTypeSummary",false))
        {
            if(this.PrincipalTypeSummary == null) {

                this.PrincipalTypeSummary = new List<PrivilegeSummaryByPrincipalType>();
                this.PrincipalTypeSummary.ApplyExploratoryFieldSpec(ec.NewChild("principalTypeSummary"));

            } else {

                this.PrincipalTypeSummary.ApplyExploratoryFieldSpec(ec.NewChild("principalTypeSummary"));

            }
        }
        else if (this.PrincipalTypeSummary != null && ec.Excludes("principalTypeSummary",false))
        {
            this.PrincipalTypeSummary = null;
        }
        //      C# -> Count? TotalSummary
        // GraphQL -> totalSummary: Count (type)
        if (ec.Includes("totalSummary",false))
        {
            if(this.TotalSummary == null) {

                this.TotalSummary = new Count();
                this.TotalSummary.ApplyExploratoryFieldSpec(ec.NewChild("totalSummary"));

            } else {

                this.TotalSummary.ApplyExploratoryFieldSpec(ec.NewChild("totalSummary"));

            }
        }
        else if (this.TotalSummary != null && ec.Excludes("totalSummary",false))
        {
            this.TotalSummary = null;
        }
    }


    #endregion

    } // class GetPrivilegedPrincipalsSummaryResp
    
    #endregion

    public static class ListGetPrivilegedPrincipalsSummaryRespExtensions
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
            this List<GetPrivilegedPrincipalsSummaryResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetPrivilegedPrincipalsSummaryResp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetPrivilegedPrincipalsSummaryResp> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetPrivilegedPrincipalsSummaryResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetPrivilegedPrincipalsSummaryResp> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
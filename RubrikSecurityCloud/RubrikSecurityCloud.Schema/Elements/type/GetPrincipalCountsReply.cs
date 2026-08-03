// GetPrincipalCountsReply.cs
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
    #region GetPrincipalCountsReply
    public class GetPrincipalCountsReply: BaseType
    {
        #region members

        //      C# -> IdpPrincipalCounts? IdpPrincipalCount
        // GraphQL -> idpPrincipalCount: IDPPrincipalCounts (type)
        [JsonProperty("idpPrincipalCount")]
        public IdpPrincipalCounts? IdpPrincipalCount { get; set; }

        //      C# -> Count? PrincipalCount
        // GraphQL -> principalCount: Count (type)
        [JsonProperty("principalCount")]
        public Count? PrincipalCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetPrincipalCountsReply";
    }

    public GetPrincipalCountsReply Set(
        IdpPrincipalCounts? IdpPrincipalCount = null,
        Count? PrincipalCount = null
    ) 
    {
        if ( IdpPrincipalCount != null ) {
            this.IdpPrincipalCount = IdpPrincipalCount;
        }
        if ( PrincipalCount != null ) {
            this.PrincipalCount = PrincipalCount;
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
        //      C# -> IdpPrincipalCounts? IdpPrincipalCount
        // GraphQL -> idpPrincipalCount: IDPPrincipalCounts (type)
        if (this.IdpPrincipalCount != null) {
            var fspec = this.IdpPrincipalCount.AsFieldSpec(conf.Child("idpPrincipalCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "idpPrincipalCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Count? PrincipalCount
        // GraphQL -> principalCount: Count (type)
        if (this.PrincipalCount != null) {
            var fspec = this.PrincipalCount.AsFieldSpec(conf.Child("principalCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "principalCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IdpPrincipalCounts? IdpPrincipalCount
        // GraphQL -> idpPrincipalCount: IDPPrincipalCounts (type)
        if (ec.Includes("idpPrincipalCount",false))
        {
            if(this.IdpPrincipalCount == null) {

                this.IdpPrincipalCount = new IdpPrincipalCounts();
                this.IdpPrincipalCount.ApplyExploratoryFieldSpec(ec.NewChild("idpPrincipalCount"));

            } else {

                this.IdpPrincipalCount.ApplyExploratoryFieldSpec(ec.NewChild("idpPrincipalCount"));

            }
        }
        else if (this.IdpPrincipalCount != null && ec.Excludes("idpPrincipalCount",false))
        {
            this.IdpPrincipalCount = null;
        }
        //      C# -> Count? PrincipalCount
        // GraphQL -> principalCount: Count (type)
        if (ec.Includes("principalCount",false))
        {
            if(this.PrincipalCount == null) {

                this.PrincipalCount = new Count();
                this.PrincipalCount.ApplyExploratoryFieldSpec(ec.NewChild("principalCount"));

            } else {

                this.PrincipalCount.ApplyExploratoryFieldSpec(ec.NewChild("principalCount"));

            }
        }
        else if (this.PrincipalCount != null && ec.Excludes("principalCount",false))
        {
            this.PrincipalCount = null;
        }
    }


    #endregion

    } // class GetPrincipalCountsReply
    
    #endregion

    public static class ListGetPrincipalCountsReplyExtensions
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
            this List<GetPrincipalCountsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetPrincipalCountsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetPrincipalCountsReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetPrincipalCountsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetPrincipalCountsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
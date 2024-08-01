// PrincipalDetails.cs
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
    #region PrincipalDetails
    public class PrincipalDetails: BaseType
    {
        #region members

        //      C# -> List<UserAccessGroup>? DirectGroups
        // GraphQL -> directGroups: [UserAccessGroup!]! (type)
        [JsonProperty("directGroups")]
        public List<UserAccessGroup>? DirectGroups { get; set; }

        //      C# -> PrincipalSummary? PrincipalSummary
        // GraphQL -> principalSummary: PrincipalSummary! (type)
        [JsonProperty("principalSummary")]
        public PrincipalSummary? PrincipalSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrincipalDetails";
    }

    public PrincipalDetails Set(
        List<UserAccessGroup>? DirectGroups = null,
        PrincipalSummary? PrincipalSummary = null
    ) 
    {
        if ( DirectGroups != null ) {
            this.DirectGroups = DirectGroups;
        }
        if ( PrincipalSummary != null ) {
            this.PrincipalSummary = PrincipalSummary;
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
        //      C# -> List<UserAccessGroup>? DirectGroups
        // GraphQL -> directGroups: [UserAccessGroup!]! (type)
        if (this.DirectGroups != null) {
            var fspec = this.DirectGroups.AsFieldSpec(conf.Child("directGroups"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "directGroups" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrincipalSummary? PrincipalSummary
        // GraphQL -> principalSummary: PrincipalSummary! (type)
        if (this.PrincipalSummary != null) {
            var fspec = this.PrincipalSummary.AsFieldSpec(conf.Child("principalSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "principalSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<UserAccessGroup>? DirectGroups
        // GraphQL -> directGroups: [UserAccessGroup!]! (type)
        if (ec.Includes("directGroups",false))
        {
            if(this.DirectGroups == null) {

                this.DirectGroups = new List<UserAccessGroup>();
                this.DirectGroups.ApplyExploratoryFieldSpec(ec.NewChild("directGroups"));

            } else {

                this.DirectGroups.ApplyExploratoryFieldSpec(ec.NewChild("directGroups"));

            }
        }
        else if (this.DirectGroups != null && ec.Excludes("directGroups",false))
        {
            this.DirectGroups = null;
        }
        //      C# -> PrincipalSummary? PrincipalSummary
        // GraphQL -> principalSummary: PrincipalSummary! (type)
        if (ec.Includes("principalSummary",false))
        {
            if(this.PrincipalSummary == null) {

                this.PrincipalSummary = new PrincipalSummary();
                this.PrincipalSummary.ApplyExploratoryFieldSpec(ec.NewChild("principalSummary"));

            } else {

                this.PrincipalSummary.ApplyExploratoryFieldSpec(ec.NewChild("principalSummary"));

            }
        }
        else if (this.PrincipalSummary != null && ec.Excludes("principalSummary",false))
        {
            this.PrincipalSummary = null;
        }
    }


    #endregion

    } // class PrincipalDetails
    
    #endregion

    public static class ListPrincipalDetailsExtensions
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
            this List<PrincipalDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PrincipalDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrincipalDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
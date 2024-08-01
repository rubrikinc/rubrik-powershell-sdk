// ArchivalLocationWarningsDetails.cs
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
    #region ArchivalLocationWarningsDetails
    public class ArchivalLocationWarningsDetails: BaseType
    {
        #region members

        //      C# -> SlaArchivalWarning? Code
        // GraphQL -> code: SlaArchivalWarning! (enum)
        [JsonProperty("code")]
        public SlaArchivalWarning? Code { get; set; }

        //      C# -> SpecificArchivalLocationWarningDetails? SpecificArchivalLocationWarningDetails
        // GraphQL -> specificArchivalLocationWarningDetails: SpecificArchivalLocationWarningDetails! (interface)
        [JsonProperty("specificArchivalLocationWarningDetails")]
        public SpecificArchivalLocationWarningDetails? SpecificArchivalLocationWarningDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalLocationWarningsDetails";
    }

    public ArchivalLocationWarningsDetails Set(
        SlaArchivalWarning? Code = null,
        SpecificArchivalLocationWarningDetails? SpecificArchivalLocationWarningDetails = null
    ) 
    {
        if ( Code != null ) {
            this.Code = Code;
        }
        if ( SpecificArchivalLocationWarningDetails != null ) {
            this.SpecificArchivalLocationWarningDetails = SpecificArchivalLocationWarningDetails;
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
        //      C# -> SlaArchivalWarning? Code
        // GraphQL -> code: SlaArchivalWarning! (enum)
        if (this.Code != null) {
            if (conf.Flat) {
                s += conf.Prefix + "code\n" ;
            } else {
                s += ind + "code\n" ;
            }
        }
        //      C# -> SpecificArchivalLocationWarningDetails? SpecificArchivalLocationWarningDetails
        // GraphQL -> specificArchivalLocationWarningDetails: SpecificArchivalLocationWarningDetails! (interface)
        if (this.SpecificArchivalLocationWarningDetails != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.SpecificArchivalLocationWarningDetails, conf.Child("specificArchivalLocationWarningDetails"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "specificArchivalLocationWarningDetails" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SlaArchivalWarning? Code
        // GraphQL -> code: SlaArchivalWarning! (enum)
        if (ec.Includes("code",true))
        {
            if(this.Code == null) {

                this.Code = new SlaArchivalWarning();

            } else {


            }
        }
        else if (this.Code != null && ec.Excludes("code",true))
        {
            this.Code = null;
        }
        //      C# -> SpecificArchivalLocationWarningDetails? SpecificArchivalLocationWarningDetails
        // GraphQL -> specificArchivalLocationWarningDetails: SpecificArchivalLocationWarningDetails! (interface)
        if (ec.Includes("specificArchivalLocationWarningDetails",false))
        {
            if(this.SpecificArchivalLocationWarningDetails == null) {

                var impls = new List<SpecificArchivalLocationWarningDetails>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("specificArchivalLocationWarningDetails"));
                this.SpecificArchivalLocationWarningDetails = (SpecificArchivalLocationWarningDetails)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SpecificArchivalLocationWarningDetails>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("specificArchivalLocationWarningDetails"));
                this.SpecificArchivalLocationWarningDetails = (SpecificArchivalLocationWarningDetails)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.SpecificArchivalLocationWarningDetails != null && ec.Excludes("specificArchivalLocationWarningDetails",false))
        {
            this.SpecificArchivalLocationWarningDetails = null;
        }
    }


    #endregion

    } // class ArchivalLocationWarningsDetails
    
    #endregion

    public static class ListArchivalLocationWarningsDetailsExtensions
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
            this List<ArchivalLocationWarningsDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalLocationWarningsDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalLocationWarningsDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalLocationWarningsDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalLocationWarningsDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
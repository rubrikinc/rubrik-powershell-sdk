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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> SlaArchivalWarning? Code
        // GraphQL -> code: SlaArchivalWarning! (enum)
        if (this.Code != null) {
            s += ind + "code\n" ;
        }
        //      C# -> SpecificArchivalLocationWarningDetails? SpecificArchivalLocationWarningDetails
        // GraphQL -> specificArchivalLocationWarningDetails: SpecificArchivalLocationWarningDetails! (interface)
        if (this.SpecificArchivalLocationWarningDetails != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.SpecificArchivalLocationWarningDetails).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "specificArchivalLocationWarningDetails {\n" + fspec + ind + "}\n";
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SlaArchivalWarning? Code
        // GraphQL -> code: SlaArchivalWarning! (enum)
        if (this.Code == null && Exploration.Includes(parent + ".code", true))
        {
            this.Code = new SlaArchivalWarning();
        }
        //      C# -> SpecificArchivalLocationWarningDetails? SpecificArchivalLocationWarningDetails
        // GraphQL -> specificArchivalLocationWarningDetails: SpecificArchivalLocationWarningDetails! (interface)
        if (this.SpecificArchivalLocationWarningDetails == null && Exploration.Includes(parent + ".specificArchivalLocationWarningDetails"))
        {
            var impls = new List<SpecificArchivalLocationWarningDetails>();
            impls.ApplyExploratoryFieldSpec(parent + ".specificArchivalLocationWarningDetails");
            this.SpecificArchivalLocationWarningDetails = (SpecificArchivalLocationWarningDetails)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class ArchivalLocationWarningsDetails
    
    #endregion

    public static class ListArchivalLocationWarningsDetailsExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<ArchivalLocationWarningsDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalLocationWarningsDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalLocationWarningsDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
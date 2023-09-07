// SlaArchivalValidationWithWarnings.cs
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
    #region SlaArchivalValidationWithWarnings
    public class SlaArchivalValidationWithWarnings: BaseType
    {
        #region members

        //      C# -> SlaArchivalWarning? Code
        // GraphQL -> code: SlaArchivalWarning! (enum)
        [JsonProperty("code")]
        public SlaArchivalWarning? Code { get; set; }

        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        [JsonProperty("severity")]
        public WarningSeverityEnum? Severity { get; set; }

        //      C# -> SlaArchivalWarningsDetails? WarningDetails
        // GraphQL -> warningDetails: SlaArchivalWarningsDetails (interface)
        [JsonProperty("warningDetails")]
        public SlaArchivalWarningsDetails? WarningDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SlaArchivalValidationWithWarnings";
    }

    public SlaArchivalValidationWithWarnings Set(
        SlaArchivalWarning? Code = null,
        WarningSeverityEnum? Severity = null,
        SlaArchivalWarningsDetails? WarningDetails = null
    ) 
    {
        if ( Code != null ) {
            this.Code = Code;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( WarningDetails != null ) {
            this.WarningDetails = WarningDetails;
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
        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        if (this.Severity != null) {
            s += ind + "severity\n" ;
        }
        //      C# -> SlaArchivalWarningsDetails? WarningDetails
        // GraphQL -> warningDetails: SlaArchivalWarningsDetails (interface)
        if (this.WarningDetails != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.WarningDetails).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "warningDetails {\n" + fspec + ind + "}\n";
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SlaArchivalWarning? Code
        // GraphQL -> code: SlaArchivalWarning! (enum)
        if (this.Code == null && ec.Includes("code",true))
        {
            this.Code = new SlaArchivalWarning();
        }
        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        if (this.Severity == null && ec.Includes("severity",true))
        {
            this.Severity = new WarningSeverityEnum();
        }
        //      C# -> SlaArchivalWarningsDetails? WarningDetails
        // GraphQL -> warningDetails: SlaArchivalWarningsDetails (interface)
        if (this.WarningDetails == null && ec.Includes("warningDetails",false))
        {
            var impls = new List<SlaArchivalWarningsDetails>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("warningDetails"));
            this.WarningDetails = (SlaArchivalWarningsDetails)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class SlaArchivalValidationWithWarnings
    
    #endregion

    public static class ListSlaArchivalValidationWithWarningsExtensions
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
            this List<SlaArchivalValidationWithWarnings> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SlaArchivalValidationWithWarnings> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaArchivalValidationWithWarnings());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SlaArchivalValidationWithWarnings> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// SlaDomainWithWarnings.cs
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
    #region SlaDomainWithWarnings
    public class SlaDomainWithWarnings: BaseType
    {
        #region members

        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain! (interface)
        [JsonProperty("slaDomain")]
        public SlaDomain? SlaDomain { get; set; }

        //      C# -> List<SlaWarning>? Warnings
        // GraphQL -> warnings: [SlaWarning!]! (type)
        [JsonProperty("warnings")]
        public List<SlaWarning>? Warnings { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SlaDomainWithWarnings";
    }

    public SlaDomainWithWarnings Set(
        SlaDomain? SlaDomain = null,
        List<SlaWarning>? Warnings = null
    ) 
    {
        if ( SlaDomain != null ) {
            this.SlaDomain = SlaDomain;
        }
        if ( Warnings != null ) {
            this.Warnings = Warnings;
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
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain! (interface)
        if (this.SlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.SlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "slaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> List<SlaWarning>? Warnings
        // GraphQL -> warnings: [SlaWarning!]! (type)
        if (this.Warnings != null) {
            var fspec = this.Warnings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "warnings {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain! (interface)
        if (this.SlaDomain == null && Exploration.Includes(parent + ".slaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".slaDomain");
            this.SlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> List<SlaWarning>? Warnings
        // GraphQL -> warnings: [SlaWarning!]! (type)
        if (this.Warnings == null && Exploration.Includes(parent + ".warnings"))
        {
            this.Warnings = new List<SlaWarning>();
            this.Warnings.ApplyExploratoryFieldSpec(parent + ".warnings");
        }
    }


    #endregion

    } // class SlaDomainWithWarnings
    
    #endregion

    public static class ListSlaDomainWithWarningsExtensions
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
            this List<SlaDomainWithWarnings> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SlaDomainWithWarnings> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaDomainWithWarnings());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
// O365GroupMetadata.cs
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
    #region O365GroupMetadata
    public class O365GroupMetadata: BaseType
    {
        #region members

        //      C# -> O365ConfiguredGroupMetadata? ConfiguredGroupMetadata
        // GraphQL -> configuredGroupMetadata: O365ConfiguredGroupMetadata (type)
        [JsonProperty("configuredGroupMetadata")]
        public O365ConfiguredGroupMetadata? ConfiguredGroupMetadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365GroupMetadata";
    }

    public O365GroupMetadata Set(
        O365ConfiguredGroupMetadata? ConfiguredGroupMetadata = null
    ) 
    {
        if ( ConfiguredGroupMetadata != null ) {
            this.ConfiguredGroupMetadata = ConfiguredGroupMetadata;
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
        //      C# -> O365ConfiguredGroupMetadata? ConfiguredGroupMetadata
        // GraphQL -> configuredGroupMetadata: O365ConfiguredGroupMetadata (type)
        if (this.ConfiguredGroupMetadata != null) {
            var fspec = this.ConfiguredGroupMetadata.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "configuredGroupMetadata {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> O365ConfiguredGroupMetadata? ConfiguredGroupMetadata
        // GraphQL -> configuredGroupMetadata: O365ConfiguredGroupMetadata (type)
        if (this.ConfiguredGroupMetadata == null && ec.Includes("configuredGroupMetadata",false))
        {
            this.ConfiguredGroupMetadata = new O365ConfiguredGroupMetadata();
            this.ConfiguredGroupMetadata.ApplyExploratoryFieldSpec(ec.NewChild("configuredGroupMetadata"));
        }
    }


    #endregion

    } // class O365GroupMetadata
    
    #endregion

    public static class ListO365GroupMetadataExtensions
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
            this List<O365GroupMetadata> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365GroupMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365GroupMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<O365GroupMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
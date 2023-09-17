// LegalHoldInfo.cs
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
    #region LegalHoldInfo
    public class LegalHoldInfo: BaseType
    {
        #region members

        //      C# -> System.Boolean? ShouldHoldInPlace
        // GraphQL -> shouldHoldInPlace: Boolean! (scalar)
        [JsonProperty("shouldHoldInPlace")]
        public System.Boolean? ShouldHoldInPlace { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LegalHoldInfo";
    }

    public LegalHoldInfo Set(
        System.Boolean? ShouldHoldInPlace = null
    ) 
    {
        if ( ShouldHoldInPlace != null ) {
            this.ShouldHoldInPlace = ShouldHoldInPlace;
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
        //      C# -> System.Boolean? ShouldHoldInPlace
        // GraphQL -> shouldHoldInPlace: Boolean! (scalar)
        if (this.ShouldHoldInPlace != null) {
            s += ind + "shouldHoldInPlace\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? ShouldHoldInPlace
        // GraphQL -> shouldHoldInPlace: Boolean! (scalar)
        if (this.ShouldHoldInPlace == null && ec.Includes("shouldHoldInPlace",true))
        {
            this.ShouldHoldInPlace = true;
        }
    }


    #endregion

    } // class LegalHoldInfo
    
    #endregion

    public static class ListLegalHoldInfoExtensions
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
            this List<LegalHoldInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LegalHoldInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LegalHoldInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LegalHoldInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
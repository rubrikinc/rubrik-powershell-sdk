// UrlMap.cs
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
    #region UrlMap
    public class UrlMap: BaseType
    {
        #region members

        //      C# -> UrlName? UrlName
        // GraphQL -> urlName: UrlName! (enum)
        [JsonProperty("urlName")]
        public UrlName? UrlName { get; set; }

        //      C# -> System.String? DisplayText
        // GraphQL -> displayText: String! (scalar)
        [JsonProperty("displayText")]
        public System.String? DisplayText { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UrlMap";
    }

    public UrlMap Set(
        UrlName? UrlName = null,
        System.String? DisplayText = null
    ) 
    {
        if ( UrlName != null ) {
            this.UrlName = UrlName;
        }
        if ( DisplayText != null ) {
            this.DisplayText = DisplayText;
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
        //      C# -> UrlName? UrlName
        // GraphQL -> urlName: UrlName! (enum)
        if (this.UrlName != null) {
            s += ind + "urlName\n" ;
        }
        //      C# -> System.String? DisplayText
        // GraphQL -> displayText: String! (scalar)
        if (this.DisplayText != null) {
            s += ind + "displayText\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UrlName? UrlName
        // GraphQL -> urlName: UrlName! (enum)
        if (this.UrlName == null && ec.Includes("urlName",true))
        {
            this.UrlName = new UrlName();
        }
        //      C# -> System.String? DisplayText
        // GraphQL -> displayText: String! (scalar)
        if (this.DisplayText == null && ec.Includes("displayText",true))
        {
            this.DisplayText = "FETCH";
        }
    }


    #endregion

    } // class UrlMap
    
    #endregion

    public static class ListUrlMapExtensions
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
            this List<UrlMap> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UrlMap> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UrlMap());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<UrlMap> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// FullSpObjectExclusion.cs
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
    #region FullSpObjectExclusion
    public class FullSpObjectExclusion: BaseType
    {
        #region members

        //      C# -> SharePointDescendantType? ObjectType
        // GraphQL -> objectType: SharePointDescendantType! (enum)
        [JsonProperty("objectType")]
        public SharePointDescendantType? ObjectType { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Url
        // GraphQL -> url: URL! (scalar)
        [JsonProperty("url")]
        public System.String? Url { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FullSpObjectExclusion";
    }

    public FullSpObjectExclusion Set(
        SharePointDescendantType? ObjectType = null,
        System.String? Fid = null,
        System.String? Name = null,
        System.String? Url = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Url != null ) {
            this.Url = Url;
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
        //      C# -> SharePointDescendantType? ObjectType
        // GraphQL -> objectType: SharePointDescendantType! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid != null) {
            s += ind + "fid\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? Url
        // GraphQL -> url: URL! (scalar)
        if (this.Url != null) {
            s += ind + "url\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SharePointDescendantType? ObjectType
        // GraphQL -> objectType: SharePointDescendantType! (enum)
        if (this.ObjectType == null && ec.Includes("objectType",true))
        {
            this.ObjectType = new SharePointDescendantType();
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid == null && ec.Includes("fid",true))
        {
            this.Fid = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? Url
        // GraphQL -> url: URL! (scalar)
        if (this.Url == null && ec.Includes("url",true))
        {
            this.Url = "FETCH";
        }
    }


    #endregion

    } // class FullSpObjectExclusion
    
    #endregion

    public static class ListFullSpObjectExclusionExtensions
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
            this List<FullSpObjectExclusion> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FullSpObjectExclusion> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FullSpObjectExclusion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<FullSpObjectExclusion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
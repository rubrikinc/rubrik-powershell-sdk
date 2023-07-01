// PrecheckMessage.cs
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
    #region PrecheckMessage
    public class PrecheckMessage: BaseType
    {
        #region members

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> List<UrlMap>? UrlTextMap
        // GraphQL -> urlTextMap: [UrlMap!] (type)
        [JsonProperty("urlTextMap")]
        public List<UrlMap>? UrlTextMap { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrecheckMessage";
    }

    public PrecheckMessage Set(
        System.String? Message = null,
        List<UrlMap>? UrlTextMap = null
    ) 
    {
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( UrlTextMap != null ) {
            this.UrlTextMap = UrlTextMap;
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
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        //      C# -> List<UrlMap>? UrlTextMap
        // GraphQL -> urlTextMap: [UrlMap!] (type)
        if (this.UrlTextMap != null) {
            var fspec = this.UrlTextMap.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "urlTextMap {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = "FETCH";
        }
        //      C# -> List<UrlMap>? UrlTextMap
        // GraphQL -> urlTextMap: [UrlMap!] (type)
        if (this.UrlTextMap == null && Exploration.Includes(parent + ".urlTextMap"))
        {
            this.UrlTextMap = new List<UrlMap>();
            this.UrlTextMap.ApplyExploratoryFieldSpec(parent + ".urlTextMap");
        }
    }


    #endregion

    } // class PrecheckMessage
    
    #endregion

    public static class ListPrecheckMessageExtensions
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
            this List<PrecheckMessage> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrecheckMessage> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PrecheckMessage());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
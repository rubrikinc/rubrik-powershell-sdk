// FilesetArraySpec.cs
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
    #region FilesetArraySpec
    public class FilesetArraySpec: BaseType
    {
        #region members

        //      C# -> System.String? ProxyHostId
        // GraphQL -> proxyHostId: String (scalar)
        [JsonProperty("proxyHostId")]
        public System.String? ProxyHostId { get; set; }


        #endregion

    #region methods

    public FilesetArraySpec Set(
        System.String? ProxyHostId = null
    ) 
    {
        if ( ProxyHostId != null ) {
            this.ProxyHostId = ProxyHostId;
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
        //      C# -> System.String? ProxyHostId
        // GraphQL -> proxyHostId: String (scalar)
        if (this.ProxyHostId != null) {
            s += ind + "proxyHostId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ProxyHostId
        // GraphQL -> proxyHostId: String (scalar)
        if (this.ProxyHostId == null && Exploration.Includes(parent + ".proxyHostId", true))
        {
            this.ProxyHostId = "FETCH";
        }
    }


    #endregion

    } // class FilesetArraySpec
    
    #endregion

    public static class ListFilesetArraySpecExtensions
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
            this List<FilesetArraySpec> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FilesetArraySpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetArraySpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
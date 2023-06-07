// AppIdForType.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region AppIdForType
    public class AppIdForType: BaseType
    {
        #region members

        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? AppType
        // GraphQL -> appType: String! (scalar)
        [JsonProperty("appType")]
        public System.String? AppType { get; set; }


        #endregion

    #region methods

    public AppIdForType Set(
        System.String? AppId = null,
        System.String? AppType = null
    ) 
    {
        if ( AppId != null ) {
            this.AppId = AppId;
        }
        if ( AppType != null ) {
            this.AppType = AppType;
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
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId != null) {
            s += ind + "appId\n" ;
        }
        //      C# -> System.String? AppType
        // GraphQL -> appType: String! (scalar)
        if (this.AppType != null) {
            s += ind + "appType\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId == null && Exploration.Includes(parent + ".appId", true))
        {
            this.AppId = "FETCH";
        }
        //      C# -> System.String? AppType
        // GraphQL -> appType: String! (scalar)
        if (this.AppType == null && Exploration.Includes(parent + ".appType", true))
        {
            this.AppType = "FETCH";
        }
    }


    #endregion

    } // class AppIdForType
    
    #endregion

    public static class ListAppIdForTypeExtensions
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
            this List<AppIdForType> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AppIdForType> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AppIdForType());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
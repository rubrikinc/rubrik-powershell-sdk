// FakeData.cs
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
    #region FakeData
    public class FakeData: BaseType
    {
        #region members

        //      C# -> System.String? Data
        // GraphQL -> data: String! (scalar)
        [JsonProperty("data")]
        public System.String? Data { get; set; }


        #endregion

    #region methods

    public FakeData Set(
        System.String? Data = null
    ) 
    {
        if ( Data != null ) {
            this.Data = Data;
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
        //      C# -> System.String? Data
        // GraphQL -> data: String! (scalar)
        if (this.Data != null) {
            s += ind + "data\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Data
        // GraphQL -> data: String! (scalar)
        if (this.Data == null && Exploration.Includes(parent + ".data", true))
        {
            this.Data = "FETCH";
        }
    }


    #endregion

    } // class FakeData
    
    #endregion

    public static class ListFakeDataExtensions
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
            this List<FakeData> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FakeData> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FakeData());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
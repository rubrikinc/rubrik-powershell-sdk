// NetworkHostProject.cs
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
    #region NetworkHostProject
    public class NetworkHostProject: BaseType
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        [JsonProperty("projectId")]
        public System.String? ProjectId { get; set; }


        #endregion

    #region methods

    public NetworkHostProject Set(
        System.String? Name = null,
        System.String? NativeId = null,
        System.String? ProjectId = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeId != null ) {
            this.NativeId = NativeId;
        }
        if ( ProjectId != null ) {
            this.ProjectId = ProjectId;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId != null) {
            s += ind + "nativeId\n" ;
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId != null) {
            s += ind + "projectId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId == null && Exploration.Includes(parent + ".nativeId", true))
        {
            this.NativeId = "FETCH";
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId == null && Exploration.Includes(parent + ".projectId", true))
        {
            this.ProjectId = "FETCH";
        }
    }


    #endregion

    } // class NetworkHostProject
    
    #endregion

    public static class ListNetworkHostProjectExtensions
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
            this List<NetworkHostProject> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NetworkHostProject> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NetworkHostProject());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
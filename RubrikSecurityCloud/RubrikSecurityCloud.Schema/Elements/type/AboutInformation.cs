// AboutInformation.cs
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
    #region AboutInformation
    public class AboutInformation: BaseType
    {
        #region members

        //      C# -> System.String? ApiType
        // GraphQL -> apiType: String! (scalar)
        [JsonProperty("apiType")]
        public System.String? ApiType { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        [JsonProperty("osType")]
        public System.String? OsType { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AboutInformation";
    }

    public AboutInformation Set(
        System.String? ApiType = null,
        System.String? Name = null,
        System.String? OsType = null,
        System.String? Version = null
    ) 
    {
        if ( ApiType != null ) {
            this.ApiType = ApiType;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( Version != null ) {
            this.Version = Version;
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
        //      C# -> System.String? ApiType
        // GraphQL -> apiType: String! (scalar)
        if (this.ApiType != null) {
            s += ind + "apiType\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        if (this.OsType != null) {
            s += ind + "osType\n" ;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ApiType
        // GraphQL -> apiType: String! (scalar)
        if (this.ApiType == null && Exploration.Includes(parent + ".apiType", true))
        {
            this.ApiType = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        if (this.OsType == null && Exploration.Includes(parent + ".osType", true))
        {
            this.OsType = "FETCH";
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = "FETCH";
        }
    }


    #endregion

    } // class AboutInformation
    
    #endregion

    public static class ListAboutInformationExtensions
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
            this List<AboutInformation> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AboutInformation> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AboutInformation());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
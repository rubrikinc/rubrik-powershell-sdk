// SapHanaSystemInformation.cs
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
    #region SapHanaSystemInformation
    public class SapHanaSystemInformation: BaseType
    {
        #region members

        //      C# -> SapHanaSystemAuthType? AuthType
        // GraphQL -> authType: SapHanaSystemAuthType! (enum)
        [JsonProperty("authType")]
        public SapHanaSystemAuthType? AuthType { get; set; }

        //      C# -> System.String? HanaVersion
        // GraphQL -> hanaVersion: String! (scalar)
        [JsonProperty("hanaVersion")]
        public System.String? HanaVersion { get; set; }

        //      C# -> System.Boolean? IsDtEnabled
        // GraphQL -> isDtEnabled: Boolean! (scalar)
        [JsonProperty("isDtEnabled")]
        public System.Boolean? IsDtEnabled { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaSystemInformation";
    }

    public SapHanaSystemInformation Set(
        SapHanaSystemAuthType? AuthType = null,
        System.String? HanaVersion = null,
        System.Boolean? IsDtEnabled = null
    ) 
    {
        if ( AuthType != null ) {
            this.AuthType = AuthType;
        }
        if ( HanaVersion != null ) {
            this.HanaVersion = HanaVersion;
        }
        if ( IsDtEnabled != null ) {
            this.IsDtEnabled = IsDtEnabled;
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
        //      C# -> SapHanaSystemAuthType? AuthType
        // GraphQL -> authType: SapHanaSystemAuthType! (enum)
        if (this.AuthType != null) {
            s += ind + "authType\n" ;
        }
        //      C# -> System.String? HanaVersion
        // GraphQL -> hanaVersion: String! (scalar)
        if (this.HanaVersion != null) {
            s += ind + "hanaVersion\n" ;
        }
        //      C# -> System.Boolean? IsDtEnabled
        // GraphQL -> isDtEnabled: Boolean! (scalar)
        if (this.IsDtEnabled != null) {
            s += ind + "isDtEnabled\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SapHanaSystemAuthType? AuthType
        // GraphQL -> authType: SapHanaSystemAuthType! (enum)
        if (this.AuthType == null && Exploration.Includes(parent + ".authType", true))
        {
            this.AuthType = new SapHanaSystemAuthType();
        }
        //      C# -> System.String? HanaVersion
        // GraphQL -> hanaVersion: String! (scalar)
        if (this.HanaVersion == null && Exploration.Includes(parent + ".hanaVersion", true))
        {
            this.HanaVersion = "FETCH";
        }
        //      C# -> System.Boolean? IsDtEnabled
        // GraphQL -> isDtEnabled: Boolean! (scalar)
        if (this.IsDtEnabled == null && Exploration.Includes(parent + ".isDtEnabled", true))
        {
            this.IsDtEnabled = true;
        }
    }


    #endregion

    } // class SapHanaSystemInformation
    
    #endregion

    public static class ListSapHanaSystemInformationExtensions
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
            this List<SapHanaSystemInformation> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaSystemInformation> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaSystemInformation());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
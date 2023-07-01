// NtpServerConfiguration.cs
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
    #region NtpServerConfiguration
    public class NtpServerConfiguration: BaseType
    {
        #region members

        //      C# -> System.String? Server
        // GraphQL -> server: String! (scalar)
        [JsonProperty("server")]
        public System.String? Server { get; set; }

        //      C# -> NtpSymmKeyConfiguration? SymmetricKey
        // GraphQL -> symmetricKey: NtpSymmKeyConfiguration (type)
        [JsonProperty("symmetricKey")]
        public NtpSymmKeyConfiguration? SymmetricKey { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NtpServerConfiguration";
    }

    public NtpServerConfiguration Set(
        System.String? Server = null,
        NtpSymmKeyConfiguration? SymmetricKey = null
    ) 
    {
        if ( Server != null ) {
            this.Server = Server;
        }
        if ( SymmetricKey != null ) {
            this.SymmetricKey = SymmetricKey;
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
        //      C# -> System.String? Server
        // GraphQL -> server: String! (scalar)
        if (this.Server != null) {
            s += ind + "server\n" ;
        }
        //      C# -> NtpSymmKeyConfiguration? SymmetricKey
        // GraphQL -> symmetricKey: NtpSymmKeyConfiguration (type)
        if (this.SymmetricKey != null) {
            var fspec = this.SymmetricKey.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "symmetricKey {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Server
        // GraphQL -> server: String! (scalar)
        if (this.Server == null && Exploration.Includes(parent + ".server", true))
        {
            this.Server = "FETCH";
        }
        //      C# -> NtpSymmKeyConfiguration? SymmetricKey
        // GraphQL -> symmetricKey: NtpSymmKeyConfiguration (type)
        if (this.SymmetricKey == null && Exploration.Includes(parent + ".symmetricKey"))
        {
            this.SymmetricKey = new NtpSymmKeyConfiguration();
            this.SymmetricKey.ApplyExploratoryFieldSpec(parent + ".symmetricKey");
        }
    }


    #endregion

    } // class NtpServerConfiguration
    
    #endregion

    public static class ListNtpServerConfigurationExtensions
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
            this List<NtpServerConfiguration> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NtpServerConfiguration> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NtpServerConfiguration());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
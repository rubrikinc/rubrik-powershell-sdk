// KmsEncryptionKey.cs
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
    #region KmsEncryptionKey
    public class KmsEncryptionKey: BaseType
    {
        #region members

        //      C# -> List<System.String>? Aliases
        // GraphQL -> aliases: [String!]! (scalar)
        [JsonProperty("aliases")]
        public List<System.String>? Aliases { get; set; }

        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        [JsonProperty("arn")]
        public System.String? Arn { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }


        #endregion

    #region methods

    public KmsEncryptionKey Set(
        List<System.String>? Aliases = null,
        System.String? Arn = null,
        System.String? Id = null
    ) 
    {
        if ( Aliases != null ) {
            this.Aliases = Aliases;
        }
        if ( Arn != null ) {
            this.Arn = Arn;
        }
        if ( Id != null ) {
            this.Id = Id;
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
        //      C# -> List<System.String>? Aliases
        // GraphQL -> aliases: [String!]! (scalar)
        if (this.Aliases != null) {
            s += ind + "aliases\n" ;
        }
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (this.Arn != null) {
            s += ind + "arn\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? Aliases
        // GraphQL -> aliases: [String!]! (scalar)
        if (this.Aliases == null && Exploration.Includes(parent + ".aliases", true))
        {
            this.Aliases = new List<System.String>();
        }
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (this.Arn == null && Exploration.Includes(parent + ".arn", true))
        {
            this.Arn = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
    }


    #endregion

    } // class KmsEncryptionKey
    
    #endregion

    public static class ListKmsEncryptionKeyExtensions
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
            this List<KmsEncryptionKey> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<KmsEncryptionKey> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new KmsEncryptionKey());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "KmsEncryptionKey";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? Aliases
        // GraphQL -> aliases: [String!]! (scalar)
        if (this.Aliases != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aliases\n" ;
            } else {
                s += ind + "aliases\n" ;
            }
        }
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (this.Arn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "arn\n" ;
            } else {
                s += ind + "arn\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? Aliases
        // GraphQL -> aliases: [String!]! (scalar)
        if (ec.Includes("aliases",true))
        {
            if(this.Aliases == null) {

                this.Aliases = new List<System.String>();

            } else {


            }
        }
        else if (this.Aliases != null && ec.Excludes("aliases",true))
        {
            this.Aliases = null;
        }
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (ec.Includes("arn",true))
        {
            if(this.Arn == null) {

                this.Arn = "FETCH";

            } else {


            }
        }
        else if (this.Arn != null && ec.Excludes("arn",true))
        {
            this.Arn = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
    }


    #endregion

    } // class KmsEncryptionKey
    
    #endregion

    public static class ListKmsEncryptionKeyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<KmsEncryptionKey> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<KmsEncryptionKey> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<KmsEncryptionKey> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new KmsEncryptionKey());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<KmsEncryptionKey> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
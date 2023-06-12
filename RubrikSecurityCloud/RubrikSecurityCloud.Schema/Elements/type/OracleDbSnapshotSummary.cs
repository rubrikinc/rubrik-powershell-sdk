// OracleDbSnapshotSummary.cs
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
    #region OracleDbSnapshotSummary
    public class OracleDbSnapshotSummary: BaseType
    {
        #region members

        //      C# -> System.String? DatabaseName
        // GraphQL -> databaseName: String! (scalar)
        [JsonProperty("databaseName")]
        public System.String? DatabaseName { get; set; }

        //      C# -> System.String? HostOrRacManagedId
        // GraphQL -> hostOrRacManagedId: String (scalar)
        [JsonProperty("hostOrRacManagedId")]
        public System.String? HostOrRacManagedId { get; set; }

        //      C# -> System.String? HostOrRacName
        // GraphQL -> hostOrRacName: String (scalar)
        [JsonProperty("hostOrRacName")]
        public System.String? HostOrRacName { get; set; }

        //      C# -> System.Boolean? IsValid
        // GraphQL -> isValid: Boolean (scalar)
        [JsonProperty("isValid")]
        public System.Boolean? IsValid { get; set; }

        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        [JsonProperty("tablespaces")]
        public List<System.String>? Tablespaces { get; set; }

        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        [JsonProperty("baseSnapshotSummary")]
        public BaseSnapshotSummary? BaseSnapshotSummary { get; set; }


        #endregion

    #region methods

    public OracleDbSnapshotSummary Set(
        System.String? DatabaseName = null,
        System.String? HostOrRacManagedId = null,
        System.String? HostOrRacName = null,
        System.Boolean? IsValid = null,
        List<System.String>? Tablespaces = null,
        BaseSnapshotSummary? BaseSnapshotSummary = null
    ) 
    {
        if ( DatabaseName != null ) {
            this.DatabaseName = DatabaseName;
        }
        if ( HostOrRacManagedId != null ) {
            this.HostOrRacManagedId = HostOrRacManagedId;
        }
        if ( HostOrRacName != null ) {
            this.HostOrRacName = HostOrRacName;
        }
        if ( IsValid != null ) {
            this.IsValid = IsValid;
        }
        if ( Tablespaces != null ) {
            this.Tablespaces = Tablespaces;
        }
        if ( BaseSnapshotSummary != null ) {
            this.BaseSnapshotSummary = BaseSnapshotSummary;
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
        //      C# -> System.String? DatabaseName
        // GraphQL -> databaseName: String! (scalar)
        if (this.DatabaseName != null) {
            s += ind + "databaseName\n" ;
        }
        //      C# -> System.String? HostOrRacManagedId
        // GraphQL -> hostOrRacManagedId: String (scalar)
        if (this.HostOrRacManagedId != null) {
            s += ind + "hostOrRacManagedId\n" ;
        }
        //      C# -> System.String? HostOrRacName
        // GraphQL -> hostOrRacName: String (scalar)
        if (this.HostOrRacName != null) {
            s += ind + "hostOrRacName\n" ;
        }
        //      C# -> System.Boolean? IsValid
        // GraphQL -> isValid: Boolean (scalar)
        if (this.IsValid != null) {
            s += ind + "isValid\n" ;
        }
        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        if (this.Tablespaces != null) {
            s += ind + "tablespaces\n" ;
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (this.BaseSnapshotSummary != null) {
            var fspec = this.BaseSnapshotSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "baseSnapshotSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? DatabaseName
        // GraphQL -> databaseName: String! (scalar)
        if (this.DatabaseName == null && Exploration.Includes(parent + ".databaseName", true))
        {
            this.DatabaseName = "FETCH";
        }
        //      C# -> System.String? HostOrRacManagedId
        // GraphQL -> hostOrRacManagedId: String (scalar)
        if (this.HostOrRacManagedId == null && Exploration.Includes(parent + ".hostOrRacManagedId", true))
        {
            this.HostOrRacManagedId = "FETCH";
        }
        //      C# -> System.String? HostOrRacName
        // GraphQL -> hostOrRacName: String (scalar)
        if (this.HostOrRacName == null && Exploration.Includes(parent + ".hostOrRacName", true))
        {
            this.HostOrRacName = "FETCH";
        }
        //      C# -> System.Boolean? IsValid
        // GraphQL -> isValid: Boolean (scalar)
        if (this.IsValid == null && Exploration.Includes(parent + ".isValid", true))
        {
            this.IsValid = true;
        }
        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        if (this.Tablespaces == null && Exploration.Includes(parent + ".tablespaces", true))
        {
            this.Tablespaces = new List<System.String>();
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (this.BaseSnapshotSummary == null && Exploration.Includes(parent + ".baseSnapshotSummary"))
        {
            this.BaseSnapshotSummary = new BaseSnapshotSummary();
            this.BaseSnapshotSummary.ApplyExploratoryFieldSpec(parent + ".baseSnapshotSummary");
        }
    }


    #endregion

    } // class OracleDbSnapshotSummary
    
    #endregion

    public static class ListOracleDbSnapshotSummaryExtensions
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
            this List<OracleDbSnapshotSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleDbSnapshotSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleDbSnapshotSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
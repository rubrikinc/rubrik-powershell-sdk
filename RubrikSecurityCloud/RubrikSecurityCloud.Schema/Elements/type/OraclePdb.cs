// OraclePdb.cs
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
    #region OraclePdb
    public class OraclePdb: BaseType
    {
        #region members

        //      C# -> OraclePdbOpenMode? OpenMode
        // GraphQL -> openMode: OraclePdbOpenMode! (enum)
        [JsonProperty("openMode")]
        public OraclePdbOpenMode? OpenMode { get; set; }

        //      C# -> System.Int64? ApplicationRootContainerId
        // GraphQL -> applicationRootContainerId: Long! (scalar)
        [JsonProperty("applicationRootContainerId")]
        public System.Int64? ApplicationRootContainerId { get; set; }

        //      C# -> System.Int64? DbId
        // GraphQL -> dbId: Long! (scalar)
        [JsonProperty("dbId")]
        public System.Int64? DbId { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> System.Boolean? IsApplicationPdb
        // GraphQL -> isApplicationPdb: Boolean! (scalar)
        [JsonProperty("isApplicationPdb")]
        public System.Boolean? IsApplicationPdb { get; set; }

        //      C# -> System.Boolean? IsApplicationRoot
        // GraphQL -> isApplicationRoot: Boolean! (scalar)
        [JsonProperty("isApplicationRoot")]
        public System.Boolean? IsApplicationRoot { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OraclePdb";
    }

    public OraclePdb Set(
        OraclePdbOpenMode? OpenMode = null,
        System.Int64? ApplicationRootContainerId = null,
        System.Int64? DbId = null,
        System.Int64? Id = null,
        System.Boolean? IsApplicationPdb = null,
        System.Boolean? IsApplicationRoot = null,
        System.String? Name = null
    ) 
    {
        if ( OpenMode != null ) {
            this.OpenMode = OpenMode;
        }
        if ( ApplicationRootContainerId != null ) {
            this.ApplicationRootContainerId = ApplicationRootContainerId;
        }
        if ( DbId != null ) {
            this.DbId = DbId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsApplicationPdb != null ) {
            this.IsApplicationPdb = IsApplicationPdb;
        }
        if ( IsApplicationRoot != null ) {
            this.IsApplicationRoot = IsApplicationRoot;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> OraclePdbOpenMode? OpenMode
        // GraphQL -> openMode: OraclePdbOpenMode! (enum)
        if (this.OpenMode != null) {
            s += ind + "openMode\n" ;
        }
        //      C# -> System.Int64? ApplicationRootContainerId
        // GraphQL -> applicationRootContainerId: Long! (scalar)
        if (this.ApplicationRootContainerId != null) {
            s += ind + "applicationRootContainerId\n" ;
        }
        //      C# -> System.Int64? DbId
        // GraphQL -> dbId: Long! (scalar)
        if (this.DbId != null) {
            s += ind + "dbId\n" ;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsApplicationPdb
        // GraphQL -> isApplicationPdb: Boolean! (scalar)
        if (this.IsApplicationPdb != null) {
            s += ind + "isApplicationPdb\n" ;
        }
        //      C# -> System.Boolean? IsApplicationRoot
        // GraphQL -> isApplicationRoot: Boolean! (scalar)
        if (this.IsApplicationRoot != null) {
            s += ind + "isApplicationRoot\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> OraclePdbOpenMode? OpenMode
        // GraphQL -> openMode: OraclePdbOpenMode! (enum)
        if (this.OpenMode == null && ec.Includes("openMode",true))
        {
            this.OpenMode = new OraclePdbOpenMode();
        }
        //      C# -> System.Int64? ApplicationRootContainerId
        // GraphQL -> applicationRootContainerId: Long! (scalar)
        if (this.ApplicationRootContainerId == null && ec.Includes("applicationRootContainerId",true))
        {
            this.ApplicationRootContainerId = new System.Int64();
        }
        //      C# -> System.Int64? DbId
        // GraphQL -> dbId: Long! (scalar)
        if (this.DbId == null && ec.Includes("dbId",true))
        {
            this.DbId = new System.Int64();
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = new System.Int64();
        }
        //      C# -> System.Boolean? IsApplicationPdb
        // GraphQL -> isApplicationPdb: Boolean! (scalar)
        if (this.IsApplicationPdb == null && ec.Includes("isApplicationPdb",true))
        {
            this.IsApplicationPdb = true;
        }
        //      C# -> System.Boolean? IsApplicationRoot
        // GraphQL -> isApplicationRoot: Boolean! (scalar)
        if (this.IsApplicationRoot == null && ec.Includes("isApplicationRoot",true))
        {
            this.IsApplicationRoot = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
    }


    #endregion

    } // class OraclePdb
    
    #endregion

    public static class ListOraclePdbExtensions
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
            this List<OraclePdb> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OraclePdb> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OraclePdb());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<OraclePdb> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
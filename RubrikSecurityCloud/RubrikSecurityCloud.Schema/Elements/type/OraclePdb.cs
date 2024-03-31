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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> OraclePdbOpenMode? OpenMode
        // GraphQL -> openMode: OraclePdbOpenMode! (enum)
        if (this.OpenMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "openMode\n" ;
            } else {
                s += ind + "openMode\n" ;
            }
        }
        //      C# -> System.Int64? ApplicationRootContainerId
        // GraphQL -> applicationRootContainerId: Long! (scalar)
        if (this.ApplicationRootContainerId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationRootContainerId\n" ;
            } else {
                s += ind + "applicationRootContainerId\n" ;
            }
        }
        //      C# -> System.Int64? DbId
        // GraphQL -> dbId: Long! (scalar)
        if (this.DbId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbId\n" ;
            } else {
                s += ind + "dbId\n" ;
            }
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsApplicationPdb
        // GraphQL -> isApplicationPdb: Boolean! (scalar)
        if (this.IsApplicationPdb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isApplicationPdb\n" ;
            } else {
                s += ind + "isApplicationPdb\n" ;
            }
        }
        //      C# -> System.Boolean? IsApplicationRoot
        // GraphQL -> isApplicationRoot: Boolean! (scalar)
        if (this.IsApplicationRoot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isApplicationRoot\n" ;
            } else {
                s += ind + "isApplicationRoot\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> OraclePdbOpenMode? OpenMode
        // GraphQL -> openMode: OraclePdbOpenMode! (enum)
        if (ec.Includes("openMode",true))
        {
            if(this.OpenMode == null) {

                this.OpenMode = new OraclePdbOpenMode();

            } else {


            }
        }
        else if (this.OpenMode != null && ec.Excludes("openMode",true))
        {
            this.OpenMode = null;
        }
        //      C# -> System.Int64? ApplicationRootContainerId
        // GraphQL -> applicationRootContainerId: Long! (scalar)
        if (ec.Includes("applicationRootContainerId",true))
        {
            if(this.ApplicationRootContainerId == null) {

                this.ApplicationRootContainerId = new System.Int64();

            } else {


            }
        }
        else if (this.ApplicationRootContainerId != null && ec.Excludes("applicationRootContainerId",true))
        {
            this.ApplicationRootContainerId = null;
        }
        //      C# -> System.Int64? DbId
        // GraphQL -> dbId: Long! (scalar)
        if (ec.Includes("dbId",true))
        {
            if(this.DbId == null) {

                this.DbId = new System.Int64();

            } else {


            }
        }
        else if (this.DbId != null && ec.Excludes("dbId",true))
        {
            this.DbId = null;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = new System.Int64();

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsApplicationPdb
        // GraphQL -> isApplicationPdb: Boolean! (scalar)
        if (ec.Includes("isApplicationPdb",true))
        {
            if(this.IsApplicationPdb == null) {

                this.IsApplicationPdb = true;

            } else {


            }
        }
        else if (this.IsApplicationPdb != null && ec.Excludes("isApplicationPdb",true))
        {
            this.IsApplicationPdb = null;
        }
        //      C# -> System.Boolean? IsApplicationRoot
        // GraphQL -> isApplicationRoot: Boolean! (scalar)
        if (ec.Includes("isApplicationRoot",true))
        {
            if(this.IsApplicationRoot == null) {

                this.IsApplicationRoot = true;

            } else {


            }
        }
        else if (this.IsApplicationRoot != null && ec.Excludes("isApplicationRoot",true))
        {
            this.IsApplicationRoot = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
    }


    #endregion

    } // class OraclePdb
    
    #endregion

    public static class ListOraclePdbExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<OraclePdb> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OraclePdb> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<OraclePdb> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// MongoSnapshotRbacRoleAssignment.cs
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
    #region MongoSnapshotRbacRoleAssignment
    public class MongoSnapshotRbacRoleAssignment: BaseType
    {
        #region members

        //      C# -> System.String? Db
        // GraphQL -> db: String! (scalar)
        [JsonProperty("db")]
        public System.String? Db { get; set; }

        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        [JsonProperty("role")]
        public System.String? Role { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MongoSnapshotRbacRoleAssignment";
    }

    public MongoSnapshotRbacRoleAssignment Set(
        System.String? Db = null,
        System.String? Role = null
    ) 
    {
        if ( Db != null ) {
            this.Db = Db;
        }
        if ( Role != null ) {
            this.Role = Role;
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
        //      C# -> System.String? Db
        // GraphQL -> db: String! (scalar)
        if (this.Db != null) {
            if (conf.Flat) {
                s += conf.Prefix + "db\n" ;
            } else {
                s += ind + "db\n" ;
            }
        }
        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        if (this.Role != null) {
            if (conf.Flat) {
                s += conf.Prefix + "role\n" ;
            } else {
                s += ind + "role\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Db
        // GraphQL -> db: String! (scalar)
        if (ec.Includes("db",true))
        {
            if(this.Db == null) {

                this.Db = "FETCH";

            } else {


            }
        }
        else if (this.Db != null && ec.Excludes("db",true))
        {
            this.Db = null;
        }
        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        if (ec.Includes("role",true))
        {
            if(this.Role == null) {

                this.Role = "FETCH";

            } else {


            }
        }
        else if (this.Role != null && ec.Excludes("role",true))
        {
            this.Role = null;
        }
    }


    #endregion

    } // class MongoSnapshotRbacRoleAssignment
    
    #endregion

    public static class ListMongoSnapshotRbacRoleAssignmentExtensions
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
            this List<MongoSnapshotRbacRoleAssignment> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MongoSnapshotRbacRoleAssignment> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MongoSnapshotRbacRoleAssignment> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MongoSnapshotRbacRoleAssignment());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MongoSnapshotRbacRoleAssignment> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
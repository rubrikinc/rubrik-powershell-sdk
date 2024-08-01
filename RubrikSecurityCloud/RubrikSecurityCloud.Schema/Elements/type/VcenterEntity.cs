// VcenterEntity.cs
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
    #region VcenterEntity
    public class VcenterEntity: BaseType
    {
        #region members

        //      C# -> VcenterEntityTypeEnum? EntityType
        // GraphQL -> entityType: VcenterEntityTypeEnum! (enum)
        [JsonProperty("entityType")]
        public VcenterEntityTypeEnum? EntityType { get; set; }

        //      C# -> System.String? EntityMoid
        // GraphQL -> entityMoid: String! (scalar)
        [JsonProperty("entityMoid")]
        public System.String? EntityMoid { get; set; }

        //      C# -> System.String? EntityName
        // GraphQL -> entityName: String! (scalar)
        [JsonProperty("entityName")]
        public System.String? EntityName { get; set; }

        //      C# -> List<System.String>? MissingPrivileges
        // GraphQL -> missingPrivileges: [String!]! (scalar)
        [JsonProperty("missingPrivileges")]
        public List<System.String>? MissingPrivileges { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VcenterEntity";
    }

    public VcenterEntity Set(
        VcenterEntityTypeEnum? EntityType = null,
        System.String? EntityMoid = null,
        System.String? EntityName = null,
        List<System.String>? MissingPrivileges = null
    ) 
    {
        if ( EntityType != null ) {
            this.EntityType = EntityType;
        }
        if ( EntityMoid != null ) {
            this.EntityMoid = EntityMoid;
        }
        if ( EntityName != null ) {
            this.EntityName = EntityName;
        }
        if ( MissingPrivileges != null ) {
            this.MissingPrivileges = MissingPrivileges;
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
        //      C# -> VcenterEntityTypeEnum? EntityType
        // GraphQL -> entityType: VcenterEntityTypeEnum! (enum)
        if (this.EntityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entityType\n" ;
            } else {
                s += ind + "entityType\n" ;
            }
        }
        //      C# -> System.String? EntityMoid
        // GraphQL -> entityMoid: String! (scalar)
        if (this.EntityMoid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entityMoid\n" ;
            } else {
                s += ind + "entityMoid\n" ;
            }
        }
        //      C# -> System.String? EntityName
        // GraphQL -> entityName: String! (scalar)
        if (this.EntityName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entityName\n" ;
            } else {
                s += ind + "entityName\n" ;
            }
        }
        //      C# -> List<System.String>? MissingPrivileges
        // GraphQL -> missingPrivileges: [String!]! (scalar)
        if (this.MissingPrivileges != null) {
            if (conf.Flat) {
                s += conf.Prefix + "missingPrivileges\n" ;
            } else {
                s += ind + "missingPrivileges\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> VcenterEntityTypeEnum? EntityType
        // GraphQL -> entityType: VcenterEntityTypeEnum! (enum)
        if (ec.Includes("entityType",true))
        {
            if(this.EntityType == null) {

                this.EntityType = new VcenterEntityTypeEnum();

            } else {


            }
        }
        else if (this.EntityType != null && ec.Excludes("entityType",true))
        {
            this.EntityType = null;
        }
        //      C# -> System.String? EntityMoid
        // GraphQL -> entityMoid: String! (scalar)
        if (ec.Includes("entityMoid",true))
        {
            if(this.EntityMoid == null) {

                this.EntityMoid = "FETCH";

            } else {


            }
        }
        else if (this.EntityMoid != null && ec.Excludes("entityMoid",true))
        {
            this.EntityMoid = null;
        }
        //      C# -> System.String? EntityName
        // GraphQL -> entityName: String! (scalar)
        if (ec.Includes("entityName",true))
        {
            if(this.EntityName == null) {

                this.EntityName = "FETCH";

            } else {


            }
        }
        else if (this.EntityName != null && ec.Excludes("entityName",true))
        {
            this.EntityName = null;
        }
        //      C# -> List<System.String>? MissingPrivileges
        // GraphQL -> missingPrivileges: [String!]! (scalar)
        if (ec.Includes("missingPrivileges",true))
        {
            if(this.MissingPrivileges == null) {

                this.MissingPrivileges = new List<System.String>();

            } else {


            }
        }
        else if (this.MissingPrivileges != null && ec.Excludes("missingPrivileges",true))
        {
            this.MissingPrivileges = null;
        }
    }


    #endregion

    } // class VcenterEntity
    
    #endregion

    public static class ListVcenterEntityExtensions
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
            this List<VcenterEntity> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VcenterEntity> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VcenterEntity> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VcenterEntity());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VcenterEntity> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
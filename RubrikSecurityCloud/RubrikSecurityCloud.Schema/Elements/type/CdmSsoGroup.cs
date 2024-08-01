// CdmSsoGroup.cs
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
    #region CdmSsoGroup
    public class CdmSsoGroup: BaseType
    {
        #region members

        //      C# -> CannotMigrateReasonEnum? CannotMigrateReason
        // GraphQL -> cannotMigrateReason: CannotMigrateReasonEnum! (enum)
        [JsonProperty("cannotMigrateReason")]
        public CannotMigrateReasonEnum? CannotMigrateReason { get; set; }

        //      C# -> System.Boolean? CanMigrate
        // GraphQL -> canMigrate: Boolean! (scalar)
        [JsonProperty("canMigrate")]
        public System.Boolean? CanMigrate { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<CdmRole>? AssignedCdmRoles
        // GraphQL -> assignedCdmRoles: [CdmRole!]! (type)
        [JsonProperty("assignedCdmRoles")]
        public List<CdmRole>? AssignedCdmRoles { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmSSOGroup";
    }

    public CdmSsoGroup Set(
        CannotMigrateReasonEnum? CannotMigrateReason = null,
        System.Boolean? CanMigrate = null,
        System.String? CdmId = null,
        System.String? Name = null,
        List<CdmRole>? AssignedCdmRoles = null,
        Cluster? Cluster = null
    ) 
    {
        if ( CannotMigrateReason != null ) {
            this.CannotMigrateReason = CannotMigrateReason;
        }
        if ( CanMigrate != null ) {
            this.CanMigrate = CanMigrate;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( AssignedCdmRoles != null ) {
            this.AssignedCdmRoles = AssignedCdmRoles;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
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
        //      C# -> CannotMigrateReasonEnum? CannotMigrateReason
        // GraphQL -> cannotMigrateReason: CannotMigrateReasonEnum! (enum)
        if (this.CannotMigrateReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cannotMigrateReason\n" ;
            } else {
                s += ind + "cannotMigrateReason\n" ;
            }
        }
        //      C# -> System.Boolean? CanMigrate
        // GraphQL -> canMigrate: Boolean! (scalar)
        if (this.CanMigrate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "canMigrate\n" ;
            } else {
                s += ind + "canMigrate\n" ;
            }
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmId\n" ;
            } else {
                s += ind + "cdmId\n" ;
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
        //      C# -> List<CdmRole>? AssignedCdmRoles
        // GraphQL -> assignedCdmRoles: [CdmRole!]! (type)
        if (this.AssignedCdmRoles != null) {
            var fspec = this.AssignedCdmRoles.AsFieldSpec(conf.Child("assignedCdmRoles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "assignedCdmRoles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CannotMigrateReasonEnum? CannotMigrateReason
        // GraphQL -> cannotMigrateReason: CannotMigrateReasonEnum! (enum)
        if (ec.Includes("cannotMigrateReason",true))
        {
            if(this.CannotMigrateReason == null) {

                this.CannotMigrateReason = new CannotMigrateReasonEnum();

            } else {


            }
        }
        else if (this.CannotMigrateReason != null && ec.Excludes("cannotMigrateReason",true))
        {
            this.CannotMigrateReason = null;
        }
        //      C# -> System.Boolean? CanMigrate
        // GraphQL -> canMigrate: Boolean! (scalar)
        if (ec.Includes("canMigrate",true))
        {
            if(this.CanMigrate == null) {

                this.CanMigrate = true;

            } else {


            }
        }
        else if (this.CanMigrate != null && ec.Excludes("canMigrate",true))
        {
            this.CanMigrate = null;
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (ec.Includes("cdmId",true))
        {
            if(this.CdmId == null) {

                this.CdmId = "FETCH";

            } else {


            }
        }
        else if (this.CdmId != null && ec.Excludes("cdmId",true))
        {
            this.CdmId = null;
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
        //      C# -> List<CdmRole>? AssignedCdmRoles
        // GraphQL -> assignedCdmRoles: [CdmRole!]! (type)
        if (ec.Includes("assignedCdmRoles",false))
        {
            if(this.AssignedCdmRoles == null) {

                this.AssignedCdmRoles = new List<CdmRole>();
                this.AssignedCdmRoles.ApplyExploratoryFieldSpec(ec.NewChild("assignedCdmRoles"));

            } else {

                this.AssignedCdmRoles.ApplyExploratoryFieldSpec(ec.NewChild("assignedCdmRoles"));

            }
        }
        else if (this.AssignedCdmRoles != null && ec.Excludes("assignedCdmRoles",false))
        {
            this.AssignedCdmRoles = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
    }


    #endregion

    } // class CdmSsoGroup
    
    #endregion

    public static class ListCdmSsoGroupExtensions
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
            this List<CdmSsoGroup> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmSsoGroup> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmSsoGroup> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmSsoGroup());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmSsoGroup> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
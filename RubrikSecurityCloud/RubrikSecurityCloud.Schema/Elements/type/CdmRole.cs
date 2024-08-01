// CdmRole.cs
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
    #region CdmRole
    public class CdmRole: BaseType
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

        //      C# -> System.String? CdmName
        // GraphQL -> cdmName: String! (scalar)
        [JsonProperty("cdmName")]
        public System.String? CdmName { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.Boolean? IsPartiallyUnavailable
        // GraphQL -> isPartiallyUnavailable: Boolean! (scalar)
        [JsonProperty("isPartiallyUnavailable")]
        public System.Boolean? IsPartiallyUnavailable { get; set; }

        //      C# -> System.String? RscName
        // GraphQL -> rscName: String! (scalar)
        [JsonProperty("rscName")]
        public System.String? RscName { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmRole";
    }

    public CdmRole Set(
        CannotMigrateReasonEnum? CannotMigrateReason = null,
        System.Boolean? CanMigrate = null,
        System.String? CdmId = null,
        System.String? CdmName = null,
        System.String? Description = null,
        System.Boolean? IsPartiallyUnavailable = null,
        System.String? RscName = null,
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
        if ( CdmName != null ) {
            this.CdmName = CdmName;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( IsPartiallyUnavailable != null ) {
            this.IsPartiallyUnavailable = IsPartiallyUnavailable;
        }
        if ( RscName != null ) {
            this.RscName = RscName;
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
        //      C# -> System.String? CdmName
        // GraphQL -> cdmName: String! (scalar)
        if (this.CdmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmName\n" ;
            } else {
                s += ind + "cdmName\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.Boolean? IsPartiallyUnavailable
        // GraphQL -> isPartiallyUnavailable: Boolean! (scalar)
        if (this.IsPartiallyUnavailable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPartiallyUnavailable\n" ;
            } else {
                s += ind + "isPartiallyUnavailable\n" ;
            }
        }
        //      C# -> System.String? RscName
        // GraphQL -> rscName: String! (scalar)
        if (this.RscName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rscName\n" ;
            } else {
                s += ind + "rscName\n" ;
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
        //      C# -> System.String? CdmName
        // GraphQL -> cdmName: String! (scalar)
        if (ec.Includes("cdmName",true))
        {
            if(this.CdmName == null) {

                this.CdmName = "FETCH";

            } else {


            }
        }
        else if (this.CdmName != null && ec.Excludes("cdmName",true))
        {
            this.CdmName = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> System.Boolean? IsPartiallyUnavailable
        // GraphQL -> isPartiallyUnavailable: Boolean! (scalar)
        if (ec.Includes("isPartiallyUnavailable",true))
        {
            if(this.IsPartiallyUnavailable == null) {

                this.IsPartiallyUnavailable = true;

            } else {


            }
        }
        else if (this.IsPartiallyUnavailable != null && ec.Excludes("isPartiallyUnavailable",true))
        {
            this.IsPartiallyUnavailable = null;
        }
        //      C# -> System.String? RscName
        // GraphQL -> rscName: String! (scalar)
        if (ec.Includes("rscName",true))
        {
            if(this.RscName == null) {

                this.RscName = "FETCH";

            } else {


            }
        }
        else if (this.RscName != null && ec.Excludes("rscName",true))
        {
            this.RscName = null;
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

    } // class CdmRole
    
    #endregion

    public static class ListCdmRoleExtensions
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
            this List<CdmRole> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmRole> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmRole> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmRole());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmRole> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
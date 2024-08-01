// VcenterEntitySummary.cs
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
    #region VcenterEntitySummary
    public class VcenterEntitySummary: BaseType
    {
        #region members

        //      C# -> VcenterEntityTypeEnum? EntityType
        // GraphQL -> entityType: VcenterEntityTypeEnum! (enum)
        [JsonProperty("entityType")]
        public VcenterEntityTypeEnum? EntityType { get; set; }

        //      C# -> System.Int32? MissingPrivilegesCount
        // GraphQL -> missingPrivilegesCount: Int! (scalar)
        [JsonProperty("missingPrivilegesCount")]
        public System.Int32? MissingPrivilegesCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "vCenterEntitySummary";
    }

    public VcenterEntitySummary Set(
        VcenterEntityTypeEnum? EntityType = null,
        System.Int32? MissingPrivilegesCount = null
    ) 
    {
        if ( EntityType != null ) {
            this.EntityType = EntityType;
        }
        if ( MissingPrivilegesCount != null ) {
            this.MissingPrivilegesCount = MissingPrivilegesCount;
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
        //      C# -> System.Int32? MissingPrivilegesCount
        // GraphQL -> missingPrivilegesCount: Int! (scalar)
        if (this.MissingPrivilegesCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "missingPrivilegesCount\n" ;
            } else {
                s += ind + "missingPrivilegesCount\n" ;
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
        //      C# -> System.Int32? MissingPrivilegesCount
        // GraphQL -> missingPrivilegesCount: Int! (scalar)
        if (ec.Includes("missingPrivilegesCount",true))
        {
            if(this.MissingPrivilegesCount == null) {

                this.MissingPrivilegesCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.MissingPrivilegesCount != null && ec.Excludes("missingPrivilegesCount",true))
        {
            this.MissingPrivilegesCount = null;
        }
    }


    #endregion

    } // class VcenterEntitySummary
    
    #endregion

    public static class ListVcenterEntitySummaryExtensions
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
            this List<VcenterEntitySummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VcenterEntitySummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VcenterEntitySummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VcenterEntitySummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VcenterEntitySummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
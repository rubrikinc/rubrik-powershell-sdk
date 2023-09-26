// VappTemplateExportOptions.cs
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
    #region VappTemplateExportOptions
    public class VappTemplateExportOptions: BaseType
    {
        #region members

        //      C# -> System.String? OrgVdcId
        // GraphQL -> orgVdcId: String! (scalar)
        [JsonProperty("orgVdcId")]
        public System.String? OrgVdcId { get; set; }

        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        [JsonProperty("availableStoragePolicies")]
        public List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VappTemplateExportOptions";
    }

    public VappTemplateExportOptions Set(
        System.String? OrgVdcId = null,
        List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies = null
    ) 
    {
        if ( OrgVdcId != null ) {
            this.OrgVdcId = OrgVdcId;
        }
        if ( AvailableStoragePolicies != null ) {
            this.AvailableStoragePolicies = AvailableStoragePolicies;
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
        //      C# -> System.String? OrgVdcId
        // GraphQL -> orgVdcId: String! (scalar)
        if (this.OrgVdcId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgVdcId\n" ;
            } else {
                s += ind + "orgVdcId\n" ;
            }
        }
        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        if (this.AvailableStoragePolicies != null) {
            var fspec = this.AvailableStoragePolicies.AsFieldSpec(conf.Child("availableStoragePolicies"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "availableStoragePolicies {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? OrgVdcId
        // GraphQL -> orgVdcId: String! (scalar)
        if (ec.Includes("orgVdcId",true))
        {
            if(this.OrgVdcId == null) {

                this.OrgVdcId = "FETCH";

            } else {


            }
        }
        else if (this.OrgVdcId != null && ec.Excludes("orgVdcId",true))
        {
            this.OrgVdcId = null;
        }
        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        if (ec.Includes("availableStoragePolicies",false))
        {
            if(this.AvailableStoragePolicies == null) {

                this.AvailableStoragePolicies = new List<VcdOrgVdcStorageProfile>();
                this.AvailableStoragePolicies.ApplyExploratoryFieldSpec(ec.NewChild("availableStoragePolicies"));

            } else {

                this.AvailableStoragePolicies.ApplyExploratoryFieldSpec(ec.NewChild("availableStoragePolicies"));

            }
        }
        else if (this.AvailableStoragePolicies != null && ec.Excludes("availableStoragePolicies",false))
        {
            this.AvailableStoragePolicies = null;
        }
    }


    #endregion

    } // class VappTemplateExportOptions
    
    #endregion

    public static class ListVappTemplateExportOptionsExtensions
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
            this List<VappTemplateExportOptions> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VappTemplateExportOptions> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VappTemplateExportOptions());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VappTemplateExportOptions> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
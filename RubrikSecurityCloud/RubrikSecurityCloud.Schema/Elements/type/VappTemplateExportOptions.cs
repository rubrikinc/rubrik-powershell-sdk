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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? OrgVdcId
        // GraphQL -> orgVdcId: String! (scalar)
        if (this.OrgVdcId != null) {
            s += ind + "orgVdcId\n" ;
        }
        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        if (this.AvailableStoragePolicies != null) {
            var fspec = this.AvailableStoragePolicies.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "availableStoragePolicies {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? OrgVdcId
        // GraphQL -> orgVdcId: String! (scalar)
        if (this.OrgVdcId == null && ec.Includes("orgVdcId",true))
        {
            this.OrgVdcId = "FETCH";
        }
        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        if (this.AvailableStoragePolicies == null && ec.Includes("availableStoragePolicies",false))
        {
            this.AvailableStoragePolicies = new List<VcdOrgVdcStorageProfile>();
            this.AvailableStoragePolicies.ApplyExploratoryFieldSpec(ec.NewChild("availableStoragePolicies"));
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<VappTemplateExportOptions> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
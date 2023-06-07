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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "availableStoragePolicies {\n" + this.AvailableStoragePolicies.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? OrgVdcId
        // GraphQL -> orgVdcId: String! (scalar)
        if (this.OrgVdcId == null && Exploration.Includes(parent + ".orgVdcId", true))
        {
            this.OrgVdcId = "FETCH";
        }
        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        if (this.AvailableStoragePolicies == null && Exploration.Includes(parent + ".availableStoragePolicies"))
        {
            this.AvailableStoragePolicies = new List<VcdOrgVdcStorageProfile>();
            this.AvailableStoragePolicies.ApplyExploratoryFieldSpec(parent + ".availableStoragePolicies");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VappTemplateExportOptions> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VappTemplateExportOptions());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
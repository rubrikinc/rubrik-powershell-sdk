// CloudAccountFeaturePermission.cs
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
    #region CloudAccountFeaturePermission
    public class CloudAccountFeaturePermission: BaseType
    {
        #region members

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> List<FeaturePermission>? FeaturePermissions
        // GraphQL -> featurePermissions: [FeaturePermission!]! (type)
        [JsonProperty("featurePermissions")]
        public List<FeaturePermission>? FeaturePermissions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudAccountFeaturePermission";
    }

    public CloudAccountFeaturePermission Set(
        System.String? CloudAccountId = null,
        List<FeaturePermission>? FeaturePermissions = null
    ) 
    {
        if ( CloudAccountId != null ) {
            this.CloudAccountId = CloudAccountId;
        }
        if ( FeaturePermissions != null ) {
            this.FeaturePermissions = FeaturePermissions;
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
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (this.CloudAccountId != null) {
            s += ind + "cloudAccountId\n" ;
        }
        //      C# -> List<FeaturePermission>? FeaturePermissions
        // GraphQL -> featurePermissions: [FeaturePermission!]! (type)
        if (this.FeaturePermissions != null) {
            var fspec = this.FeaturePermissions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "featurePermissions {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (this.CloudAccountId == null && ec.Includes("cloudAccountId",true))
        {
            this.CloudAccountId = "FETCH";
        }
        //      C# -> List<FeaturePermission>? FeaturePermissions
        // GraphQL -> featurePermissions: [FeaturePermission!]! (type)
        if (this.FeaturePermissions == null && ec.Includes("featurePermissions",false))
        {
            this.FeaturePermissions = new List<FeaturePermission>();
            this.FeaturePermissions.ApplyExploratoryFieldSpec(ec.NewChild("featurePermissions"));
        }
    }


    #endregion

    } // class CloudAccountFeaturePermission
    
    #endregion

    public static class ListCloudAccountFeaturePermissionExtensions
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
            this List<CloudAccountFeaturePermission> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudAccountFeaturePermission> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudAccountFeaturePermission());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CloudAccountFeaturePermission> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// IbmCosDetailsType.cs
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
    #region IbmCosDetailsType
    public class IbmCosDetailsType: BaseType
    {
        #region members

        //      C# -> IbmDeploymentType? DeploymentType
        // GraphQL -> deploymentType: IbmDeploymentType! (enum)
        [JsonProperty("deploymentType")]
        public IbmDeploymentType? DeploymentType { get; set; }

        //      C# -> System.String? ProvisioningCode
        // GraphQL -> provisioningCode: String! (scalar)
        [JsonProperty("provisioningCode")]
        public System.String? ProvisioningCode { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IbmCosDetailsType";
    }

    public IbmCosDetailsType Set(
        IbmDeploymentType? DeploymentType = null,
        System.String? ProvisioningCode = null
    ) 
    {
        if ( DeploymentType != null ) {
            this.DeploymentType = DeploymentType;
        }
        if ( ProvisioningCode != null ) {
            this.ProvisioningCode = ProvisioningCode;
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
        //      C# -> IbmDeploymentType? DeploymentType
        // GraphQL -> deploymentType: IbmDeploymentType! (enum)
        if (this.DeploymentType != null) {
            s += ind + "deploymentType\n" ;
        }
        //      C# -> System.String? ProvisioningCode
        // GraphQL -> provisioningCode: String! (scalar)
        if (this.ProvisioningCode != null) {
            s += ind + "provisioningCode\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> IbmDeploymentType? DeploymentType
        // GraphQL -> deploymentType: IbmDeploymentType! (enum)
        if (this.DeploymentType == null && Exploration.Includes(parent + ".deploymentType", true))
        {
            this.DeploymentType = new IbmDeploymentType();
        }
        //      C# -> System.String? ProvisioningCode
        // GraphQL -> provisioningCode: String! (scalar)
        if (this.ProvisioningCode == null && Exploration.Includes(parent + ".provisioningCode", true))
        {
            this.ProvisioningCode = "FETCH";
        }
    }


    #endregion

    } // class IbmCosDetailsType
    
    #endregion

    public static class ListIbmCosDetailsTypeExtensions
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
            this List<IbmCosDetailsType> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<IbmCosDetailsType> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new IbmCosDetailsType());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
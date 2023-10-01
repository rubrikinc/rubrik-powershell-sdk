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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> IbmDeploymentType? DeploymentType
        // GraphQL -> deploymentType: IbmDeploymentType! (enum)
        if (this.DeploymentType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deploymentType\n" ;
            } else {
                s += ind + "deploymentType\n" ;
            }
        }
        //      C# -> System.String? ProvisioningCode
        // GraphQL -> provisioningCode: String! (scalar)
        if (this.ProvisioningCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "provisioningCode\n" ;
            } else {
                s += ind + "provisioningCode\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> IbmDeploymentType? DeploymentType
        // GraphQL -> deploymentType: IbmDeploymentType! (enum)
        if (ec.Includes("deploymentType",true))
        {
            if(this.DeploymentType == null) {

                this.DeploymentType = new IbmDeploymentType();

            } else {


            }
        }
        else if (this.DeploymentType != null && ec.Excludes("deploymentType",true))
        {
            this.DeploymentType = null;
        }
        //      C# -> System.String? ProvisioningCode
        // GraphQL -> provisioningCode: String! (scalar)
        if (ec.Includes("provisioningCode",true))
        {
            if(this.ProvisioningCode == null) {

                this.ProvisioningCode = "FETCH";

            } else {


            }
        }
        else if (this.ProvisioningCode != null && ec.Excludes("provisioningCode",true))
        {
            this.ProvisioningCode = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<IbmCosDetailsType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IbmCosDetailsType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IbmCosDetailsType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IbmCosDetailsType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
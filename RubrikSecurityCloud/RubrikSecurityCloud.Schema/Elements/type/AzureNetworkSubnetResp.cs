// AzureNetworkSubnetResp.cs
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
    #region AzureNetworkSubnetResp
    public class AzureNetworkSubnetResp: BaseType
    {
        #region members

        //      C# -> System.Boolean? Valid
        // GraphQL -> valid: Boolean! (scalar)
        [JsonProperty("valid")]
        public System.Boolean? Valid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureNetworkSubnetResp";
    }

    public AzureNetworkSubnetResp Set(
        System.Boolean? Valid = null
    ) 
    {
        if ( Valid != null ) {
            this.Valid = Valid;
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
        //      C# -> System.Boolean? Valid
        // GraphQL -> valid: Boolean! (scalar)
        if (this.Valid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "valid\n" ;
            } else {
                s += ind + "valid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? Valid
        // GraphQL -> valid: Boolean! (scalar)
        if (ec.Includes("valid",true))
        {
            if(this.Valid == null) {

                this.Valid = true;

            } else {


            }
        }
        else if (this.Valid != null && ec.Excludes("valid",true))
        {
            this.Valid = null;
        }
    }


    #endregion

    } // class AzureNetworkSubnetResp
    
    #endregion

    public static class ListAzureNetworkSubnetRespExtensions
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
            this List<AzureNetworkSubnetResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureNetworkSubnetResp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNetworkSubnetResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureNetworkSubnetResp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
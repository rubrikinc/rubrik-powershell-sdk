// AzureNetworkSecurityGroupResp.cs
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
    #region AzureNetworkSecurityGroupResp
    public class AzureNetworkSecurityGroupResp: BaseType
    {
        #region members

        //      C# -> AzureNetworkSecurityRulesStatus? RulesStatus
        // GraphQL -> rulesStatus: AzureNetworkSecurityRulesStatus! (enum)
        [JsonProperty("rulesStatus")]
        public AzureNetworkSecurityRulesStatus? RulesStatus { get; set; }

        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        [JsonProperty("reason")]
        public System.String? Reason { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureNetworkSecurityGroupResp";
    }

    public AzureNetworkSecurityGroupResp Set(
        AzureNetworkSecurityRulesStatus? RulesStatus = null,
        System.String? Reason = null
    ) 
    {
        if ( RulesStatus != null ) {
            this.RulesStatus = RulesStatus;
        }
        if ( Reason != null ) {
            this.Reason = Reason;
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
        //      C# -> AzureNetworkSecurityRulesStatus? RulesStatus
        // GraphQL -> rulesStatus: AzureNetworkSecurityRulesStatus! (enum)
        if (this.RulesStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rulesStatus\n" ;
            } else {
                s += ind + "rulesStatus\n" ;
            }
        }
        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        if (this.Reason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reason\n" ;
            } else {
                s += ind + "reason\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureNetworkSecurityRulesStatus? RulesStatus
        // GraphQL -> rulesStatus: AzureNetworkSecurityRulesStatus! (enum)
        if (ec.Includes("rulesStatus",true))
        {
            if(this.RulesStatus == null) {

                this.RulesStatus = new AzureNetworkSecurityRulesStatus();

            } else {


            }
        }
        else if (this.RulesStatus != null && ec.Excludes("rulesStatus",true))
        {
            this.RulesStatus = null;
        }
        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        if (ec.Includes("reason",true))
        {
            if(this.Reason == null) {

                this.Reason = "FETCH";

            } else {


            }
        }
        else if (this.Reason != null && ec.Excludes("reason",true))
        {
            this.Reason = null;
        }
    }


    #endregion

    } // class AzureNetworkSecurityGroupResp
    
    #endregion

    public static class ListAzureNetworkSecurityGroupRespExtensions
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
            this List<AzureNetworkSecurityGroupResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureNetworkSecurityGroupResp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNetworkSecurityGroupResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureNetworkSecurityGroupResp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
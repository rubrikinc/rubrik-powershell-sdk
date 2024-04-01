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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
            this List<AzureNetworkSecurityGroupResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureNetworkSecurityGroupResp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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
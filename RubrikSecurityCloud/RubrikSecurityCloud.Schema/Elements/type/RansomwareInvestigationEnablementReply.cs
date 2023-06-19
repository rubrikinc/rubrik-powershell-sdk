// RansomwareInvestigationEnablementReply.cs
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
    #region RansomwareInvestigationEnablementReply
    public class RansomwareInvestigationEnablementReply: BaseType
    {
        #region members

        //      C# -> List<Microsoft365RansomwareInvestigationEnablement>? Microsoft365Subscriptions
        // GraphQL -> microsoft365Subscriptions: [Microsoft365RansomwareInvestigationEnablement!] (type)
        [JsonProperty("microsoft365Subscriptions")]
        public List<Microsoft365RansomwareInvestigationEnablement>? Microsoft365Subscriptions { get; set; }

        //      C# -> List<RubrikCloudVaultRansomwareInvestigationEnablement>? RubrikCloudVaultLocations
        // GraphQL -> rubrikCloudVaultLocations: [RubrikCloudVaultRansomwareInvestigationEnablement!] (type)
        [JsonProperty("rubrikCloudVaultLocations")]
        public List<RubrikCloudVaultRansomwareInvestigationEnablement>? RubrikCloudVaultLocations { get; set; }


        #endregion

    #region methods

    public RansomwareInvestigationEnablementReply Set(
        List<Microsoft365RansomwareInvestigationEnablement>? Microsoft365Subscriptions = null,
        List<RubrikCloudVaultRansomwareInvestigationEnablement>? RubrikCloudVaultLocations = null
    ) 
    {
        if ( Microsoft365Subscriptions != null ) {
            this.Microsoft365Subscriptions = Microsoft365Subscriptions;
        }
        if ( RubrikCloudVaultLocations != null ) {
            this.RubrikCloudVaultLocations = RubrikCloudVaultLocations;
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
        //      C# -> List<Microsoft365RansomwareInvestigationEnablement>? Microsoft365Subscriptions
        // GraphQL -> microsoft365Subscriptions: [Microsoft365RansomwareInvestigationEnablement!] (type)
        if (this.Microsoft365Subscriptions != null) {
            var fspec = this.Microsoft365Subscriptions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "microsoft365Subscriptions {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<RubrikCloudVaultRansomwareInvestigationEnablement>? RubrikCloudVaultLocations
        // GraphQL -> rubrikCloudVaultLocations: [RubrikCloudVaultRansomwareInvestigationEnablement!] (type)
        if (this.RubrikCloudVaultLocations != null) {
            var fspec = this.RubrikCloudVaultLocations.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "rubrikCloudVaultLocations {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<Microsoft365RansomwareInvestigationEnablement>? Microsoft365Subscriptions
        // GraphQL -> microsoft365Subscriptions: [Microsoft365RansomwareInvestigationEnablement!] (type)
        if (this.Microsoft365Subscriptions == null && Exploration.Includes(parent + ".microsoft365Subscriptions"))
        {
            this.Microsoft365Subscriptions = new List<Microsoft365RansomwareInvestigationEnablement>();
            this.Microsoft365Subscriptions.ApplyExploratoryFieldSpec(parent + ".microsoft365Subscriptions");
        }
        //      C# -> List<RubrikCloudVaultRansomwareInvestigationEnablement>? RubrikCloudVaultLocations
        // GraphQL -> rubrikCloudVaultLocations: [RubrikCloudVaultRansomwareInvestigationEnablement!] (type)
        if (this.RubrikCloudVaultLocations == null && Exploration.Includes(parent + ".rubrikCloudVaultLocations"))
        {
            this.RubrikCloudVaultLocations = new List<RubrikCloudVaultRansomwareInvestigationEnablement>();
            this.RubrikCloudVaultLocations.ApplyExploratoryFieldSpec(parent + ".rubrikCloudVaultLocations");
        }
    }


    #endregion

    } // class RansomwareInvestigationEnablementReply
    
    #endregion

    public static class ListRansomwareInvestigationEnablementReplyExtensions
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
            this List<RansomwareInvestigationEnablementReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RansomwareInvestigationEnablementReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RansomwareInvestigationEnablementReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types
// PrincipalRiskReasons.cs
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
    #region PrincipalRiskReasons
    public class PrincipalRiskReasons: BaseType
    {
        #region members

        //      C# -> List<RiskReason>? AccessRiskReasons
        // GraphQL -> accessRiskReasons: [RiskReason!]! (enum)
        [JsonProperty("accessRiskReasons")]
        public List<RiskReason>? AccessRiskReasons { get; set; }

        //      C# -> List<InsecureReason>? InsecureReasons
        // GraphQL -> insecureReasons: [InsecureReason!]! (enum)
        [JsonProperty("insecureReasons")]
        public List<InsecureReason>? InsecureReasons { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrincipalRiskReasons";
    }

    public PrincipalRiskReasons Set(
        List<RiskReason>? AccessRiskReasons = null,
        List<InsecureReason>? InsecureReasons = null
    ) 
    {
        if ( AccessRiskReasons != null ) {
            this.AccessRiskReasons = AccessRiskReasons;
        }
        if ( InsecureReasons != null ) {
            this.InsecureReasons = InsecureReasons;
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
        //      C# -> List<RiskReason>? AccessRiskReasons
        // GraphQL -> accessRiskReasons: [RiskReason!]! (enum)
        if (this.AccessRiskReasons != null) {
            s += ind + "accessRiskReasons\n" ;
        }
        //      C# -> List<InsecureReason>? InsecureReasons
        // GraphQL -> insecureReasons: [InsecureReason!]! (enum)
        if (this.InsecureReasons != null) {
            s += ind + "insecureReasons\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<RiskReason>? AccessRiskReasons
        // GraphQL -> accessRiskReasons: [RiskReason!]! (enum)
        if (this.AccessRiskReasons == null && ec.Includes("accessRiskReasons",true))
        {
            this.AccessRiskReasons = new List<RiskReason>();
        }
        //      C# -> List<InsecureReason>? InsecureReasons
        // GraphQL -> insecureReasons: [InsecureReason!]! (enum)
        if (this.InsecureReasons == null && ec.Includes("insecureReasons",true))
        {
            this.InsecureReasons = new List<InsecureReason>();
        }
    }


    #endregion

    } // class PrincipalRiskReasons
    
    #endregion

    public static class ListPrincipalRiskReasonsExtensions
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
            this List<PrincipalRiskReasons> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalRiskReasons> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalRiskReasons());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<PrincipalRiskReasons> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
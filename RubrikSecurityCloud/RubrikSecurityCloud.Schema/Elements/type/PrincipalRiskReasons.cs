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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<RiskReason>? AccessRiskReasons
        // GraphQL -> accessRiskReasons: [RiskReason!]! (enum)
        if (this.AccessRiskReasons != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessRiskReasons\n" ;
            } else {
                s += ind + "accessRiskReasons\n" ;
            }
        }
        //      C# -> List<InsecureReason>? InsecureReasons
        // GraphQL -> insecureReasons: [InsecureReason!]! (enum)
        if (this.InsecureReasons != null) {
            if (conf.Flat) {
                s += conf.Prefix + "insecureReasons\n" ;
            } else {
                s += ind + "insecureReasons\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<RiskReason>? AccessRiskReasons
        // GraphQL -> accessRiskReasons: [RiskReason!]! (enum)
        if (ec.Includes("accessRiskReasons",true))
        {
            if(this.AccessRiskReasons == null) {

                this.AccessRiskReasons = new List<RiskReason>();

            } else {


            }
        }
        else if (this.AccessRiskReasons != null && ec.Excludes("accessRiskReasons",true))
        {
            this.AccessRiskReasons = null;
        }
        //      C# -> List<InsecureReason>? InsecureReasons
        // GraphQL -> insecureReasons: [InsecureReason!]! (enum)
        if (ec.Includes("insecureReasons",true))
        {
            if(this.InsecureReasons == null) {

                this.InsecureReasons = new List<InsecureReason>();

            } else {


            }
        }
        else if (this.InsecureReasons != null && ec.Excludes("insecureReasons",true))
        {
            this.InsecureReasons = null;
        }
    }


    #endregion

    } // class PrincipalRiskReasons
    
    #endregion

    public static class ListPrincipalRiskReasonsExtensions
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
            this List<PrincipalRiskReasons> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PrincipalRiskReasons> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<PrincipalRiskReasons> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
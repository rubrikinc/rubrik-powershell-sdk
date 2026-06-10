// UpgradePathEligibilityReply.cs
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
    #region UpgradePathEligibilityReply
    public class UpgradePathEligibilityReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsEligible
        // GraphQL -> isEligible: Boolean! (scalar)
        [JsonProperty("isEligible")]
        public System.Boolean? IsEligible { get; set; }

        //      C# -> List<PathBlocker>? Blockers
        // GraphQL -> blockers: [PathBlocker!]! (type)
        [JsonProperty("blockers")]
        public List<PathBlocker>? Blockers { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpgradePathEligibilityReply";
    }

    public UpgradePathEligibilityReply Set(
        System.Boolean? IsEligible = null,
        List<PathBlocker>? Blockers = null
    ) 
    {
        if ( IsEligible != null ) {
            this.IsEligible = IsEligible;
        }
        if ( Blockers != null ) {
            this.Blockers = Blockers;
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
        //      C# -> System.Boolean? IsEligible
        // GraphQL -> isEligible: Boolean! (scalar)
        if (this.IsEligible != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEligible\n" ;
            } else {
                s += ind + "isEligible\n" ;
            }
        }
        //      C# -> List<PathBlocker>? Blockers
        // GraphQL -> blockers: [PathBlocker!]! (type)
        if (this.Blockers != null) {
            var fspec = this.Blockers.AsFieldSpec(conf.Child("blockers"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "blockers" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsEligible
        // GraphQL -> isEligible: Boolean! (scalar)
        if (ec.Includes("isEligible",true))
        {
            if(this.IsEligible == null) {

                this.IsEligible = true;

            } else {


            }
        }
        else if (this.IsEligible != null && ec.Excludes("isEligible",true))
        {
            this.IsEligible = null;
        }
        //      C# -> List<PathBlocker>? Blockers
        // GraphQL -> blockers: [PathBlocker!]! (type)
        if (ec.Includes("blockers",false))
        {
            if(this.Blockers == null) {

                this.Blockers = new List<PathBlocker>();
                this.Blockers.ApplyExploratoryFieldSpec(ec.NewChild("blockers"));

            } else {

                this.Blockers.ApplyExploratoryFieldSpec(ec.NewChild("blockers"));

            }
        }
        else if (this.Blockers != null && ec.Excludes("blockers",false))
        {
            this.Blockers = null;
        }
    }


    #endregion

    } // class UpgradePathEligibilityReply
    
    #endregion

    public static class ListUpgradePathEligibilityReplyExtensions
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
            this List<UpgradePathEligibilityReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpgradePathEligibilityReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpgradePathEligibilityReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpgradePathEligibilityReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpgradePathEligibilityReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
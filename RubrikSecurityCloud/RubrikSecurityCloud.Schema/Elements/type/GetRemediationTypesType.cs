// GetRemediationTypesType.cs
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
    #region GetRemediationTypesType
    public class GetRemediationTypesType: BaseType
    {
        #region members

        //      C# -> List<RemediationAvailability>? Remediations
        // GraphQL -> remediations: [RemediationAvailability!]! (type)
        [JsonProperty("remediations")]
        public List<RemediationAvailability>? Remediations { get; set; }

        //      C# -> RemediationTargets? Targets
        // GraphQL -> targets: RemediationTargets (type)
        [JsonProperty("targets")]
        public RemediationTargets? Targets { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetRemediationTypesType";
    }

    public GetRemediationTypesType Set(
        List<RemediationAvailability>? Remediations = null,
        RemediationTargets? Targets = null
    ) 
    {
        if ( Remediations != null ) {
            this.Remediations = Remediations;
        }
        if ( Targets != null ) {
            this.Targets = Targets;
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
        //      C# -> List<RemediationAvailability>? Remediations
        // GraphQL -> remediations: [RemediationAvailability!]! (type)
        if (this.Remediations != null) {
            var fspec = this.Remediations.AsFieldSpec(conf.Child("remediations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "remediations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RemediationTargets? Targets
        // GraphQL -> targets: RemediationTargets (type)
        if (this.Targets != null) {
            var fspec = this.Targets.AsFieldSpec(conf.Child("targets"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targets" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<RemediationAvailability>? Remediations
        // GraphQL -> remediations: [RemediationAvailability!]! (type)
        if (ec.Includes("remediations",false))
        {
            if(this.Remediations == null) {

                this.Remediations = new List<RemediationAvailability>();
                this.Remediations.ApplyExploratoryFieldSpec(ec.NewChild("remediations"));

            } else {

                this.Remediations.ApplyExploratoryFieldSpec(ec.NewChild("remediations"));

            }
        }
        else if (this.Remediations != null && ec.Excludes("remediations",false))
        {
            this.Remediations = null;
        }
        //      C# -> RemediationTargets? Targets
        // GraphQL -> targets: RemediationTargets (type)
        if (ec.Includes("targets",false))
        {
            if(this.Targets == null) {

                this.Targets = new RemediationTargets();
                this.Targets.ApplyExploratoryFieldSpec(ec.NewChild("targets"));

            } else {

                this.Targets.ApplyExploratoryFieldSpec(ec.NewChild("targets"));

            }
        }
        else if (this.Targets != null && ec.Excludes("targets",false))
        {
            this.Targets = null;
        }
    }


    #endregion

    } // class GetRemediationTypesType
    
    #endregion

    public static class ListGetRemediationTypesTypeExtensions
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
            this List<GetRemediationTypesType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetRemediationTypesType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetRemediationTypesType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetRemediationTypesType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetRemediationTypesType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
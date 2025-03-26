// HostDiagnosisSummary.cs
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
    #region HostDiagnosisSummary
    public class HostDiagnosisSummary: BaseType
    {
        #region members

        //      C# -> List<HostConnectivitySummary>? Connectivity
        // GraphQL -> connectivity: [HostConnectivitySummary!]! (type)
        [JsonProperty("connectivity")]
        public List<HostConnectivitySummary>? Connectivity { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HostDiagnosisSummary";
    }

    public HostDiagnosisSummary Set(
        List<HostConnectivitySummary>? Connectivity = null
    ) 
    {
        if ( Connectivity != null ) {
            this.Connectivity = Connectivity;
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
        //      C# -> List<HostConnectivitySummary>? Connectivity
        // GraphQL -> connectivity: [HostConnectivitySummary!]! (type)
        if (this.Connectivity != null) {
            var fspec = this.Connectivity.AsFieldSpec(conf.Child("connectivity"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "connectivity" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<HostConnectivitySummary>? Connectivity
        // GraphQL -> connectivity: [HostConnectivitySummary!]! (type)
        if (ec.Includes("connectivity",false))
        {
            if(this.Connectivity == null) {

                this.Connectivity = new List<HostConnectivitySummary>();
                this.Connectivity.ApplyExploratoryFieldSpec(ec.NewChild("connectivity"));

            } else {

                this.Connectivity.ApplyExploratoryFieldSpec(ec.NewChild("connectivity"));

            }
        }
        else if (this.Connectivity != null && ec.Excludes("connectivity",false))
        {
            this.Connectivity = null;
        }
    }


    #endregion

    } // class HostDiagnosisSummary
    
    #endregion

    public static class ListHostDiagnosisSummaryExtensions
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
            this List<HostDiagnosisSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HostDiagnosisSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HostDiagnosisSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HostDiagnosisSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HostDiagnosisSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
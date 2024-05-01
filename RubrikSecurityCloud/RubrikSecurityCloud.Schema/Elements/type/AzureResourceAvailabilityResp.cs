// AzureResourceAvailabilityResp.cs
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
    #region AzureResourceAvailabilityResp
    public class AzureResourceAvailabilityResp: BaseType
    {
        #region members

        //      C# -> System.Boolean? Available
        // GraphQL -> available: Boolean! (scalar)
        [JsonProperty("available")]
        public System.Boolean? Available { get; set; }

        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        [JsonProperty("reason")]
        public System.String? Reason { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureResourceAvailabilityResp";
    }

    public AzureResourceAvailabilityResp Set(
        System.Boolean? Available = null,
        System.String? Reason = null
    ) 
    {
        if ( Available != null ) {
            this.Available = Available;
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
        //      C# -> System.Boolean? Available
        // GraphQL -> available: Boolean! (scalar)
        if (this.Available != null) {
            if (conf.Flat) {
                s += conf.Prefix + "available\n" ;
            } else {
                s += ind + "available\n" ;
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
        //      C# -> System.Boolean? Available
        // GraphQL -> available: Boolean! (scalar)
        if (ec.Includes("available",true))
        {
            if(this.Available == null) {

                this.Available = true;

            } else {


            }
        }
        else if (this.Available != null && ec.Excludes("available",true))
        {
            this.Available = null;
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

    } // class AzureResourceAvailabilityResp
    
    #endregion

    public static class ListAzureResourceAvailabilityRespExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AzureResourceAvailabilityResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureResourceAvailabilityResp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureResourceAvailabilityResp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureResourceAvailabilityResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureResourceAvailabilityResp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
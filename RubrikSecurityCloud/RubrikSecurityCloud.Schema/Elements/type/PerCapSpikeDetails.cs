// PerCapSpikeDetails.cs
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
    #region PerCapSpikeDetails
    public class PerCapSpikeDetails: BaseType
    {
        #region members

        //      C# -> System.String? CapDisplayName
        // GraphQL -> capDisplayName: String! (scalar)
        [JsonProperty("capDisplayName")]
        public System.String? CapDisplayName { get; set; }

        //      C# -> System.String? CapId
        // GraphQL -> capId: String! (scalar)
        [JsonProperty("capId")]
        public System.String? CapId { get; set; }

        //      C# -> List<System.Int32>? ErrorCodes
        // GraphQL -> errorCodes: [Int!]! (scalar)
        [JsonProperty("errorCodes")]
        public List<System.Int32>? ErrorCodes { get; set; }

        //      C# -> List<System.String>? Results
        // GraphQL -> results: [String!]! (scalar)
        [JsonProperty("results")]
        public List<System.String>? Results { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PerCapSpikeDetails";
    }

    public PerCapSpikeDetails Set(
        System.String? CapDisplayName = null,
        System.String? CapId = null,
        List<System.Int32>? ErrorCodes = null,
        List<System.String>? Results = null
    ) 
    {
        if ( CapDisplayName != null ) {
            this.CapDisplayName = CapDisplayName;
        }
        if ( CapId != null ) {
            this.CapId = CapId;
        }
        if ( ErrorCodes != null ) {
            this.ErrorCodes = ErrorCodes;
        }
        if ( Results != null ) {
            this.Results = Results;
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
        //      C# -> System.String? CapDisplayName
        // GraphQL -> capDisplayName: String! (scalar)
        if (this.CapDisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "capDisplayName\n" ;
            } else {
                s += ind + "capDisplayName\n" ;
            }
        }
        //      C# -> System.String? CapId
        // GraphQL -> capId: String! (scalar)
        if (this.CapId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "capId\n" ;
            } else {
                s += ind + "capId\n" ;
            }
        }
        //      C# -> List<System.Int32>? ErrorCodes
        // GraphQL -> errorCodes: [Int!]! (scalar)
        if (this.ErrorCodes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorCodes\n" ;
            } else {
                s += ind + "errorCodes\n" ;
            }
        }
        //      C# -> List<System.String>? Results
        // GraphQL -> results: [String!]! (scalar)
        if (this.Results != null) {
            if (conf.Flat) {
                s += conf.Prefix + "results\n" ;
            } else {
                s += ind + "results\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? CapDisplayName
        // GraphQL -> capDisplayName: String! (scalar)
        if (ec.Includes("capDisplayName",true))
        {
            if(this.CapDisplayName == null) {

                this.CapDisplayName = "FETCH";

            } else {


            }
        }
        else if (this.CapDisplayName != null && ec.Excludes("capDisplayName",true))
        {
            this.CapDisplayName = null;
        }
        //      C# -> System.String? CapId
        // GraphQL -> capId: String! (scalar)
        if (ec.Includes("capId",true))
        {
            if(this.CapId == null) {

                this.CapId = "FETCH";

            } else {


            }
        }
        else if (this.CapId != null && ec.Excludes("capId",true))
        {
            this.CapId = null;
        }
        //      C# -> List<System.Int32>? ErrorCodes
        // GraphQL -> errorCodes: [Int!]! (scalar)
        if (ec.Includes("errorCodes",true))
        {
            if(this.ErrorCodes == null) {

                this.ErrorCodes = new List<System.Int32>();

            } else {


            }
        }
        else if (this.ErrorCodes != null && ec.Excludes("errorCodes",true))
        {
            this.ErrorCodes = null;
        }
        //      C# -> List<System.String>? Results
        // GraphQL -> results: [String!]! (scalar)
        if (ec.Includes("results",true))
        {
            if(this.Results == null) {

                this.Results = new List<System.String>();

            } else {


            }
        }
        else if (this.Results != null && ec.Excludes("results",true))
        {
            this.Results = null;
        }
    }


    #endregion

    } // class PerCapSpikeDetails
    
    #endregion

    public static class ListPerCapSpikeDetailsExtensions
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
            this List<PerCapSpikeDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PerCapSpikeDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PerCapSpikeDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PerCapSpikeDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PerCapSpikeDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
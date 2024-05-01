// GetO365ServiceStatusResp.cs
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
    #region GetO365ServiceStatusResp
    public class GetO365ServiceStatusResp: BaseType
    {
        #region members

        //      C# -> O365ServiceStatusIndication? Status
        // GraphQL -> status: O365ServiceStatusIndication! (enum)
        [JsonProperty("status")]
        public O365ServiceStatusIndication? Status { get; set; }

        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime (scalar)
        [JsonProperty("lastUpdated")]
        public DateTime? LastUpdated { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetO365ServiceStatusResp";
    }

    public GetO365ServiceStatusResp Set(
        O365ServiceStatusIndication? Status = null,
        DateTime? LastUpdated = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( LastUpdated != null ) {
            this.LastUpdated = LastUpdated;
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
        //      C# -> O365ServiceStatusIndication? Status
        // GraphQL -> status: O365ServiceStatusIndication! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime (scalar)
        if (this.LastUpdated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastUpdated\n" ;
            } else {
                s += ind + "lastUpdated\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> O365ServiceStatusIndication? Status
        // GraphQL -> status: O365ServiceStatusIndication! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new O365ServiceStatusIndication();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime (scalar)
        if (ec.Includes("lastUpdated",true))
        {
            if(this.LastUpdated == null) {

                this.LastUpdated = new DateTime();

            } else {


            }
        }
        else if (this.LastUpdated != null && ec.Excludes("lastUpdated",true))
        {
            this.LastUpdated = null;
        }
    }


    #endregion

    } // class GetO365ServiceStatusResp
    
    #endregion

    public static class ListGetO365ServiceStatusRespExtensions
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
            this List<GetO365ServiceStatusResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetO365ServiceStatusResp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetO365ServiceStatusResp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetO365ServiceStatusResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetO365ServiceStatusResp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
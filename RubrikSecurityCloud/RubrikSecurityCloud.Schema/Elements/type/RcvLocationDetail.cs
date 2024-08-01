// RcvLocationDetail.cs
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
    #region RcvLocationDetail
    public class RcvLocationDetail: BaseType
    {
        #region members

        //      C# -> System.String? RscArchivalLocationId
        // GraphQL -> rscArchivalLocationId: String! (scalar)
        [JsonProperty("rscArchivalLocationId")]
        public System.String? RscArchivalLocationId { get; set; }

        //      C# -> List<System.String>? SlaDomainIds
        // GraphQL -> slaDomainIds: [String!]! (scalar)
        [JsonProperty("slaDomainIds")]
        public List<System.String>? SlaDomainIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcvLocationDetail";
    }

    public RcvLocationDetail Set(
        System.String? RscArchivalLocationId = null,
        List<System.String>? SlaDomainIds = null
    ) 
    {
        if ( RscArchivalLocationId != null ) {
            this.RscArchivalLocationId = RscArchivalLocationId;
        }
        if ( SlaDomainIds != null ) {
            this.SlaDomainIds = SlaDomainIds;
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
        //      C# -> System.String? RscArchivalLocationId
        // GraphQL -> rscArchivalLocationId: String! (scalar)
        if (this.RscArchivalLocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rscArchivalLocationId\n" ;
            } else {
                s += ind + "rscArchivalLocationId\n" ;
            }
        }
        //      C# -> List<System.String>? SlaDomainIds
        // GraphQL -> slaDomainIds: [String!]! (scalar)
        if (this.SlaDomainIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaDomainIds\n" ;
            } else {
                s += ind + "slaDomainIds\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? RscArchivalLocationId
        // GraphQL -> rscArchivalLocationId: String! (scalar)
        if (ec.Includes("rscArchivalLocationId",true))
        {
            if(this.RscArchivalLocationId == null) {

                this.RscArchivalLocationId = "FETCH";

            } else {


            }
        }
        else if (this.RscArchivalLocationId != null && ec.Excludes("rscArchivalLocationId",true))
        {
            this.RscArchivalLocationId = null;
        }
        //      C# -> List<System.String>? SlaDomainIds
        // GraphQL -> slaDomainIds: [String!]! (scalar)
        if (ec.Includes("slaDomainIds",true))
        {
            if(this.SlaDomainIds == null) {

                this.SlaDomainIds = new List<System.String>();

            } else {


            }
        }
        else if (this.SlaDomainIds != null && ec.Excludes("slaDomainIds",true))
        {
            this.SlaDomainIds = null;
        }
    }


    #endregion

    } // class RcvLocationDetail
    
    #endregion

    public static class ListRcvLocationDetailExtensions
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
            this List<RcvLocationDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcvLocationDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvLocationDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvLocationDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvLocationDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
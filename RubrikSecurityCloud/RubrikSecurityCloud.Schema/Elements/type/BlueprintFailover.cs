// BlueprintFailover.cs
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
    #region BlueprintFailover
    public class BlueprintFailover: BaseType
    {
        #region members

        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum! (enum)
        [JsonProperty("failoverType")]
        public FailoverTypeEnum? FailoverType { get; set; }

        //      C# -> FailoverStatusEnum? Status
        // GraphQL -> status: FailoverStatusEnum! (enum)
        [JsonProperty("status")]
        public FailoverStatusEnum? Status { get; set; }

        //      C# -> System.String? FailoverId
        // GraphQL -> failoverId: String! (scalar)
        [JsonProperty("failoverId")]
        public System.String? FailoverId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BlueprintFailover";
    }

    public BlueprintFailover Set(
        FailoverTypeEnum? FailoverType = null,
        FailoverStatusEnum? Status = null,
        System.String? FailoverId = null
    ) 
    {
        if ( FailoverType != null ) {
            this.FailoverType = FailoverType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( FailoverId != null ) {
            this.FailoverId = FailoverId;
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
        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum! (enum)
        if (this.FailoverType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failoverType\n" ;
            } else {
                s += ind + "failoverType\n" ;
            }
        }
        //      C# -> FailoverStatusEnum? Status
        // GraphQL -> status: FailoverStatusEnum! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? FailoverId
        // GraphQL -> failoverId: String! (scalar)
        if (this.FailoverId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failoverId\n" ;
            } else {
                s += ind + "failoverId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum! (enum)
        if (ec.Includes("failoverType",true))
        {
            if(this.FailoverType == null) {

                this.FailoverType = new FailoverTypeEnum();

            } else {


            }
        }
        else if (this.FailoverType != null && ec.Excludes("failoverType",true))
        {
            this.FailoverType = null;
        }
        //      C# -> FailoverStatusEnum? Status
        // GraphQL -> status: FailoverStatusEnum! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new FailoverStatusEnum();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? FailoverId
        // GraphQL -> failoverId: String! (scalar)
        if (ec.Includes("failoverId",true))
        {
            if(this.FailoverId == null) {

                this.FailoverId = "FETCH";

            } else {


            }
        }
        else if (this.FailoverId != null && ec.Excludes("failoverId",true))
        {
            this.FailoverId = null;
        }
    }


    #endregion

    } // class BlueprintFailover
    
    #endregion

    public static class ListBlueprintFailoverExtensions
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
            this List<BlueprintFailover> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BlueprintFailover> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BlueprintFailover> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BlueprintFailover());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BlueprintFailover> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
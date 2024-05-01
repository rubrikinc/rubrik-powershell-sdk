// ZrsAvailabilityReply.cs
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
    #region ZrsAvailabilityReply
    public class ZrsAvailabilityReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsAvailable
        // GraphQL -> isAvailable: Boolean! (scalar)
        [JsonProperty("isAvailable")]
        public System.Boolean? IsAvailable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ZrsAvailabilityReply";
    }

    public ZrsAvailabilityReply Set(
        System.Boolean? IsAvailable = null
    ) 
    {
        if ( IsAvailable != null ) {
            this.IsAvailable = IsAvailable;
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
        //      C# -> System.Boolean? IsAvailable
        // GraphQL -> isAvailable: Boolean! (scalar)
        if (this.IsAvailable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAvailable\n" ;
            } else {
                s += ind + "isAvailable\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsAvailable
        // GraphQL -> isAvailable: Boolean! (scalar)
        if (ec.Includes("isAvailable",true))
        {
            if(this.IsAvailable == null) {

                this.IsAvailable = true;

            } else {


            }
        }
        else if (this.IsAvailable != null && ec.Excludes("isAvailable",true))
        {
            this.IsAvailable = null;
        }
    }


    #endregion

    } // class ZrsAvailabilityReply
    
    #endregion

    public static class ListZrsAvailabilityReplyExtensions
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
            this List<ZrsAvailabilityReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ZrsAvailabilityReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ZrsAvailabilityReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ZrsAvailabilityReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ZrsAvailabilityReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
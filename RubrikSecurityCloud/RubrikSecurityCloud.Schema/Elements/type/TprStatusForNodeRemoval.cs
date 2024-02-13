// TprStatusForNodeRemoval.cs
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
    #region TprStatusForNodeRemoval
    public class TprStatusForNodeRemoval: BaseType
    {
        #region members

        //      C# -> TprReqStatus? Status
        // GraphQL -> status: TprReqStatus! (enum)
        [JsonProperty("status")]
        public TprReqStatus? Status { get; set; }

        //      C# -> System.String? TprRequestId
        // GraphQL -> tprRequestId: String! (scalar)
        [JsonProperty("tprRequestId")]
        public System.String? TprRequestId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprStatusForNodeRemoval";
    }

    public TprStatusForNodeRemoval Set(
        TprReqStatus? Status = null,
        System.String? TprRequestId = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( TprRequestId != null ) {
            this.TprRequestId = TprRequestId;
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
        //      C# -> TprReqStatus? Status
        // GraphQL -> status: TprReqStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? TprRequestId
        // GraphQL -> tprRequestId: String! (scalar)
        if (this.TprRequestId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tprRequestId\n" ;
            } else {
                s += ind + "tprRequestId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TprReqStatus? Status
        // GraphQL -> status: TprReqStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new TprReqStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? TprRequestId
        // GraphQL -> tprRequestId: String! (scalar)
        if (ec.Includes("tprRequestId",true))
        {
            if(this.TprRequestId == null) {

                this.TprRequestId = "FETCH";

            } else {


            }
        }
        else if (this.TprRequestId != null && ec.Excludes("tprRequestId",true))
        {
            this.TprRequestId = null;
        }
    }


    #endregion

    } // class TprStatusForNodeRemoval
    
    #endregion

    public static class ListTprStatusForNodeRemovalExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<TprStatusForNodeRemoval> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<TprStatusForNodeRemoval> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TprStatusForNodeRemoval> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprStatusForNodeRemoval());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TprStatusForNodeRemoval> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
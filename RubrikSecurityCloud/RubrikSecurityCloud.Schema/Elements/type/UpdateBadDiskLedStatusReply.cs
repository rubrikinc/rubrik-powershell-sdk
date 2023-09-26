// UpdateBadDiskLedStatusReply.cs
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
    #region UpdateBadDiskLedStatusReply
    public class UpdateBadDiskLedStatusReply: BaseType
    {
        #region members

        //      C# -> CdmFindBadDiskResultType? Result
        // GraphQL -> result: CdmFindBadDiskResultType! (enum)
        [JsonProperty("result")]
        public CdmFindBadDiskResultType? Result { get; set; }

        //      C# -> System.String? Output
        // GraphQL -> output: String (scalar)
        [JsonProperty("output")]
        public System.String? Output { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateBadDiskLedStatusReply";
    }

    public UpdateBadDiskLedStatusReply Set(
        CdmFindBadDiskResultType? Result = null,
        System.String? Output = null
    ) 
    {
        if ( Result != null ) {
            this.Result = Result;
        }
        if ( Output != null ) {
            this.Output = Output;
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
        //      C# -> CdmFindBadDiskResultType? Result
        // GraphQL -> result: CdmFindBadDiskResultType! (enum)
        if (this.Result != null) {
            if (conf.Flat) {
                s += conf.Prefix + "result\n" ;
            } else {
                s += ind + "result\n" ;
            }
        }
        //      C# -> System.String? Output
        // GraphQL -> output: String (scalar)
        if (this.Output != null) {
            if (conf.Flat) {
                s += conf.Prefix + "output\n" ;
            } else {
                s += ind + "output\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CdmFindBadDiskResultType? Result
        // GraphQL -> result: CdmFindBadDiskResultType! (enum)
        if (ec.Includes("result",true))
        {
            if(this.Result == null) {

                this.Result = new CdmFindBadDiskResultType();

            } else {


            }
        }
        else if (this.Result != null && ec.Excludes("result",true))
        {
            this.Result = null;
        }
        //      C# -> System.String? Output
        // GraphQL -> output: String (scalar)
        if (ec.Includes("output",true))
        {
            if(this.Output == null) {

                this.Output = "FETCH";

            } else {


            }
        }
        else if (this.Output != null && ec.Excludes("output",true))
        {
            this.Output = null;
        }
    }


    #endregion

    } // class UpdateBadDiskLedStatusReply
    
    #endregion

    public static class ListUpdateBadDiskLedStatusReplyExtensions
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
            this List<UpdateBadDiskLedStatusReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateBadDiskLedStatusReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateBadDiskLedStatusReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateBadDiskLedStatusReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// RegisterNasSystemReply.cs
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
    #region RegisterNasSystemReply
    public class RegisterNasSystemReply: BaseType
    {
        #region members

        //      C# -> AsyncRequestStatus? NasDiscoverJobStatus
        // GraphQL -> nasDiscoverJobStatus: AsyncRequestStatus (type)
        [JsonProperty("nasDiscoverJobStatus")]
        public AsyncRequestStatus? NasDiscoverJobStatus { get; set; }

        //      C# -> UpdateNasSystemReply? NasSystemSummary
        // GraphQL -> nasSystemSummary: UpdateNasSystemReply (type)
        [JsonProperty("nasSystemSummary")]
        public UpdateNasSystemReply? NasSystemSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RegisterNasSystemReply";
    }

    public RegisterNasSystemReply Set(
        AsyncRequestStatus? NasDiscoverJobStatus = null,
        UpdateNasSystemReply? NasSystemSummary = null
    ) 
    {
        if ( NasDiscoverJobStatus != null ) {
            this.NasDiscoverJobStatus = NasDiscoverJobStatus;
        }
        if ( NasSystemSummary != null ) {
            this.NasSystemSummary = NasSystemSummary;
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
        //      C# -> AsyncRequestStatus? NasDiscoverJobStatus
        // GraphQL -> nasDiscoverJobStatus: AsyncRequestStatus (type)
        if (this.NasDiscoverJobStatus != null) {
            var fspec = this.NasDiscoverJobStatus.AsFieldSpec(conf.Child("nasDiscoverJobStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nasDiscoverJobStatus {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> UpdateNasSystemReply? NasSystemSummary
        // GraphQL -> nasSystemSummary: UpdateNasSystemReply (type)
        if (this.NasSystemSummary != null) {
            var fspec = this.NasSystemSummary.AsFieldSpec(conf.Child("nasSystemSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nasSystemSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AsyncRequestStatus? NasDiscoverJobStatus
        // GraphQL -> nasDiscoverJobStatus: AsyncRequestStatus (type)
        if (ec.Includes("nasDiscoverJobStatus",false))
        {
            if(this.NasDiscoverJobStatus == null) {

                this.NasDiscoverJobStatus = new AsyncRequestStatus();
                this.NasDiscoverJobStatus.ApplyExploratoryFieldSpec(ec.NewChild("nasDiscoverJobStatus"));

            } else {

                this.NasDiscoverJobStatus.ApplyExploratoryFieldSpec(ec.NewChild("nasDiscoverJobStatus"));

            }
        }
        else if (this.NasDiscoverJobStatus != null && ec.Excludes("nasDiscoverJobStatus",false))
        {
            this.NasDiscoverJobStatus = null;
        }
        //      C# -> UpdateNasSystemReply? NasSystemSummary
        // GraphQL -> nasSystemSummary: UpdateNasSystemReply (type)
        if (ec.Includes("nasSystemSummary",false))
        {
            if(this.NasSystemSummary == null) {

                this.NasSystemSummary = new UpdateNasSystemReply();
                this.NasSystemSummary.ApplyExploratoryFieldSpec(ec.NewChild("nasSystemSummary"));

            } else {

                this.NasSystemSummary.ApplyExploratoryFieldSpec(ec.NewChild("nasSystemSummary"));

            }
        }
        else if (this.NasSystemSummary != null && ec.Excludes("nasSystemSummary",false))
        {
            this.NasSystemSummary = null;
        }
    }


    #endregion

    } // class RegisterNasSystemReply
    
    #endregion

    public static class ListRegisterNasSystemReplyExtensions
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
            this List<RegisterNasSystemReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RegisterNasSystemReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RegisterNasSystemReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RegisterNasSystemReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RegisterNasSystemReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
                    s += ind + "nasDiscoverJobStatus" + " " + "{\n" + fspec + ind + "}\n" ;
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
                    s += ind + "nasSystemSummary" + " " + "{\n" + fspec + ind + "}\n" ;
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
            this List<RegisterNasSystemReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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
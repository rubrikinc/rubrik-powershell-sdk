// GetDataPreviewReply.cs
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
    #region GetDataPreviewReply
    public class GetDataPreviewReply: BaseType
    {
        #region members

        //      C# -> SampleOutput? SampleOutput
        // GraphQL -> sampleOutput: SampleOutput (type)
        [JsonProperty("sampleOutput")]
        public SampleOutput? SampleOutput { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetDataPreviewReply";
    }

    public GetDataPreviewReply Set(
        SampleOutput? SampleOutput = null
    ) 
    {
        if ( SampleOutput != null ) {
            this.SampleOutput = SampleOutput;
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
        //      C# -> SampleOutput? SampleOutput
        // GraphQL -> sampleOutput: SampleOutput (type)
        if (this.SampleOutput != null) {
            var fspec = this.SampleOutput.AsFieldSpec(conf.Child("sampleOutput"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sampleOutput" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SampleOutput? SampleOutput
        // GraphQL -> sampleOutput: SampleOutput (type)
        if (ec.Includes("sampleOutput",false))
        {
            if(this.SampleOutput == null) {

                this.SampleOutput = new SampleOutput();
                this.SampleOutput.ApplyExploratoryFieldSpec(ec.NewChild("sampleOutput"));

            } else {

                this.SampleOutput.ApplyExploratoryFieldSpec(ec.NewChild("sampleOutput"));

            }
        }
        else if (this.SampleOutput != null && ec.Excludes("sampleOutput",false))
        {
            this.SampleOutput = null;
        }
    }


    #endregion

    } // class GetDataPreviewReply
    
    #endregion

    public static class ListGetDataPreviewReplyExtensions
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
            this List<GetDataPreviewReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetDataPreviewReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetDataPreviewReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetDataPreviewReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetDataPreviewReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// SampleOutput.cs
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
    #region SampleOutput
    public class SampleOutput: BaseType
    {
        #region members

        //      C# -> System.String? DirectoryPath
        // GraphQL -> directoryPath: String! (scalar)
        [JsonProperty("directoryPath")]
        public System.String? DirectoryPath { get; set; }

        //      C# -> System.String? FileFullPath
        // GraphQL -> fileFullPath: String! (scalar)
        [JsonProperty("fileFullPath")]
        public System.String? FileFullPath { get; set; }

        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        [JsonProperty("fileName")]
        public System.String? FileName { get; set; }

        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: String! (scalar)
        [JsonProperty("workloadFid")]
        public System.String? WorkloadFid { get; set; }

        //      C# -> List<SampledColumn>? Columns
        // GraphQL -> columns: [SampledColumn!]! (type)
        [JsonProperty("columns")]
        public List<SampledColumn>? Columns { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SampleOutput";
    }

    public SampleOutput Set(
        System.String? DirectoryPath = null,
        System.String? FileFullPath = null,
        System.String? FileName = null,
        System.String? WorkloadFid = null,
        List<SampledColumn>? Columns = null
    ) 
    {
        if ( DirectoryPath != null ) {
            this.DirectoryPath = DirectoryPath;
        }
        if ( FileFullPath != null ) {
            this.FileFullPath = FileFullPath;
        }
        if ( FileName != null ) {
            this.FileName = FileName;
        }
        if ( WorkloadFid != null ) {
            this.WorkloadFid = WorkloadFid;
        }
        if ( Columns != null ) {
            this.Columns = Columns;
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
        //      C# -> System.String? DirectoryPath
        // GraphQL -> directoryPath: String! (scalar)
        if (this.DirectoryPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "directoryPath\n" ;
            } else {
                s += ind + "directoryPath\n" ;
            }
        }
        //      C# -> System.String? FileFullPath
        // GraphQL -> fileFullPath: String! (scalar)
        if (this.FileFullPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileFullPath\n" ;
            } else {
                s += ind + "fileFullPath\n" ;
            }
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileName\n" ;
            } else {
                s += ind + "fileName\n" ;
            }
        }
        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: String! (scalar)
        if (this.WorkloadFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadFid\n" ;
            } else {
                s += ind + "workloadFid\n" ;
            }
        }
        //      C# -> List<SampledColumn>? Columns
        // GraphQL -> columns: [SampledColumn!]! (type)
        if (this.Columns != null) {
            var fspec = this.Columns.AsFieldSpec(conf.Child("columns"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "columns" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DirectoryPath
        // GraphQL -> directoryPath: String! (scalar)
        if (ec.Includes("directoryPath",true))
        {
            if(this.DirectoryPath == null) {

                this.DirectoryPath = "FETCH";

            } else {


            }
        }
        else if (this.DirectoryPath != null && ec.Excludes("directoryPath",true))
        {
            this.DirectoryPath = null;
        }
        //      C# -> System.String? FileFullPath
        // GraphQL -> fileFullPath: String! (scalar)
        if (ec.Includes("fileFullPath",true))
        {
            if(this.FileFullPath == null) {

                this.FileFullPath = "FETCH";

            } else {


            }
        }
        else if (this.FileFullPath != null && ec.Excludes("fileFullPath",true))
        {
            this.FileFullPath = null;
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (ec.Includes("fileName",true))
        {
            if(this.FileName == null) {

                this.FileName = "FETCH";

            } else {


            }
        }
        else if (this.FileName != null && ec.Excludes("fileName",true))
        {
            this.FileName = null;
        }
        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: String! (scalar)
        if (ec.Includes("workloadFid",true))
        {
            if(this.WorkloadFid == null) {

                this.WorkloadFid = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadFid != null && ec.Excludes("workloadFid",true))
        {
            this.WorkloadFid = null;
        }
        //      C# -> List<SampledColumn>? Columns
        // GraphQL -> columns: [SampledColumn!]! (type)
        if (ec.Includes("columns",false))
        {
            if(this.Columns == null) {

                this.Columns = new List<SampledColumn>();
                this.Columns.ApplyExploratoryFieldSpec(ec.NewChild("columns"));

            } else {

                this.Columns.ApplyExploratoryFieldSpec(ec.NewChild("columns"));

            }
        }
        else if (this.Columns != null && ec.Excludes("columns",false))
        {
            this.Columns = null;
        }
    }


    #endregion

    } // class SampleOutput
    
    #endregion

    public static class ListSampleOutputExtensions
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
            this List<SampleOutput> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SampleOutput> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SampleOutput> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SampleOutput());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SampleOutput> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
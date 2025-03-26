// DataTypeResult.cs
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
    #region DataTypeResult
    public class DataTypeResult: BaseType
    {
        #region members

        //      C# -> Analyzer? DataType
        // GraphQL -> dataType: Analyzer (type)
        [JsonProperty("dataType")]
        public Analyzer? DataType { get; set; }

        //      C# -> DataTypeStats? Result
        // GraphQL -> result: DataTypeStats (type)
        [JsonProperty("result")]
        public DataTypeStats? Result { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DataTypeResult";
    }

    public DataTypeResult Set(
        Analyzer? DataType = null,
        DataTypeStats? Result = null
    ) 
    {
        if ( DataType != null ) {
            this.DataType = DataType;
        }
        if ( Result != null ) {
            this.Result = Result;
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
        //      C# -> Analyzer? DataType
        // GraphQL -> dataType: Analyzer (type)
        if (this.DataType != null) {
            var fspec = this.DataType.AsFieldSpec(conf.Child("dataType"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataType" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> DataTypeStats? Result
        // GraphQL -> result: DataTypeStats (type)
        if (this.Result != null) {
            var fspec = this.Result.AsFieldSpec(conf.Child("result"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "result" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> Analyzer? DataType
        // GraphQL -> dataType: Analyzer (type)
        if (ec.Includes("dataType",false))
        {
            if(this.DataType == null) {

                this.DataType = new Analyzer();
                this.DataType.ApplyExploratoryFieldSpec(ec.NewChild("dataType"));

            } else {

                this.DataType.ApplyExploratoryFieldSpec(ec.NewChild("dataType"));

            }
        }
        else if (this.DataType != null && ec.Excludes("dataType",false))
        {
            this.DataType = null;
        }
        //      C# -> DataTypeStats? Result
        // GraphQL -> result: DataTypeStats (type)
        if (ec.Includes("result",false))
        {
            if(this.Result == null) {

                this.Result = new DataTypeStats();
                this.Result.ApplyExploratoryFieldSpec(ec.NewChild("result"));

            } else {

                this.Result.ApplyExploratoryFieldSpec(ec.NewChild("result"));

            }
        }
        else if (this.Result != null && ec.Excludes("result",false))
        {
            this.Result = null;
        }
    }


    #endregion

    } // class DataTypeResult
    
    #endregion

    public static class ListDataTypeResultExtensions
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
            this List<DataTypeResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DataTypeResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DataTypeResult> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DataTypeResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DataTypeResult> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// GetSchemaResponse.cs
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
    #region GetSchemaResponse
    public class GetSchemaResponse: BaseType
    {
        #region members

        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.Int64? ReturnCode
        // GraphQL -> returnCode: Long (scalar)
        [JsonProperty("returnCode")]
        public System.Int64? ReturnCode { get; set; }

        //      C# -> System.Boolean? Status
        // GraphQL -> status: Boolean (scalar)
        [JsonProperty("status")]
        public System.Boolean? Status { get; set; }

        //      C# -> CassandraSchemaObject? Data
        // GraphQL -> data: CassandraSchemaObject (type)
        [JsonProperty("data")]
        public CassandraSchemaObject? Data { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetSchemaResponse";
    }

    public GetSchemaResponse Set(
        System.String? Message = null,
        System.Int64? ReturnCode = null,
        System.Boolean? Status = null,
        CassandraSchemaObject? Data = null
    ) 
    {
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( ReturnCode != null ) {
            this.ReturnCode = ReturnCode;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Data != null ) {
            this.Data = Data;
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
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        //      C# -> System.Int64? ReturnCode
        // GraphQL -> returnCode: Long (scalar)
        if (this.ReturnCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "returnCode\n" ;
            } else {
                s += ind + "returnCode\n" ;
            }
        }
        //      C# -> System.Boolean? Status
        // GraphQL -> status: Boolean (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> CassandraSchemaObject? Data
        // GraphQL -> data: CassandraSchemaObject (type)
        if (this.Data != null) {
            var fspec = this.Data.AsFieldSpec(conf.Child("data"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "data" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (ec.Includes("message",true))
        {
            if(this.Message == null) {

                this.Message = "FETCH";

            } else {


            }
        }
        else if (this.Message != null && ec.Excludes("message",true))
        {
            this.Message = null;
        }
        //      C# -> System.Int64? ReturnCode
        // GraphQL -> returnCode: Long (scalar)
        if (ec.Includes("returnCode",true))
        {
            if(this.ReturnCode == null) {

                this.ReturnCode = new System.Int64();

            } else {


            }
        }
        else if (this.ReturnCode != null && ec.Excludes("returnCode",true))
        {
            this.ReturnCode = null;
        }
        //      C# -> System.Boolean? Status
        // GraphQL -> status: Boolean (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = true;

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> CassandraSchemaObject? Data
        // GraphQL -> data: CassandraSchemaObject (type)
        if (ec.Includes("data",false))
        {
            if(this.Data == null) {

                this.Data = new CassandraSchemaObject();
                this.Data.ApplyExploratoryFieldSpec(ec.NewChild("data"));

            } else {

                this.Data.ApplyExploratoryFieldSpec(ec.NewChild("data"));

            }
        }
        else if (this.Data != null && ec.Excludes("data",false))
        {
            this.Data = null;
        }
    }


    #endregion

    } // class GetSchemaResponse
    
    #endregion

    public static class ListGetSchemaResponseExtensions
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
            this List<GetSchemaResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetSchemaResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetSchemaResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetSchemaResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetSchemaResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
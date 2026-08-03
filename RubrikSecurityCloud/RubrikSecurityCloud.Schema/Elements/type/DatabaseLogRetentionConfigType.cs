// DatabaseLogRetentionConfigType.cs
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
    #region DatabaseLogRetentionConfigType
    public class DatabaseLogRetentionConfigType: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsDisabled
        // GraphQL -> isDisabled: Boolean! (scalar)
        [JsonProperty("isDisabled")]
        public System.Boolean? IsDisabled { get; set; }

        //      C# -> System.Int64? LogRetentionInMs
        // GraphQL -> logRetentionInMs: Long! (scalar)
        [JsonProperty("logRetentionInMs")]
        public System.Int64? LogRetentionInMs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DatabaseLogRetentionConfigType";
    }

    public DatabaseLogRetentionConfigType Set(
        System.Boolean? IsDisabled = null,
        System.Int64? LogRetentionInMs = null
    ) 
    {
        if ( IsDisabled != null ) {
            this.IsDisabled = IsDisabled;
        }
        if ( LogRetentionInMs != null ) {
            this.LogRetentionInMs = LogRetentionInMs;
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
        //      C# -> System.Boolean? IsDisabled
        // GraphQL -> isDisabled: Boolean! (scalar)
        if (this.IsDisabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDisabled\n" ;
            } else {
                s += ind + "isDisabled\n" ;
            }
        }
        //      C# -> System.Int64? LogRetentionInMs
        // GraphQL -> logRetentionInMs: Long! (scalar)
        if (this.LogRetentionInMs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logRetentionInMs\n" ;
            } else {
                s += ind + "logRetentionInMs\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsDisabled
        // GraphQL -> isDisabled: Boolean! (scalar)
        if (ec.Includes("isDisabled",true))
        {
            if(this.IsDisabled == null) {

                this.IsDisabled = true;

            } else {


            }
        }
        else if (this.IsDisabled != null && ec.Excludes("isDisabled",true))
        {
            this.IsDisabled = null;
        }
        //      C# -> System.Int64? LogRetentionInMs
        // GraphQL -> logRetentionInMs: Long! (scalar)
        if (ec.Includes("logRetentionInMs",true))
        {
            if(this.LogRetentionInMs == null) {

                this.LogRetentionInMs = new System.Int64();

            } else {


            }
        }
        else if (this.LogRetentionInMs != null && ec.Excludes("logRetentionInMs",true))
        {
            this.LogRetentionInMs = null;
        }
    }


    #endregion

    } // class DatabaseLogRetentionConfigType
    
    #endregion

    public static class ListDatabaseLogRetentionConfigTypeExtensions
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
            this List<DatabaseLogRetentionConfigType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DatabaseLogRetentionConfigType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DatabaseLogRetentionConfigType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DatabaseLogRetentionConfigType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DatabaseLogRetentionConfigType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// StepsOneof.cs
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
    #region StepsOneof
    public class StepsOneof: BaseType
    {
        #region members

        //      C# -> ComplexRecoverySteps? ComplexSteps
        // GraphQL -> complexSteps: ComplexRecoverySteps (type)
        [JsonProperty("complexSteps")]
        public ComplexRecoverySteps? ComplexSteps { get; set; }

        //      C# -> RecoverySteps? SimpleSteps
        // GraphQL -> simpleSteps: RecoverySteps (type)
        [JsonProperty("simpleSteps")]
        public RecoverySteps? SimpleSteps { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "StepsOneof";
    }

    public StepsOneof Set(
        ComplexRecoverySteps? ComplexSteps = null,
        RecoverySteps? SimpleSteps = null
    ) 
    {
        if ( ComplexSteps != null ) {
            this.ComplexSteps = ComplexSteps;
        }
        if ( SimpleSteps != null ) {
            this.SimpleSteps = SimpleSteps;
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
        //      C# -> ComplexRecoverySteps? ComplexSteps
        // GraphQL -> complexSteps: ComplexRecoverySteps (type)
        if (this.ComplexSteps != null) {
            var fspec = this.ComplexSteps.AsFieldSpec(conf.Child("complexSteps"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "complexSteps" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoverySteps? SimpleSteps
        // GraphQL -> simpleSteps: RecoverySteps (type)
        if (this.SimpleSteps != null) {
            var fspec = this.SimpleSteps.AsFieldSpec(conf.Child("simpleSteps"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "simpleSteps" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ComplexRecoverySteps? ComplexSteps
        // GraphQL -> complexSteps: ComplexRecoverySteps (type)
        if (ec.Includes("complexSteps",false))
        {
            if(this.ComplexSteps == null) {

                this.ComplexSteps = new ComplexRecoverySteps();
                this.ComplexSteps.ApplyExploratoryFieldSpec(ec.NewChild("complexSteps"));

            } else {

                this.ComplexSteps.ApplyExploratoryFieldSpec(ec.NewChild("complexSteps"));

            }
        }
        else if (this.ComplexSteps != null && ec.Excludes("complexSteps",false))
        {
            this.ComplexSteps = null;
        }
        //      C# -> RecoverySteps? SimpleSteps
        // GraphQL -> simpleSteps: RecoverySteps (type)
        if (ec.Includes("simpleSteps",false))
        {
            if(this.SimpleSteps == null) {

                this.SimpleSteps = new RecoverySteps();
                this.SimpleSteps.ApplyExploratoryFieldSpec(ec.NewChild("simpleSteps"));

            } else {

                this.SimpleSteps.ApplyExploratoryFieldSpec(ec.NewChild("simpleSteps"));

            }
        }
        else if (this.SimpleSteps != null && ec.Excludes("simpleSteps",false))
        {
            this.SimpleSteps = null;
        }
    }


    #endregion

    } // class StepsOneof
    
    #endregion

    public static class ListStepsOneofExtensions
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
            this List<StepsOneof> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<StepsOneof> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<StepsOneof> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StepsOneof());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<StepsOneof> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace RubrikSecurityCloud.Types
{
    public abstract class BaseType : IFieldSpec
    {
       // Composite field spec support:
        // _next is the pointer to next object in chain.
        // Used for building up a chain of objects
        // to represent a "composite field spec".
        internal BaseType? _next = null;
        public BaseType? Next() => _next;
        public void SetNext(BaseType? next) => _next = next;
        public bool IsComposite() => _next != null;
        public int CompositeLength()
        {
            int len = 1;
            BaseType? next = _next;
            while (next != null)
            {
                len++;
                next = next._next;
            }
            return len;
        }

        // IFieldSpec interface:
        public abstract string AsFieldSpec(FieldSpecConfig? conf = null);

        public virtual List<string> SelectedFields()
        {
            return StringUtils.FieldSpecStringToList(
                this.AsFieldSpec(new FieldSpecConfig { Flat = true }));
                    
        }

        public virtual List<string> AllFields()
        {
            return StringUtils.FlattenFieldToFieldSpecList(
                ReflectionUtils.FlattenFieldFull(this.GetType().FullName));
        }

        public List<string> UnselectedFields()
        {
            return StringUtils.BuildUnselectedList(
                this.AllFields(), this.SelectedFields());
        }


        public abstract void ApplyExploratoryFieldSpec(ExplorationContext ec);
        public void SelectForRetrieval()
        {
            this.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
        // Returns the name of the type as it would appear in a GraphQL schema.
        // Should be overridden if the GraphQL type name is different from 
        // the C# class name.
        public virtual string GetGqlTypeName()
        {
            return this.GetType().Name;
        }
    }

    public static class ListBaseTypeExtensions
    {
        public static string AsFieldSpec(this List<BaseType> list,
                                         FieldSpecConfig? conf = null)
        {
            conf = (conf == null) ? new FieldSpecConfig() : conf;
            string ind = conf.IndentStr();
            StringBuilder sb = new StringBuilder();
            foreach (BaseType item in list)
            {
                string fs = item.AsFieldSpec(conf.Child(ignoreComposition:true));
                if (conf.Flat)
                {
                    sb.Append(fs);
                }
                else
                {
                    sb.Append(ind + " ... on " + item.GetType().Name + " {\n" + fs + ind + "}\n");
                }
            }
            return sb.ToString();
        }

        public static List<string> SelectedFields(this List<BaseType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }

        // public static List<string> AllFields(this List<BaseType> list)
        // {
        //     return list.SelectMany(item => item.AllFields()).ToList()
        //         .Distinct().OrderBy(s => s).ToList();
        // }

        // public static List<string> UnselectedFields(this List<BaseType> list)
        // {
        //     return StringUtils.BuildUnselectedList(
        //         list.AllFields(), list.SelectedFields());
        // }

        public static void ApplyExploratoryFieldSpec(
            this List<BaseType> list,
            ExplorationContext ec)
        {
            foreach (BaseType item in list)
            {
                item.ApplyExploratoryFieldSpec(ec);
            }
        }

        public static void SelectForRetrieval(this List<BaseType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }
}

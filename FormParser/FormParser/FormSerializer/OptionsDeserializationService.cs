using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;

namespace FormParser
{
    public class OptionsDeserializationService
    {
        public static IDescriptionAdapter Adapter { get; set; }

        public OptionsDeserializationService(IDescriptionAdapter adapter)
        {
            Adapter = adapter;
        }

        public static readonly Dictionary<string, PropertyDecoder> OptionsDecodeActionsContainer =
            new Dictionary<string, PropertyDecoder>
            {
                {"", PropertyDecodeAction },
                {"Int32", IntTypeDecoder },
                {"Int64", LongTypeDecoder },
                {"Boolean", BoolTypeDecoder },
                {"Double", DoubleTypeDecoder },
                {"String", StringTypeDecoder }
            };

        public static readonly Dictionary<string, PropertyDecoder> ExtensionsTypesDecoders =
            new Dictionary<string, PropertyDecoder>();

        public void DecodeObject(object description, object target)
        {
            Adapter.ReadProperties(description, target, OptionsDecodeActionsContainer);
        }

        #region Decoders

        private static void PropertyDecodeAction(object description, object target, string propertyName)
        {
            var propertyInfo = target.GetType().GetProperty(propertyName);
            
            Debug.Assert(propertyInfo != null);

            var propType = propertyInfo.PropertyType;
            if (OptionsDecodeActionsContainer.ContainsKey(propType.Name))
            {
                OptionsDecodeActionsContainer[propType.Name](description, target, propertyName);
            }
            else if (propType.IsEnum)
            {
                EnumTypeDecoder(description, target, propertyName);
            }
            else if (ExtensionsTypesDecoders.ContainsKey(propType.Name))
            {
                ExtensionsTypesDecoders[propType.Name](description, target, propertyName);
            }
            else
            {
                ObjectTypeDecoder(description, target, propertyName);
            }
        }

        private static void ObjectTypeDecoder(object description, object target, string propertyName)
        {
            var objectProperty = target.GetType().GetProperty(propertyName);

            Debug.Assert(objectProperty != null);

            var objPropValue = objectProperty.GetValue(target, null);
            if (objPropValue == null) return;

            Adapter.ReadProperties(description, objectProperty.GetValue(target, null), OptionsDecodeActionsContainer);
        }

        private static void EnumTypeDecoder(object description, object target, string propertyName)
        {
            var property = target.GetType().GetProperty(propertyName);

            Debug.Assert(property != null);

            if (property.GetSetMethod() == null)
                return;

            property.SetValue(target, Enum.Parse(property.PropertyType, Adapter.GetStringProperty(description, propertyName)), null);
        }

        private static void StringTypeDecoder(object description, object target, string propertyName)
        {
            var property = target.GetType().GetProperty(propertyName);

            Debug.Assert(property != null);

            if (property.GetSetMethod() == null)
                return;

            property.SetValue(target, Adapter.GetStringProperty(description, propertyName), null);
        }

        private static void BoolTypeDecoder(object description, object target, string propertyName)
        {
            var property = target.GetType().GetProperty(propertyName);

            Debug.Assert(property != null);

            if (property.GetSetMethod() == null)
                return;

            property.SetValue(target, Adapter.GetBoolProperty(description, propertyName), null);
        }

        private static void DoubleTypeDecoder(object description, object target, string propertyName)
        {
            var property = target.GetType().GetProperty(propertyName);

            Debug.Assert(property != null);

            if (property.GetSetMethod() == null)
                return;

            property.SetValue(target, Adapter.GetDoubleProperty(description, propertyName), null);
        }

        private static void IntTypeDecoder(object description, object target, string propertyName)
        {
            var property = target.GetType().GetProperty(propertyName);

            Debug.Assert(property != null);

            if (property.GetSetMethod() == null)
                return;

            property.SetValue(target, Adapter.GetIntProperty(description, propertyName), null);
        }

        private static void LongTypeDecoder(object description, object target, string propertyName)
        {
            var property = target.GetType().GetProperty(propertyName);

            Debug.Assert(property != null);

            if (property.GetSetMethod() == null)
                return;

            property.SetValue(target, Adapter.GetLongProperty(description, propertyName), null);
        }

        #endregion

    }
}

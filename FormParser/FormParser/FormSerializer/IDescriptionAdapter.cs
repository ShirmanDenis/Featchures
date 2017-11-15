using System.Collections;
using System.Collections.Generic;

namespace FormParser
{
    public delegate void PropertyDecoder(object description, object target, string propertyName);

    public interface IDescriptionAdapter
    {
        string GetObjectClassName(object description);
        string GetObjectValue(object description);
        int? GetIntProperty(object description, string propertyName);
        long? GetLongProperty(object description, string propertyName);
        double? GetDoubleProperty(object description, string propertyName);
        string GetStringProperty(object description, string propertyName);
        T GetEnumProperty<T>(object description, string propertyName);
        bool? GetBoolProperty(object description, string propertyName);
        void ReadProperties(object description, object target, Dictionary<string, PropertyDecoder> propDecoders);
    }
}

namespace FormParser
{
    public delegate void PropertyEncoder(object parentHandle, object target, string objectName);

    public interface IDescriptionBuilder
    {
        object BeginObject(string name);
        void EndObject(object objectHandle);

        void WriteProperty(object parentHandle, string name, string value);

        object BeginObjectProperty(object parentHandle, string name, string value = "");
        void EndObjectProperty(object objectPropertyHandle);

        object BeginArrayProperty(object parentHandle, string name);
        void EndArrayProperty(object arrayPropertyHandle);

        object BeginArrayObjectItem(object parentHandle, string name);
        void EndArrayObjectItem(object itemHandle);
    }
}

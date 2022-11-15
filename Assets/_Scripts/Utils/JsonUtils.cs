namespace ClicheSurvivors.Utils
{
    using System.IO;
    using Newtonsoft.Json;
    using UnityEngine;

    public static class JsonUtils
    {
        public static void ToJsonFile<T>(T obj, string outPath)
        {
            try
            {
                var serializer = new JsonSerializer();

                using var sw = new StreamWriter(outPath);
                using var writer = new JsonTextWriter(sw);
                serializer.Serialize(writer, obj);
            }
            catch (JsonSerializationException e)
            {
                Debug.LogError($"Failed to serialize object: {obj} due to the following error:\n{e.Message}");
                throw;
            }
        }

        public static T FromJsonFile<T>(string jsonFilePath)
        {
            try
            {
                var serializer = new JsonSerializer();

                using var sr = new StreamReader(jsonFilePath);
                using var reader = new JsonTextReader(sr);
                return serializer.Deserialize<T>(reader);
            }
            catch (JsonSerializationException e)
            {
                Debug.LogError($"Failed to de-serialize object from path: {jsonFilePath} due to the following error:\n{e.Message}");
                throw;
            }
        }
    }
}

using Newtonsoft.Json;

namespace Services.Helpers
{
    public static class FileReader
    {
        public static T ReadFile<T>(string path)
        {
            using var streamReader = new StreamReader(path);
            return JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
        }
    }
}
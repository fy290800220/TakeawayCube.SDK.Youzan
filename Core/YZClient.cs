using System.Collections.Generic;

namespace YouZanSdkNetCore.Core
{
    public interface YZClient
    {
        string Invoke(string apiName, string version, string method, IDictionary<string, object> apiParams, List<KeyValuePair<string, string>> files);
    }
}

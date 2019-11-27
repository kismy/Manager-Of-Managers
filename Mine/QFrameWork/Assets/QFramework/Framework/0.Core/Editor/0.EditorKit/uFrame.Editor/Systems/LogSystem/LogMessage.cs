using System.Collections.Generic;
using Invert.Data;
using QFramework;
using QFramework.Json;

namespace QFramework.GraphDesigner.Unity.WindowsPlugin
{
    public class LogMessage : IMessage, IDataRecord
    {

        [JsonProperty]
        public string Identifier { get; set; }
        [JsonProperty]
        public MessageType MessageType { get; set; }
        [JsonProperty]
        public string Message { get; set; }
        
        public IRepository Repository { get; set; }
        public bool Changed { get; set; }
        public IEnumerable<string> ForeignKeys {
            get { yield break; }
        }
    }


}
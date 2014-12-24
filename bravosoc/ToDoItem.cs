using System;
using Newtonsoft.Json;

namespace bravosoc
{
	public class ToDoItem
	{
		public string Id { get; set; }

		[JsonProperty(PropertyName = "text")]
		public string Text { get; set; }
        [JsonProperty(PropertyName = "facebookname")]
        public string FaceBookName { get; set; }
        [JsonProperty(PropertyName = "twitterhandle")]
        public string TwitterHandle { get; set; }
        [JsonProperty(PropertyName = "instagramname")]
        public string InstagramName { get; set; }
        [JsonProperty(PropertyName = "mobilephone")]
        public string MobilePhone { get; set; }
        [JsonProperty(PropertyName = "emailaddress")]
        public string EmailAddress { get; set; }
		[JsonProperty(PropertyName = "complete")]
		public bool Complete { get; set; }
        [JsonProperty(PropertyName = "remove")]
        public bool Remove { get; set; }
	}
}


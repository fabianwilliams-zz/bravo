using Microsoft.WindowsAzure.Mobile.Service;

namespace bravosocService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }
        public string FaceBookName { get; set; }
        public string TwitterHandle { get; set; }
        public string InstagramName { get; set; }
        public string MobilePhone { get; set; }
        public string EmailAddress { get; set; }
        public bool Complete { get; set; }
        public bool Remove { get; set; }
    }
}
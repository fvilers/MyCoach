
namespace MyCoach.Business.Domain.Model
{
    public class Image : Entity<Image>
    {
        public byte[] Content { get; set; }
        public string ContentType { get; set; }
    }
}

namespace Support.WebApi.Models
{
    public class GetProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}

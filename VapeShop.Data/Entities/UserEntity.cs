namespace VapeShop.Data.Entities
{
	public class UserEntity
	{
		public long Id { get; set; }
		public string FirstName {  get; set; } = string.Empty;
		public string Name { get; set; } = string.Empty;
		public string LastName {  get; set; } = string.Empty;
		public string Phone { get; set; } = string.Empty;
		public DateTime DateBithDay {  get; set; }
		public DateTime DateReg {  get; set; }
	}
}

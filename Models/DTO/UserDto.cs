namespace WebApplication120240122.Models.DTO
{
	public class UserDto
	{
		//DTO是Data Transfer Object的縮寫，中文為資料傳輸物件
		public string? Name { get; set; }
		public int Age { get; set; } = 29;
		public string? Email { get; set; }

		public IFormFile? Avatar { get; set; }

	}
}

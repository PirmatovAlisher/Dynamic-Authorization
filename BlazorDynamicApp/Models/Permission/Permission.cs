namespace BlazorDynamicApp.Models.Permission
{
	public class Permission
	{
		public int Id { get; set; }
		public string Name { get; set; } // e.g., "CanEdit", "CanDelete"
		public ResourceType Resource { get; set; } // Enum for Resource
	}
}

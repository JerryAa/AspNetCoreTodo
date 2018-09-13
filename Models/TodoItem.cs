using System; 
using System.ComponentModel.DateAnnotations;

namespace AspNetCoreTodo.Models 
{ 
	public class TodoItem
	{ 
		public Guid id { get; set; } 

		public bool IsDone {get; set; } 

		[Required] 
		public string Title {get; set; } 

		public DateTimeOffset? DueAt {get; set;} 

	} 

} 

using System;
using System.ComponentModel.DataAnnotations;
namespace Crud.Models
{
	public class Usuarios
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[StringLength(100)]
		[Display(Name = "Nombre")]
		public string Nombre { get; set; }

		[Required]
		[StringLength(100)]
		[Display(Name = "Correo")]
		public string Correo { get; set;}
		

		[Required]
		[StringLength(100)]
		[Display(Name = "Numero")]
		public string Numero { get; set;}
		
	}
}

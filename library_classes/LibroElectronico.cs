using System;

namespace app1_Classes
{
	/// <summary>
	/// Libro electronico.
	/// </summary>
	public class LibroElectronico : Libro
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="app1_Classes.LibroElectronico"/> class.
		/// </summary>
		public LibroElectronico ()
		{			
		}

		/// <summary>
		/// What this instance.
		/// </summary>
		public override string What(){
			return "Soy un libro electrónico";
		}

		/// <summary>
		/// Add this instance to BD
		/// </summary>
		public override int Add(){
			try
			{
				//Añade el objeto a la tabla Libro de la BD
				Random rnd = new Random();
				return rnd.Next(1,1000);
			}
			catch{
				return 0;
			}
		}
	}
}


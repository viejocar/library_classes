using System;

namespace app1_Classes
{	
	/// <summary>
	/// Libro.
	/// </summary>
	public class Libro
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="app1_Classes.Libro"/> class.
		/// </summary>
		public Libro ()
		{
		}

		private int _id = 0;

		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public int Id() {
			return _id;
		}

		/// <summary>
		/// Título del libro
		/// </summary>
		/// <value>The title.</value>
		public string Title { get; set;}

		/// <summary>
		/// Autor del libro
		/// </summary>
		/// <value>The author.</value>
		public string Author { get; set;}

		/// <summary>
		/// Gets or sets the price.
		/// </summary>
		/// <value>The price.</value>
		public string Price { get; set;}

		/// <summary>
		/// Gets or sets the image.
		/// </summary>
		/// <value>The image.</value>
		public int Image { get; set;}

		/// <summary>
		/// Número de páginas del libro
		/// </summary>
		/// <value>The pages.</value>
		public int Pages { get; set;}

		/// <summary>
		/// Adds the pages.
		/// </summary>
		/// <returns><c>true</c>, if pages was added, <c>false</c> otherwise.</returns>
		/// <param name="numPages">Number pages.</param>
		public int AddPages(int numPages){			
			Pages += numPages;
			return Pages;
		}

		/// <summary>
		/// Adds the author.
		/// </summary>
		/// <returns>The author.</returns>
		/// <param name="author">Author.</param>
		public string AddAuthor(string author) {
			Author += ", " + author;
			return Author;
		}

		/// <summary>
		/// What this instance.
		/// </summary>
		public virtual string What(){
			return "Soy un libro impreso.";
		}

		/// <summary>
		/// Add this instance to BD
		/// </summary>
		public virtual int Add(){
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


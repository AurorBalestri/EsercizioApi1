namespace EsercizioApi1
{
    public class Book
    {
        private string _author;
        private string _title;
        private int _barcode;

        public string Author { get { return _author; } set { _author = value; } }
        public string Title { get { return _title; } set { _title = value; } }

        public int Barcode { get { return _barcode; } set { _barcode = value; } }


        public Book()
        {

        }
        public Book(string autore, string title, int barcode)
        {
            Author = autore;
            Title = title;
            Barcode = barcode;
        }
    }
}

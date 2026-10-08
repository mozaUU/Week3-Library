namespace Library
{
    class Book
    {
        private string title; // private field
        private string author;// private field
        private string isbn; // private field

        // Title property allows access
        // to the title private field
        public string Title
        {
            get { return title; }  // get method
            set { title = value; } // set method
        }
        public string Author
        {
            get { return author; }
            set
            {
                // Checks if any character in the incoming string is a digit
                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
        }

        public string ISBN
        {
            get { return isbn; }
            set
            {
                // Checks that the incoming string is not blank
                if (value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
        }
    }
}
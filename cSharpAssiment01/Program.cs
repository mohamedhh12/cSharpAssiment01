namespace cSharpAssiment01
{
    class Book { 
        public string Title { get; set; }
        public int Pages {  get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task01
            Book book = new Book
            {
                Title = "C# Fundamentals",
                Pages = 464 // not "464" => compile time error "we can not store string in a variable of type int  
            };

            // Store it in a variable of type object
            object obj = book;

            // Print the object
            Console.WriteLine(obj);
            #endregion
            #region Task02
            // Call object methods
            Console.WriteLine("To string: " + book.ToString());
            Console.WriteLine("Is equal ? => : " + book.Equals(book));
            Console.WriteLine("Hash code is : " + book.GetHashCode());
            Console.WriteLine(book.GetType());
            #endregion
            #region Task03
            try
            {
                int zero = 0;
                int result = 10 /zero ; // exeption : dividing by zero 
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion
            #region Task04
            book.Pages = 300;
            double PagesNum = book.Pages;// implist casting 
            Console.WriteLine("The new value of pages is => "+ PagesNum);
            #endregion
            #region Task04
            double price = 49.99;
            int nuwPrice = (int)price;// explicit casting
            #endregion
            #region Task05
            String BageText = "464";
            int num = Convert.ToInt32(BageText);
            Console.WriteLine(num);
            #endregion
            #region Task06
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);
            string badText = "abc";
      
            if (int.TryParse(badText, out int number))
            {
                Console.WriteLine(number);// in case of parsing 
            }
            else
            {
                Console.WriteLine("Invalid number");// in case of can't parse 
            }
            #endregion
            #region Task07 
            int P_Num = 464;
            string T_Num = P_Num.ToString(); 
            Console.WriteLine(T_Num);
            Console.WriteLine(T_Num.GetType());// To get the new type 
            #endregion
            #region Task08
            /*
            Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            */
            int copies = 100;
            object objCopies = copies; // Boxing 
            int newCopies = (int)copies;// unBoxing 
            Console.WriteLine(copies);
            Console.WriteLine(newCopies);
            #endregion
            #region Task09
            
            int? yearNum = null;

            // Check if it has a value
            Console.WriteLine(yearNum.HasValue);
            yearNum = 2023;

            Console.WriteLine(yearNum.Value);
            #endregion
            #region Task10

            string? reviewer = null;
            Console.WriteLine(reviewer == null); // checking
            #endregion
            #region Task11
            Book? book01 = null;

            // Safely access the Title property
            Console.WriteLine(book?.Title);
            #endregion
            #region Task12
            string? title = null;

            string output = title ?? "Untitled";
            Console.WriteLine(output);

            // Use ??= to assign a value only if title is null
            title ??= "Untitled";

            // Print title after assignment
            Console.WriteLine(title);
            #endregion
            #region Task13
            string? name = "Ahmed";
            string conName = name!;

            Console.WriteLine(conName);
            #endregion
        }
    }
    }


using System;

namespace Practise_CS
{
   public class OldLibrary
   {
      public static void Book()
      {
         string book = Console.ReadLine();
         int quantity = Convert.ToInt32(Console.ReadLine());
         string[] books = new string[quantity];
         int counter = 0;
         bool bl = false;
         for (int i = 0; i < books.Length; i++, counter++)
         {
            books[i] = Console.ReadLine();
            if (books[i]==book)
            {
               Console.WriteLine("вы проверили книг: {0}, и нашли книгу",i);
               bl = true;
               break;
            }
         }

         if (bl==false)
         {
            Console.WriteLine("вы проверили книг: {0}, и не нашли книгу", counter);
         }
      }
       
                
        
   }
}
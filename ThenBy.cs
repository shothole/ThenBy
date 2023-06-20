string[] words = { "the", "quick", "brown", "fox", "jumps" };  

  

IEnumerable<string> query = from word in words  

                            orderby word.Length, word.Substring(0, 1)  

                            select word;  

  

foreach (string str in query)  

    Console.WriteLine(str);  

  

/* This code produces the following output:  

  

    fox  

    the  

    brown  

    jumps  

    quick  

*/

  string[] arraytocheck = { "a", "32", "435", "912123", "ok" };
  Console.WriteLine("Дано: " + String.Join(",", arraytocheck));
  
  arraytocheck = arraytocheck.Where(element => element.Length <= 3).ToArray();
  Console.WriteLine("Выдано: " + String.Join(",", arraytocheck));
 

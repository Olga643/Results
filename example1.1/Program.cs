  string[] arrayToCheck = { "a", "32", "435", "912123", "ok" };
  Console.WriteLine("Дано: " + String.Join(",", arrayToCheck));
  
  arrayToCheck = arrayToCheck.Where(element => element.Length <= 3).ToArray();
  Console.WriteLine("Выдано: " + String.Join(",", arrayToCheck));
 

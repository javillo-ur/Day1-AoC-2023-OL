Console.WriteLine(File.ReadAllLines("..\\..\\..\\input.txt")
    .Select(j => j.Replace("one", "o1e").Replace("two", "t2o").Replace("three", "t3ree").Replace("four","f4ur").Replace("five", "f5ve").Replace("six", "s6x").Replace("seven", "s7ven").Replace("eight", "e8ght").Replace("nine", "n9ne"))
    .Sum(j => int.Parse(j.First(c => char.IsDigit(c)) + "") * 10 + int.Parse(j.Last(c => char.IsDigit(c)) + "")));

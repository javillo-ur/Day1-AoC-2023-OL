Console.WriteLine(File.ReadAllLines("input.txt")
    .Sum(j => int.Parse(j.First(c => char.IsDigit(c)) + "") * 10 + int.Parse(j.Last(c => char.IsDigit(c)) + "")));
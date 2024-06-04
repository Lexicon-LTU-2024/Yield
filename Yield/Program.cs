


var numbers = GetNumbers();
IEnumerator<int> enumerator = numbers.GetEnumerator();

while (enumerator.MoveNext())
{
	int item = enumerator.Current;
    Console.WriteLine(item);
}


foreach (var number in GetNumbers())
{
    Console.WriteLine(number);
}


IEnumerable<int> GetNumbers()
{
    var num = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

	foreach (var number in num)
	{
		yield return number;
	}
}
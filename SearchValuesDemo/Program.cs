using System.Buffers;

var searchValues = SearchValues.Create(new[] { 'a', 'e', 'i', 'o', 'u' });

var vowelResult = ContainsVowel("The quick brown fox jumps over the lazy dog");

Console.WriteLine(vowelResult);

bool ContainsVowel(ReadOnlySpan<char> text) => text.ContainsAny(searchValues);

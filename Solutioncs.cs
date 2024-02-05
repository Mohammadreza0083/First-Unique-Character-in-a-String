namespace First_Unique_Character_in_a_String
{
    internal class Solutioncs : ISolution
    {
        public int FirstUniqChar(string input)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (charCount[input[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

namespace C_Task3_Arrays_
{
    public class Task1 : ITask
    {
        public void Execute()
        {
            var positiveNumbers = Methods.GetPositiveArrayFromKeyboard();
            VerifyAscArray(positiveNumbers);
        }
        private static void VerifyAscArray(int[] positiveNumbers)
        {
            for (int i = 0; i < positiveNumbers.Length - 1; i++)
            {
                if (positiveNumbers[i] >= positiveNumbers[i + 1])
                {
                    Console.WriteLine("No");

                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}

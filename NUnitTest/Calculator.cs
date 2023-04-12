namespace NUnitTest
{
    public class Calculator
    {
        private int CurrentNumber { get; set; }

        public void Add(int number)
        {
            CurrentNumber += number;
        }
        public int Sum()
        {
            int temp = CurrentNumber;
            CurrentNumber = 0;
            return temp;

        }
    }
}

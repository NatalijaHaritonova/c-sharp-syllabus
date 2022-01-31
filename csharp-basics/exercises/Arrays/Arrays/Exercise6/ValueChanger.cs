namespace Exercise6
{
    public class ValueChanger
    {
        public int[] arr { get; } = new int[10];
        public int[] arr2 { get; } = new int[10];
        private Random rd = new Random();
        public ValueChanger()
        {
        }

        public void AddValues()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(1, 100);
            }
            arr.CopyTo(arr2, 0);
        }

        public void ChangeValues(int value, int position)
        {
            arr.SetValue(value, position);
        }

        public string ShowAllArr()
        {
            return ShowArr(arr) + ShowArr(arr2);
        }

        public static string ShowArr(int[] arr)
        {
            var result = "";
            foreach (int i in arr)
            {
                result += $"{i} ";
            }
            return result + "\n";
        }
    }
}

namespace MyHelperClassLibrary
{
    public static class Helper
    {
        public static string CreateBookCode(string bookName, int number)
        {
            return bookName.Substring(0,2).ToUpper() + number;
        }
        public static void Add<T>(T item, ref T[] arr)
        {
            Array.Resize(ref arr,arr.Length + 1);
            arr[^1] = item;

        }
        public static void Remove<T>(T searched, ref T[] arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if (!item.Equals(searched))
                {
                    count++;
                }
            }
            T[] newArr = new T[count];
            int index = 0;
            foreach (var item in arr)
            {
                if (!item.Equals(searched))
                {
                    newArr[index++] = item;
                }
            }
            arr = newArr;
        }
    }
}

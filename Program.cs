namespace Assignment6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 3;         
            int[,] array = { { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 }};                                             
            for (int i = 0; i < num /2; i++)
            {
                for (int j = 0; j < num -1-i; j++)
                {                 
                    int temp = array[i, j];                 
                    array[i, j] = array[num-1-j, i];                 
                    array[num - 1 - j, i] = array[num-1-i, num-1-j];                  
                    array[num - 1 - i, num - 1 - j] = array[j, num - 1 - i];                 
                    array[j, num-1-i] = temp; 
                }               
            }           
            Print(array);
        }      
        static void Print(int[,] array)
        {
            int num = 3; //less or = 3.
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                    Console.Write(array[i, j] + " ");
                Console.WriteLine();
            }
        }
    }


}



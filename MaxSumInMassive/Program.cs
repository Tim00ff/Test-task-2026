class Program
{
    public static int SubSum(int[] mas){

    int maxSum = 0;
    int partialSum = 0;
        foreach(int el in  mas){
        partialSum += el;
        maxSum = Math.Max(maxSum, partialSum);
        if (partialSum < 0){partialSum = 0;}
    }
    return maxSum;
}

    
    static void Main()
    {

        int[] mas = [1,2,-10,2, 5,-3,20,-3];
        Console.WriteLine(SubSum(mas));

}

    }



class Euler {
    public static void Main() {
        Console.WriteLine(EvenFibonacciNumbers());
    }

    public static int MultiplesOf3or5() {
        int sum = 0;
        
        for (int i = 0; i < 1000; i++) {
            if (i % 3 == 0 || i % 5 == 0) {
                sum += i;
            }
        }
        return sum;
    }

    public static int EvenFibonacciNumbers() {

        int a = 1, b = 2, sum = 0;
        while (b < 4000000) {
            if (b % 2 == 0) {
                sum += b;
            }
            int nextnum = a + b;
            a = b;
            b = nextnum;
        }
        return sum;
    }

}
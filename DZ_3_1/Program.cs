//Массивы и функции программирования

Console.WriteLine("Задача №19");
bool isPalindrome(int x) {
    int div = 1;
    while (x / div >= 10) {
        div *= 10;
    }
    Console.WriteLine(div);
    while (x != 0) {
        int l = x / div;
        int r = x % 10;
        if (l != r) { 
            Console.WriteLine("Not Palindrom");
            return false;
        }
        x = (x % div) / 10;
        div /= 100;
    }
    Console.WriteLine("Palindrom");
    return true;
}

isPalindrome(14212);
isPalindrome(12821);
isPalindrome(23432);
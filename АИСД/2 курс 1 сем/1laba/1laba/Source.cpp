#include <iostream>
using namespace std;

void hanoi(int i, int k, int n)
{
    if (n == 1) {
        cout << "Move disk 1 from pin " << i << " to pin " << k << ".\n";
    }
    else {
        int tmp = 6 - i - k; 			
        hanoi(i, tmp, n - 1);
        cout << "Move disk " << n << " from pin " << i << " to pin " << k << ".\n";
        hanoi(tmp, k, n - 1);
    }
}


int main()
{
    setlocale(LC_ALL, "RU");
    int n, i, k;
    do {
        std::cout << " ¬ведите первый стержень: ";
        std::cin >> i;
    } while (i <= 0);
    do {
        std::cout << " ¬ведите конечный стержень: ";
        std::cin >> k;
    } while (k <= 0);
    do {
        std::cout << " ¬ведите кол-во дисков: " << std::endl;
        std::cin >> n;
    } while (n <= 0);
    hanoi(i, k, n);
    return 0;
}
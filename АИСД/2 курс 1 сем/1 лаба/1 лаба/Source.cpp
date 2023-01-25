#include <iostream>
using namespace std;

void hanoi(int i, int k, int n)
{
    if (n != 0) {
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
    std::cout << " ¬ведите первый стержень: ";
    std::cin >> i;
    std::cout << " ¬ведите конечный стержень: ";
    std::cin >> k;
    std::cout << " ¬ведите кол-во дисков: " << std::endl;
    std::cin >> n;
    hanoi(i, k, n);
    return 0;
}
#include <iostream>
#include <cmath> // fmod için gerekli

int main() {
    using namespace std;

    double sayi1 = 0.0;
    double sayi2 = 0.0;
    char islem = ' ';

    cout << "Please enter the first number: ";
    if (!(cin >> sayi1)) { // 0 yerine değişkene aktarıyoruz
        cout << "Please enter a valid number!\n";
        return 1;
    }

    cout << "Please enter the operation (+, -, *, /, %): ";
    cin >> islem;

    cout << "Please enter the second number: ";
    if (!(cin >> sayi2)) {
        cout << "Please enter a valid number!\n";
        return 1;
    }

    cout << "\nResult: ";

    switch (islem) {
        case '+':
            cout << sayi1 + sayi2 << '\n';
            break;
        case '-':
            cout << sayi1 - sayi2 << '\n';
            break;
        case '%' :
          if (sayi2 == 0) { // 0'a bölünme kontrolü tam burada yapılır
                cout << "Error: A number cannot be divided by zero!\n";
            } else {
            cout << fmod(sayi1, sayi2) << '\n';
            }
            break;
        case '*':
            cout << sayi1 * sayi2 << '\n';
            break;
        case '/':
            if (sayi2 == 0) { // 0'a bölünme kontrolü tam burada yapılır
                cout << "Error: A number cannot be divided by zero!\n";
            } else {
                cout << sayi1 / sayi2 << '\n';
            }
            break;
        default:
            cout << "Error: Invalid operation!\n";
            break;
    }

    return 0;
}

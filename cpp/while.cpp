#include <iostream>
#include <cmath>

int main() {
    using namespace std;

    double x = 0.0;
    double y = 0.0;
    double sonuc = 0.0;
    char islem = ' ';
    char devam = 'e';

    cout << "Birinci sayiyi girin: ";
    if (!(cin >> x)) {
        cout << "Gecerli bir sayi girmediniz!\n";
        return 1;
    }

    do {
        bool gecerli = true;

        cout << "Islemi girin (+, -, *, /, %): ";
        cin >> islem;
        if (islem != '+' && islem != '-' && islem != '*' && islem != '/' && islem != '%') {
            cout << "Hata: Gecersiz bir islem operatoru girdiniz!\n";
            continue;
        }

        cout << "Ikinci sayiyi girin: ";
        if (!(cin >> y)) {
            cout << "Gecerli bir sayi girmediniz!\n";
            return 1;
        }

        switch (islem) {
            case '+':
                sonuc = x + y;
                break;
            case '-':
                sonuc = x - y;
                break;
            case '*':
                sonuc = x * y;
                break;
            case '/':
                if (y == 0) {
                    cout << "Hata: Bir sayi 0'a bolunemez!\n";
                    gecerli = false;
                } else {
                    sonuc = x / y;
                }
                break;
            case '%':
                if (y == 0) {
                    cout << "Hata: Bir sayi 0'a bolunemez!\n";
                    gecerli = false;
                } else {
                    sonuc = fmod(x, y);
                }
                break;
       }

        if (gecerli) {
            cout << "Sonuc: " << sonuc << '\n';
            x = sonuc;
        }

        cout << "Devam? (e/h): ";
        cin >> devam;

    } while (devam == 'e');

    return 0;
}

#include <iostream>

int main() {
    double bakiye = 1000.0;
    double cekilecekTutar;
    double yatirilmakistenenTutar; // int yerine double yapıldı
    int islem;

    do { // 1. Parantez BURAYA eklendi
        std::cout << "\nWhich operation do you want to perform? (1: Withdraw Money, 2: Deposit Money, 3: Check Balance, 4: Exit): ";
        std::cin >> islem;

        if (islem == 1) {
            std::cout << "Enter the amount to withdraw: ";
            std::cin >> cekilecekTutar;
            if (cekilecekTutar > 0 && cekilecekTutar <= bakiye) {
                bakiye -= cekilecekTutar;
                std::cout << "New balance: " << bakiye << "\n";
            } else {
                std::cout << "Invalid amount or insufficient balance.\n";
            }
        } else if (islem == 2) {
            std::cout << "Enter the amount to deposit: ";
            std::cin >> yatirilmakistenenTutar;
            if (yatirilmakistenenTutar > 0) {
                bakiye += yatirilmakistenenTutar;
                std::cout << "New balance: " << bakiye << "$" << "\n";
            } else {
                std::cout << "Invalid amount.\n";
            }
        } else if (islem == 3) {
            std::cout << "Current balance: " << bakiye << "$" << "\n";
        } else if (islem == 4) {
            std::cout << "Exiting...\n";
        } else {
            std::cout << "Invalid operation.\n";
        }

    } while (islem != 4); // 2. Kapanış parantezi ve mantıklı döngü şartı

    return 0;
}
#include "iostream"

int main(){
    int x;
    do{
        std::cout << "Please enter a positive number: ";
        std::cin >> x;
    }while(x <= 0);
std::cout << "You entered: " << x << "\n";
    return 0;
}
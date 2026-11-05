#include <iostream>

int main() {
  std::cout << "Adinizi girin: ";
  std::string ad;
  std::cin >> ad;

  int adu = ad.length();
  if (adu > 10) {
    std::cout << "adiniz cok uzun :O";
  } else if (adu < 5) {
    std::cout << "adiniz baya kisa";
  } else {
    std::cout << "adiniz tam olmasi gereken uzunlukta";
  }
  return 0;
};

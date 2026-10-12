#include <iostream>

int main() {
    int age;
    bool hasLicense;

    std::cout << "Enter age: ";
    std::cin >> age;
    std::cout << "Does the person have a license? (1 for yes, 0 for no): ";
    std::cin >> hasLicense;

    // Logical AND: Both conditions must be true
    if (age >= 18 && hasLicense) {
        std::cout << "Person can drive legally.\n";
    }

    // Logical OR: At least one condition must be true
    if (age < 18 || !hasLicense) {
        std::cout << "Person cannot drive legally.\n";
    }

    // Logical NOT: Inverts the condition
    if (!hasLicense) {
        std::cout << "No license found.\n";
    }

    return 0;
}   
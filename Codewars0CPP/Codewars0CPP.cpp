#include <iostream>
#include "Kata.h"

int main()
{
    std::cout << "Hello World!\n";
    //unsigned long result = Kata::findNextPower(1245678, 6);
    unsigned long result = Kata::findNextPower(4782969, 7);
    std::cout << "result == " << std::endl;
    std::cout << result << std::endl;

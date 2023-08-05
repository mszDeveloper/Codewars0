#pragma once
#include <cmath>
#include <iostream>

class Kata
{
public:
	//https://www.codewars.com/kata/56ba65c6a15703ac7e002075
	static unsigned long findNextPower(unsigned int val, unsigned int pow)
	{
		double near = std::pow(val, 1. / pow) + 0.0000001;
		double root = std::floor(near) + 1.;
		double result = std::pow(root, pow);
		return (unsigned long)result;
	}
	/**
	unsigned long findNextPower(const unsigned int val, const unsigned int pow) {
	return std::pow(std::ceil(std::pow(val + 1, 1. / pow)), pow);
}
	static unsigned long findNextPower1(unsigned int val, unsigned int pow)
	{
		double q = std::pow(val + 1, 1. / pow);
		double w = std::ceil(q);
		double e = std::pow(w, pow);
		return (unsigned long)e;
	}
	*/
















};


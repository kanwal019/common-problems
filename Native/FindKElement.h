#pragma once

#include <iostream>
#include <vector>
#include <string>
#include <stdlib.h>
#include <algorithm>

class FindKElement
{
public:
	static void DisplayResult();

private:
	static long FindLargest(vector<long> iVector, int iCount, int iPosition);
};

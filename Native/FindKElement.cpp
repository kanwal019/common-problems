#include "pch.h"
#include "FindKElement.h"

using namespace std;

void
FindKElement::DisplayResult() 
{
    int count;
    cin >> count;

    for (int i = 0; i < count; i++)
    {
        vector<long> iVector;
        int iCount;
        cin >> iCount;
        
        string arrayLine;
        cin >> arrayLine;

        char* cArrayLine = & arrayLine[0];
        char* token = strtok(cArrayLine, " ");

        while (token != NULL) 
        {
            iVector.push_back(strtol(token, nullptr, 10));
            token = strtok(NULL, " ");
        }

        int iPosition;
        cin >> iPosition;
        
        cout<<FindLargest(iVector, iCount, iPosition)<<endl;
    }
}

long 
FindKElement::FindLargest(vector<long> iVector, int iCount, int iPosition)
{
    int count = iCount;
    int position = static_cast<size_t>(position);

    for (int i = 0; i < count; i++)
    {
        for (int j = 0; j < count; j++)
        {
            if (i == j)
            {
                continue;
            }

            long diff = abs(iVector.at(i) - iVector.at(j));

            if (!(find(iVector.begin(), iVector.end(), diff) != iVector.end()))
            {
                iVector.push_back(diff);
                count++;
            }
        }

    }

    sort(iVector.begin(), iVector.end());

    if (position <= iVector.size())
    {
        return iVector.at(iVector.size() - iPosition);
    }

    return -1;
}

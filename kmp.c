#include<iostream>
using namespace std;

int strLength = 0;
int patternLength = 0;
int LPS[1000];

void makeLPS(string pattern) {
    for (int i = 0; i < pattern.length(); i++) {
        LPS[i] = 0;
    }
    int length = 0;
    int i = 1;
    while (i < pattern.length()) {
        if (pattern.at(i) == pattern.at(length)) {
            LPS[i] = length + 1;
            length += 1; 
            i += 1;
        } else {
            if (length != 0) {
                length = LPS[length - 1];
            } else {
                LPS[i] = 0;
                i += 1;
            }            
        }
    }
}

int main() {
    string txt = "";
    string pattern = "";
    cout << "enter the text" << endl;
    cin >> txt;
    cout << "enter the pattern" << endl;
    cin >> pattern;

    int i = 0;
    int j = 0;
    while (i < txt.length()) {
        if(txt.at(i) == pattern.at(j)) {
            i++;
            j++;
        } else {
            if (j != 0) 
                j = LPS[j-1];
            else
                i += 1;
        }
        if (j == pattern.length()) {
            cout << "Pattern matched at index :\t" << (i - j) << endl;
            j = LPS[j-1];
        }
    }
}
#include <iostream>
#include <string>
using namespace std;

string DIGITS = "0123456789ABCDEF";

// 2 -> 8/16
string fromBin(string num, int group) {
    int dot = num.find('.');
    string intPart, fracPart;

    if (dot == -1) {
        intPart = num;
        fracPart = "";
    }
    else {
        intPart = num.substr(0, dot);
        fracPart = num.substr(dot + 1);
    }

    // Дополняем целую часть нулями слева
    while (intPart.length() % group != 0)
        intPart = "0" + intPart;

    string result = "";
    for (int i = 0; i < intPart.length(); i += group) {
        string bits = intPart.substr(i, group);
        int val = 0;
        for (int j = 0; j < bits.length(); j++)
            val = val * 2 + (bits[j] - '0');
        result += DIGITS[val];
    }

    if (fracPart != "") {
        // Дополняем дробную часть нулями справа
        while (fracPart.length() % group != 0)
            fracPart = fracPart + "0";

        result += ".";
        for (int i = 0; i < fracPart.length(); i += group) {
            string bits = fracPart.substr(i, group);
            int val = 0;
            for (int j = 0; j < bits.length(); j++)
                val = val * 2 + (bits[j] - '0');
            result += DIGITS[val];
        }
    }
    return result;
}

// 8/16 -> 2
string toBin(string num, int bits) {
    int dot = num.find('.');
    string intPart, fracPart;

    if (dot == -1) {
        intPart = num;
        fracPart = "";
    }
    else {
        intPart = num.substr(0, dot);
        fracPart = num.substr(dot + 1);
    }

    string result = "";
    for (int i = 0; i < intPart.length(); i++) {
        char c = intPart[i];
        int val;
        if (c >= '0' && c <= '9') val = c - '0';
        else val = toupper(c) - 'A' + 10;

        for (int j = bits - 1; j >= 0; j--) {
            if ((val >> j) & 1) result += "1";
            else result += "0";
        }
    }

    // Убираем ведущие нули
    int pos = result.find('1');
    if (pos != -1) result = result.substr(pos);
    else result = "0";

    if (fracPart != "") {
        result += ".";
        for (int i = 0; i < fracPart.length(); i++) {
            char c = fracPart[i];
            int val;
            if (c >= '0' && c <= '9') val = c - '0';
            else val = toupper(c) - 'A' + 10;

            for (int j = bits - 1; j >= 0; j--) {
                if ((val >> j) & 1) result += "1";
                else result += "0";
            }
        }
    }
    return result;
}

// 10 -> любая система
string fromDec(double num, int base) {
    int intPart = num;
    double fracPart = num - intPart;

    string result;
    if (intPart == 0) result = "0";
    else result = "";

    while (intPart > 0) {
        result = DIGITS[intPart % base] + result;
        intPart = intPart / base;
    }

    if (fracPart > 0) {
        result += ".";
        for (int i = 0; i < 10; i++) {
            if (fracPart == 0) break;
            fracPart = fracPart * base;
            int digit = fracPart;
            result += DIGITS[digit];
            fracPart = fracPart - digit;
        }
    }
    return result;
}

int main() {
    setlocale(LC_ALL, "");

    cout << "1-10->любая 2-2->8 3-2->16 4-8->2 5-16->2\nВыбор: ";
    int choice;
    cin >> choice;

    if (choice == 1) {
        double num;
        int base;
        cout << "Число: ";
        cin >> num;
        cout << "Система: ";
        cin >> base;
        cout << fromDec(num, base);
    }
    else if (choice == 2) {
        string num;
        cout << "Двоичное: ";
        cin >> num;
        cout << fromBin(num, 3);
    }
    else if (choice == 3) {
        string num;
        cout << "Двоичное: ";
        cin >> num;
        cout << fromBin(num, 4);
    }
    else if (choice == 4) {
        string num;
        cout << "Восьмеричное: ";
        cin >> num;
        cout << toBin(num, 3);
    }
    else if (choice == 5) {
        string num;
        cout << "Шестнадцатеричное: ";
        cin >> num;
        cout << toBin(num, 4);
    }

    return 0;
}
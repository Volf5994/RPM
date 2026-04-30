#include <iostream>
#include <string>
#include <cmath>

using namespace std;

/**
 * Вычисляет диапазон допустимых значений для знакового целого числа.
 */
bool get_signed_range(int n_bytes, long long& min_val, long long& max_val) {
    if (n_bytes <= 0 || n_bytes > 8) {
        return false;
    }
    
    int total_bits = n_bytes * 8;
    
    // Вычисляем 2^(total_bits - 1)
    long long power_of_two = 1;
    for (int i = 0; i < total_bits - 1; i++) {
        power_of_two = power_of_two * 2;
    }
    
    min_val = -power_of_two;
    max_val = power_of_two - 1;
    return true;
}

/**
 * Вычисляет диапазон допустимых значений для беззнакового целого числа.
 */
bool get_unsigned_range(int n_bytes, unsigned long long& min_val, 
                        unsigned long long& max_val) {
    if (n_bytes <= 0 || n_bytes > 8) {
        return false;
    }
    
    int total_bits = n_bytes * 8;
    
    // Вычисляем 2^total_bits
    unsigned long long power_of_two = 1;
    for (int i = 0; i < total_bits; i++) {
        power_of_two = power_of_two * 2;
    }
    
    min_val = 0;
    max_val = power_of_two - 1;
    return true;
}

/**
 * Преобразует знаковое целое число в двоичную строку заданной разрядности.
 */
string signed_to_binary(long long number, int total_bits) {
    string binary(total_bits, '0');
    
    if (number >= 0) {
        for (int i = total_bits - 1; i >= 0; i--) {
            binary[i] = (number % 2 == 1) ? '1' : '0';
            number = number / 2;
        }
    } else {
        unsigned long long abs_num = -number;
        for (int i = total_bits - 1; i >= 0; i--) {
            binary[i] = (abs_num % 2 == 1) ? '1' : '0';
            abs_num = abs_num / 2;
        }
        
        for (int i = 0; i < total_bits; i++) {
            binary[i] = (binary[i] == '0') ? '1' : '0';
        }
        
        int carry = 1;
        for (int i = total_bits - 1; i >= 0; i--) {
            if (binary[i] == '0' && carry == 1) {
                binary[i] = '1';
                carry = 0;
            } else if (binary[i] == '1' && carry == 1) {
                binary[i] = '0';
                carry = 1;
            }
        }
    }
    
    return binary;
}

/**
 * Преобразует беззнаковое целое число в двоичную строку заданной разрядности.
 */
string unsigned_to_binary(unsigned long long number, int total_bits) {
    string binary(total_bits, '0');
    
    for (int i = total_bits - 1; i >= 0; i--) {
        binary[i] = (number % 2 == 1) ? '1' : '0';
        number = number / 2;
    }
    
    return binary;
}

int main() {
    setlocale(LC_ALL, "Russian");
    
    long long number;
    int n_bytes;
    int format_choice;
    
    cout << "=== Программа кодирования целых чисел ===" << endl;
    cout << "Введите целое число для кодирования: ";
    cin >> number;
    
    cout << "Введите количество байт памяти (1, 2, 4 или 8): ";
    cin >> n_bytes;
    
    cout << "Выберите формат кода:" << endl;
    cout << "  1 — знаковый (старший бит — знак)" << endl;
    cout << "  2 — беззнаковый (все биты — значение)" << endl;
    cout << "Ваш выбор: ";
    cin >> format_choice;
    
    int total_bits = n_bytes * 8;
    
    if (format_choice == 1) {
        long long min_val, max_val;
        
        if (!get_signed_range(n_bytes, min_val, max_val)) {
            cout << "Ошибка вычисления диапазона!" << endl;
            return 1;
        }
        
        cout << "\nДиапазон знаковых чисел для " << n_bytes << " байт: ["
             << min_val << ", " << max_val << "]" << endl;
        
        if (number < min_val || number > max_val) {
            cout << "ОШИБКА! Число " << number 
                 << " не может быть размещено в " << n_bytes 
                 << " байтах (знаковый формат)." << endl;
        } else {
            string binary = signed_to_binary(number, total_bits);
            cout << "Двоичный код числа " << number << " (" << n_bytes 
                 << " байт, знаковый): " << binary << endl;
            cout << "Старший бит (знак): " << binary[0] << endl;
            cout << "Биты значения:     " << binary.substr(1) << endl;
        }
        
    } else if (format_choice == 2) {
        unsigned long long min_val, max_val;
        
        if (!get_unsigned_range(n_bytes, min_val, max_val)) {
            cout << "Ошибка вычисления диапазона!" << endl;
            return 1;
        }
        
        cout << "\nДиапазон беззнаковых чисел для " << n_bytes << " байт: ["
             << min_val << ", " << max_val << "]" << endl;
        
        if (number < 0) {
            cout << "ОШИБКА! Отрицательное число " << number 
                 << " не может быть представлено в беззнаковом формате." << endl;
        } else if (static_cast<unsigned long long>(number) > max_val) {
            cout << "ОШИБКА! Число " << number 
                 << " не может быть размещено в " << n_bytes 
                 << " байтах (беззнаковый формат)." << endl;
        } else {
            string binary = unsigned_to_binary(
                static_cast<unsigned long long>(number), total_bits);
            cout << "Двоичный код числа " << number << " (" << n_bytes 
                 << " байт, беззнаковый): " << binary << endl;
            cout << "Все биты используются для хранения значения." << endl;
        }
        
    } else {
        cout << "Ошибка! Неверный выбор формата кода." << endl;
        return 1;
    }
    
    return 0;
}
# XOR
Gamma encryption
Шифрование методом гаммирования 

[RU]

В этом способе шифрование выполняется путем сложения символов исходного текста и ключа по модулю, равному числу букв в алфавите. Если в исходном алфавите, например, 33 символа, то сложение производится по модулю 33. Такой процесс сложения исходного текста и ключа называется в криптографии наложением гаммы.

Пусть символам исходного алфавита соответствуют числа от 0 (А) до 32 (Я). Если обозначить число, соответствующее исходному символу, x, а символу ключа – k, то можно записать правило гаммирования следующим образом:

z = x + k (mod N)

где z – закодированный символ, N - количество символов в алфавите, а сложение по модулю N - операция, аналогичная обычному сложению, с тем отличием, что если обычное суммирование дает результат, больший или равный N, то значением суммы считается остаток от деления его на N.

[EN]

In this method encryption is performed by adding the characters of the source text and the key modulo equal to the number of letters in the alphabet. If the source alphabet, for example, has 33 characters, then the addition is made modulo 33. This process of adding the source text and the key is called gamma superposition in cryptography.

Let symbols of source alphabet correspond to numbers from 0 (A) to 32 (Y). If we denote the number corresponding to the source symbol by x and the key symbol by k, we can write the gamming rule as follows:

z = x + k (mod N)

where z is the encoded character, N is the number of characters in the alphabet, and addition modulo N is an operation similar to ordinary addition, with the difference that if ordinary addition gives a result greater than or equal to N, then the sum value is the remainder of its division by N.

format PE console
entry start

section '.data' data readable writeable
    n dd 4     ; Задаем значение n (количество чисел)
    sum dd 0    ; Инициализируем переменную для хранения суммы
    i dd 1      ; Инициализируем переменную для хранения текущего числа i

section '.code' code readable executable
start:
    mov ecx, [n]       ; Загружаем n в регистр ecx
    mov ebx, 0         ; Обнуляем регистр ebx для хранения суммы
    mov esi, [i]       ; Загружаем начальное значение i в регистр esi

    ; Цикл для вычисления суммы кубов натуральных чисел
    sum_loop:
        ; Вычисление куба текущего числа и добавление к сумме
        mov eax, esi
        imul eax, eax     ; Квадрат текущего числа
        imul eax, esi     ; Куб текущего числа
        add ebx, eax

        inc esi           ; Увеличение i

        loop sum_loop

    ; Результат находится в регистре ebx (сумма кубов)
    mov [sum], ebx
    ; Теперь в sum


    ; Завершение программы
    mov     eax, 1
    xor     ebx, ebx
    int     0x80

;section '.idata' import data readable
;library kernel, 'kernel32.dll',\
;         msvcrt, 'msvcrt.dll'

;import kernel,\
;        ExitProcess, 'ExitProcess'

;import msvcrt,\
;        printf, 'printf'

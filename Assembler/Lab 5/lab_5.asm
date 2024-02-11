format PE console
entry main

;include 'win32a.inc'

section '.data' data readable writeable
    srcArray dd 1.0, 2.0, 3.0, 4.0, 5.0 ; Початковий масив
    dstArray dd 0.0, 0.0, 0.0, 0.0, 0.0 ; Масив призначення
    arraySize dd 5 ; Кількість елементів у масиві

section '.text' code readable executable
main:
    push ebp
    mov ebp, esp

    ; Завантажуємо адреси початкового та призначеного масивів
    mov esi, srcArray
    mov edi, dstArray

    ; Завантажуємо кількість елементів у масиві
    mov ecx, [arraySize]

copyLoop:
    ; Копіюємо значення елементу з початкового масиву до призначеного
    mov eax, [esi]
    mov [edi], eax

    ; Збільшуємо вказівники на наступний елемент у масивах
    add esi, 4
    add edi, 4

    ; Зменшуємо лічильник
    loop copyLoop

    ; Вихід з програми

  mov     eax, 0x1
  mov     ebx, 0
  int     0x80




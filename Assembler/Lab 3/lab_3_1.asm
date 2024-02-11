format PE console
entry start

section '.data' data readable writeable
    n dd 5
    sum dd 0
    i dd 1

section '.code' code readable executable
start:
    mov ecx, [n]
    mov ebx, 0
    mov esi, [i]


    while_start:
        cmp esi, ecx
        jae while_end


        mov eax, esi
        imul eax, eax     ; Обчислюємо куб числа
        imul eax, esi

        add ebx, eax

        inc esi

        jmp while_start


    while_end:

    mov [sum], ebx


    mov     eax, 1
    xor     ebx, ebx
    int     0x80

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


    sum_loop:

        mov eax, esi
        imul eax, eax
        imul eax, esi
        add ebx, eax

        inc esi

        cmp esi, ecx
        jne sum_loop




    mov [sum], ebx


    mov     eax, 1
    xor     ebx, ebx
    int     0x80

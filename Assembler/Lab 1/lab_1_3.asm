format PE64 console
entry main
;include 'win32a.inc'

section '.data' data readable writeable
;resStr db 'Result: %d', 0
    a    dq 4    ; Перше число
    b    dq 2    ; Друге число
    k    dq 1    ; Третє число
    result dq ?

section '.code' code readable executable
main:
     ;y = (b/2-2/k)/(b-a*k+1) ;поменяли 53 на 2
               ;9/15
        ;b/2
    mov rax, [b]
    cqo
    mov rcx, 2
    idiv rcx
    mov [result], rax  ;result записано от b/2

        ;53/k
    mov rax, 2
    cqo
    mov rcx, [k]
    idiv rcx        ;eax от 53/k

    neg rax ;eax от -(53/k)


    add [result], rax  ; result = (b/2-53/k)

    mov rax, [a]
    imul rax, [k]
    inc rax
    sub [b], rax

    xor rax, rax
    mov rax, [result];9
    cqo
    mov rcx, [b]         ;15
    idiv rcx
    mov [result], rax


    ; Якщо жоден з прапорів не встановлено, вивести результат
   ; push resStr
    ;push eax
    ;call [printf]


    jmp     exit


exit:

    ;invoke ExitProcess, 0

;section '.idata' import data readable
;         library kernel, 'kernel32.dll',\
;                 msvcrt, 'msvcrt.dll'
;
;         import kernel,\
;                ExitProcess, 'ExitProcess'
;
;         import msvcrt,\
;;                printf, 'printf',\
;                scanf, 'scanf',\
;                getch, '_getch'
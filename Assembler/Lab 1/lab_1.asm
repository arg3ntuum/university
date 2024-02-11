format PE console
entry main
include 'win32a.inc'

section '.data' data readable writeable
    num1    dd 5    ; Перше число
    num2    dd 3    ; Друге число
     strOf db "Overflow flag (OF) is set.", 0
     strCr db "Carry flag (CF) is set.", 0
     strZr db "Zero flag (ZF) is set." , 0
     strRs db  "Result: ", 0

section '.code' code readable executable
main:
    mov     eax, [num1]  ; Завантажити перше число в eax
    sub     eax, [num2]  ; Відняти друге число від першого

    ; Встановити прапори переповнення, переносу та нульового результату
    jo      overflow     ; Перевірка OF
    jc      carry        ; Перевірка CF
    jz      zero         ; Перевірка ZF

        ; Якщо жоден з прапорів не встановлено, вивести результат
        ; push strRs
        ; push eax
        ; call [printf]
    jmp exit

overflow:
        ;  push  strOf
        ;  call [printf]
    jmp exit

carry:
        ;push  strCr
        ; call [printf]
    jmp exit

zero:
        ;push  strZr
        ;call [printf]
    jmp exit

exit:
     call [getch]

    invoke  ExitProcess, 0

section '.idata' import data readable
         library kernel, 'kernel32.dll',\
                 msvcrt, 'msvcrt.dll'

         import kernel,\
                ExitProcess, 'ExitProcess'

         import msvcrt,\
                printf, 'printf',\
                scanf, 'scanf',\
                getch, '_getch'
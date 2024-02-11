format PE64 console
entry start

section '.data' data writable
 a dd 5
 b dd 2
 x dd 0
section '.text' code executable
start:
mov eax,[a] ;заносимо в регістр значення а
cmp eax,[b] ;порівнюємо значення а і b
 jl a2 ;перехід на мітку а2, якщо а<b
 jg a1 ;перехід на мітку а1, якщо a>b
 je a3 ;перехід на мітку а3, якщо a=b
;==================== a<b ============================
a1:
 cmp [a], 0 ;перевірка ділення на нуль
 je exit ;якщо b=0, то переходимо на вихід


 mov eax, [b]
 cdq ;розширюємо регістр EAX
 idiv [a] ;ділимо на a: b/a
 add eax, 10 ;додаємо 10  b/a+10
 mov [x], eax ;заносимо значення результату
 jmp exit ;перехід на вихід
;==================== a>b ============================
a2:
 cmp [b], 0 ;перевірка ділення на нуль
 je exit ;якщо а=0, то переходимо на вихід
 mov eax, [a] ; запишемо а до регистру
 imul eax, 2 ; 2*a
 sub eax, 5 ;2 * a - 5
 cdq ;розширюємо регістр EAX
 idiv [b] ; ділимо на а
 mov [x], eax ;заносимо значення результату
 jmp exit
;==================== a=b ============================
a3:
 mov [x], 3425 ;заносимо значення результату -2
 mov eax, 3425
exit:
       ; call [getch]
    xor eax, eax

  mov     eax, 0x1
  mov     ebx, 0
  int     0x80

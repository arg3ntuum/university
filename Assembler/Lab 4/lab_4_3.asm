format PE console
entry start
section '.data' data writable

bit_str1 dd 12345678h
bit_str2 dd 90abcdefh
section '.text' code executable
start:
;9023cdef

mov eax,[bit_str1] ; 12345678
mov ebx,[bit_str2] ; 90abcdef
ror ebx,24 ; bcdef90a
rol eax,4 ; 67812345
shld ebx,eax,8 ; ef90a678
rol ebx,16 ; 90a678ef
format PE64 console
entry start
bit_str dq 1234567890abcdefh
start:
mov rax,[bit_str]
ror rax,60 ;
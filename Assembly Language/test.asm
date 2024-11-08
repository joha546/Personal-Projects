dosseg
.model small
.stack 100h
.data
.code
main proc
    mov dl, '5'      ; Load character '5' into DL register
    mov ah, 2        ; Function 2h - Display character in DL
    int 21h          ; Call DOS interrupt to display character

    mov ah, 4Ch      ; Function 4Ch - Terminate program
    int 21h          ; Call DOS interrupt to terminate
main endp
end main

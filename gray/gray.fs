\ *********************************************************************
\ GRAY encoding
\    Filename:      gray.fs
\    Date:          04 dec 2023
\    Updated:       04 dec 2023
\    File Version:  1.0
\    Forth:         eForth Linux
\    Copyright:     Marc PETREMANN
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************

\ n' = n xor 
: >gray ( n -- n' ) 
    dup 1 rshift    \ logical right shift 1 bit
    xor         
  ;

cell 8 * constant BITS_PER_CELL

: gray> ( n -- n )
    0  1 BITS_PER_CELL 1- lshift  ( -- g b mask )             
    begin
        >r          \ sauve mask sur pile retour
        2dup 1 rshift xor
        r@ and or                               
        r> 1 rshift
        dup 0=
    until
    drop nip ;      \ nettoie pile de données en laissant le résultat
  ;

: .r ( n width -- )
    >r str
    r> over - 0 max spaces
    type
  ;

: test
    2 base !        \ sélectionne base binaire
    32 0 do
        cr I  dup 5 .r ."  ==> "    \ affiche valeurs (binaire) 
        >gray dup 5 .r ."  ==> "    \ justifiés à droite sur 5 caractères
        gray>     5 .r
    loop
    decimal ;         \ remet en décimal



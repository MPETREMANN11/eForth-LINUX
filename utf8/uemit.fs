\ *********************************************************************
\ emit word for UT8 characters
\    Filename:      uemit.fs
\    Date:          29 nov 2023
\    Updated:       29 nov 2023
\    File Version:  1.1
\    MCU:           Linux / Web / Windows
\    Forth:         eForth Linux
\    Copyright:     Marc PETREMANN
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


\ buffer for UTF8 char
create charUTF8     
   0 c,  0 c,  0 c,  0 c,  \ allot 4 bytes only

: clearCharUTF8 ( -- )
    charUTF8 4 0 fill
  ;

\ reverse interger bytes, example:
\  hex 1a2b3C -- 3c2b1a
: reverse-bytes-to-charUTF8  { n0 -- }
    0 { result }
    n0
    begin
        $100 u/mod
    ?dup while
        swap
        result $100 * + to result
    repeat
    result $100 * + 
    charUTF8 !
  ;

\ display UTF8 encoded character
: uemit ( n -- )
    charUTF8 4 0 fill           \ reset charUTF8
    reverse-bytes-to-charUTF8   \ reverse bytes
    charUTF8 4 type             \ display UTF8 character
  ;

安

: tt s" 安" ;



\ *********************************************************************
\ display UTF8 character set
\    Filename:      utf8Set.fs
\    Date:          02 dec 2023
\    Updated:       02 dec 2023
\    File Version:  1.1
\    Forth:         eForth Linux
\    Copyright:     Marc PETREMANN
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


8 constant LINE_LIMIT

\ CR only if i MOD = 0
: cr? ( i -- )
    1+ LINE_LIMIT mod
    0= if 
        cr
    then
  ;

$40 constant BYTE_DIVISOR

\ split n modulo BYTE_DIVISOR
: mod40Recombine ( n -- )
    BYTE_DIVISOR /mod 
    dup 0 > if
        recurse
    then
    $100 * +
  ;

$C080       constant MASK_2_BYTES
$E08080     constant MASK_3_BYTES
$F0808080   constant MASK_4_BYTES

$8000     constant LIMIT_2_BYTES
$10000    constant LIMIT_3_BYTES
$200000   constant LIMIT_4_bytes

: bytesToUTF8 ( n -- n' )
    >r
    r@ LIMIT_2_BYTES < if
        r> mod40Recombine
        MASK_2_BYTES OR
        exit
    then
    r@ LIMIT_3_BYTES < if
        r> mod40Recombine
        MASK_3_BYTES OR
        exit
    then
    r@ LIMIT_4_BYTES < if
        r> mod40Recombine
        MASK_4_BYTES OR
        exit
    then
    abort" UTF8 conversion failed"
  ;


\ display hex value format NNNN
: .###### ( n -- )
    <# # # # # # # #> type
  ;

: utf8Set { start stop -- }
    base @ { currentBase }
    hex
    stop 1+ start do
        i .######
        space 
        i bytesToUTF8 uemit
        2 spaces
        i cr?
    loop
    currentBase base !
  ;





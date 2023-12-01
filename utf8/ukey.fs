\ *********************************************************************
\ key word for UT8 characters
\    Filename:      uekey.fs
\    Date:          29 nov 2023
\    Updated:       29 nov 2023
\    File Version:  1.1
\    MCU:           Linux / Web / Windows
\    Forth:         eForth Linux
\    Copyright:     Marc PETREMANN
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


0 value keyUTF8

: toKeyUTF8  ( c -- )
    keyUTF8 8 lshift or to keyUTF8
  ;

\ execute key recursively
: getKeys ( n -- )
    1 lshift dup $80 and    \ test if bit b7 is not null
    if   recurse            \ re-execute xkey
    else drop  then         \ otherwise, drop n
    key toKeyUTF8           \ and execute key 1 or may times
  ;
    
\ key version for UTF8 characters
: ukey
    key to keyUTF8
    keyUTF8 $7F > if                \ if 1st key code > $7F
        keyUTF8 1 lshift getKeys    \ execute xkey
    then
    keyUTF8
  ;


\ all UTF8 characters:
\ https://symbl.cc/fr/unicode/table/#miscellaneous-symbols

\ example:
\ copy cracatre '♿'
\ ukey 
\ paste '♿'  and <enter>
\ push $e299bf  on stack

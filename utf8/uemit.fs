\ *********************************************************************
\ emit word for UT8 characters
\    Filename:      uemit.fs
\    Date:          29 nov 2023
\    Updated:       01 dec 2023
\    File Version:  1.1
\    MCU:           Linux / Web / Windows
\    Forth:         eForth Linux
\    Copyright:     Marc PETREMANN
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


\ reverse interger bytes, example:
\  hex 1a2b3C --> 3c2b1a
: reverse-bytes  ( n0 -- )
    0 { result }
    3 for
        result 100 * to result
        100 u/mod swap +to result
    next
    drop
    result
  ;

\ emit UTF8 encoded character
: uemit ( n -- )
    reverse-bytes
    >r rp@ 4 type
    rdrop
  ;

\ example:
\ hex  E282AC uemit    \ display: €




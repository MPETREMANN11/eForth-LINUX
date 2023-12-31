\ *********************************************************************
\ emit word for UT8 characters
\    Filename:      uemit.fs
\    Date:          29 nov 2023
\    Updated:       01 dec 2023
\    File Version:  1.1
\    Forth:         eForth Linux
\    Copyright:     Marc PETREMANN
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


\ divide value by $100 and leave q r on stack
\  example: hex $1234 100div \ leave: 12 34
: 100div ( n -- q r )
    $100 u/mod swap
  ;

\ reverse interger bytes, example:
\  hex 1a2b3C --> 3c2b1a
: reverse-bytes  ( n0 -- n1 )
    100div $100 * >r
    100div r> + $100 * >r
    100div r> + $100 * >r
    r> +
  ;


\ emit UTF8 encoded character
: uemit ( n -- )
    reverse-bytes
    >r rp@ 4 type
    rdrop
  ;

\ example:
\ hex  E282AC uemit    \ display: €




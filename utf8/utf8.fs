






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


: uemit ( n -- )
    charUTF8 4 0 fill  \ reset charUTF8
    reverse-bytes-to-charUTF8 
    charUTF8 4 type
  ;

: udump
    charUTF8 4 dump ;


: tt 
    $800 $80 do
        i uemit
    loop
  ;





\ value 0 or -1
-1 value ASSERT_LEVEL

: assert(   ( -- )
    ASSERT_LEVEL 0= if
        POSTPONE (
    then
  ; immediate


: ) ( fl -- )
    0= if
        cr ." ASSERT : " 
        tib #tib @ type
        -1 throw
    then
  ; immediate

assert( 1 2 + 3 = )
assert( 1 2 + 5 = )




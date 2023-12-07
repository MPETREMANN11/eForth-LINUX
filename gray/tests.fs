\ *********************************************************************
\ unit tests for GRAY
\    Filename:      tests.fs
\    Date:          04 dec 2023
\    Updated:       06 dec 2023
\    File Version:  1.0
\    Forth:         eForth Linux
\    Copyright:     Marc PETREMANN
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


assert( 0 >gray  0 = )
assert( 1 >gray  1 = )
assert( 2 >gray  3 = )
assert( 3 >gray  2 = )
assert( 4 >gray  6 = )
assert( 5 >gray  7 = )
assert( 6 >gray  5 = )
assert( 7 >gray  4 = )



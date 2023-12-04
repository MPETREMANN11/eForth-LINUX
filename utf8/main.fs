\ *********************************************************************
\ main file for UT8 characters key and emit
\    Filename:      main.fs
\    Date:          29 nov 2023
\    Updated:       01 dec 2023
\    File Version:  1.1
\    Forth:         eForth Linux
\    Copyright:     Marc PETREMANN
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


DEFINED? --xutf8  [IF]  forget --xutf8  [THEN]
create --xutf8

s" dumpTool.fs"     included
s" ukey.fs"         included
s" uemit.fs"        included
s" utf8Set.fs"      included
s" utf8Tables.fs"   included

\ used only for unit tests
s" tests.fs"        included

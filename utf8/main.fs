\ *********************************************************************
\ main file for UT8 characters key and emit
\    Filename:      ùain.fs
\    Date:          29 nov 2023
\    Updated:       01 dec 2023
\    File Version:  1.1
\    MCU:           Linux / Web / Windows
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

s" tests.fs"        included

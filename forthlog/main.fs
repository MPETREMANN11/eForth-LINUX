\ *********************************************************************
\ FORTHLOG - main file
\    Filename:      main.fs
\    Date:          13 dec 2023
\    Updated:       13 dec 2023
\    File Version:  1.0
\    MCU:           ESP32-WROOM-32
\    Forth:         eForth all versions
\    Copyright:     Marc PETREMANN
\    Author:        Francis LEY
\    Adapt. eForth: Marc PETREMANN
\    GNU General Public License
\ *********************************************************************



DEFINED? --forthlog  [IF] forget --forthlog [THEN]
create --forthlog

s" config.fs"           included
s" compatibility.fs"    included
s" forthlog.fs"         included
s" assert.fs"           included
s" tests.fs"            included



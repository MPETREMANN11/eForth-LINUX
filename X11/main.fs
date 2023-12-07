\ *********************************************************************
\ main file for X11 developpments
\    Filename:      main.fs
\    Date:          07 dec 2023
\    Updated:       07 dec 2023
\    File Version:  1.0
\    Forth:         eForth Linux
\    Copyright:     Marc PETREMANN
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************

DEFINED? --X11  [IF]  forget --X11  [THEN]
create --X11


s" X11extend.fs"    included
s" defColors.fs"    included
\ s" config.fs"       required
s" x11test1.fs"     included


\ used only for unit tests
\ s" tests.fs"        required





